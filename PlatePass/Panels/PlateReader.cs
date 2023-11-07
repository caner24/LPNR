using Emgu.CV;
using Emgu.CV.Structure;
using IronOcr;
using IronSoftware.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PlatePass.Panels
{
    public partial class PlateReader : UserControl
    {
        public PlateReader()
        {
            InitializeComponent();
        }
        string fileName;
        Bitmap img;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {



            Guid guid = Guid.NewGuid();
            fileName = guid + ".jpg";
            string filePath = Path.Combine(Application.StartupPath + "\\Plate", fileName);
            pbxCamera.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);

            PlateRemember(filePath);
            GetTextFromImg();

        }
        void GetTextFromImg()
        {
            var Ocr = new IronTesseract();
            Ocr.Language = OcrLanguage.Turkish;
            using (var Input = new OcrInput())
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Input.DeNoise();
                    Input.ToGrayScale();
                    pbxPlate.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    var ContentArea = new CropRectangle(x: 39, y: 0, height: 85, width: 380);
                    Input.AddImage(ms.ToArray(), ContentArea);
                    var Result = Ocr.Read(Input);
                    tbxPlaka.Text = Result.Text;
                }

            }

        }
        void PlateRemember(string filename)
        {
            Mat frame = CvInvoke.Imread(filename);
            SobelAndGrayFilter.ProcessFrame(frame);
            img = SobelAndGrayFilter.img;
            pbxPlate.Image = img;
            if (img == null)
            {
                MessageBox.Show("Plaka okunamadı resmin okunakli olduğundan emin olun !.", "Okunaksiz ressim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PlateReader_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            using (Mat frame = new Mat())
            {
                using (VideoCapture capture = new VideoCapture())
                    while (CvInvoke.WaitKey(1) == -1)
                    {
                        capture.Read(frame);
                        pbxCamera.Image = frame.ToBitmap();
                    }
            }
        }
    }
}
