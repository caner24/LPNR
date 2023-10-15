namespace LPNR.Panels
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeletePlate = new System.Windows.Forms.Button();
            this.btnUpdatePlate = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.pbxPlate = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSavePlate = new System.Windows.Forms.Button();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.tbxPlate = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbxCar = new System.Windows.Forms.PictureBox();
            this.dgwPlateData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlateData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btnDeletePlate);
            this.panel1.Controls.Add(this.btnUpdatePlate);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mtbPhone);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.tbxEmail);
            this.panel1.Controls.Add(this.pbxPlate);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnSavePlate);
            this.panel1.Controls.Add(this.lblPlaka);
            this.panel1.Controls.Add(this.tbxPlate);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 475);
            this.panel1.TabIndex = 1;
            // 
            // btnDeletePlate
            // 
            this.btnDeletePlate.Location = new System.Drawing.Point(137, 402);
            this.btnDeletePlate.Name = "btnDeletePlate";
            this.btnDeletePlate.Size = new System.Drawing.Size(136, 64);
            this.btnDeletePlate.TabIndex = 17;
            this.btnDeletePlate.Text = "Sil";
            this.btnDeletePlate.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePlate
            // 
            this.btnUpdatePlate.Location = new System.Drawing.Point(3, 402);
            this.btnUpdatePlate.Name = "btnUpdatePlate";
            this.btnUpdatePlate.Size = new System.Drawing.Size(128, 64);
            this.btnUpdatePlate.TabIndex = 16;
            this.btnUpdatePlate.Text = "Güncelle";
            this.btnUpdatePlate.UseVisualStyleBackColor = true;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::LPNR.Properties.Resources.WiaQjTMthL4145xeWdya;
            this.pbxLogo.Location = new System.Drawing.Point(2, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(270, 117);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 15;
            this.pbxLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Plaka : ";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(72, 201);
            this.mtbPhone.Mask = "(+90) 000-0000000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(197, 20);
            this.mtbPhone.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(5, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 18);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(72, 175);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(197, 20);
            this.tbxEmail.TabIndex = 9;
            // 
            // pbxPlate
            // 
            this.pbxPlate.Location = new System.Drawing.Point(3, 256);
            this.pbxPlate.Name = "pbxPlate";
            this.pbxPlate.Size = new System.Drawing.Size(270, 70);
            this.pbxPlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPlate.TabIndex = 8;
            this.pbxPlate.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(2, 332);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(129, 64);
            this.btnOpenFile.TabIndex = 7;
            this.btnOpenFile.Text = "Dosya Seç";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnCameraOpen_Click);
            // 
            // btnSavePlate
            // 
            this.btnSavePlate.Location = new System.Drawing.Point(137, 332);
            this.btnSavePlate.Name = "btnSavePlate";
            this.btnSavePlate.Size = new System.Drawing.Size(136, 64);
            this.btnSavePlate.TabIndex = 6;
            this.btnSavePlate.Text = "Plaka Kaydet";
            this.btnSavePlate.UseVisualStyleBackColor = true;
            this.btnSavePlate.Click += new System.EventHandler(this.btnSavePlate_Click);
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaka.Location = new System.Drawing.Point(5, 203);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(41, 18);
            this.lblPlaka.TabIndex = 5;
            this.lblPlaka.Text = "Tel : ";
            // 
            // tbxPlate
            // 
            this.tbxPlate.Location = new System.Drawing.Point(73, 229);
            this.tbxPlate.Name = "tbxPlate";
            this.tbxPlate.Size = new System.Drawing.Size(197, 20);
            this.tbxPlate.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(4, 149);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(68, 18);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Soyadı : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(5, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Adı : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pbxCar
            // 
            this.pbxCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCar.BackColor = System.Drawing.Color.Gray;
            this.pbxCar.Location = new System.Drawing.Point(276, 0);
            this.pbxCar.Name = "pbxCar";
            this.pbxCar.Size = new System.Drawing.Size(854, 300);
            this.pbxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCar.TabIndex = 2;
            this.pbxCar.TabStop = false;
            this.pbxCar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgwPlateData
            // 
            this.dgwPlateData.BackgroundColor = System.Drawing.Color.Coral;
            this.dgwPlateData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPlateData.Location = new System.Drawing.Point(276, 306);
            this.dgwPlateData.Name = "dgwPlateData";
            this.dgwPlateData.Size = new System.Drawing.Size(854, 169);
            this.dgwPlateData.TabIndex = 3;
            // 
            // PlateRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgwPlateData);
            this.Controls.Add(this.pbxCar);
            this.Controls.Add(this.panel1);
            this.Name = "PlateRegister";
            this.Size = new System.Drawing.Size(1130, 475);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPlateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.TextBox tbxPlate;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSavePlate;
        private System.Windows.Forms.PictureBox pbxCar;
        private System.Windows.Forms.PictureBox pbxPlate;
        private System.Windows.Forms.DataGridView dgwPlateData;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnDeletePlate;
        private System.Windows.Forms.Button btnUpdatePlate;
    }
}
