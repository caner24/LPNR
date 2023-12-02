namespace PlatePass.Panels
{
    partial class PlateDetail
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
            tbxPlate = new TextBox();
            label1 = new Label();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            tbxSurname = new TextBox();
            lblSurname = new Label();
            tbxName = new TextBox();
            lblName = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            pbxLogo = new PictureBox();
            label2 = new Label();
            dgwGecis = new DataGridView();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwGecis).BeginInit();
            SuspendLayout();
            // 
            // tbxPlate
            // 
            tbxPlate.Location = new System.Drawing.Point(71, 126);
            tbxPlate.Name = "tbxPlate";
            tbxPlate.Size = new System.Drawing.Size(200, 23);
            tbxPlate.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 126);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 18);
            label1.TabIndex = 14;
            label1.Text = "Plaka :";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new System.Drawing.Point(71, 224);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new System.Drawing.Size(200, 23);
            tbxEmail.TabIndex = 24;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new System.Drawing.Point(3, 229);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(55, 18);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email :";
            // 
            // tbxSurname
            // 
            tbxSurname.Location = new System.Drawing.Point(71, 193);
            tbxSurname.Name = "tbxSurname";
            tbxSurname.Size = new System.Drawing.Size(200, 23);
            tbxSurname.TabIndex = 22;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSurname.Location = new System.Drawing.Point(0, 197);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(64, 18);
            lblSurname.TabIndex = 21;
            lblSurname.Text = "Soyad : ";
            // 
            // tbxName
            // 
            tbxName.Location = new System.Drawing.Point(71, 157);
            tbxName.Name = "tbxName";
            tbxName.Size = new System.Drawing.Size(200, 23);
            tbxName.TabIndex = 20;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new System.Drawing.Point(3, 158);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(39, 18);
            lblName.TabIndex = 19;
            lblName.Text = "Ad : ";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(3, 347);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(268, 57);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(3, 410);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(268, 62);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Kaydı Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = Properties.Resources.Kouyenilogo;
            pbxLogo.Location = new System.Drawing.Point(5, 3);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new System.Drawing.Size(270, 117);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 27;
            pbxLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(579, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(228, 28);
            label2.TabIndex = 29;
            label2.Text = "~~~ Tüm Geçişler ~~~";
            // 
            // dgwGecis
            // 
            dgwGecis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwGecis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGecis.Location = new System.Drawing.Point(280, 34);
            dgwGecis.Name = "dgwGecis";
            dgwGecis.RowTemplate.Height = 25;
            dgwGecis.Size = new System.Drawing.Size(848, 439);
            dgwGecis.TabIndex = 28;
            dgwGecis.CellDoubleClick += dgwGecis_CellDoubleClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(3, 284);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(268, 57);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // PlateDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Coral;
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(dgwGecis);
            Controls.Add(pbxLogo);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(tbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(tbxSurname);
            Controls.Add(lblSurname);
            Controls.Add(tbxName);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(tbxPlate);
            Name = "PlateDetail";
            Size = new System.Drawing.Size(1130, 475);
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwGecis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxPlate;
        private Label label1;
        private TextBox tbxEmail;
        private Label lblEmail;
        private TextBox tbxSurname;
        private Label lblSurname;
        private TextBox tbxName;
        private Label lblName;
        private Button btnUpdate;
        private Button btnDelete;
        private PictureBox pbxLogo;
        private Label label2;
        private DataGridView dgwGecis;
        private Button btnSearch;
    }
}
