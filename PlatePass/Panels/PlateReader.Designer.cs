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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxCamera).BeginInit();
            SuspendLayout();
            // 
            // pbxCamera
            // 
            pbxCamera.Location = new Point(187, 3);
            pbxCamera.Name = "pbxCamera";
            pbxCamera.Size = new Size(940, 272);
            pbxCamera.TabIndex = 0;
            pbxCamera.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(187, 360);
            button1.Name = "button1";
            button1.Size = new Size(940, 112);
            button1.TabIndex = 1;
            button1.Text = "İsle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PlateReader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(pbxCamera);
            Name = "PlateReader";
            Size = new Size(1130, 475);
            ((System.ComponentModel.ISupportInitialize)pbxCamera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxCamera;
        private Button button1;
    }
}
