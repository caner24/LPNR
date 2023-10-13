﻿using AForge;
using AForge.Imaging;
using AForge.Math.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LPNR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmpsobe;
            Bitmap bmpmedian;
            Bitmap otsu;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce bir resim Seçin");
            }
            else
            {

                progressBar1.Visible = true;
                int i, j;
                Color ort;//Color sınıfından bir renk nesne tanımlıyoruz.

                //int r,g,b;
                progressBar1.Maximum = bmp.Width * bmp.Height;//İşlem çubuğunun maksimim olduğu yer for döngüsünün sonundaki piksel değerine erişmemiz durumundadır.
                for (i = 0; i <= bmp.Width - 1; i++)//dikey olarak görüntümüzü tarıyoruz.
                {
                    for (j = 0; j <= bmp.Height - 1; j++)//yatay olarak görüntümüzü tarıyoruz. 
                    {
                        ort = bmp.GetPixel(i, j);
                        ort = Color.FromArgb((byte)((ort.R + ort.G + ort.B) / 3), (byte)((ort.R + ort.G + ort.B) / 3), (byte)((ort.R + ort.G + ort.B) / 3));
                        bmp.SetPixel(i, j, ort);
                        if ((i % 10) == 0)//her on satırda bir göstergeyi güncelle
                        {
                            progressBar1.Value = i * bmp.Height + j;
                            Application.DoEvents();
                        }
                    }
                }

            }
            //////////////////////// Median //////////////

            bmpmedian = ExtBitmap.MedianFilter(bmp, 3);

            /////////////////////// SOBEL ///////////////

            bmpsobe = ExtBitmap.Sobel3x3Filter(bmpmedian, true);
            Bitmap bmpsobe1 = (Bitmap)bmpsobe.Clone();

            /////////// otsu
            int x, y;
            int genislik = bmpsobe1.Width;
            int yukseklik = bmpsobe1.Height;
            byte[] pixeller = new byte[(int)genislik * yukseklik];
            Bitmap resim = (Bitmap)bmpsobe1.Clone();
            for (y = 0; y < yukseklik; y++)
                for (x = 0; x < genislik; x++)
                    // Pixelleri kütüphanenin işleyebileceği tek boyutlu bir diziye atıyoruz.
                    // Gri seviyede tüm ana renkler eşit olduğu için sadece kırmızıyı okumak gri seviye için yeterli.
                    pixeller[y * genislik + x] = resim.GetPixel(x, y).R;

            byte esikDeger = 0;
            OtsuEsikleme(ref pixeller[0], ref esikDeger, genislik, yukseklik);
            int renkk;
            for (y = 0; y < yukseklik; y++)
                for (x = 0; x < genislik; x++)
                {
                    renkk = pixeller[y * genislik + x]; // gri
                    resim.SetPixel(x, y, Color.FromArgb(renkk, renkk, renkk)); // Gri seviyeyi argb moduna dönüştürüp resme aktarıyoruz.
                }

            otsu = (Bitmap)resim.Clone();
            Bitmap bmperosion;
            Bitmap bmpdilation;
            Bitmap bmpclosing;


            bmperosion = ExtBitmap.DilateAndErodeFilter(otsu, 3, akıllıgecissistemleri.ExtBitmap.MorphologyType.Erosion, true, true, true);
            Bitmap bmperosionn = (Bitmap)bmperosion.Clone();

            bmpdilation = ExtBitmap.DilateAndErodeFilter(bmperosionn, 7, akıllıgecissistemleri.ExtBitmap.MorphologyType.Dilation, true, true, true);
            Bitmap bmpdilationn = (Bitmap)bmpdilation.Clone();

            Bitmap one = (Bitmap)bmpdilationn.Clone();
            BlobsFiltering filter0 = new BlobsFiltering();
            // filtre ayarlaması
            filter0.CoupledSizeFiltering = true;
            filter0.MinWidth = 70;
            filter0.MinHeight = 40;
            // filtre uygula
            filter0.ApplyInPlace(one);


            Bitmap one2 = (Bitmap)one.Clone();
            bmpclosing = ExtBitmap.CloseMorphologyFilter(one2, 15, true, true, true);
            Bitmap bmperosio = (Bitmap)bmpclosing.Clone();

            Bitmap bmperosionson = ExtBitmap.DilateAndErodeFilter(bmperosio, 9, akıllıgecissistemleri.ExtBitmap.MorphologyType.Erosion, true, true, true);
            Bitmap blobson = (Bitmap)bmperosionson.Clone();

            BlobsFiltering filterson = new BlobsFiltering();
            // filtre ayarla
            filterson.CoupledSizeFiltering = true;
            filterson.MinWidth = 50;
            filterson.MinHeight = 200;
            // filtre uygula

            filterson.ApplyInPlace(blobson);
            Bitmap rect = (Bitmap)blobson.Clone();

            Bitmap one1 = (Bitmap)rect.Clone();

            ConnectedComponentsLabeling filter = new ConnectedComponentsLabeling();
            // filtre uygula
            Bitmap newImage = filter.Apply(one1);
            Bitmap newImage1 = (Bitmap)newImage.Clone();
            // obje sayısını kontrol et
            int objectCount = filter.ObjectCount;

            BlobCounter blobCounter = new BlobCounter();
            blobCounter.ProcessImage(rect);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            // Görüntüye çizmek için Graphic nesnesi ve bir kalem oluştur
            Graphics g = Graphics.FromImage(rect);
            Pen bluePen = new Pen(Color.Blue, 2);
            // her nesne kpntrol edilir ve etrafında daire çizilir.

            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                /*
                 * x1=0
                 * x2=1
                 * y1=2
                 * y2=3
                 */
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);
                List<IntPoint> corners = PointsCloud.FindQuadrilateralCorners(edgePoints);
                int[] sinirlar = sinir(corners);
                sinirlar[0] = sinirlar[0] - 2;
                sinirlar[1] = sinirlar[1] + 2;
                sinirlar[2] = sinirlar[2] - 2;
                sinirlar[3] = sinirlar[3] + 2;
                int en = sinirlar[1] - sinirlar[0];
                int boy = sinirlar[3] - sinirlar[2];
                float ort = (float)en / (float)boy;

                List<IntPoint> ucnoktalar = new List<IntPoint>();
                ucnoktalar.Add(new IntPoint(sinirlar[0], sinirlar[2]));
                ucnoktalar.Add(new IntPoint(sinirlar[1], sinirlar[2]));
                ucnoktalar.Add(new IntPoint(sinirlar[1], sinirlar[3]));
                ucnoktalar.Add(new IntPoint(sinirlar[0], sinirlar[3]));
                g.DrawPolygon(bluePen, ToPointsArray(ucnoktalar));
                g.DrawString("Plaka kordinatlari : (x,y): (" + sinirlar[0].ToString() + "," + sinirlar[2].ToString() + ")\n en, boy,ort: " + (sinirlar[1] - sinirlar[0]).ToString() + ", "
                 + (sinirlar[3] - sinirlar[2]).ToString() + "," + ort.ToString() + " blob sayisi:" + blobs.Length.ToString(), new Font("Arial", 8), Brushes.White, new System.Drawing.Point(sinirlar[0], sinirlar[3] + 4));
            }

            bluePen.Dispose();
            g.Dispose();


            Bitmap rect1 = (Bitmap)pictureBox1.Image.Clone();
            Graphics g1 = Graphics.FromImage(rect1);
            Pen bluePen2 = new Pen(Color.Red, 2);
            // her nesne kpntrol edilir ve etrafında daire çizilir.

            List<Blob> bloplar = new List<Blob>();
            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);
                List<IntPoint> corners = PointsCloud.FindQuadrilateralCorners(edgePoints);
                int[] sinirlar = sinir(corners);
                sinirlar[0] = sinirlar[0] - 5;
                sinirlar[1] = sinirlar[1];
                sinirlar[2] = sinirlar[2] - 5;
                sinirlar[3] = sinirlar[3] + 5;
                int en = sinirlar[1] - sinirlar[0];
                int boy = sinirlar[3] - sinirlar[2];
                float ort = (float)en / (float)boy;
                if (ort >= 3 && ort <= 5.7)
                {

                    g1.DrawLines(bluePen2, new System.Drawing.Point[] { new System.Drawing.Point(sinirlar[0], sinirlar[2]),
                        new System.Drawing.Point(sinirlar[1] , sinirlar[2]), new System.Drawing.Point(sinirlar[1], sinirlar[3]),
                        new System.Drawing.Point(sinirlar[0], sinirlar[3]), new System.Drawing.Point( sinirlar[0], sinirlar[2]) });

                    g1.DrawString("Plaka kordinatlari : (x,y): (" + sinirlar[0].ToString() + "," + sinirlar[2].ToString() + ")\n en, boy,ort: " + (sinirlar[1] - sinirlar[0]).ToString() + ", "
                                + (sinirlar[3] - sinirlar[2]).ToString() + "," + ort.ToString() + " blob sayisi:" + blobs.Length.ToString(), new Font("Arial", 8), Brushes.White, new System.Drawing.Point(sinirlar[0], sinirlar[3] + 4));
                }
            }

            bluePen2.Dispose();
            g1.Dispose();


            Bitmap bn = null;
            Bitmap kes1 = (Bitmap)rect1.Clone();
            Graphics g2 = Graphics.FromImage(kes1);
            Pen bluePen3 = new Pen(Color.Red, 2);
            // her nesne kpntrol edilir ve etrafında daire çizilir.

            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);
                List<IntPoint> corners = PointsCloud.FindQuadrilateralCorners(edgePoints);
                int[] sinirlar = sinir(corners);
                sinirlar[0] = sinirlar[0] - 5;
                sinirlar[1] = sinirlar[1];
                sinirlar[2] = sinirlar[2] - 5;
                sinirlar[3] = sinirlar[3] + 5;

                int en = sinirlar[1] - sinirlar[0];
                int boy = sinirlar[3] - sinirlar[2];
                float ort = en / boy;
                if (ort >= 3 && ort <= 5.7)
                {
                    g2.DrawLines(bluePen3, new System.Drawing.Point[] { new System.Drawing.Point(sinirlar[0], sinirlar[2]),
                        new System.Drawing.Point(sinirlar[1] , sinirlar[2]), new System.Drawing.Point(sinirlar[1], sinirlar[3]),
                        new System.Drawing.Point(sinirlar[0], sinirlar[3]), new System.Drawing.Point( sinirlar[0], sinirlar[2]) });

                    for (int ii = 0; ii < kes1.Width; ii++)
                    {
                        for (int ji = 0; ji < kes1.Height; ji++)
                        {
                            if ((ii >= sinirlar[0] && ii <= sinirlar[1]) && (ji >= sinirlar[2]) && ji <= sinirlar[3])
                                continue;
                            else
                                kes1.SetPixel(ii, ji, Color.Black);

                        }
                    }
                    bn = new Bitmap(en, boy);
                    Graphics g3 = Graphics.FromImage(bn);
                    g3.DrawImage(kes1, -sinirlar[0], -sinirlar[2]);
                    pictureBox2.Image = bn;
                }
            }

            bluePen3.Dispose();
            g2.Dispose();
        }
        public int[] sinir(List<IntPoint> list)
        {
            int[] sinirlar = { 0, 0, 0, 0 };
            int x1, x2, y1, y2;
            x1 = x2 = y1 = y2 = 0;
            bool first = true;
            foreach (IntPoint p in list)
            {
                if (first)
                {
                    x1 = x2 = p.X;
                    y1 = y2 = p.Y;
                    first = false;
                    continue;
                }
                if (p.X < x1)
                    x1 = p.X;
                if (p.X > x2)
                    x2 = p.X;
                if (p.Y < y1)
                    y1 = p.Y;
                if (p.Y > y2)
                    y2 = p.Y;
            }
            sinirlar[0] = x1;
            sinirlar[1] = x2;
            sinirlar[2] = y1;
            sinirlar[3] = y2;
            return sinirlar;
        }
    }
}
