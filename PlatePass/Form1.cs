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
            PlateRegister register = new PlateRegister();
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
    }
}