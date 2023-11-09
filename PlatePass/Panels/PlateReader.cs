using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using IronOcr;
using IronSoftware.Drawing;
using PlatePass.Business.Abstract;
using PlatePass.Business.DI;
using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PlatePass.Panels
{
    public partial class PlateReader : UserControl
    {
        public PlateReader()
        {
            InitializeComponent();
            _plateService = InstanceFactory.GetInstance<IPlateService>();
            _plateDetailService = InstanceFactory.GetInstance<IPlateDetailService>();
        }
        private readonly IPlateService _plateService;
        private readonly IPlateDetailService _plateDetailService;
        string fileName;
        Bitmap img;
        Plate _plates;

        private async void btnSorgula_Click(object sender, EventArgs e)
        {
            cbxNotFound.Checked = false;
            cbxOkay.Checked = false;
            btnTanimli.Enabled = false;
            btnTanimsiz.Enabled = false;

            Guid guid = Guid.NewGuid();
            fileName = guid + ".jpg";
            string filePath = Path.Combine(Application.StartupPath + "\\Plate", fileName);
            pbxCamera.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            PlateRemember(filePath);

            _plates = await _plateService.GetEntityByIdentityAsync(x => x.PlateText == tbxPlate.Text.ToString());
            if (_plates == null)
            {
                cbxNotFound.Checked = true;
                btnTanimsiz.Enabled = true;
                btnTanimli.Enabled = false;


            }
            else
            {
                cbxOkay.Checked = true;
                btnTanimli.Enabled = true;
                btnTanimsiz.Enabled = false;
                await _plateDetailService.AddEntityAsync(new PlateDetails { IsSafePlate = true, PassDate = DateTime.UtcNow, PlateId = _plates.Id });
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
                            tbxPlate.Text = text;
                            if (tbxPlate.Text == null)
                            {
                                tbxPlate.Text = " Resim çok bulanik !.";
                            }
                        }
                    }
                }
            }

        }
        void PlateRemember(string filename)
        {
            Mat frame = CvInvoke.Imread(filename);
            SobelAndGrayFilter.ProcessFrame(frame);
            img = SobelAndGrayFilter.img;
            pbxPlate.Image = img;
            if (pbxPlate.Image != null)
            {
                FilterPlate2(BitmapToUMat((Bitmap)pbxPlate.Image));
                GetTextFromImg();
            }
            if (img == null)
            {
                MessageBox.Show("Plaka okunamadı resmin okunakli olduğundan emin olun !.", "Okunaksiz ressim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void PlateReader_Load(object sender, EventArgs e)
        {
            var plateDetailsList = await _plateDetailService.GetAllEntityAsync();

            // Assuming dgwGecis is your DataGridView
            dgwGecis.AutoGenerateColumns = false;

            // Add columns manually
            dgwGecis.Columns.Add("Id", "ID");
            dgwGecis.Columns.Add("PassDate", "Pass Date");
            dgwGecis.Columns.Add("PlateId", "Plate ID");
            dgwGecis.Columns.Add("PlateText", "Plate");

            // Bind data to DataGridView
            foreach (var plateDetails in plateDetailsList)
            {
                // Assuming Plate has a property named "Name"
                dgwGecis.Rows.Add(plateDetails.Id, plateDetails.PassDate, plateDetails.PlateId, plateDetails.Plate.PlateText);
            }
        }
        private UMat BitmapToUMat(Bitmap bitmap)
        {
            if (bitmap == null)
            {
                throw new ArgumentNullException("Input bitmap is null.");
            }

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

        private async void button2_Click(object sender, EventArgs e)
        {
            cbxNotFound.Checked = false;
            cbxOkay.Checked = false;
            btnTanimli.Enabled = false;
            btnTanimsiz.Enabled = false;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Resim Dosyaları (*.bmp)|*.jpg;*.gif;*.bmp;*.png;*.jpeg";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbxCamera.ImageLocation = dialog.FileName;
                    Mat frame = CvInvoke.Imread(dialog.FileName);
                    SobelAndGrayFilter.ProcessFrame(frame);
                    img = SobelAndGrayFilter.img;
                    pbxPlate.Image = img;
                    FilterPlate2(BitmapToUMat((Bitmap)pbxPlate.Image));
                    if (pbxPlate.Image != null)
                    {
                        GetTextFromImg();
                        if (tbxPlate.Text == "")
                            MessageBox.Show("Resim çok bulanik okunamiyor !.");
                    }
                    else
                    {
                        MessageBox.Show("Resim çok bulanik okunamiyor !.");
                    }
                }
            }
            _plates = await _plateService.GetEntityByIdentityAsync(x => x.PlateText == tbxPlate.Text.ToString());
            if (_plates == null)
            {
                cbxNotFound.Checked = true;
                btnTanimsiz.Enabled = true;
                btnTanimli.Enabled = false;
            }
            else
            {
                cbxOkay.Checked = true;
                btnTanimli.Enabled = true;
                btnTanimsiz.Enabled = false;
                await _plateDetailService.AddEntityAsync(new PlateDetails { IsSafePlate = true, PassDate = DateTime.UtcNow, PlateId = _plates.Id });
            }
        }
    }
}
