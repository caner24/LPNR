using Emgu.CV.CvEnum;
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

namespace PlatePass.Panels
{
    public partial class PlateRegister : UserControl
    {
        public PlateRegister()
        {
            InitializeComponent();
        }
        static Bitmap img;
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                tbxPlaka.Clear();
                dialog.Filter = "Resim Dosyaları (*.bmp)|*.jpg;*.gif;*.bmp;*.png;*.jpeg";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbxCar.ImageLocation = dialog.FileName;
                    img = null;
                    Mat frame = CvInvoke.Imread(dialog.FileName);
                    SobelAndGrayFilter.ProcessFrame(frame);
                    img = SobelAndGrayFilter.img;
                    pbxPlate.Image = img;
                    if (img == null)
                    {
                        MessageBox.Show("Plaka okunamadı resmin okunakli olduğundan emin olun !.", "Okunaksiz ressim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FilterImg();
                        GetTextFromImg();
                    }
                }
            }

            void GetTextFromImg()
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    using (var engine = new TesseractEngine(@"C:\Users\cnr24\Downloads\tessdata-main\tessdata-main", "tur", EngineMode.LstmOnly))
                    {
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
            void FilterImg()
            {
                var filter = new PointedColorFloodFill();
                filter.FillColor = Color.White;
                filter.Tolerance = Color.FromArgb(60, 60, 60);

                filter.StartingPoint = new IntPoint(0, 0);
                filter.ApplyInPlace(img);
                filter.StartingPoint = new IntPoint(img.Size.Width - 1, 0);
                filter.ApplyInPlace(img);
                filter.StartingPoint = new IntPoint(img.Size.Width - 1, img.Size.Height - 1);
                filter.ApplyInPlace(img);
                filter.StartingPoint = new IntPoint(0, img.Size.Height - 1);
                filter.ApplyInPlace(img);

                var bradleyfilter = new BradleyLocalThresholding();
                bradleyfilter.ApplyInPlace(img);
                filter.Tolerance = Color.FromArgb(10, 10, 10);
            }
        }
    }
}
