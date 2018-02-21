namespace BankingSystem
{
    partial class GeneralForm
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
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormHeader = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.Logout_Btn = new System.Windows.Forms.Button();
            this.eTax_Btn = new System.Windows.Forms.Button();
            this.Bills_Btn = new System.Windows.Forms.Button();
            this.Payments_Btn = new System.Windows.Forms.Button();
            this.Account_Btn = new System.Windows.Forms.Button();
            this.Menu_Btn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HorizontalTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ParticlesTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.FormHeader.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormHeader
            // 
            this.FormHeader.Controls.Add(this.Exit_Btn);
            this.FormHeader.Controls.Add(this.TitleLabel);
            this.ParticlesTransition.SetDecoration(this.FormHeader, BunifuAnimatorNS.DecorationType.None);
            this.HorizontalTransition.SetDecoration(this.FormHeader, BunifuAnimatorNS.DecorationType.None);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(1000, 45);
            this.FormHeader.TabIndex = 8;
            // 
            // Exit_Btn
            // 
            this.HorizontalTransition.SetDecoration(this.Exit_Btn, BunifuAnimatorNS.DecorationType.None);
            this.ParticlesTransition.SetDecoration(this.Exit_Btn, BunifuAnimatorNS.DecorationType.None);
            this.Exit_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit_Btn.FlatAppearance.BorderSize = 0;
            this.Exit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Exit_Btn.Location = new System.Drawing.Point(955, 0);
            this.Exit_Btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(45, 45);
            this.Exit_Btn.TabIndex = 8;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // TitleLabel
            // 
            this.HorizontalTransition.SetDecoration(this.TitleLabel, BunifuAnimatorNS.DecorationType.None);
            this.ParticlesTransition.SetDecoration(this.TitleLabel, BunifuAnimatorNS.DecorationType.None);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1000, 45);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Banking System";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TitleLabel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.Logout_Btn);
            this.NavigationPanel.Controls.Add(this.eTax_Btn);
            this.NavigationPanel.Controls.Add(this.Bills_Btn);
            this.NavigationPanel.Controls.Add(this.Payments_Btn);
            this.NavigationPanel.Controls.Add(this.Account_Btn);
            this.NavigationPanel.Controls.Add(this.Menu_Btn);
            this.ParticlesTransition.SetDecoration(this.NavigationPanel, BunifuAnimatorNS.DecorationType.None);
            this.HorizontalTransition.SetDecoration(this.NavigationPanel, BunifuAnimatorNS.DecorationType.None);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 45);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(230, 555);
            this.NavigationPanel.TabIndex = 9;
            // 
            // Logout_Btn
            // 
            this.HorizontalTransition.SetDecoration(this.Logout_Btn, BunifuAnimatorNS.DecorationType.None);
            this.ParticlesTransition.SetDecoration(this.Logout_Btn, BunifuAnimatorNS.DecorationType.None);
            this.Logout_Btn.FlatAppearance.BorderSize = 0;
            this.Logout_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Logout_Btn.Image = global::BankingSystem.Properties.Resources.logout;
            this.Logout_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout_Btn.Location = new System.Drawing.Point(0, 475);
            this.Logout_Btn.Name = "Logout_Btn";
            this.Logout_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Logout_Btn.Size = new System.Drawing.Size(230, 80);
            this.Logout_Btn.TabIndex = 10;
            this.Logout_Btn.Text = "   Log out";
            this.Logout_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout_Btn.UseVisualStyleBackColor = true;
            this.Logout_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // eTax_Btn
            // 
            this.HorizontalTransition.SetDecoration(this.eTax_Btn, BunifuAnimatorNS.DecorationType.None);
            this.ParticlesTransition.SetDecoration(this.eTax_Btn, BunifuAnimatorNS.DecorationType.None);
            this.eTax_Btn.FlatAppearance.BorderSize = 0;
            this.eTax_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.eTax_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eTax_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.eTax_Btn.Image = global::BankingSystem.Properties.Resources.service;
            this.eTax_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eTax_Btn.Location = new System.Drawing.Point(0, 300);
            this.eTax_Btn.Name = "eTax_Btn";
            this.eTax_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.eTax_Btn.Size = new System.Drawing.Size(230, 80);
            this.eTax_Btn.TabIndex = 8;
            this.eTax_Btn.Text = "   e - Tax and Services";
            this.eTax_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.eTax_Btn.UseVisualStyleBackColor = true;
            this.eTax_Btn.Click += new System.EventHandler(this.eTax_Btn_Click);
            // 
            // Bills_Btn
            // 
            this.HorizontalTransition.SetDecoration(this.Bills_Btn, BunifuAnimatorNS.DecorationType.None);
            this.ParticlesTransition.SetDecoration(this.Bills_Btn, BunifuAnimatorNS.DecorationType.None);
            this.Bills_Btn.FlatAppearance.BorderSize = 0;
            this.Bills_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Bills_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bills_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Bills_Btn.Image = global::BankingSystem.Properties.Resources.bills;
            this.Bills_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bills_Btn.Location = new System.Drawing.Point(0, 220);
            this.Bills_Btn.Name = "Bills_Btn";
            this.Bills_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Bills_Btn.Size = new System.Drawing.Size(230, 80);
            this.Bills_Btn.TabIndex = 7;
            this.Bills_Btn.Text = "   Bills";
            this.Bills_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bills_Btn.UseVisualStyleBackColor = true;
            this.Bills_Btn.Click += new System.EventHandler(this.Bills_Btn_Click);
            // 
            // Payments_Btn
            // 
            this.HorizontalTransition.SetDecoration(this.Payments_Btn, BunifuAnimatorNS.DecorationType.None);
            this.ParticlesTransition.SetDecoration(this.Payments_Btn, BunifuAnimatorNS.DecorationType.None);
            this.Payments_Btn.FlatAppearance.BorderSize = 0;
            this.Payments_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Payments_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Payments_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Payments_Btn.Image = global::BankingSystem.Properties.Resources.fundtransfer;
            this.Payments_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Payments_Btn.Location = new System.Drawing.Point(0, 140);
            this.Payments_Btn.Name = "Payments_Btn";
            this.Payments_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Payments_Btn.Size = new System.Drawing.Size(230, 80);
            this.Payments_Btn.TabIndex = 6;
            this.Payments_Btn.Text = "   Payments and Transfers";
            this.Payments_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Payments_Btn.UseVisualStyleBackColor = true;
            this.Payments_Btn.Click += new System.EventHandler(this.Payments_Btn_Click);
            // 
            // Account_Btn
            // 
            this.HorizontalTransition.SetDecoration(this.Account_Btn, BunifuAnimatorNS.DecorationType.None);
            this.ParticlesTransition.SetDecoration(this.Account_Btn, BunifuAnimatorNS.DecorationType.None);
            this.Account_Btn.FlatAppearance.BorderSize = 0;
            this.Account_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Account_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Account_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Account_Btn.Image = global::BankingSystem.Properties.Resources.profile;
            this.Account_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account_Btn.Location = new System.Drawing.Point(0, 60);
            this.Account_Btn.Name = "Account_Btn";
            this.Account_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Account_Btn.Size = new System.Drawing.Size(230, 80);
            this.Account_Btn.TabIndex = 5;
            this.Account_Btn.Text = "   AccountSummary";
            this.Account_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Account_Btn.UseVisualStyleBackColor = false;
            this.Account_Btn.Click += new System.EventHandler(this.Account_Btn_Click);
            // 
            // Menu_Btn
            // 
            this.HorizontalTransition.SetDecoration(this.Menu_Btn, BunifuAnimatorNS.DecorationType.None);
            this.ParticlesTransition.SetDecoration(this.Menu_Btn, BunifuAnimatorNS.DecorationType.None);
            this.Menu_Btn.FlatAppearance.BorderSize = 0;
            this.Menu_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Menu_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Menu_Btn.Image = global::BankingSystem.Properties.Resources.menu;
            this.Menu_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu_Btn.Location = new System.Drawing.Point(0, 0);
            this.Menu_Btn.Name = "Menu_Btn";
            this.Menu_Btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Menu_Btn.Size = new System.Drawing.Size(230, 60);
            this.Menu_Btn.TabIndex = 11;
            this.Menu_Btn.Text = "   Menu";
            this.Menu_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Menu_Btn.UseVisualStyleBackColor = true;
            this.Menu_Btn.Click += new System.EventHandler(this.Menu_Btn_Click);
            // 
            // MainPanel
            // 
            this.ParticlesTransition.SetDecoration(this.MainPanel, BunifuAnimatorNS.DecorationType.None);
            this.HorizontalTransition.SetDecoration(this.MainPanel, BunifuAnimatorNS.DecorationType.None);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(230, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(10);
            this.MainPanel.Size = new System.Drawing.Size(770, 555);
            this.MainPanel.TabIndex = 10;
            // 
            // HorizontalTransition
            // 
            this.HorizontalTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.HorizontalTransition.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.HorizontalTransition.DefaultAnimation = animation10;
            // 
            // ParticlesTransition
            // 
            this.ParticlesTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.ParticlesTransition.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 1;
            animation9.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 2F;
            animation9.TransparencyCoeff = 0F;
            this.ParticlesTransition.DefaultAnimation = animation9;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.FormHeader);
            this.HorizontalTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ParticlesTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GeneralForm";
            this.Text = "GeneralForm";
            this.FormHeader.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Label TitleLabel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button eTax_Btn;
        private System.Windows.Forms.Button Bills_Btn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Logout_Btn;
        private System.Windows.Forms.Button Menu_Btn;
        private System.Windows.Forms.Button Payments_Btn;
        private System.Windows.Forms.Button Account_Btn;
        private BunifuAnimatorNS.BunifuTransition ParticlesTransition;
        private BunifuAnimatorNS.BunifuTransition HorizontalTransition;
    }
}