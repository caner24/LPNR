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

namespace PlatePass.Panels
{
    public partial class PlateReader : UserControl
    {
        public PlateReader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CvInvoke.NamedWindow(win1); //Create the window using the specific name
            using (Mat frame = new Mat())
            using (VideoCapture capture = new VideoCapture())
                while (CvInvoke.WaitKey(1) == -1)
                {
                    capture.Read(frame);
                    pbxCamera.Image = frame.ToBitmap();
                    //CvInvoke.Imshow(pbxCamera.Image, frame);
                }
        }
    }
}
