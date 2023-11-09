
namespace PlatePass.Panels
{
    partial class PlateReader
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbxCamera = new PictureBox();
            pbxPlate = new PictureBox();
            button2 = new Button();
            btnSorgula = new Button();
            btnOpenCamera = new Button();
            cbxOkay = new CheckBox();
            cbxNotFound = new CheckBox();
            pbxLogo = new PictureBox();
            btnTanimli = new Button();
            btnTanimsiz = new Button();
            label1 = new Label();
            tbxPlate = new TextBox();
            dgwGecis = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxCamera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwGecis).BeginInit();
            SuspendLayout();
            // 
            // pbxCamera
            // 
            pbxCamera.Image = Properties.Resources._1;
            pbxCamera.Location = new System.Drawing.Point(279, 3);
            pbxCamera.Name = "pbxCamera";
            pbxCamera.Size = new System.Drawing.Size(848, 309);
            pbxCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCamera.TabIndex = 0;
            pbxCamera.TabStop = false;
            // 
            // pbxPlate
            // 
            pbxPlate.Location = new System.Drawing.Point(0, 236);
            pbxPlate.Name = "pbxPlate";
            pbxPlate.Size = new System.Drawing.Size(270, 76);
            pbxPlate.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPlate.TabIndex = 2;
            pbxPlate.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(3, 401);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(270, 71);
            button2.TabIndex = 3;
            button2.Text = "Dosyadan Aç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSorgula
            // 
            btnSorgula.Location = new System.Drawing.Point(135, 318);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new System.Drawing.Size(138, 80);
            btnSorgula.TabIndex = 4;
            btnSorgula.Text = "Sorgula";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // btnOpenCamera
            // 
            btnOpenCamera.Location = new System.Drawing.Point(0, 318);
            btnOpenCamera.Name = "btnOpenCamera";
            btnOpenCamera.Size = new System.Drawing.Size(129, 80);
            btnOpenCamera.TabIndex = 5;
            btnOpenCamera.Text = "Kamera Aç";
            btnOpenCamera.UseVisualStyleBackColor = true;
            btnOpenCamera.Click += btnOpenCamera_Click;
            // 
            // cbxOkay
            // 
            cbxOkay.AutoSize = true;
            cbxOkay.Location = new System.Drawing.Point(0, 170);
            cbxOkay.Name = "cbxOkay";
            cbxOkay.Size = new System.Drawing.Size(95, 19);
            cbxOkay.TabIndex = 6;
            cbxOkay.Text = "Tanımlı Plaka";
            cbxOkay.UseVisualStyleBackColor = true;
            // 
            // cbxNotFound
            // 
            cbxNotFound.AutoSize = true;
            cbxNotFound.Location = new System.Drawing.Point(0, 206);
            cbxNotFound.Name = "cbxNotFound";
            cbxNotFound.Size = new System.Drawing.Size(102, 19);
            cbxNotFound.TabIndex = 7;
            cbxNotFound.Text = "Tanımsız Plaka";
            cbxNotFound.UseVisualStyleBackColor = true;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.Kouyenilogo;
            pbxLogo.Location = new System.Drawing.Point(3, 3);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new System.Drawing.Size(270, 117);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 8;
            pbxLogo.TabStop = false;
            // 
            // btnTanimli
            // 
            btnTanimli.BackColor = System.Drawing.Color.Green;
            btnTanimli.Enabled = false;
            btnTanimli.Location = new System.Drawing.Point(113, 166);
            btnTanimli.Name = "btnTanimli";
            btnTanimli.Size = new System.Drawing.Size(157, 23);
            btnTanimli.TabIndex = 9;
            btnTanimli.UseVisualStyleBackColor = false;
            // 
            // btnTanimsiz
            // 
            btnTanimsiz.BackColor = System.Drawing.Color.Red;
            btnTanimsiz.Enabled = false;
            btnTanimsiz.Location = new System.Drawing.Point(113, 202);
            btnTanimsiz.Name = "btnTanimsiz";
            btnTanimsiz.Size = new System.Drawing.Size(157, 23);
            btnTanimsiz.TabIndex = 10;
            btnTanimsiz.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 131);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 18);
            label1.TabIndex = 11;
            label1.Text = "Plaka";
            // 
            // tbxPlate
            // 
            tbxPlate.Enabled = false;
            tbxPlate.Location = new System.Drawing.Point(116, 126);
            tbxPlate.Name = "tbxPlate";
            tbxPlate.Size = new System.Drawing.Size(154, 23);
            tbxPlate.TabIndex = 12;
            // 
            // dgwGecis
            // 
            dgwGecis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwGecis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGecis.Location = new System.Drawing.Point(279, 340);
            dgwGecis.Name = "dgwGecis";
            dgwGecis.RowTemplate.Height = 25;
            dgwGecis.Size = new System.Drawing.Size(848, 132);
            dgwGecis.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(587, 312);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(221, 28);
            label2.TabIndex = 14;
            label2.Text = "~~~ Son 10 Geçiş ~~~";
            // 
            // PlateReader
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Coral;
            Controls.Add(label2);
            Controls.Add(dgwGecis);
            Controls.Add(tbxPlate);
            Controls.Add(label1);
            Controls.Add(btnTanimsiz);
            Controls.Add(btnTanimli);
            Controls.Add(pbxLogo);
            Controls.Add(cbxNotFound);
            Controls.Add(cbxOkay);
            Controls.Add(btnOpenCamera);
            Controls.Add(btnSorgula);
            Controls.Add(button2);
            Controls.Add(pbxPlate);
            Controls.Add(pbxCamera);
            Name = "PlateReader";
            Size = new System.Drawing.Size(1130, 475);
            Load += PlateReader_Load;
            ((System.ComponentModel.ISupportInitialize)pbxCamera).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwGecis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxCamera;
        private PictureBox pbxPlate;
        private Button button2;
        private Button btnSorgula;
        private Button btnOpenCamera;
        private CheckBox cbxOkay;
        private CheckBox cbxNotFound;
        private PictureBox pbxLogo;
        private Button btnTanimli;
        private Button btnTanimsiz;
        private Label label1;
        private TextBox tbxPlate;
        private DataGridView dgwGecis;
        private Label label2;
    }
}
