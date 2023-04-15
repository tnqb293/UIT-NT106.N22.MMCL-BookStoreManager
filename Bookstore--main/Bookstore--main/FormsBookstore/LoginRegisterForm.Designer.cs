namespace Bookstore__main
{
    partial class LoginRegisterForm
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
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegisterForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.pnRegister = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLoginRegister = new System.Windows.Forms.Label();
            this.tbEmailRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbReEnterPasswordRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreateAccountRegister = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbPasswordRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUsernameResgister = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbRegister = new System.Windows.Forms.Label();
            this.pnLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCreateAccountLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoginLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tsRememberMe = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lbRememberMe = new System.Windows.Forms.Label();
            this.tbPasswordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbUsernameLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbUserLogin = new System.Windows.Forms.Label();
            this.Guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnRegister.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(374, 481);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 13;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.guna2Transition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation3;
            // 
            // pnRegister
            // 
            this.pnRegister.Controls.Add(this.btnLoginRegister);
            this.pnRegister.Controls.Add(this.tbEmailRegister);
            this.pnRegister.Controls.Add(this.tbReEnterPasswordRegister);
            this.pnRegister.Controls.Add(this.btnCreateAccountRegister);
            this.pnRegister.Controls.Add(this.tbPasswordRegister);
            this.pnRegister.Controls.Add(this.tbUsernameResgister);
            this.pnRegister.Controls.Add(this.lbRegister);
            this.guna2Transition1.SetDecoration(this.pnRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnRegister.Location = new System.Drawing.Point(0, 0);
            this.pnRegister.Name = "pnRegister";
            this.pnRegister.Size = new System.Drawing.Size(302, 392);
            this.pnRegister.TabIndex = 23;
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.AutoSize = true;
            this.btnLoginRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnLoginRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLoginRegister.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegister.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoginRegister.Location = new System.Drawing.Point(227, 349);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.Size = new System.Drawing.Size(37, 13);
            this.btnLoginRegister.TabIndex = 11;
            this.btnLoginRegister.Text = "Login";
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click_1);
            // 
            // tbEmailRegister
            // 
            this.tbEmailRegister.BorderRadius = 8;
            this.tbEmailRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbEmailRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbEmailRegister.DefaultText = "";
            this.tbEmailRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmailRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmailRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmailRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmailRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tbEmailRegister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbEmailRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmailRegister.Location = new System.Drawing.Point(30, 231);
            this.tbEmailRegister.Name = "tbEmailRegister";
            this.tbEmailRegister.PasswordChar = '\0';
            this.tbEmailRegister.PlaceholderText = "Email";
            this.tbEmailRegister.SelectedText = "";
            this.tbEmailRegister.Size = new System.Drawing.Size(243, 36);
            this.tbEmailRegister.TabIndex = 10;
            // 
            // tbReEnterPasswordRegister
            // 
            this.tbReEnterPasswordRegister.BorderRadius = 8;
            this.tbReEnterPasswordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbReEnterPasswordRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbReEnterPasswordRegister.DefaultText = "";
            this.tbReEnterPasswordRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbReEnterPasswordRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbReEnterPasswordRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbReEnterPasswordRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbReEnterPasswordRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tbReEnterPasswordRegister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbReEnterPasswordRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbReEnterPasswordRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbReEnterPasswordRegister.Location = new System.Drawing.Point(30, 178);
            this.tbReEnterPasswordRegister.Name = "tbReEnterPasswordRegister";
            this.tbReEnterPasswordRegister.PasswordChar = '●';
            this.tbReEnterPasswordRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbReEnterPasswordRegister.PlaceholderText = "Password";
            this.tbReEnterPasswordRegister.SelectedText = "";
            this.tbReEnterPasswordRegister.Size = new System.Drawing.Size(243, 36);
            this.tbReEnterPasswordRegister.TabIndex = 9;
            // 
            // btnCreateAccountRegister
            // 
            this.btnCreateAccountRegister.Animated = true;
            this.btnCreateAccountRegister.AutoRoundedCorners = true;
            this.btnCreateAccountRegister.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.btnCreateAccountRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCreateAccountRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.btnCreateAccountRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccountRegister.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccountRegister.Location = new System.Drawing.Point(30, 290);
            this.btnCreateAccountRegister.Name = "btnCreateAccountRegister";
            this.btnCreateAccountRegister.Size = new System.Drawing.Size(243, 45);
            this.btnCreateAccountRegister.TabIndex = 8;
            this.btnCreateAccountRegister.Text = "Create Account";
            this.btnCreateAccountRegister.Click += new System.EventHandler(this.btnCreateAccountRegister_Click);
            // 
            // tbPasswordRegister
            // 
            this.tbPasswordRegister.BorderRadius = 8;
            this.tbPasswordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbPasswordRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbPasswordRegister.DefaultText = "";
            this.tbPasswordRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPasswordRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPasswordRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPasswordRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPasswordRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tbPasswordRegister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPasswordRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPasswordRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPasswordRegister.Location = new System.Drawing.Point(30, 126);
            this.tbPasswordRegister.Name = "tbPasswordRegister";
            this.tbPasswordRegister.PasswordChar = '●';
            this.tbPasswordRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPasswordRegister.PlaceholderText = "Password";
            this.tbPasswordRegister.SelectedText = "";
            this.tbPasswordRegister.Size = new System.Drawing.Size(243, 36);
            this.tbPasswordRegister.TabIndex = 5;
            // 
            // tbUsernameResgister
            // 
            this.tbUsernameResgister.BorderRadius = 8;
            this.tbUsernameResgister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbUsernameResgister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbUsernameResgister.DefaultText = "";
            this.tbUsernameResgister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsernameResgister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsernameResgister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsernameResgister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsernameResgister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tbUsernameResgister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsernameResgister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUsernameResgister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsernameResgister.Location = new System.Drawing.Point(30, 73);
            this.tbUsernameResgister.Name = "tbUsernameResgister";
            this.tbUsernameResgister.PasswordChar = '\0';
            this.tbUsernameResgister.PlaceholderText = "Username";
            this.tbUsernameResgister.SelectedText = "";
            this.tbUsernameResgister.Size = new System.Drawing.Size(243, 36);
            this.tbUsernameResgister.TabIndex = 4;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbRegister.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.Location = new System.Drawing.Point(97, 15);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(101, 31);
            this.lbRegister.TabIndex = 3;
            this.lbRegister.Text = "Register";
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.pnRegister);
            this.pnLogin.Controls.Add(this.btnCreateAccountLogin);
            this.pnLogin.Controls.Add(this.btnLoginLogin);
            this.pnLogin.Controls.Add(this.tsRememberMe);
            this.pnLogin.Controls.Add(this.lbRememberMe);
            this.pnLogin.Controls.Add(this.tbPasswordLogin);
            this.pnLogin.Controls.Add(this.tbUsernameLogin);
            this.pnLogin.Controls.Add(this.lbUserLogin);
            this.guna2Transition1.SetDecoration(this.pnLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnLogin.Location = new System.Drawing.Point(468, 77);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(302, 392);
            this.pnLogin.TabIndex = 22;
            // 
            // btnCreateAccountLogin
            // 
            this.btnCreateAccountLogin.Animated = true;
            this.btnCreateAccountLogin.AutoRoundedCorners = true;
            this.btnCreateAccountLogin.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.btnCreateAccountLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCreateAccountLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnCreateAccountLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccountLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnCreateAccountLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCreateAccountLogin.Location = new System.Drawing.Point(38, 328);
            this.btnCreateAccountLogin.Name = "btnCreateAccountLogin";
            this.btnCreateAccountLogin.Size = new System.Drawing.Size(243, 45);
            this.btnCreateAccountLogin.TabIndex = 8;
            this.btnCreateAccountLogin.Text = "Create Account";
            this.btnCreateAccountLogin.Click += new System.EventHandler(this.btnCreateAccountLogin_Click);
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.Animated = true;
            this.btnLoginLogin.AutoRoundedCorners = true;
            this.btnLoginLogin.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.btnLoginLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLoginLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.btnLoginLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLoginLogin.ForeColor = System.Drawing.Color.White;
            this.btnLoginLogin.Location = new System.Drawing.Point(39, 222);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(243, 45);
            this.btnLoginLogin.TabIndex = 7;
            this.btnLoginLogin.Text = "LOGIN";
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            // 
            // tsRememberMe
            // 
            this.tsRememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsRememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsRememberMe.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsRememberMe.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.tsRememberMe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tsRememberMe.Location = new System.Drawing.Point(39, 179);
            this.tsRememberMe.Name = "tsRememberMe";
            this.tsRememberMe.Size = new System.Drawing.Size(35, 20);
            this.tsRememberMe.TabIndex = 5;
            this.tsRememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsRememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsRememberMe.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsRememberMe.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // lbRememberMe
            // 
            this.lbRememberMe.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbRememberMe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbRememberMe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRememberMe.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbRememberMe.Location = new System.Drawing.Point(80, 179);
            this.lbRememberMe.Name = "lbRememberMe";
            this.lbRememberMe.Size = new System.Drawing.Size(108, 19);
            this.lbRememberMe.TabIndex = 6;
            this.lbRememberMe.Text = "Remember me";
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.BorderRadius = 8;
            this.tbPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbPasswordLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbPasswordLogin.DefaultText = "";
            this.tbPasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPasswordLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tbPasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPasswordLogin.Location = new System.Drawing.Point(38, 126);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '●';
            this.tbPasswordLogin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPasswordLogin.PlaceholderText = "Password";
            this.tbPasswordLogin.SelectedText = "";
            this.tbPasswordLogin.Size = new System.Drawing.Size(243, 36);
            this.tbPasswordLogin.TabIndex = 2;
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.BorderRadius = 8;
            this.tbUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbUsernameLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbUsernameLogin.DefaultText = "";
            this.tbUsernameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsernameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsernameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsernameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsernameLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tbUsernameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsernameLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUsernameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsernameLogin.Location = new System.Drawing.Point(38, 73);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.PasswordChar = '\0';
            this.tbUsernameLogin.PlaceholderText = "Username";
            this.tbUsernameLogin.SelectedText = "";
            this.tbUsernameLogin.Size = new System.Drawing.Size(243, 36);
            this.tbUsernameLogin.TabIndex = 1;
            // 
            // lbUserLogin
            // 
            this.lbUserLogin.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbUserLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbUserLogin.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserLogin.Location = new System.Drawing.Point(113, 10);
            this.lbUserLogin.Name = "lbUserLogin";
            this.lbUserLogin.Size = new System.Drawing.Size(75, 31);
            this.lbUserLogin.TabIndex = 0;
            this.lbUserLogin.Text = "Login";
            // 
            // Guna2ControlBox2
            // 
            this.Guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.Guna2ControlBox2.Location = new System.Drawing.Point(743, 12);
            this.Guna2ControlBox2.Name = "Guna2ControlBox2";
            this.Guna2ControlBox2.Size = new System.Drawing.Size(27, 25);
            this.Guna2ControlBox2.TabIndex = 21;
            // 
            // Guna2ControlBox1
            // 
            this.Guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.Guna2ControlBox1.Location = new System.Drawing.Point(776, 12);
            this.Guna2ControlBox1.Name = "Guna2ControlBox1";
            this.Guna2ControlBox1.Size = new System.Drawing.Size(27, 25);
            this.Guna2ControlBox1.TabIndex = 20;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // LoginRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 481);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.Guna2ControlBox2);
            this.Controls.Add(this.Guna2ControlBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginRegisterForm";
            this.Load += new System.EventHandler(this.LoginRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnRegister.ResumeLayout(false);
            this.pnRegister.PerformLayout();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel pnRegister;
        internal System.Windows.Forms.Label btnLoginRegister;
        private Guna.UI2.WinForms.Guna2TextBox tbEmailRegister;
        private Guna.UI2.WinForms.Guna2TextBox tbReEnterPasswordRegister;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateAccountRegister;
        private Guna.UI2.WinForms.Guna2TextBox tbPasswordRegister;
        private Guna.UI2.WinForms.Guna2TextBox tbUsernameResgister;
        private System.Windows.Forms.Label lbRegister;
        private Guna.UI2.WinForms.Guna2Panel pnLogin;
        private Guna.UI2.WinForms.Guna2Button btnCreateAccountLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btnLoginLogin;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsRememberMe;
        private System.Windows.Forms.Label lbRememberMe;
        private Guna.UI2.WinForms.Guna2TextBox tbPasswordLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbUsernameLogin;
        private System.Windows.Forms.Label lbUserLogin;
        private Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
    }
}

