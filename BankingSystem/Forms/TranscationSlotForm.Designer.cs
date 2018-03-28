namespace BankingSystem
{
    partial class TranscationSlotForm
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Amount_Label = new System.Windows.Forms.Label();
            this.TransactionId_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TitleLabel
            // 
            this.TitleLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.TitleLabel.Location = new System.Drawing.Point(1, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(165, 45);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Transaction Id";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(1, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Amount_Label
            // 
            this.Amount_Label.ForeColor = System.Drawing.Color.LimeGreen;
            this.Amount_Label.Location = new System.Drawing.Point(176, 46);
            this.Amount_Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Amount_Label.Name = "Amount_Label";
            this.Amount_Label.Size = new System.Drawing.Size(158, 45);
            this.Amount_Label.TabIndex = 10;
            this.Amount_Label.Text = "250";
            this.Amount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TransactionId_Label
            // 
            this.TransactionId_Label.ForeColor = System.Drawing.Color.LimeGreen;
            this.TransactionId_Label.Location = new System.Drawing.Point(176, 1);
            this.TransactionId_Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TransactionId_Label.Name = "TransactionId_Label";
            this.TransactionId_Label.Size = new System.Drawing.Size(158, 45);
            this.TransactionId_Label.TabIndex = 11;
            this.TransactionId_Label.Text = "12";
            this.TransactionId_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TranscationSlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(335, 90);
            this.Controls.Add(this.TransactionId_Label);
            this.Controls.Add(this.Amount_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TranscationSlotForm";
            this.Text = "TranscationSlotForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TransactionId_Label;
        private System.Windows.Forms.Label Amount_Label;
    }
}