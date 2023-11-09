using System.Reflection.PortableExecutable;

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
            lblPlaka = new Label();
            btnOpenFile = new Button();
            btnSavePlate = new Button();
            pbxCar = new PictureBox();
            tbxPlaka = new TextBox();
            lblEmail = new Label();
            tbxEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCar).BeginInit();
            SuspendLayout();
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.Kouyenilogo;
            pbxLogo.Location = new System.Drawing.Point(3, 3);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new System.Drawing.Size(270, 117);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 0;
            pbxLogo.TabStop = false;
            // 
            // pbxPlate
            // 
            pbxPlate.Location = new System.Drawing.Point(3, 261);
            pbxPlate.Name = "pbxPlate";
            pbxPlate.Size = new System.Drawing.Size(270, 70);
            pbxPlate.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPlate.TabIndex = 1;
            pbxPlate.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new System.Drawing.Point(1, 139);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(39, 18);
            lblName.TabIndex = 2;
            lblName.Text = "Ad : ";
            // 
            // tbxName
            // 
            tbxName.Location = new System.Drawing.Point(69, 134);
            tbxName.Name = "tbxName";
            tbxName.Size = new System.Drawing.Size(200, 23);
            tbxName.TabIndex = 3;
            // 
            // tbxSurname
            // 
            tbxSurname.Location = new System.Drawing.Point(69, 163);
            tbxSurname.Name = "tbxSurname";
            tbxSurname.Size = new System.Drawing.Size(200, 23);
            tbxSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSurname.Location = new System.Drawing.Point(-1, 167);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(64, 18);
            lblSurname.TabIndex = 4;
            lblSurname.Text = "Soyad : ";
            // 
            // lblPlaka
            // 
            lblPlaka.AutoSize = true;
            lblPlaka.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlaka.Location = new System.Drawing.Point(1, 236);
            lblPlaka.Name = "lblPlaka";
            lblPlaka.Size = new System.Drawing.Size(56, 18);
            lblPlaka.TabIndex = 10;
            lblPlaka.Text = "Plaka :";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new System.Drawing.Point(3, 337);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new System.Drawing.Size(270, 64);
            btnOpenFile.TabIndex = 13;
            btnOpenFile.Text = "Dosya Seç";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSavePlate
            // 
            btnSavePlate.Location = new System.Drawing.Point(3, 403);
            btnSavePlate.Name = "btnSavePlate";
            btnSavePlate.Size = new System.Drawing.Size(270, 64);
            btnSavePlate.TabIndex = 14;
            btnSavePlate.Text = "Plaka Kaydet";
            btnSavePlate.UseVisualStyleBackColor = true;
            btnSavePlate.Click += btnSavePlate_Click;
            // 
            // pbxCar
            // 
            pbxCar.Location = new System.Drawing.Point(279, 3);
            pbxCar.Name = "pbxCar";
            pbxCar.Size = new System.Drawing.Size(848, 464);
            pbxCar.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCar.TabIndex = 17;
            pbxCar.TabStop = false;
            // 
            // tbxPlaka
            // 
            tbxPlaka.Location = new System.Drawing.Point(69, 232);
            tbxPlaka.Name = "tbxPlaka";
            tbxPlaka.Size = new System.Drawing.Size(200, 23);
            tbxPlaka.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new System.Drawing.Point(1, 203);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(47, 18);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new System.Drawing.Point(69, 199);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new System.Drawing.Size(200, 23);
            tbxEmail.TabIndex = 7;
            // 
            // PlateRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Coral;
            Controls.Add(tbxPlaka);
            Controls.Add(pbxCar);
            Controls.Add(btnSavePlate);
            Controls.Add(btnOpenFile);
            Controls.Add(lblPlaka);
            Controls.Add(tbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(tbxSurname);
            Controls.Add(lblSurname);
            Controls.Add(tbxName);
            Controls.Add(lblName);
            Controls.Add(pbxPlate);
            Controls.Add(pbxLogo);
            Name = "PlateRegister";
            Size = new System.Drawing.Size(1130, 475);
            Load += PlateRegister_Load;
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
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblPlaka;
        private Button btnOpenFile;
        private Button btnSavePlate;
        private PictureBox pbxCar;
        private TextBox tbxPlaka;
        private Label lblEmail;
        private TextBox tbxEmail;
    }
}
