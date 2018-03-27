namespace BankingSystem
{
    partial class TransferForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Receiver_No_Textbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.Amount_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Pay_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Raleway", 20F);
            this.label2.Location = new System.Drawing.Point(121, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Transfer Funds";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Raleway", 12F);
            this.label1.Location = new System.Drawing.Point(23, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Reciever\'s Account Number";
            // 
            // Receiver_No_Textbox
            // 
            this.Receiver_No_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Receiver_No_Textbox.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Receiver_No_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.Receiver_No_Textbox.HintForeColor = System.Drawing.Color.DarkGray;
            this.Receiver_No_Textbox.HintText = "";
            this.Receiver_No_Textbox.isPassword = false;
            this.Receiver_No_Textbox.LineFocusedColor = System.Drawing.Color.Lime;
            this.Receiver_No_Textbox.LineIdleColor = System.Drawing.Color.Gray;
            this.Receiver_No_Textbox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.Receiver_No_Textbox.LineThickness = 2;
            this.Receiver_No_Textbox.Location = new System.Drawing.Point(248, 98);
            this.Receiver_No_Textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Receiver_No_Textbox.Name = "Receiver_No_Textbox";
            this.Receiver_No_Textbox.Size = new System.Drawing.Size(200, 33);
            this.Receiver_No_Textbox.TabIndex = 22;
            this.Receiver_No_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Raleway", 12F);
            this.label3.Location = new System.Drawing.Point(23, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Amount";
            // 
            // Amount_TextBox
            // 
            this.Amount_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Amount_TextBox.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.Amount_TextBox.HintForeColor = System.Drawing.Color.DarkGray;
            this.Amount_TextBox.HintText = "";
            this.Amount_TextBox.isPassword = false;
            this.Amount_TextBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.Amount_TextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.Amount_TextBox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.Amount_TextBox.LineThickness = 2;
            this.Amount_TextBox.Location = new System.Drawing.Point(248, 151);
            this.Amount_TextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Amount_TextBox.Name = "Amount_TextBox";
            this.Amount_TextBox.Size = new System.Drawing.Size(200, 33);
            this.Amount_TextBox.TabIndex = 24;
            this.Amount_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Pay_Btn
            // 
            this.Pay_Btn.FlatAppearance.BorderSize = 0;
            this.Pay_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Pay_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pay_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Pay_Btn.Location = new System.Drawing.Point(173, 243);
            this.Pay_Btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Pay_Btn.Name = "Pay_Btn";
            this.Pay_Btn.Size = new System.Drawing.Size(100, 45);
            this.Pay_Btn.TabIndex = 25;
            this.Pay_Btn.Text = "Pay";
            this.Pay_Btn.UseVisualStyleBackColor = true;
            this.Pay_Btn.Click += new System.EventHandler(this.Pay_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(473, 381);
            this.Controls.Add(this.Pay_Btn);
            this.Controls.Add(this.Amount_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Receiver_No_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Amount_TextBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Receiver_No_Textbox;
        private System.Windows.Forms.Button Pay_Btn;
    }
}