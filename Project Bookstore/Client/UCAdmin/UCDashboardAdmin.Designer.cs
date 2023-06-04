namespace Client.UC
{
    partial class UCDashboardAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDashboardAdmin));
            this.dgvCustomerChart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TopCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBookChart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnStatistics = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbNumberofBookAvailable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnNumberOfBooksPurchase = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbBookSold = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbCustomerNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnAmountPaid = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnExitDashboardCustomer = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookChart)).BeginInit();
            this.pnStatistics.SuspendLayout();
            this.guna2GradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.pnNumberOfBooksPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnAmountPaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomerChart
            // 
            this.dgvCustomerChart.AllowUserToAddRows = false;
            this.dgvCustomerChart.AllowUserToDeleteRows = false;
            this.dgvCustomerChart.AllowUserToResizeColumns = false;
            this.dgvCustomerChart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCustomerChart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerChart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerChart.ColumnHeadersHeight = 28;
            this.dgvCustomerChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomerChart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TopCustomer,
            this.Customer,
            this.NumberBook});
            this.dgvCustomerChart.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerChart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerChart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerChart.Location = new System.Drawing.Point(22, 169);
            this.dgvCustomerChart.Name = "dgvCustomerChart";
            this.dgvCustomerChart.RowHeadersVisible = false;
            this.dgvCustomerChart.Size = new System.Drawing.Size(390, 488);
            this.dgvCustomerChart.TabIndex = 13;
            this.dgvCustomerChart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerChart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomerChart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerChart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomerChart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerChart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerChart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerChart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCustomerChart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomerChart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerChart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomerChart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomerChart.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvCustomerChart.ThemeStyle.ReadOnly = false;
            this.dgvCustomerChart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerChart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomerChart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerChart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerChart.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCustomerChart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerChart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TopCustomer
            // 
            this.TopCustomer.FillWeight = 30.45685F;
            this.TopCustomer.HeaderText = "Top";
            this.TopCustomer.Name = "TopCustomer";
            this.TopCustomer.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.FillWeight = 134.7716F;
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            // 
            // NumberBook
            // 
            this.NumberBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NumberBook.FillWeight = 134.7716F;
            this.NumberBook.HeaderText = "Number of books purchased";
            this.NumberBook.Name = "NumberBook";
            this.NumberBook.Width = 161;
            // 
            // dgvBookChart
            // 
            this.dgvBookChart.AllowUserToAddRows = false;
            this.dgvBookChart.AllowUserToDeleteRows = false;
            this.dgvBookChart.AllowUserToResizeColumns = false;
            this.dgvBookChart.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBookChart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookChart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBookChart.ColumnHeadersHeight = 28;
            this.dgvBookChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBookChart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.bookname,
            this.booksold});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookChart.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBookChart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBookChart.Location = new System.Drawing.Point(450, 169);
            this.dgvBookChart.Name = "dgvBookChart";
            this.dgvBookChart.RowHeadersVisible = false;
            this.dgvBookChart.Size = new System.Drawing.Size(390, 488);
            this.dgvBookChart.TabIndex = 14;
            this.dgvBookChart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookChart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBookChart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBookChart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBookChart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBookChart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookChart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBookChart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBookChart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBookChart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookChart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBookChart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBookChart.ThemeStyle.HeaderStyle.Height = 28;
            this.dgvBookChart.ThemeStyle.ReadOnly = false;
            this.dgvBookChart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookChart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBookChart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookChart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBookChart.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBookChart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBookChart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 30.45685F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Top";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // bookname
            // 
            this.bookname.FillWeight = 142.5432F;
            this.bookname.HeaderText = "Book name";
            this.bookname.Name = "bookname";
            // 
            // booksold
            // 
            this.booksold.FillWeight = 126.9999F;
            this.booksold.HeaderText = "Number of books sold";
            this.booksold.Name = "booksold";
            // 
            // pnStatistics
            // 
            this.pnStatistics.Controls.Add(this.guna2GradientPanel4);
            this.pnStatistics.Controls.Add(this.pnNumberOfBooksPurchase);
            this.pnStatistics.Controls.Add(this.guna2GradientPanel2);
            this.pnStatistics.Controls.Add(this.pnAmountPaid);
            this.pnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnStatistics.Location = new System.Drawing.Point(0, 42);
            this.pnStatistics.Name = "pnStatistics";
            this.pnStatistics.Size = new System.Drawing.Size(863, 115);
            this.pnStatistics.TabIndex = 12;
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BorderRadius = 20;
            this.guna2GradientPanel4.Controls.Add(this.guna2PictureBox4);
            this.guna2GradientPanel4.Controls.Add(this.lbNumberofBookAvailable);
            this.guna2GradientPanel4.Controls.Add(this.label8);
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(640, 6);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(200, 100);
            this.guna2GradientPanel4.TabIndex = 3;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(142, 11);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(46, 43);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 2;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            // 
            // lbNumberofBookAvailable
            // 
            this.lbNumberofBookAvailable.AutoSize = true;
            this.lbNumberofBookAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lbNumberofBookAvailable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberofBookAvailable.ForeColor = System.Drawing.Color.Transparent;
            this.lbNumberofBookAvailable.Location = new System.Drawing.Point(12, 60);
            this.lbNumberofBookAvailable.Name = "lbNumberofBookAvailable";
            this.lbNumberofBookAvailable.Size = new System.Drawing.Size(67, 25);
            this.lbNumberofBookAvailable.TabIndex = 1;
            this.lbNumberofBookAvailable.Text = "10000";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(13, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 43);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ebook hiện có";
            // 
            // pnNumberOfBooksPurchase
            // 
            this.pnNumberOfBooksPurchase.BorderRadius = 20;
            this.pnNumberOfBooksPurchase.Controls.Add(this.guna2PictureBox3);
            this.pnNumberOfBooksPurchase.Controls.Add(this.lbBookSold);
            this.pnNumberOfBooksPurchase.Controls.Add(this.label6);
            this.pnNumberOfBooksPurchase.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pnNumberOfBooksPurchase.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.pnNumberOfBooksPurchase.Location = new System.Drawing.Point(228, 6);
            this.pnNumberOfBooksPurchase.Name = "pnNumberOfBooksPurchase";
            this.pnNumberOfBooksPurchase.Size = new System.Drawing.Size(200, 100);
            this.pnNumberOfBooksPurchase.TabIndex = 2;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(138, 11);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(46, 43);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 2;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // lbBookSold
            // 
            this.lbBookSold.AutoSize = true;
            this.lbBookSold.BackColor = System.Drawing.Color.Transparent;
            this.lbBookSold.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookSold.ForeColor = System.Drawing.Color.Transparent;
            this.lbBookSold.Location = new System.Drawing.Point(14, 60);
            this.lbBookSold.Name = "lbBookSold";
            this.lbBookSold.Size = new System.Drawing.Size(67, 25);
            this.lbBookSold.TabIndex = 1;
            this.lbBookSold.Text = "10000";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(13, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 49);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ebook đã bán";
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BorderRadius = 20;
            this.guna2GradientPanel2.Controls.Add(this.guna2PictureBox2);
            this.guna2GradientPanel2.Controls.Add(this.lbCustomerNumber);
            this.guna2GradientPanel2.Controls.Add(this.label4);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(434, 6);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(200, 100);
            this.guna2GradientPanel2.TabIndex = 1;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(138, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(46, 43);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // lbCustomerNumber
            // 
            this.lbCustomerNumber.AutoSize = true;
            this.lbCustomerNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbCustomerNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerNumber.ForeColor = System.Drawing.Color.Transparent;
            this.lbCustomerNumber.Location = new System.Drawing.Point(12, 60);
            this.lbCustomerNumber.Name = "lbCustomerNumber";
            this.lbCustomerNumber.Size = new System.Drawing.Size(67, 25);
            this.lbCustomerNumber.TabIndex = 1;
            this.lbCustomerNumber.Text = "10000";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 43);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khách hàng";
            // 
            // pnAmountPaid
            // 
            this.pnAmountPaid.BorderRadius = 20;
            this.pnAmountPaid.Controls.Add(this.guna2PictureBox1);
            this.pnAmountPaid.Controls.Add(this.lbRevenue);
            this.pnAmountPaid.Controls.Add(this.label1);
            this.pnAmountPaid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.pnAmountPaid.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.pnAmountPaid.Location = new System.Drawing.Point(22, 6);
            this.pnAmountPaid.Name = "pnAmountPaid";
            this.pnAmountPaid.Size = new System.Drawing.Size(200, 100);
            this.pnAmountPaid.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(138, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(46, 43);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lbRevenue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRevenue.ForeColor = System.Drawing.Color.Transparent;
            this.lbRevenue.Location = new System.Drawing.Point(12, 60);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(67, 25);
            this.lbRevenue.TabIndex = 1;
            this.lbRevenue.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.Guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.btnExitDashboardCustomer);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(863, 42);
            this.guna2Panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 33;
            // 
            // Guna2ControlBox2
            // 
            this.Guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.Guna2ControlBox2.Location = new System.Drawing.Point(782, 3);
            this.Guna2ControlBox2.Name = "Guna2ControlBox2";
            this.Guna2ControlBox2.Size = new System.Drawing.Size(36, 36);
            this.Guna2ControlBox2.TabIndex = 27;
            // 
            // btnExitDashboardCustomer
            // 
            this.btnExitDashboardCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitDashboardCustomer.FillColor = System.Drawing.Color.White;
            this.btnExitDashboardCustomer.IconColor = System.Drawing.Color.DimGray;
            this.btnExitDashboardCustomer.Location = new System.Drawing.Point(824, 3);
            this.btnExitDashboardCustomer.Name = "btnExitDashboardCustomer";
            this.btnExitDashboardCustomer.Size = new System.Drawing.Size(36, 36);
            this.btnExitDashboardCustomer.TabIndex = 26;
            // 
            // UCDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvCustomerChart);
            this.Controls.Add(this.dgvBookChart);
            this.Controls.Add(this.pnStatistics);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCDashboardAdmin";
            this.Size = new System.Drawing.Size(863, 663);
            this.Load += new System.EventHandler(this.UCDashboardAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookChart)).EndInit();
            this.pnStatistics.ResumeLayout(false);
            this.guna2GradientPanel4.ResumeLayout(false);
            this.guna2GradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.pnNumberOfBooksPurchase.ResumeLayout(false);
            this.pnNumberOfBooksPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.pnAmountPaid.ResumeLayout(false);
            this.pnAmountPaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView dgvCustomerChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberBook;
        public Guna.UI2.WinForms.Guna2DataGridView dgvBookChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookname;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksold;
        private Guna.UI2.WinForms.Guna2Panel pnStatistics;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label lbNumberofBookAvailable;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientPanel pnNumberOfBooksPurchase;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label lbBookSold;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label lbCustomerNumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientPanel pnAmountPaid;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbRevenue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox btnExitDashboardCustomer;
    }
}
