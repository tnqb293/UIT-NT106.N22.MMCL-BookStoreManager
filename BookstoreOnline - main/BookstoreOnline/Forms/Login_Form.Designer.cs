namespace BookstoreOnline
{
    partial class Login_Form
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pn_regis = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tb_EmailRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_RepasswordRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tb_UsernameRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_PasswordRegister = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_LoginRegister = new System.Windows.Forms.Label();
            this.btn_CreateAccountRegister = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pn_login = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.Label3 = new System.Windows.Forms.Label();
            this.tb_UsernameLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_PasswordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.tsRememberme = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btn_CreateAccountLogin = new Guna.UI2.WinForms.Guna2Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btn_LoginUser = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pn_regis.SuspendLayout();
            this.pn_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2PictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(374, 490);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pn_regis
            // 
            this.pn_regis.BackColor = System.Drawing.Color.Transparent;
            this.pn_regis.Controls.Add(this.tb_EmailRegister);
            this.pn_regis.Controls.Add(this.tb_RepasswordRegister);
            this.pn_regis.Controls.Add(this.Label4);
            this.pn_regis.Controls.Add(this.tb_UsernameRegister);
            this.pn_regis.Controls.Add(this.tb_PasswordRegister);
            this.pn_regis.Controls.Add(this.btn_LoginRegister);
            this.pn_regis.Controls.Add(this.btn_CreateAccountRegister);
            this.guna2Transition1.SetDecoration(this.pn_regis, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pn_regis.FillColor = System.Drawing.Color.White;
            this.pn_regis.Location = new System.Drawing.Point(468, 77);
            this.pn_regis.Name = "pn_regis";
            this.pn_regis.ShadowColor = System.Drawing.Color.White;
            this.pn_regis.ShadowDepth = 80;
            this.pn_regis.ShadowShift = 10;
            this.pn_regis.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pn_regis.Size = new System.Drawing.Size(302, 392);
            this.pn_regis.TabIndex = 14;
            // 
            // tb_EmailRegister
            // 
            this.tb_EmailRegister.Animated = true;
            this.tb_EmailRegister.BorderRadius = 8;
            this.tb_EmailRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tb_EmailRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tb_EmailRegister.DefaultText = "";
            this.tb_EmailRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_EmailRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_EmailRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_EmailRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_EmailRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_EmailRegister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_EmailRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_EmailRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_EmailRegister.Location = new System.Drawing.Point(38, 236);
            this.tb_EmailRegister.Name = "tb_EmailRegister";
            this.tb_EmailRegister.PasswordChar = '\0';
            this.tb_EmailRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_EmailRegister.PlaceholderText = "Email";
            this.tb_EmailRegister.SelectedText = "";
            this.tb_EmailRegister.Size = new System.Drawing.Size(243, 36);
            this.tb_EmailRegister.TabIndex = 10;
            // 
            // tb_RepasswordRegister
            // 
            this.tb_RepasswordRegister.Animated = true;
            this.tb_RepasswordRegister.BorderRadius = 8;
            this.tb_RepasswordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tb_RepasswordRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tb_RepasswordRegister.DefaultText = "";
            this.tb_RepasswordRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_RepasswordRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_RepasswordRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RepasswordRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_RepasswordRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_RepasswordRegister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RepasswordRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_RepasswordRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_RepasswordRegister.Location = new System.Drawing.Point(38, 179);
            this.tb_RepasswordRegister.Name = "tb_RepasswordRegister";
            this.tb_RepasswordRegister.PasswordChar = '●';
            this.tb_RepasswordRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_RepasswordRegister.PlaceholderText = "Re-enter password";
            this.tb_RepasswordRegister.SelectedText = "";
            this.tb_RepasswordRegister.Size = new System.Drawing.Size(243, 36);
            this.tb_RepasswordRegister.TabIndex = 9;
            this.tb_RepasswordRegister.UseSystemPasswordChar = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.Label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label4.Location = new System.Drawing.Point(93, 10);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 31);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Register";
            // 
            // tb_UsernameRegister
            // 
            this.tb_UsernameRegister.Animated = true;
            this.tb_UsernameRegister.BorderRadius = 8;
            this.tb_UsernameRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tb_UsernameRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tb_UsernameRegister.DefaultText = "";
            this.tb_UsernameRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_UsernameRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_UsernameRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UsernameRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UsernameRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_UsernameRegister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_UsernameRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_UsernameRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_UsernameRegister.Location = new System.Drawing.Point(38, 69);
            this.tb_UsernameRegister.Name = "tb_UsernameRegister";
            this.tb_UsernameRegister.PasswordChar = '\0';
            this.tb_UsernameRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_UsernameRegister.PlaceholderText = "Username";
            this.tb_UsernameRegister.SelectedText = "";
            this.tb_UsernameRegister.Size = new System.Drawing.Size(243, 36);
            this.tb_UsernameRegister.TabIndex = 1;
            // 
            // tb_PasswordRegister
            // 
            this.tb_PasswordRegister.Animated = true;
            this.tb_PasswordRegister.BorderRadius = 8;
            this.tb_PasswordRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tb_PasswordRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tb_PasswordRegister.DefaultText = "";
            this.tb_PasswordRegister.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_PasswordRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_PasswordRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_PasswordRegister.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_PasswordRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_PasswordRegister.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_PasswordRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_PasswordRegister.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_PasswordRegister.Location = new System.Drawing.Point(38, 126);
            this.tb_PasswordRegister.Name = "tb_PasswordRegister";
            this.tb_PasswordRegister.PasswordChar = '●';
            this.tb_PasswordRegister.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_PasswordRegister.PlaceholderText = "Password";
            this.tb_PasswordRegister.SelectedText = "";
            this.tb_PasswordRegister.Size = new System.Drawing.Size(243, 36);
            this.tb_PasswordRegister.TabIndex = 2;
            this.tb_PasswordRegister.UseSystemPasswordChar = true;
            // 
            // btn_LoginRegister
            // 
            this.btn_LoginRegister.AutoSize = true;
            this.btn_LoginRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btn_LoginRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_LoginRegister.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoginRegister.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_LoginRegister.Location = new System.Drawing.Point(228, 359);
            this.btn_LoginRegister.Name = "btn_LoginRegister";
            this.btn_LoginRegister.Size = new System.Drawing.Size(37, 13);
            this.btn_LoginRegister.TabIndex = 6;
            this.btn_LoginRegister.Text = "Login";
            this.btn_LoginRegister.Click += new System.EventHandler(this.btn_LoginRegister_Click);
            // 
            // btn_CreateAccountRegister
            // 
            this.btn_CreateAccountRegister.Animated = true;
            this.btn_CreateAccountRegister.AutoRoundedCorners = true;
            this.btn_CreateAccountRegister.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.btn_CreateAccountRegister, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_CreateAccountRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.btn_CreateAccountRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_CreateAccountRegister.ForeColor = System.Drawing.Color.White;
            this.btn_CreateAccountRegister.Location = new System.Drawing.Point(38, 303);
            this.btn_CreateAccountRegister.Name = "btn_CreateAccountRegister";
            this.btn_CreateAccountRegister.Size = new System.Drawing.Size(243, 45);
            this.btn_CreateAccountRegister.TabIndex = 5;
            this.btn_CreateAccountRegister.Text = "Create Account";
            this.btn_CreateAccountRegister.Click += new System.EventHandler(this.btn_CreateAccountRegister_Click);
            // 
            // pn_login
            // 
            this.pn_login.BackColor = System.Drawing.Color.Transparent;
            this.pn_login.Controls.Add(this.Label3);
            this.pn_login.Controls.Add(this.tb_UsernameLogin);
            this.pn_login.Controls.Add(this.tb_PasswordLogin);
            this.pn_login.Controls.Add(this.tsRememberme);
            this.pn_login.Controls.Add(this.btn_CreateAccountLogin);
            this.pn_login.Controls.Add(this.Label1);
            this.pn_login.Controls.Add(this.Label2);
            this.pn_login.Controls.Add(this.btn_LoginUser);
            this.guna2Transition1.SetDecoration(this.pn_login, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pn_login.FillColor = System.Drawing.Color.White;
            this.pn_login.Location = new System.Drawing.Point(468, 77);
            this.pn_login.Name = "pn_login";
            this.pn_login.ShadowColor = System.Drawing.Color.White;
            this.pn_login.ShadowDepth = 80;
            this.pn_login.ShadowShift = 10;
            this.pn_login.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pn_login.Size = new System.Drawing.Size(302, 392);
            this.pn_login.TabIndex = 13;
            this.pn_login.Visible = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.Label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label3.Location = new System.Drawing.Point(91, 10);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(129, 31);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "User Login";
            // 
            // tb_UsernameLogin
            // 
            this.tb_UsernameLogin.Animated = true;
            this.tb_UsernameLogin.BorderRadius = 8;
            this.tb_UsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tb_UsernameLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tb_UsernameLogin.DefaultText = "";
            this.tb_UsernameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_UsernameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_UsernameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UsernameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UsernameLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_UsernameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_UsernameLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_UsernameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_UsernameLogin.Location = new System.Drawing.Point(38, 69);
            this.tb_UsernameLogin.Name = "tb_UsernameLogin";
            this.tb_UsernameLogin.PasswordChar = '\0';
            this.tb_UsernameLogin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_UsernameLogin.PlaceholderText = "Username";
            this.tb_UsernameLogin.SelectedText = "";
            this.tb_UsernameLogin.Size = new System.Drawing.Size(243, 36);
            this.tb_UsernameLogin.TabIndex = 1;
            // 
            // tb_PasswordLogin
            // 
            this.tb_PasswordLogin.Animated = true;
            this.tb_PasswordLogin.BorderRadius = 8;
            this.tb_PasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tb_PasswordLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tb_PasswordLogin.DefaultText = "";
            this.tb_PasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_PasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_PasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_PasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_PasswordLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.tb_PasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_PasswordLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_PasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_PasswordLogin.Location = new System.Drawing.Point(38, 126);
            this.tb_PasswordLogin.Name = "tb_PasswordLogin";
            this.tb_PasswordLogin.PasswordChar = '●';
            this.tb_PasswordLogin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tb_PasswordLogin.PlaceholderText = "Password";
            this.tb_PasswordLogin.SelectedText = "";
            this.tb_PasswordLogin.Size = new System.Drawing.Size(243, 36);
            this.tb_PasswordLogin.TabIndex = 2;
            this.tb_PasswordLogin.UseSystemPasswordChar = true;
            // 
            // tsRememberme
            // 
            this.tsRememberme.Animated = true;
            this.tsRememberme.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsRememberme.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsRememberme.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsRememberme.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.tsRememberme, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tsRememberme.Location = new System.Drawing.Point(38, 179);
            this.tsRememberme.Name = "tsRememberme";
            this.tsRememberme.Size = new System.Drawing.Size(35, 20);
            this.tsRememberme.TabIndex = 3;
            this.tsRememberme.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsRememberme.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsRememberme.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsRememberme.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // btn_CreateAccountLogin
            // 
            this.btn_CreateAccountLogin.Animated = true;
            this.btn_CreateAccountLogin.AutoRoundedCorners = true;
            this.btn_CreateAccountLogin.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.btn_CreateAccountLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_CreateAccountLogin.FillColor = System.Drawing.Color.Transparent;
            this.btn_CreateAccountLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAccountLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btn_CreateAccountLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_CreateAccountLogin.Location = new System.Drawing.Point(38, 328);
            this.btn_CreateAccountLogin.Name = "btn_CreateAccountLogin";
            this.btn_CreateAccountLogin.Size = new System.Drawing.Size(243, 45);
            this.btn_CreateAccountLogin.TabIndex = 7;
            this.btn_CreateAccountLogin.Text = "Create Account";
            this.btn_CreateAccountLogin.Click += new System.EventHandler(this.btn_CreateAccountLogin_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.Label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label1.Location = new System.Drawing.Point(79, 179);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(108, 19);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Remember me";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.Label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label2.Location = new System.Drawing.Point(70, 278);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(178, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Forgeot Username or Password ?";
            // 
            // btn_LoginUser
            // 
            this.btn_LoginUser.Animated = true;
            this.btn_LoginUser.AutoRoundedCorners = true;
            this.btn_LoginUser.BorderRadius = 21;
            this.guna2Transition1.SetDecoration(this.btn_LoginUser, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_LoginUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(135)))));
            this.btn_LoginUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_LoginUser.ForeColor = System.Drawing.Color.White;
            this.btn_LoginUser.Location = new System.Drawing.Point(38, 222);
            this.btn_LoginUser.Name = "btn_LoginUser";
            this.btn_LoginUser.Size = new System.Drawing.Size(243, 45);
            this.btn_LoginUser.TabIndex = 5;
            this.btn_LoginUser.Text = "LOGIN";
            this.btn_LoginUser.Click += new System.EventHandler(this.btn_LoginUser_Click);
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
            this.Guna2ControlBox1.TabIndex = 15;
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
            this.Guna2ControlBox2.TabIndex = 16;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 481);
            this.Controls.Add(this.Guna2ControlBox2);
            this.Controls.Add(this.Guna2ControlBox1);
            this.Controls.Add(this.pn_regis);
            this.Controls.Add(this.pn_login);
            this.Controls.Add(this.guna2PictureBox1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pn_regis.ResumeLayout(false);
            this.pn_regis.PerformLayout();
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        internal Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox2;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
        internal Guna.UI2.WinForms.Guna2ShadowPanel pn_regis;
        internal Guna.UI2.WinForms.Guna2TextBox tb_EmailRegister;
        internal Guna.UI2.WinForms.Guna2TextBox tb_RepasswordRegister;
        internal System.Windows.Forms.Label Label4;
        internal Guna.UI2.WinForms.Guna2TextBox tb_UsernameRegister;
        internal Guna.UI2.WinForms.Guna2TextBox tb_PasswordRegister;
        internal System.Windows.Forms.Label btn_LoginRegister;
        internal Guna.UI2.WinForms.Guna2GradientButton btn_CreateAccountRegister;
        internal Guna.UI2.WinForms.Guna2ShadowPanel pn_login;
        internal System.Windows.Forms.Label Label3;
        internal Guna.UI2.WinForms.Guna2TextBox tb_UsernameLogin;
        internal Guna.UI2.WinForms.Guna2TextBox tb_PasswordLogin;
        internal Guna.UI2.WinForms.Guna2ToggleSwitch tsRememberme;
        internal Guna.UI2.WinForms.Guna2Button btn_CreateAccountLogin;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal Guna.UI2.WinForms.Guna2GradientButton btn_LoginUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        internal Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

