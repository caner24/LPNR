
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
            components = new System.ComponentModel.Container();
            pbxCamera = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pbxPlate = new PictureBox();
            button2 = new Button();
            btnSorgula = new Button();
            btnOpenCamera = new Button();
            tbxPlaka = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxCamera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPlate).BeginInit();
            SuspendLayout();
            // 
            // pbxCamera
            // 
            pbxCamera.Image = Properties.Resources._1;
            pbxCamera.Location = new System.Drawing.Point(187, 3);
            pbxCamera.Name = "pbxCamera";
            pbxCamera.Size = new System.Drawing.Size(940, 272);
            pbxCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxCamera.TabIndex = 0;
            pbxCamera.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pbxPlate
            // 
            pbxPlate.Location = new System.Drawing.Point(3, 346);
            pbxPlate.Name = "pbxPlate";
            pbxPlate.Size = new System.Drawing.Size(334, 126);
            pbxPlate.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPlate.TabIndex = 2;
            pbxPlate.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(975, 384);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(152, 88);
            button2.TabIndex = 3;
            button2.Text = "Dosyadan Aç";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSorgula
            // 
            btnSorgula.Location = new System.Drawing.Point(973, 281);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new System.Drawing.Size(152, 80);
            btnSorgula.TabIndex = 4;
            btnSorgula.Text = "Sorgula";
            btnSorgula.UseVisualStyleBackColor = true;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // btnOpenCamera
            // 
            btnOpenCamera.Location = new System.Drawing.Point(815, 281);
            btnOpenCamera.Name = "btnOpenCamera";
            btnOpenCamera.Size = new System.Drawing.Size(152, 80);
            btnOpenCamera.TabIndex = 5;
            btnOpenCamera.Text = "Kamera Aç";
            btnOpenCamera.UseVisualStyleBackColor = true;
            btnOpenCamera.Click += btnOpenCamera_Click;
            // 
            // tbxPlaka
            // 
            tbxPlaka.Location = new System.Drawing.Point(23, 298);
            tbxPlaka.Name = "tbxPlaka";
            tbxPlaka.Size = new System.Drawing.Size(200, 23);
            tbxPlaka.TabIndex = 19;
            // 
            // PlateReader
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbxPlaka);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxCamera;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbxPlate;
        private Button button2;
        private Button btnSorgula;
        private Button btnOpenCamera;
        private TextBox tbxPlaka;
    }
}
