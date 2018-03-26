namespace BankingSystem
{
    partial class LoginForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogIn_Btn = new System.Windows.Forms.Button();
            this.SignUp_Btn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FormHeader = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.BunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuLoadingAnimation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.UserID_Textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password_Textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserIDLabel
            // 
            this.bunifuLoadingAnimation.SetDecoration(this.UserIDLabel, BunifuAnimatorNS.DecorationType.None);
            this.UserIDLabel.Location = new System.Drawing.Point(78, 116);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(100, 20);
            this.UserIDLabel.TabIndex = 1;
            this.UserIDLabel.Text = "User ID";
            // 
            // PasswordLabel
            // 
            this.bunifuLoadingAnimation.SetDecoration(this.PasswordLabel, BunifuAnimatorNS.DecorationType.None);
            this.PasswordLabel.Location = new System.Drawing.Point(78, 175);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 20);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password";
            // 
            // LogIn_Btn
            // 
            this.bunifuLoadingAnimation.SetDecoration(this.LogIn_Btn, BunifuAnimatorNS.DecorationType.None);
            this.LogIn_Btn.FlatAppearance.BorderSize = 0;
            this.LogIn_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LogIn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.LogIn_Btn.Location = new System.Drawing.Point(116, 233);
            this.LogIn_Btn.Name = "LogIn_Btn";
            this.LogIn_Btn.Size = new System.Drawing.Size(100, 40);
            this.LogIn_Btn.TabIndex = 4;
            this.LogIn_Btn.Text = "Log in";
            this.LogIn_Btn.UseVisualStyleBackColor = true;
            this.LogIn_Btn.Click += new System.EventHandler(this.LogIn_Btn_Click);
            // 
            // SignUp_Btn
            // 
            this.bunifuLoadingAnimation.SetDecoration(this.SignUp_Btn, BunifuAnimatorNS.DecorationType.None);
            this.SignUp_Btn.FlatAppearance.BorderSize = 0;
            this.SignUp_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SignUp_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.SignUp_Btn.Location = new System.Drawing.Point(273, 233);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(100, 40);
            this.SignUp_Btn.TabIndex = 5;
            this.SignUp_Btn.Text = "Sign Up";
            this.SignUp_Btn.UseVisualStyleBackColor = true;
            this.SignUp_Btn.Click += new System.EventHandler(this.SignUp_Btn_Click);
            // 
            // TitleLabel
            // 
            this.bunifuLoadingAnimation.SetDecoration(this.TitleLabel, BunifuAnimatorNS.DecorationType.None);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(500, 45);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Banking System";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHeader
            // 
            this.FormHeader.Controls.Add(this.Exit_Btn);
            this.FormHeader.Controls.Add(this.TitleLabel);
            this.bunifuLoadingAnimation.SetDecoration(this.FormHeader, BunifuAnimatorNS.DecorationType.None);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(500, 45);
            this.FormHeader.TabIndex = 7;
            // 
            // Exit_Btn
            // 
            this.bunifuLoadingAnimation.SetDecoration(this.Exit_Btn, BunifuAnimatorNS.DecorationType.None);
            this.Exit_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Btn.FlatAppearance.BorderSize = 0;
            this.Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Exit_Btn.Location = new System.Drawing.Point(459, 0);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(41, 45);
            this.Exit_Btn.TabIndex = 8;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // BunifuDragControl
            // 
            this.BunifuDragControl.Fixed = true;
            this.BunifuDragControl.Horizontal = true;
            this.BunifuDragControl.TargetControl = this.TitleLabel;
            this.BunifuDragControl.Vertical = true;
            // 
            // bunifuLoadingAnimation
            // 
            this.bunifuLoadingAnimation.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.bunifuLoadingAnimation.Cursor = null;
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
            this.bunifuLoadingAnimation.DefaultAnimation = animation1;
            // 
            // UserID_Textbox
            // 
            this.UserID_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuLoadingAnimation.SetDecoration(this.UserID_Textbox, BunifuAnimatorNS.DecorationType.None);
            this.UserID_Textbox.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.UserID_Textbox.HintForeColor = System.Drawing.Color.DarkGray;
            this.UserID_Textbox.HintText = "";
            this.UserID_Textbox.isPassword = false;
            this.UserID_Textbox.LineFocusedColor = System.Drawing.Color.Lime;
            this.UserID_Textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.UserID_Textbox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.UserID_Textbox.LineThickness = 2;
            this.UserID_Textbox.Location = new System.Drawing.Point(218, 106);
            this.UserID_Textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UserID_Textbox.Name = "UserID_Textbox";
            this.UserID_Textbox.Size = new System.Drawing.Size(200, 33);
            this.UserID_Textbox.TabIndex = 9;
            this.UserID_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserID_Textbox.OnValueChanged += new System.EventHandler(this.UserID_Textbox_OnValueChanged);
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.Password_Textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_Textbox.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.Password_Textbox.BorderThickness = 2;
            this.Password_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuLoadingAnimation.SetDecoration(this.Password_Textbox, BunifuAnimatorNS.DecorationType.None);
            this.Password_Textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Password_Textbox.isPassword = true;
            this.Password_Textbox.Location = new System.Drawing.Point(218, 156);
            this.Password_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(200, 39);
            this.Password_Textbox.TabIndex = 11;
            this.Password_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_Textbox.OnValueChanged += new System.EventHandler(this.Password_Textbox_OnValueChanged);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.UserID_Textbox);
            this.Controls.Add(this.FormHeader);
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.LogIn_Btn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserIDLabel);
            this.bunifuLoadingAnimation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.FormHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label UserIDLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LogIn_Btn;
        private System.Windows.Forms.Button SignUp_Btn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button Exit_Btn;
        private Bunifu.Framework.UI.BunifuDragControl BunifuDragControl;
        private BunifuAnimatorNS.BunifuTransition bunifuLoadingAnimation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserID_Textbox;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password_Textbox;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

