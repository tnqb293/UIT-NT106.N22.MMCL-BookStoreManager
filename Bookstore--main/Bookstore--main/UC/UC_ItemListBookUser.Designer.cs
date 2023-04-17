namespace Bookstore__main.UC
{
    partial class UC_ItemListBookUser
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
            this.PictureBook = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.QuantityBook = new System.Windows.Forms.Label();
            this.NationBook = new System.Windows.Forms.Label();
            this.PriceBook = new System.Windows.Forms.Label();
            this.CategoryBook = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.WriterName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBook)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBook
            // 
            this.PictureBook.BackColor = System.Drawing.Color.Transparent;
            this.PictureBook.BorderRadius = 5;
            this.PictureBook.ImageRotate = 0F;
            this.PictureBook.Location = new System.Drawing.Point(3, 2);
            this.PictureBook.Name = "PictureBook";
            this.PictureBook.Size = new System.Drawing.Size(63, 100);
            this.PictureBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBook.TabIndex = 51;
            this.PictureBook.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.Guna2Button17);
            this.guna2Panel1.Controls.Add(this.QuantityBook);
            this.guna2Panel1.Controls.Add(this.NationBook);
            this.guna2Panel1.Controls.Add(this.PriceBook);
            this.guna2Panel1.Controls.Add(this.CategoryBook);
            this.guna2Panel1.Controls.Add(this.BookName);
            this.guna2Panel1.Controls.Add(this.WriterName);
            this.guna2Panel1.Controls.Add(this.PictureBook);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(237, 110);
            this.guna2Panel1.TabIndex = 1;
            // 
            // Guna2Button17
            // 
            this.Guna2Button17.Animated = true;
            this.Guna2Button17.BackColor = System.Drawing.Color.Transparent;
            this.Guna2Button17.BorderRadius = 10;
            this.Guna2Button17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.Guna2Button17.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2Button17.ForeColor = System.Drawing.Color.White;
            this.Guna2Button17.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.Guna2Button17.Location = new System.Drawing.Point(166, 63);
            this.Guna2Button17.Name = "Guna2Button17";
            this.Guna2Button17.Size = new System.Drawing.Size(62, 26);
            this.Guna2Button17.TabIndex = 58;
            this.Guna2Button17.Text = "Buy Now";
            // 
            // QuantityBook
            // 
            this.QuantityBook.AutoSize = true;
            this.QuantityBook.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuantityBook.Location = new System.Drawing.Point(69, 84);
            this.QuantityBook.Name = "QuantityBook";
            this.QuantityBook.Size = new System.Drawing.Size(35, 12);
            this.QuantityBook.TabIndex = 57;
            this.QuantityBook.Text = "100000";
            this.QuantityBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NationBook
            // 
            this.NationBook.AutoSize = true;
            this.NationBook.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationBook.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NationBook.Location = new System.Drawing.Point(185, 2);
            this.NationBook.Name = "NationBook";
            this.NationBook.Size = new System.Drawing.Size(44, 12);
            this.NationBook.TabIndex = 56;
            this.NationBook.Text = "Nhật Bản";
            // 
            // PriceBook
            // 
            this.PriceBook.AutoSize = true;
            this.PriceBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.PriceBook.Location = new System.Drawing.Point(68, 67);
            this.PriceBook.Name = "PriceBook";
            this.PriceBook.Size = new System.Drawing.Size(83, 17);
            this.PriceBook.TabIndex = 55;
            this.PriceBook.Text = "100000 VND";
            this.PriceBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryBook
            // 
            this.CategoryBook.AutoSize = true;
            this.CategoryBook.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CategoryBook.Location = new System.Drawing.Point(69, 2);
            this.CategoryBook.Name = "CategoryBook";
            this.CategoryBook.Size = new System.Drawing.Size(52, 12);
            this.CategoryBook.TabIndex = 54;
            this.CategoryBook.Text = "Hành động";
            this.CategoryBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookName
            // 
            this.BookName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BookName.Location = new System.Drawing.Point(68, 14);
            this.BookName.MaximumSize = new System.Drawing.Size(300, 60);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(152, 33);
            this.BookName.TabIndex = 53;
            this.BookName.Text = "RE:ZERO - Bắt đầu lại ở thế giới khác 15";
            // 
            // WriterName
            // 
            this.WriterName.AutoSize = true;
            this.WriterName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.WriterName.Location = new System.Drawing.Point(69, 47);
            this.WriterName.Name = "WriterName";
            this.WriterName.Size = new System.Drawing.Size(107, 13);
            this.WriterName.TabIndex = 52;
            this.WriterName.Text = "Gun Gun Febrianza";
            // 
            // UC_ItemListBookUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ItemListBookUser";
            this.Size = new System.Drawing.Size(237, 110);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBook)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2PictureBox PictureBook;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button17;
        internal System.Windows.Forms.Label QuantityBook;
        internal System.Windows.Forms.Label NationBook;
        internal System.Windows.Forms.Label PriceBook;
        internal System.Windows.Forms.Label CategoryBook;
        internal System.Windows.Forms.Label BookName;
        internal System.Windows.Forms.Label WriterName;
    }
}
