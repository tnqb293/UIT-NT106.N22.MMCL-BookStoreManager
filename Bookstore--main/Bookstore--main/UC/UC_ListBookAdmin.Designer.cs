using System.Drawing;

namespace Bookstore__main.UC
{
    partial class UC_ListBookAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ListBookAdmin));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.Guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnZA = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSortByPriceDesc = new Guna.UI2.WinForms.Guna2Button();
            this.btnSortByPriceAsc = new Guna.UI2.WinForms.Guna2Button();
            this.btnAZ = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Controls.Add(this.Guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.Guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(948, 48);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.btnSearch.BorderRadius = 13;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(621, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 28);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderRadius = 18;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.Location = new System.Drawing.Point(184, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Books";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(429, 36);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.Guna2TextBox1_TextChanged);
            // 
            // Guna2ControlBox2
            // 
            this.Guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.Guna2ControlBox2.Location = new System.Drawing.Point(867, 6);
            this.Guna2ControlBox2.Name = "Guna2ControlBox2";
            this.Guna2ControlBox2.Size = new System.Drawing.Size(36, 36);
            this.Guna2ControlBox2.TabIndex = 23;
            // 
            // Guna2ControlBox1
            // 
            this.Guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.Guna2ControlBox1.Location = new System.Drawing.Point(909, 6);
            this.Guna2ControlBox1.Name = "Guna2ControlBox1";
            this.Guna2ControlBox1.Size = new System.Drawing.Size(36, 36);
            this.Guna2ControlBox1.TabIndex = 22;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 13;
            this.guna2Panel2.Controls.Add(this.btnZA);
            this.guna2Panel2.Controls.Add(this.guna2Button3);
            this.guna2Panel2.Controls.Add(this.btnSortByPriceDesc);
            this.guna2Panel2.Controls.Add(this.btnSortByPriceAsc);
            this.guna2Panel2.Controls.Add(this.btnAZ);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 48);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(948, 40);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btnZA
            // 
            this.btnZA.Animated = true;
            this.btnZA.AutoRoundedCorners = true;
            this.btnZA.BackColor = System.Drawing.Color.Transparent;
            this.btnZA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.btnZA.BorderRadius = 13;
            this.btnZA.BorderThickness = 1;
            this.btnZA.FillColor = System.Drawing.Color.Transparent;
            this.btnZA.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnZA.ForeColor = System.Drawing.Color.DimGray;
            this.btnZA.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btnZA.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnZA.Location = new System.Drawing.Point(197, 6);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(97, 28);
            this.btnZA.TabIndex = 16;
            this.btnZA.Text = "Z đến A";
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.guna2Button3.BorderRadius = 13;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(734, 6);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(97, 28);
            this.guna2Button3.TabIndex = 15;
            this.guna2Button3.Text = "Mới nhất";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnSortByPriceDesc
            // 
            this.btnSortByPriceDesc.Animated = true;
            this.btnSortByPriceDesc.BackColor = System.Drawing.Color.Transparent;
            this.btnSortByPriceDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.btnSortByPriceDesc.BorderRadius = 13;
            this.btnSortByPriceDesc.BorderThickness = 1;
            this.btnSortByPriceDesc.FillColor = System.Drawing.Color.Transparent;
            this.btnSortByPriceDesc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByPriceDesc.ForeColor = System.Drawing.Color.DimGray;
            this.btnSortByPriceDesc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btnSortByPriceDesc.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSortByPriceDesc.Location = new System.Drawing.Point(519, 6);
            this.btnSortByPriceDesc.Name = "btnSortByPriceDesc";
            this.btnSortByPriceDesc.Size = new System.Drawing.Size(170, 28);
            this.btnSortByPriceDesc.TabIndex = 14;
            this.btnSortByPriceDesc.Text = "Giá từ thấp đến cao";
            this.btnSortByPriceDesc.Click += new System.EventHandler(this.btnSortByPriceDesc_Click);
            // 
            // btnSortByPriceAsc
            // 
            this.btnSortByPriceAsc.Animated = true;
            this.btnSortByPriceAsc.BackColor = System.Drawing.Color.Transparent;
            this.btnSortByPriceAsc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.btnSortByPriceAsc.BorderRadius = 13;
            this.btnSortByPriceAsc.BorderThickness = 1;
            this.btnSortByPriceAsc.FillColor = System.Drawing.Color.Transparent;
            this.btnSortByPriceAsc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByPriceAsc.ForeColor = System.Drawing.Color.DimGray;
            this.btnSortByPriceAsc.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btnSortByPriceAsc.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSortByPriceAsc.Location = new System.Drawing.Point(323, 6);
            this.btnSortByPriceAsc.Name = "btnSortByPriceAsc";
            this.btnSortByPriceAsc.Size = new System.Drawing.Size(190, 28);
            this.btnSortByPriceAsc.TabIndex = 13;
            this.btnSortByPriceAsc.Text = "Giá từ cao đến thấp";
            this.btnSortByPriceAsc.Click += new System.EventHandler(this.btnSortByPriceAsc_Click);
            // 
            // btnAZ
            // 
            this.btnAZ.Animated = true;
            this.btnAZ.AutoRoundedCorners = true;
            this.btnAZ.BackColor = System.Drawing.Color.Transparent;
            this.btnAZ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.btnAZ.BorderRadius = 13;
            this.btnAZ.BorderThickness = 1;
            this.btnAZ.FillColor = System.Drawing.Color.Transparent;
            this.btnAZ.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAZ.ForeColor = System.Drawing.Color.DimGray;
            this.btnAZ.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(79)))), ((int)(((byte)(101)))));
            this.btnAZ.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAZ.Location = new System.Drawing.Point(94, 6);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(97, 28);
            this.btnAZ.TabIndex = 12;
            this.btnAZ.Text = "A đến Z";
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 470);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // UC_ListBookAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ListBookAdmin";
            this.Size = new System.Drawing.Size(948, 558);
            this.Load += new System.EventHandler(this.UC_ListBook_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
        internal Guna.UI2.WinForms.Guna2Button btnAZ;
        internal Guna.UI2.WinForms.Guna2TextBox txtSearch;
        internal Guna.UI2.WinForms.Guna2Button btnSortByPriceAsc;
        internal Guna.UI2.WinForms.Guna2Button guna2Button3;
        internal Guna.UI2.WinForms.Guna2Button btnSortByPriceDesc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal Guna.UI2.WinForms.Guna2Button btnSearch;
        internal Guna.UI2.WinForms.Guna2Button btnZA;
    }
}
