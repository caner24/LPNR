﻿using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Tesseract;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using AForge.Imaging.Filters;
using AForge;
using AForge.Imaging;
using IronOcr;
using IronSoftware.Drawing;
using BitMiracle.LibTiff.Classic;
using PlatePass.Business.Abstract;
using PlatePass.Business.DI;
using PlatePass.Entities;
using Microsoft.EntityFrameworkCore;
using PlatePass.Business.Validation;

namespace PlatePass.Panels
{
    public partial class PlateRegister : UserControl
    {

        static Bitmap img;
        private readonly IPlateService _plateService;
        private readonly IUserService _userService;
        public PlateRegister()
        {
            InitializeComponent();
            _plateService = InstanceFactory.GetInstance<IPlateService>();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }


        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            tbxPlaka.Clear();
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Resim Dosyaları (*.bmp)|*.jpg;*.gif;*.bmp;*.png;*.jpeg";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbxCar.ImageLocation = dialog.FileName;
                    Mat frame = CvInvoke.Imread(dialog.FileName);
                    SobelAndGrayFilter.ProcessFrame(frame);
                    img = SobelAndGrayFilter.img;
                    pbxPlate.Image = img;
                    var filteredImg = BitmapToUMat((Bitmap)pbxPlate.Image);
                    if (filteredImg != null)
                    {
                        FilterPlate2(filteredImg);
                        if (pbxPlate.Image != null)
                        {
                            GetTextFromImg();
                            if (tbxPlaka.Text == "")
                                MessageBox.Show("Resim çok bulanik okunamiyor !.");
                        }
                        else
                        {
                            MessageBox.Show("Resim çok bulanik okunamiyor !.");
                        }

                    }


                }
            }

        }

        void GetTextFromImg()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                pbxPlate.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                using (var engine = new TesseractEngine(System.Windows.Forms.Application.StartupPath + @"\tessdata-main", "tur", EngineMode.Default))
                {
                    engine.SetVariable("tessedit_char_whitelist", "ABCDEFGHIJKLMNOPQRSTUVWXYZ-1234567890");
                    using (var img = Pix.LoadFromMemory(ms.ToArray()))
                    {
                        using (var page = engine.Process(img))
                        {
                            string text = page.GetText();
                            tbxPlaka.Text = text;
                            if (tbxPlaka.Text == null)
                            {
                                tbxPlaka.Text = " Resim çok bulanik !.";
                            }
                        }
                    }
                }
            }
        }

        private UMat BitmapToUMat(Bitmap bitmap)
        {

            if (bitmap != null)
            {
                int channels;

                if (bitmap.PixelFormat == System.Drawing.Imaging.PixelFormat.Format8bppIndexed)
                {
                    channels = 1; // Grayscale
                }
                else if (bitmap.PixelFormat == System.Drawing.Imaging.PixelFormat.Format24bppRgb)
                {
                    channels = 3; // RGB
                }
                else if (bitmap.PixelFormat == System.Drawing.Imaging.PixelFormat.Format32bppArgb)
                {
                    channels = 4; // ARGB
                }
                else
                {
                    throw new NotSupportedException("Unsupported pixel format.");
                }
                UMat umat = new UMat(bitmap.Size, DepthType.Cv8U, channels);

                CvInvoke.CvtColor(bitmap.ToImage<Bgr, byte>(), umat, ColorConversion.Bgr2Gray);

                return umat;
            }
            else
            {
                MessageBox.Show("Resim çok bulanik plaka tanimlanamadi.");
                return null;
            }

        }

        public void FilterPlate2(UMat plate)
        {
            UMat thresh = new UMat();
            CvInvoke.Threshold(plate, thresh, 120, 255, ThresholdType.BinaryInv);
            //Image<Gray, Byte> thresh = plate.ThresholdBinaryInv(new Gray(120), new Gray(255));

            System.Drawing.Size plateSize = plate.Size;
            using (Mat plateMask = new Mat(plateSize.Height, plateSize.Width, DepthType.Cv8U, 1))
            using (Mat plateCanny = new Mat())
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                plateMask.SetTo(new MCvScalar(255.0));
                CvInvoke.Canny(plate, plateCanny, 100, 50);
                CvInvoke.FindContours(plateCanny, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                int count = contours.Size;
                for (int i = 1; i < count; i++)
                {
                    using (VectorOfPoint contour = contours[i])
                    {

                        System.Drawing.Rectangle rect = CvInvoke.BoundingRectangle(contour);
                        if (rect.Height > (plateSize.Height >> 1))
                        {
                            rect.X -= 1; rect.Y -= 1; rect.Width += 2; rect.Height += 2;
                            System.Drawing.Rectangle roi = new System.Drawing.Rectangle(System.Drawing.Point.Empty, plate.Size);
                            rect.Intersect(roi);
                            CvInvoke.Rectangle(plateMask, rect, new MCvScalar(), -1);
                            //plateMask.Draw(rect, new Gray(0.0), -1);
                        }
                    }

                }

                thresh.SetTo(new MCvScalar(), plateMask);
            }

            CvInvoke.Erode(thresh, thresh, null, new System.Drawing.Point(-1, -1), 1, BorderType.Constant, CvInvoke.MorphologyDefaultBorderValue);
            CvInvoke.Dilate(thresh, thresh, null, new System.Drawing.Point(-1, -1), 1, BorderType.Constant, CvInvoke.MorphologyDefaultBorderValue);

            pbxPlate.Image = thresh.ToBitmap();
        }

        private async void btnSavePlate_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                EmailAdres = tbxEmail.Text,
                UserName = tbxName.Text,
                UserSurname = tbxSurname.Text
            };
            foreach (var item in tbxPlaka.Text.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                user.Plates.Add(new Plate { PlateText = item });
            }
            var validator = new UserValidator();
            var validationResult = validator.Validate(user);

            if (validationResult.IsValid)
            {
                await _userService.AddEntityAsync(user);
                MessageBox.Show("Plaka başarılı bir şekilde kaydedildi");
                this.Refresh();
            }
            else
            {
                string errorMessage = string.Join("\n", validationResult.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(errorMessage);
            }
        }

        private async void PlateRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
