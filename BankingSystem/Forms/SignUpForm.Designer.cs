namespace BankingSystem
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Password_Textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UserID_Textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserIDLabel = new System.Windows.Forms.Label();
            this.RePassword_Textbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountNumber_Textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_Textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DOB_DatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.Checkbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUp_Btn = new System.Windows.Forms.Button();
            this.Name_Textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.Exit_Btn);
            this.HeaderPanel.Controls.Add(this.TitleLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(700, 45);
            this.HeaderPanel.TabIndex = 0;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Btn.FlatAppearance.BorderSize = 0;
            this.Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Exit_Btn.Location = new System.Drawing.Point(659, 0);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(41, 45);
            this.Exit_Btn.TabIndex = 9;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(700, 45);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Banking System";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.Password_Textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password_Textbox.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.Password_Textbox.BorderThickness = 2;
            this.Password_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Password_Textbox.isPassword = true;
            this.Password_Textbox.Location = new System.Drawing.Point(237, 187);
            this.Password_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.Size = new System.Drawing.Size(200, 39);
            this.Password_Textbox.TabIndex = 15;
            this.Password_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserID_Textbox
            // 
            this.UserID_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserID_Textbox.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.UserID_Textbox.HintForeColor = System.Drawing.Color.DarkGray;
            this.UserID_Textbox.HintText = "";
            this.UserID_Textbox.isPassword = false;
            this.UserID_Textbox.LineFocusedColor = System.Drawing.Color.Lime;
            this.UserID_Textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.UserID_Textbox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.UserID_Textbox.LineThickness = 2;
            this.UserID_Textbox.Location = new System.Drawing.Point(237, 127);
            this.UserID_Textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UserID_Textbox.Name = "UserID_Textbox";
            this.UserID_Textbox.Size = new System.Drawing.Size(200, 33);
            this.UserID_Textbox.TabIndex = 14;
            this.UserID_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Location = new System.Drawing.Point(30, 196);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(200, 20);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Password";
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.Location = new System.Drawing.Point(30, 140);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(200, 20);
            this.UserIDLabel.TabIndex = 12;
            this.UserIDLabel.Text = "User ID";
            // 
            // RePassword_Textbox
            // 
            this.RePassword_Textbox.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.RePassword_Textbox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RePassword_Textbox.BorderColorMouseHover = System.Drawing.Color.Lime;
            this.RePassword_Textbox.BorderThickness = 2;
            this.RePassword_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RePassword_Textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RePassword_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.RePassword_Textbox.isPassword = true;
            this.RePassword_Textbox.Location = new System.Drawing.Point(238, 243);
            this.RePassword_Textbox.Margin = new System.Windows.Forms.Padding(4);
            this.RePassword_Textbox.Name = "RePassword_Textbox";
            this.RePassword_Textbox.Size = new System.Drawing.Size(200, 39);
            this.RePassword_Textbox.TabIndex = 17;
            this.RePassword_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Re-Enter Password";
            // 
            // AccountNumber_Textbox
            // 
            this.AccountNumber_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountNumber_Textbox.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumber_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.AccountNumber_Textbox.HintForeColor = System.Drawing.Color.DarkGray;
            this.AccountNumber_Textbox.HintText = "";
            this.AccountNumber_Textbox.isPassword = false;
            this.AccountNumber_Textbox.LineFocusedColor = System.Drawing.Color.Lime;
            this.AccountNumber_Textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.AccountNumber_Textbox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.AccountNumber_Textbox.LineThickness = 2;
            this.AccountNumber_Textbox.Location = new System.Drawing.Point(238, 71);
            this.AccountNumber_Textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AccountNumber_Textbox.Name = "AccountNumber_Textbox";
            this.AccountNumber_Textbox.Size = new System.Drawing.Size(200, 33);
            this.AccountNumber_Textbox.TabIndex = 19;
            this.AccountNumber_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(30, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Account Number";
            // 
            // Email_Textbox
            // 
            this.Email_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_Textbox.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Email_Textbox.HintForeColor = System.Drawing.Color.DarkGray;
            this.Email_Textbox.HintText = "";
            this.Email_Textbox.isPassword = false;
            this.Email_Textbox.LineFocusedColor = System.Drawing.Color.Lime;
            this.Email_Textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.Email_Textbox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.Email_Textbox.LineThickness = 2;
            this.Email_Textbox.Location = new System.Drawing.Point(237, 341);
            this.Email_Textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Email_Textbox.Name = "Email_Textbox";
            this.Email_Textbox.Size = new System.Drawing.Size(200, 33);
            this.Email_Textbox.TabIndex = 21;
            this.Email_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(30, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date of Birth";
            // 
            // DOB_DatePicker
            // 
            this.DOB_DatePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.DOB_DatePicker.BorderRadius = 0;
            this.DOB_DatePicker.ForeColor = System.Drawing.Color.White;
            this.DOB_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB_DatePicker.FormatCustom = null;
            this.DOB_DatePicker.Location = new System.Drawing.Point(236, 393);
            this.DOB_DatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.DOB_DatePicker.Name = "DOB_DatePicker";
            this.DOB_DatePicker.Size = new System.Drawing.Size(304, 34);
            this.DOB_DatePicker.TabIndex = 23;
            this.DOB_DatePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(471, 136);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(201, 201);
            this.bunifuCircleProgressbar1.TabIndex = 24;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // Checkbox
            // 
            this.Checkbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox.Checked = false;
            this.Checkbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox.ForeColor = System.Drawing.Color.White;
            this.Checkbox.Location = new System.Drawing.Point(34, 453);
            this.Checkbox.Margin = new System.Windows.Forms.Padding(6);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Size = new System.Drawing.Size(20, 20);
            this.Checkbox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(63, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(499, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "I have read the Terms and Conditions and agree to it.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.FlatAppearance.BorderSize = 0;
            this.SignUp_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SignUp_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUp_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.SignUp_Btn.Location = new System.Drawing.Point(300, 490);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(100, 40);
            this.SignUp_Btn.TabIndex = 27;
            this.SignUp_Btn.Text = "Sign Up";
            this.SignUp_Btn.UseVisualStyleBackColor = true;
            this.SignUp_Btn.Click += new System.EventHandler(this.SignUp_Btn_Click);
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name_Textbox.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Name_Textbox.HintForeColor = System.Drawing.Color.DarkGray;
            this.Name_Textbox.HintText = "";
            this.Name_Textbox.isPassword = false;
            this.Name_Textbox.LineFocusedColor = System.Drawing.Color.Lime;
            this.Name_Textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.Name_Textbox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.Name_Textbox.LineThickness = 2;
            this.Name_Textbox.Location = new System.Drawing.Point(236, 290);
            this.Name_Textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(200, 33);
            this.Name_Textbox.TabIndex = 29;
            this.Name_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(29, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Name";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TitleLabel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Checkbox);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.DOB_DatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_Textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountNumber_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RePassword_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.UserID_Textbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserIDLabel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Label TitleLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password_Textbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserID_Textbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserIDLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox RePassword_Textbox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AccountNumber_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private Bunifu.Framework.UI.BunifuDatepicker DOB_DatePicker;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SignUp_Btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Name_Textbox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}