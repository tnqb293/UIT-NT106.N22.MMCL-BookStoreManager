namespace Client.Forms
{
    partial class FMainCustomer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainCustomer));
            this.pnContentCustomer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnControlCustomer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnSettingAccountPanel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchaseHistoryPanel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboardPanel = new Guna.UI2.WinForms.Guna2Button();
            this.btnListBookPanel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPurchaseBookPanel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbNameCustomer = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnControlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnContentCustomer
            // 
            this.pnContentCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContentCustomer.Location = new System.Drawing.Point(199, 0);
            this.pnContentCustomer.Name = "pnContentCustomer";
            this.pnContentCustomer.Size = new System.Drawing.Size(862, 720);
            this.pnContentCustomer.TabIndex = 5;
            this.pnContentCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContentAdmin_Paint);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnControlCustomer
            // 
            this.pnControlCustomer.Controls.Add(this.btnSettingAccountPanel);
            this.pnControlCustomer.Controls.Add(this.btnPurchaseHistoryPanel);
            this.pnControlCustomer.Controls.Add(this.btnDashboardPanel);
            this.pnControlCustomer.Controls.Add(this.btnListBookPanel);
            this.pnControlCustomer.Controls.Add(this.btnPurchaseBookPanel);
            this.pnControlCustomer.Controls.Add(this.guna2PictureBox2);
            this.pnControlCustomer.Controls.Add(this.lbMoney);
            this.pnControlCustomer.Controls.Add(this.lbNameCustomer);
            this.pnControlCustomer.Controls.Add(this.guna2PictureBox1);
            this.pnControlCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnControlCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.pnControlCustomer.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.pnControlCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnControlCustomer.Name = "pnControlCustomer";
            this.pnControlCustomer.Size = new System.Drawing.Size(199, 720);
            this.pnControlCustomer.TabIndex = 4;
            this.pnControlCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnControlCustomer_Paint);
            // 
            // btnSettingAccountPanel
            // 
            this.btnSettingAccountPanel.Animated = true;
            this.btnSettingAccountPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnSettingAccountPanel.BorderRadius = 20;
            this.btnSettingAccountPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnSettingAccountPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSettingAccountPanel.ForeColor = System.Drawing.Color.White;
            this.btnSettingAccountPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnSettingAccountPanel.Location = new System.Drawing.Point(-36, 465);
            this.btnSettingAccountPanel.Name = "btnSettingAccountPanel";
            this.btnSettingAccountPanel.Size = new System.Drawing.Size(220, 45);
            this.btnSettingAccountPanel.TabIndex = 20;
            this.btnSettingAccountPanel.Text = "Tài khoản";
            this.btnSettingAccountPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettingAccountPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnSettingAccountPanel.Click += new System.EventHandler(this.btnSettingAccountPanel_Click);
            // 
            // btnPurchaseHistoryPanel
            // 
            this.btnPurchaseHistoryPanel.Animated = true;
            this.btnPurchaseHistoryPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchaseHistoryPanel.BorderRadius = 20;
            this.btnPurchaseHistoryPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnPurchaseHistoryPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPurchaseHistoryPanel.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseHistoryPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnPurchaseHistoryPanel.Location = new System.Drawing.Point(-36, 414);
            this.btnPurchaseHistoryPanel.Name = "btnPurchaseHistoryPanel";
            this.btnPurchaseHistoryPanel.Size = new System.Drawing.Size(220, 45);
            this.btnPurchaseHistoryPanel.TabIndex = 19;
            this.btnPurchaseHistoryPanel.Text = "Lịch sử mua";
            this.btnPurchaseHistoryPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchaseHistoryPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnPurchaseHistoryPanel.Click += new System.EventHandler(this.btnPurchaseHistory_Click);
            // 
            // btnDashboardPanel
            // 
            this.btnDashboardPanel.Animated = true;
            this.btnDashboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardPanel.BorderRadius = 20;
            this.btnDashboardPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboardPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardPanel.ForeColor = System.Drawing.Color.White;
            this.btnDashboardPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnDashboardPanel.Location = new System.Drawing.Point(-36, 261);
            this.btnDashboardPanel.Name = "btnDashboardPanel";
            this.btnDashboardPanel.Size = new System.Drawing.Size(220, 45);
            this.btnDashboardPanel.TabIndex = 17;
            this.btnDashboardPanel.Text = "Bảng điều khiển";
            this.btnDashboardPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboardPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnDashboardPanel.Click += new System.EventHandler(this.btnDashboardPanel_Click);
            // 
            // btnListBookPanel
            // 
            this.btnListBookPanel.Animated = true;
            this.btnListBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnListBookPanel.BorderRadius = 20;
            this.btnListBookPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnListBookPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBookPanel.ForeColor = System.Drawing.Color.White;
            this.btnListBookPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnListBookPanel.Location = new System.Drawing.Point(-36, 312);
            this.btnListBookPanel.Name = "btnListBookPanel";
            this.btnListBookPanel.Size = new System.Drawing.Size(220, 45);
            this.btnListBookPanel.TabIndex = 18;
            this.btnListBookPanel.Text = "Cửa hàng ebook";
            this.btnListBookPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListBookPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnListBookPanel.Click += new System.EventHandler(this.btnListBookPanel_Click);
            // 
            // btnPurchaseBookPanel
            // 
            this.btnPurchaseBookPanel.Animated = true;
            this.btnPurchaseBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnPurchaseBookPanel.BorderRadius = 20;
            this.btnPurchaseBookPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnPurchaseBookPanel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnPurchaseBookPanel.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseBookPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnPurchaseBookPanel.Location = new System.Drawing.Point(-36, 363);
            this.btnPurchaseBookPanel.Name = "btnPurchaseBookPanel";
            this.btnPurchaseBookPanel.Size = new System.Drawing.Size(220, 45);
            this.btnPurchaseBookPanel.TabIndex = 16;
            this.btnPurchaseBookPanel.Text = "Sách đã mua";
            this.btnPurchaseBookPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPurchaseBookPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnPurchaseBookPanel.Click += new System.EventHandler(this.btnPurchaseBookPanel_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(32, 176);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(49, 44);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbMoney.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.ForeColor = System.Drawing.Color.White;
            this.lbMoney.Location = new System.Drawing.Point(80, 186);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(78, 25);
            this.lbMoney.TabIndex = 5;
            this.lbMoney.Text = "120000";
            // 
            // lbNameCustomer
            // 
            this.lbNameCustomer.AutoSize = true;
            this.lbNameCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lbNameCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameCustomer.ForeColor = System.Drawing.Color.White;
            this.lbNameCustomer.Location = new System.Drawing.Point(88, 161);
            this.lbNameCustomer.Name = "lbNameCustomer";
            this.lbNameCustomer.Size = new System.Drawing.Size(71, 25);
            this.lbNameCustomer.TabIndex = 4;
            this.lbNameCustomer.Text = "Admin";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 33);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(172, 68);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // FMainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 720);
            this.Controls.Add(this.pnContentCustomer);
            this.Controls.Add(this.pnControlCustomer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMainCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMainCustomer";
            this.Load += new System.EventHandler(this.FMainCustomer_Load);
            this.pnControlCustomer.ResumeLayout(false);
            this.pnControlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lbMoney;
        public Guna.UI2.WinForms.Guna2GradientPanel pnContentCustomer;
        public Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2GradientPanel pnControlCustomer;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        public System.Windows.Forms.Label lbNameCustomer;
        public Guna.UI2.WinForms.Guna2Button btnPurchaseHistoryPanel;
        public Guna.UI2.WinForms.Guna2Button btnDashboardPanel;
        public Guna.UI2.WinForms.Guna2Button btnListBookPanel;
        public Guna.UI2.WinForms.Guna2Button btnPurchaseBookPanel;
        public Guna.UI2.WinForms.Guna2Button btnSettingAccountPanel;
    }
}