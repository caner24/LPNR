using PlatePass.Panels;

namespace PlatePass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PlateReader register = new PlateReader();
            panel1.Controls.Add(register);
        }

        private void plateReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PlateReader register = new PlateReader();
            panel1.Controls.Add(register);
        }

        private void plateRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PlateRegister register = new PlateRegister();
            panel1.Controls.Add(register);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void plateDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PlateDetail plateDetail = new PlateDetail();
            panel1.Controls.Add(plateDetail);
        }
    }
}