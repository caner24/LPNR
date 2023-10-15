using AForge.Video;
using AForge.Video.DirectShow;
using LPNR.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LPNR.Panels
{
    public partial class PlateReader : UserControl
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice vcd;
        public PlateReader()
        {

            InitializeComponent();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in filterInfoCollection)
            {
                cbxCameraList.Items.Add(item.Name);
                cbxCameraList.SelectedIndex = 0;
            }
        }
        private void OpenCamera()
        {
            vcd = new VideoCaptureDevice(filterInfoCollection[cbxCameraList.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
        }
        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            OpenCamera();
        }
        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnCapturePhoto_Click(object sender, EventArgs e)
        {
            pbxPlate.Image = pbxCamera.Image;
            pbxPlate.Image = UploadFile.resimYukleImage(pbxPlate.Image);
            pbxPlateDetail.Image = GaborFilter.GaborAndSomeFilter(pbxPlate.Image);


        }
    }
}
