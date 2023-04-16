namespace Bookstore__main.FormsBookstore
{
    partial class AdminForm
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnButton = new Guna.UI2.WinForms.Guna2Panel();
            this.btnListBookPanel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboardPanel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddBookPanel = new Guna.UI2.WinForms.Guna2Button();
            this.pnContent = new Guna.UI2.WinForms.Guna2Panel();
            this.btnListAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnButton
            // 
            this.pnButton.AutoSize = true;
            this.pnButton.Controls.Add(this.btnListAdmin);
            this.pnButton.Controls.Add(this.btnListBookPanel);
            this.pnButton.Controls.Add(this.btnDashboardPanel);
            this.pnButton.Controls.Add(this.btnAddBookPanel);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.pnButton.Location = new System.Drawing.Point(0, 0);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(180, 720);
            this.pnButton.TabIndex = 0;
            // 
            // btnListBookPanel
            // 
            this.btnListBookPanel.Animated = true;
            this.btnListBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnListBookPanel.BorderRadius = 20;
            this.btnListBookPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnListBookPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnListBookPanel.ForeColor = System.Drawing.Color.White;
            this.btnListBookPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnListBookPanel.Location = new System.Drawing.Point(-34, 303);
            this.btnListBookPanel.Name = "btnListBookPanel";
            this.btnListBookPanel.Size = new System.Drawing.Size(211, 45);
            this.btnListBookPanel.TabIndex = 14;
            this.btnListBookPanel.Text = "Books";
            this.btnListBookPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListBookPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnListBookPanel.Click += new System.EventHandler(this.btnListBookPanel_Click);
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
            this.btnDashboardPanel.Location = new System.Drawing.Point(-34, 252);
            this.btnDashboardPanel.Name = "btnDashboardPanel";
            this.btnDashboardPanel.Size = new System.Drawing.Size(211, 45);
            this.btnDashboardPanel.TabIndex = 13;
            this.btnDashboardPanel.Text = "Dashboard";
            this.btnDashboardPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboardPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnDashboardPanel.Click += new System.EventHandler(this.btnDashboardPanel_Click_1);
            // 
            // btnAddBookPanel
            // 
            this.btnAddBookPanel.Animated = true;
            this.btnAddBookPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBookPanel.BorderRadius = 20;
            this.btnAddBookPanel.FillColor = System.Drawing.Color.Transparent;
            this.btnAddBookPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBookPanel.ForeColor = System.Drawing.Color.White;
            this.btnAddBookPanel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnAddBookPanel.Location = new System.Drawing.Point(-34, 354);
            this.btnAddBookPanel.Name = "btnAddBookPanel";
            this.btnAddBookPanel.Size = new System.Drawing.Size(211, 45);
            this.btnAddBookPanel.TabIndex = 12;
            this.btnAddBookPanel.Text = "Add book";
            this.btnAddBookPanel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddBookPanel.TextOffset = new System.Drawing.Point(60, 0);
            this.btnAddBookPanel.Click += new System.EventHandler(this.btnAddBookPanel_Click_1);
            // 
            // pnContent
            // 
            this.pnContent.AutoSize = true;
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(180, 0);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(881, 720);
            this.pnContent.TabIndex = 1;
            // 
            // btnListAdmin
            // 
            this.btnListAdmin.Animated = true;
            this.btnListAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnListAdmin.BorderRadius = 20;
            this.btnListAdmin.FillColor = System.Drawing.Color.Transparent;
            this.btnListAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnListAdmin.ForeColor = System.Drawing.Color.White;
            this.btnListAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(109)))), ((int)(((byte)(228)))));
            this.btnListAdmin.Location = new System.Drawing.Point(-34, 405);
            this.btnListAdmin.Name = "btnListAdmin";
            this.btnListAdmin.Size = new System.Drawing.Size(211, 45);
            this.btnListAdmin.TabIndex = 15;
            this.btnListAdmin.Text = "List";
            this.btnListAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnListAdmin.TextOffset = new System.Drawing.Point(60, 0);
            this.btnListAdmin.Click += new System.EventHandler(this.btnListAdmin_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1061, 720);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel pnButton;
        private Guna.UI2.WinForms.Guna2Button btnListBookPanel;
        internal Guna.UI2.WinForms.Guna2Button btnDashboardPanel;
        internal Guna.UI2.WinForms.Guna2Button btnAddBookPanel;
        private Guna.UI2.WinForms.Guna2Panel pnContent;
        internal Guna.UI2.WinForms.Guna2Button btnListAdmin;
    }
}