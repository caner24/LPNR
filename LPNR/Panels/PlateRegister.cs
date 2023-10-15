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

namespace LPNR.Panels
{
    public partial class PlateRegister : UserControl
    {
        public PlateRegister()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCameraOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Resim Dosyaları (*.bmp)|*.jpg;*.gif;*.bmp;*.png;*.jpeg";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbxCar.Image = UploadFile.resimYukle(dialog.FileName);
                    pbxPlate.Image = GaborFilter.GaborAndSomeFilter(pbxCar.Image);
                    if (pbxPlate.Image == null)
                    {
                        MessageBox.Show("Plaka okunaklı değil plaka okunaklı olduğundan emin olunuz.", "Hatali Resim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
