namespace PlatePass
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            plateReaderToolStripMenuItem = new ToolStripMenuItem();
            plateRegisterToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnClose = new Button();
            btnFullScreen = new Button();
            btnHide = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plateReaderToolStripMenuItem, plateRegisterToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1130, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // plateReaderToolStripMenuItem
            // 
            plateReaderToolStripMenuItem.Name = "plateReaderToolStripMenuItem";
            plateReaderToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            plateReaderToolStripMenuItem.Text = "Plate Reader";
            plateReaderToolStripMenuItem.Click += plateReaderToolStripMenuItem_Click;
            // 
            // plateRegisterToolStripMenuItem
            // 
            plateRegisterToolStripMenuItem.Name = "plateRegisterToolStripMenuItem";
            plateRegisterToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            plateRegisterToolStripMenuItem.Text = "Plate Register";
            plateRegisterToolStripMenuItem.Click += plateRegisterToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Coral;
            panel1.Location = new System.Drawing.Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1130, 475);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(1091, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(37, 24);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnFullScreen
            // 
            btnFullScreen.Font = new Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFullScreen.Location = new System.Drawing.Point(1051, 0);
            btnFullScreen.Name = "btnFullScreen";
            btnFullScreen.Size = new System.Drawing.Size(37, 24);
            btnFullScreen.TabIndex = 1;
            btnFullScreen.Text = "[]";
            btnFullScreen.UseVisualStyleBackColor = true;
            btnFullScreen.Click += btnFullScreen_Click;
            // 
            // btnHide
            // 
            btnHide.Font = new Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHide.Location = new System.Drawing.Point(1010, 1);
            btnHide.Name = "btnHide";
            btnHide.Size = new System.Drawing.Size(37, 24);
            btnHide.TabIndex = 1;
            btnHide.Text = "_";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.AntiqueWhite;
            ClientSize = new System.Drawing.Size(1130, 529);
            Controls.Add(btnHide);
            Controls.Add(btnFullScreen);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem plateReaderToolStripMenuItem;
        private ToolStripMenuItem plateRegisterToolStripMenuItem;
        private Panel panel1;
        private Button btnFullScreen;
        private Button btnClose;
        private Button btnHide;
    }
}