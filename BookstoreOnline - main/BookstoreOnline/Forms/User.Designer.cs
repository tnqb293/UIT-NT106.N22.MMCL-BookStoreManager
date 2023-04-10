namespace BookstoreOnline.Forms
{
    partial class User
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
            this.pnControl = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnCartPanel = new Guna.UI2.WinForms.Guna2Button();
            this.btnBookPanel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboardPanel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pn_Container = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnControl.SuspendLayout();
            this.pn_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btnAddBook);
            this.pnControl.Controls.Add(this.btnCartPanel);
            this.pnControl.Controls.Add(this.btnBookPanel);
            this.pnControl.Controls.Add(this.btnDashboardPanel);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(68)))));
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(238, 720);
            this.pnControl.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Animated = true;
            this.btnAddBook.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBook.BorderRadius = 20;
            this.btnAddBook.FillColor = System.Drawing.Color.Transparent;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnAddBook.Location = new System.Drawing.Point(-16, 338);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(187, 45);
            this.btnAddBook.TabIndex = 9;
            this.btnAddBook.Text = "Add book";
            this.btnAddBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddBook.TextOffset = new System.Drawing.Point(60, 0);
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnCartPanel
            // 
            this.btnCartPanel.Animated = true;
            this.btnCartPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnCartPanel.BorderRadius = 20;
            this.btnCartPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnCartPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCartPanel.ForeColor = System.Drawing.Color.White;
            this.btnCartPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnCartPanel.Location = new System.Drawing.Point(-16, 287);
            this.btnCartPanel.Name = "btnCartPanel";
            this.btnCartPanel.Size = new System.Drawing.Size(187, 45);
            this.btnCartPanel.TabIndex = 8;
            this.btnCartPanel.Text = "Cart";
            this.btnCartPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCartPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnCartPanel.Click += new System.EventHandler(this.btnCartPanel_Click);
            // 
            // btnBookPanel
            // 
            this.btnBookPanel.Animated = true;
            this.btnBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnBookPanel.BorderRadius = 20;
            this.btnBookPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnBookPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBookPanel.ForeColor = System.Drawing.Color.White;
            this.btnBookPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnBookPanel.Location = new System.Drawing.Point(-16, 236);
            this.btnBookPanel.Name = "btnBookPanel";
            this.btnBookPanel.Size = new System.Drawing.Size(187, 45);
            this.btnBookPanel.TabIndex = 7;
            this.btnBookPanel.Text = "Books";
            this.btnBookPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBookPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnBookPanel.Click += new System.EventHandler(this.btnBookPanel_Click);
            // 
            // btnDashboardPanel
            // 
            this.btnDashboardPanel.Animated = true;
            this.btnDashboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboardPanel.BorderRadius = 20;
            this.btnDashboardPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboardPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDashboardPanel.ForeColor = System.Drawing.Color.White;
            this.btnDashboardPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnDashboardPanel.Location = new System.Drawing.Point(-16, 185);
            this.btnDashboardPanel.Name = "btnDashboardPanel";
            this.btnDashboardPanel.Size = new System.Drawing.Size(187, 45);
            this.btnDashboardPanel.TabIndex = 6;
            this.btnDashboardPanel.Text = "Dashboard";
            this.btnDashboardPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboardPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnDashboardPanel.Click += new System.EventHandler(this.btnDashboardPanel_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnControl;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pn_Container
            // 
            this.pn_Container.Controls.Add(this.Guna2ControlBox2);
            this.pn_Container.Controls.Add(this.Guna2ControlBox1);
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(238, 0);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(1103, 720);
            this.pn_Container.TabIndex = 19;
            // 
            // Guna2ControlBox2
            // 
            this.Guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.Guna2ControlBox2.Location = new System.Drawing.Point(1034, 12);
            this.Guna2ControlBox2.Name = "Guna2ControlBox2";
            this.Guna2ControlBox2.Size = new System.Drawing.Size(27, 25);
            this.Guna2ControlBox2.TabIndex = 20;
            // 
            // Guna2ControlBox1
            // 
            this.Guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.Guna2ControlBox1.Location = new System.Drawing.Point(1067, 12);
            this.Guna2ControlBox1.Name = "Guna2ControlBox1";
            this.Guna2ControlBox1.Size = new System.Drawing.Size(27, 25);
            this.Guna2ControlBox1.TabIndex = 19;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 720);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.pnControl);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "User";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.pnControl.ResumeLayout(false);
            this.pn_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnControl;
        internal Guna.UI2.WinForms.Guna2Button btnCartPanel;
        private Guna.UI2.WinForms.Guna2Button btnBookPanel;
        internal Guna.UI2.WinForms.Guna2Button btnDashboardPanel;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel pn_Container;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox2;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
        internal Guna.UI2.WinForms.Guna2Button btnAddBook;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
    }
}