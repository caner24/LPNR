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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plateReaderToolStripMenuItem, plateRegisterToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1130, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // plateReaderToolStripMenuItem
            // 
            plateReaderToolStripMenuItem.Name = "plateReaderToolStripMenuItem";
            plateReaderToolStripMenuItem.Size = new Size(84, 20);
            plateReaderToolStripMenuItem.Text = "Plate Reader";
            plateReaderToolStripMenuItem.Click += plateReaderToolStripMenuItem_Click;
            // 
            // plateRegisterToolStripMenuItem
            // 
            plateRegisterToolStripMenuItem.Name = "plateRegisterToolStripMenuItem";
            plateRegisterToolStripMenuItem.Size = new Size(90, 20);
            plateRegisterToolStripMenuItem.Text = "Plate Register";
            plateRegisterToolStripMenuItem.Click += plateRegisterToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1130, 475);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1130, 529);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
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
    }
}