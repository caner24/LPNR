using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass
{
    public class SobelAndGrayFilter
    {
       public static Bitmap img;

        public static void ProcessFrame(Mat frame)
        {
            Mat grayImage = new Mat();
            CvInvoke.CvtColor(frame, grayImage, ColorConversion.Bgr2Gray);
            grayImage = blur_Img(grayImage);

            Mat edges = new Mat();
            edges = sobel_Filter(grayImage);
            edges = threshold_Img(edges);

            Mat closed = new Mat();
            closed = morphological_Closing(edges);

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(closed, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

            List<System.Drawing.Rectangle> licensePlateRectangles = new List<System.Drawing.Rectangle>();
            for (int i = 0; i < contours.Size; i++)
            {
                VectorOfPoint contour = contours[i];
                System.Drawing.Rectangle boundingRect = CvInvoke.BoundingRectangle(contour);

                double aspectRatio = (double)boundingRect.Width / boundingRect.Height;
                double area = CvInvoke.ContourArea(contour);

                if (aspectRatio > 2.5 && aspectRatio < 7 && area > 4000 && area < 30000)
                {
                    licensePlateRectangles.Add(boundingRect);
                }
            }

            foreach (System.Drawing.Rectangle plateRect in licensePlateRectangles)
            {
                Mat plateImage = new Mat(frame, plateRect);

                Mat plateGray = new Mat();
                CvInvoke.CvtColor(plateImage, plateGray, ColorConversion.Bgr2Gray);

                Mat plateThreshold = new Mat();
                CvInvoke.AdaptiveThreshold(plateGray, plateThreshold, 255, AdaptiveThresholdType.GaussianC, ThresholdType.BinaryInv, 11, 4);

                Mat plateCandidates = new Mat();
                CvInvoke.BitwiseNot(plateThreshold, plateCandidates);

                VectorOfVectorOfPoint candidateContours = new VectorOfVectorOfPoint();
                CvInvoke.FindContours(plateCandidates, candidateContours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

                List<System.Drawing.Rectangle> characterRectangles = new List<System.Drawing.Rectangle>();
                for (int i = 0; i < candidateContours.Size; i++)
                {
                    VectorOfPoint candidateContour = candidateContours[i];
                    System.Drawing.Rectangle candidateRect = CvInvoke.BoundingRectangle(candidateContour);

                    double aspectRatio = (double)candidateRect.Width / candidateRect.Height;
                    double area = CvInvoke.ContourArea(candidateContour);

                    if (aspectRatio > 0.1 && aspectRatio < 1 && area > 100)
                    {
                        characterRectangles.Add(candidateRect);
                    }
                }
                foreach (System.Drawing.Rectangle characterRect in characterRectangles)
                {
                    display_Picture(plateGray);
                    return;
                }
            }
        }
        static void display_Picture(Mat frame)
        {
            img = frame.ToBitmap();
        }
        static Mat blur_Img(Mat grayImage)
        {
            CvInvoke.GaussianBlur(grayImage, grayImage, new System.Drawing.Size(5, 5), 0);
            return grayImage;
        }

        static Mat sobel_Filter(Mat grayImage)
        {
            Mat edges = new Mat();
            CvInvoke.Sobel(grayImage, edges, DepthType.Cv8U, 1, 0, 3, 1, 0, BorderType.Default);
            return edges;
        }
        static Mat threshold_Img(Mat edges)
        {
            CvInvoke.Threshold(edges, edges, 0, 255, ThresholdType.Otsu);
            return edges;
        }
        static Mat morphological_Closing(Mat edges)
        {
            Mat closed = new Mat();
            Mat kernel = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new System.Drawing.Size(17, 3), new System.Drawing.Point(-1, -1));
            CvInvoke.MorphologyEx(edges, closed, MorphOp.Close, kernel, new System.Drawing.Point(-1, -1), 3, BorderType.Default, new MCvScalar(255, 255, 255));
            return closed;
        }
    }
}
