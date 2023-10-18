namespace PlatePass.Panels
{
    partial class PlateRegister
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
            pbxLogo = new PictureBox();
            pbxPlate = new PictureBox();
            lblName = new Label();
            tbxName = new TextBox();
            tbxSurname = new TextBox();
            lblSurname = new Label();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            lblTel = new Label();
            lblPlaka = new Label();
            mtbTel = new MaskedTextBox();
            btnOpenFile = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pbxCar = new PictureBox();
            tbxPlaka = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCar).BeginInit();
            SuspendLayout();
            // 
            // pbxLogo
            // 
            pbxLogo.Location = new Point(3, 3);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(270, 117);
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // pbxPlate
            // 
            pbxPlate.Location = new Point(3, 261);
            pbxPlate.Name = "pbxPlate";
            pbxPlate.Size = new Size(270, 70);
            pbxPlate.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPlate.TabIndex = 1;
            pbxPlate.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(5, 127);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 18);
            lblName.TabIndex = 2;
            lblName.Text = "Ad : ";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(73, 122);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(200, 23);
            tbxName.TabIndex = 3;
            // 
            // tbxSurname
            // 
            tbxSurname.Location = new Point(73, 149);
            tbxSurname.Name = "tbxSurname";
            tbxSurname.Size = new Size(200, 23);
            tbxSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSurname.Location = new Point(3, 153);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(64, 18);
            lblSurname.TabIndex = 4;
            lblSurname.Text = "Soyad : ";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(73, 178);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(200, 23);
            tbxEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(5, 182);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 18);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTel.Location = new Point(5, 211);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(41, 18);
            lblTel.TabIndex = 8;
            lblTel.Text = "Tel : ";
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlaka.Location = new Point(5, 240);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new Size(56, 18);
            lblPlaka.TabIndex = 10;
            lblPlaka.Text = "Plaka :";
            // 
            // mtbTel
            // 
            mtbTel.Location = new Point(73, 207);
            mtbTel.Mask = "(+90) 000-0000";
            mtbTel.Name = "mtbTel";
            mtbTel.Size = new Size(200, 23);
            mtbTel.TabIndex = 12;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(5, 337);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(129, 64);
            btnOpenFile.TabIndex = 13;
            btnOpenFile.Text = "Dosya Seç";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // button1
            // 
            button1.Location = new Point(140, 337);
            button1.Name = "button1";
            button1.Size = new Size(129, 64);
            button1.TabIndex = 14;
            button1.Text = "Dosya Seç";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(140, 403);
            button2.Name = "button2";
            button2.Size = new Size(129, 64);
            button2.TabIndex = 16;
            button2.Text = "Dosya Seç";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(5, 403);
            button3.Name = "button3";
            button3.Size = new Size(129, 64);
            button3.TabIndex = 15;
            button3.Text = "Dosya Seç";
            button3.UseVisualStyleBackColor = true;
            // 
            // pbxCar
            // 
            pbxCar.Location = new Point(279, 3);
            pbxCar.Name = "pbxCar";
            pbxCar.Size = new Size(848, 328);
            pbxCar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCar.TabIndex = 17;
            pbxCar.TabStop = false;
            // 
            // tbxPlaka
            // 
            tbxPlaka.Location = new Point(73, 236);
            tbxPlaka.Name = "tbxPlaka";
            tbxPlaka.Size = new Size(200, 23);
            tbxPlaka.TabIndex = 18;
            // 
            // PlateRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            Controls.Add(tbxPlaka);
            Controls.Add(pbxCar);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(btnOpenFile);
            Controls.Add(mtbTel);
            Controls.Add(lblPlaka);
            Controls.Add(lblTel);
            Controls.Add(tbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(tbxSurname);
            Controls.Add(lblSurname);
            Controls.Add(tbxName);
            Controls.Add(lblName);
            Controls.Add(pbxPlate);
            Controls.Add(pbxLogo);
            Name = "PlateRegister";
            Size = new Size(1130, 475);
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxLogo;
        private PictureBox pbxPlate;
        private Label lblName;
        private TextBox tbxName;
        private TextBox tbxSurname;
        private Label lblSurname;
        private TextBox tbxEmail;
        private Label lblEmail;
        private TextBox textBox3;
        private Label lblTel;
        private TextBox textBox4;
        private Label lblPlaka;
        private MaskedTextBox mtbTel;
        private Button btnOpenFile;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pbxCar;
        private TextBox tbxPlaka;
    }
}
