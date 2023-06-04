namespace Client.UC
{
    partial class UCItemReadBookCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCItemReadBookCustomer));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReadBook = new Guna.UI2.WinForms.Guna2Button();
            this.lbNumberOfBookRemaining = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbWriterName = new System.Windows.Forms.Label();
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.pbCoverImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Red;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnReadBook);
            this.guna2Panel1.Controls.Add(this.lbNumberOfBookRemaining);
            this.guna2Panel1.Controls.Add(this.lbMoney);
            this.guna2Panel1.Controls.Add(this.lbWriterName);
            this.guna2Panel1.Controls.Add(this.lbBookName);
            this.guna2Panel1.Controls.Add(this.lbCountry);
            this.guna2Panel1.Controls.Add(this.lbLanguage);
            this.guna2Panel1.Controls.Add(this.pbCoverImage);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(353, 129);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnReadBook
            // 
            this.btnReadBook.BackColor = System.Drawing.Color.Transparent;
            this.btnReadBook.BorderRadius = 5;
            this.btnReadBook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnReadBook.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReadBook.ForeColor = System.Drawing.Color.White;
            this.btnReadBook.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnReadBook.Image = ((System.Drawing.Image)(resources.GetObject("btnReadBook.Image")));
            this.btnReadBook.ImageSize = new System.Drawing.Size(32, 32);
            this.btnReadBook.Location = new System.Drawing.Point(258, 70);
            this.btnReadBook.Name = "btnReadBook";
            this.btnReadBook.Size = new System.Drawing.Size(90, 50);
            this.btnReadBook.TabIndex = 64;
            this.btnReadBook.Click += new System.EventHandler(this.btnReadBook_Click);
            // 
            // lbNumberOfBookRemaining
            // 
            this.lbNumberOfBookRemaining.AutoSize = true;
            this.lbNumberOfBookRemaining.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfBookRemaining.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbNumberOfBookRemaining.Location = new System.Drawing.Point(105, 107);
            this.lbNumberOfBookRemaining.Name = "lbNumberOfBookRemaining";
            this.lbNumberOfBookRemaining.Size = new System.Drawing.Size(68, 13);
            this.lbNumberOfBookRemaining.TabIndex = 62;
            this.lbNumberOfBookRemaining.Text = "Đã bán: 130";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lbMoney.Location = new System.Drawing.Point(104, 84);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(148, 21);
            this.lbMoney.TabIndex = 60;
            this.lbMoney.Text = "100.000.000.0VND";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWriterName
            // 
            this.lbWriterName.AutoSize = true;
            this.lbWriterName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWriterName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbWriterName.Location = new System.Drawing.Point(104, 67);
            this.lbWriterName.Name = "lbWriterName";
            this.lbWriterName.Size = new System.Drawing.Size(121, 17);
            this.lbWriterName.TabIndex = 59;
            this.lbWriterName.Text = "Gun Gun Febranza";
            // 
            // lbBookName
            // 
            this.lbBookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBookName.Location = new System.Drawing.Point(104, 25);
            this.lbBookName.MaximumSize = new System.Drawing.Size(300, 60);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(244, 42);
            this.lbBookName.TabIndex = 58;
            this.lbBookName.Text = "RE:ZERO - Bắt đầu lại ở thế giới khác 15";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCountry.Location = new System.Drawing.Point(240, 3);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(108, 13);
            this.lbCountry.TabIndex = 57;
            this.lbCountry.Text = "Quốc gia: Nhật Bản";
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLanguage.Location = new System.Drawing.Point(104, 3);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(66, 13);
            this.lbLanguage.TabIndex = 55;
            this.lbLanguage.Text = "Hành động";
            this.lbLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCoverImage
            // 
            this.pbCoverImage.BackColor = System.Drawing.Color.Transparent;
            this.pbCoverImage.BorderRadius = 5;
            this.pbCoverImage.Image = ((System.Drawing.Image)(resources.GetObject("pbCoverImage.Image")));
            this.pbCoverImage.ImageRotate = 0F;
            this.pbCoverImage.Location = new System.Drawing.Point(3, 3);
            this.pbCoverImage.Name = "pbCoverImage";
            this.pbCoverImage.Size = new System.Drawing.Size(95, 123);
            this.pbCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoverImage.TabIndex = 52;
            this.pbCoverImage.TabStop = false;
            // 
            // UCItemReadBookCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCItemReadBookCustomer";
            this.Size = new System.Drawing.Size(353, 129);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoverImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        internal Guna.UI2.WinForms.Guna2Button btnReadBook;
        internal System.Windows.Forms.Label lbNumberOfBookRemaining;
        internal System.Windows.Forms.Label lbMoney;
        internal System.Windows.Forms.Label lbWriterName;
        internal System.Windows.Forms.Label lbBookName;
        internal System.Windows.Forms.Label lbCountry;
        internal System.Windows.Forms.Label lbLanguage;
        internal Guna.UI2.WinForms.Guna2PictureBox pbCoverImage;
    }
}
