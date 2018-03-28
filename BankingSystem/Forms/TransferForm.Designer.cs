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
            this.DepoistAmount_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.WithdrawAmount_TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.Withdraw_Btn = new System.Windows.Forms.Button();
            this.Deposit_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Raleway", 14F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(770, 50);
            this.label2.TabIndex = 20;
            this.label2.Text = "Transfer Funds";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Raleway", 12F);
            this.label1.Location = new System.Drawing.Point(170, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
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
            this.Receiver_No_Textbox.Location = new System.Drawing.Point(395, 371);
            this.Receiver_No_Textbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Receiver_No_Textbox.Name = "Receiver_No_Textbox";
            this.Receiver_No_Textbox.Size = new System.Drawing.Size(200, 33);
            this.Receiver_No_Textbox.TabIndex = 22;
            this.Receiver_No_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Raleway", 12F);
            this.label3.Location = new System.Drawing.Point(170, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Amount Payable";
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
            this.Amount_TextBox.Location = new System.Drawing.Point(395, 424);
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
            this.Pay_Btn.Location = new System.Drawing.Point(301, 481);
            this.Pay_Btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Pay_Btn.Name = "Pay_Btn";
            this.Pay_Btn.Size = new System.Drawing.Size(150, 45);
            this.Pay_Btn.TabIndex = 25;
            this.Pay_Btn.Text = "Pay";
            this.Pay_Btn.UseVisualStyleBackColor = true;
            this.Pay_Btn.Click += new System.EventHandler(this.Pay_Btn_Click);
            // 
            // DepoistAmount_TextBox
            // 
            this.DepoistAmount_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DepoistAmount_TextBox.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepoistAmount_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.DepoistAmount_TextBox.HintForeColor = System.Drawing.Color.DarkGray;
            this.DepoistAmount_TextBox.HintText = "";
            this.DepoistAmount_TextBox.isPassword = false;
            this.DepoistAmount_TextBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.DepoistAmount_TextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.DepoistAmount_TextBox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.DepoistAmount_TextBox.LineThickness = 2;
            this.DepoistAmount_TextBox.Location = new System.Drawing.Point(395, 86);
            this.DepoistAmount_TextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DepoistAmount_TextBox.Name = "DepoistAmount_TextBox";
            this.DepoistAmount_TextBox.Size = new System.Drawing.Size(200, 33);
            this.DepoistAmount_TextBox.TabIndex = 27;
            this.DepoistAmount_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Raleway", 12F);
            this.label4.Location = new System.Drawing.Point(170, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Deposit Amount";
            // 
            // WithdrawAmount_TextBox
            // 
            this.WithdrawAmount_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WithdrawAmount_TextBox.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawAmount_TextBox.ForeColor = System.Drawing.Color.Silver;
            this.WithdrawAmount_TextBox.HintForeColor = System.Drawing.Color.DarkGray;
            this.WithdrawAmount_TextBox.HintText = "";
            this.WithdrawAmount_TextBox.isPassword = false;
            this.WithdrawAmount_TextBox.LineFocusedColor = System.Drawing.Color.Lime;
            this.WithdrawAmount_TextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.WithdrawAmount_TextBox.LineMouseHoverColor = System.Drawing.Color.LimeGreen;
            this.WithdrawAmount_TextBox.LineThickness = 2;
            this.WithdrawAmount_TextBox.Location = new System.Drawing.Point(395, 220);
            this.WithdrawAmount_TextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.WithdrawAmount_TextBox.Name = "WithdrawAmount_TextBox";
            this.WithdrawAmount_TextBox.Size = new System.Drawing.Size(200, 33);
            this.WithdrawAmount_TextBox.TabIndex = 29;
            this.WithdrawAmount_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Raleway", 12F);
            this.label5.Location = new System.Drawing.Point(170, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Withdraw Amount";
            // 
            // Withdraw_Btn
            // 
            this.Withdraw_Btn.FlatAppearance.BorderSize = 0;
            this.Withdraw_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Withdraw_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Withdraw_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Withdraw_Btn.Location = new System.Drawing.Point(301, 280);
            this.Withdraw_Btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Withdraw_Btn.Name = "Withdraw_Btn";
            this.Withdraw_Btn.Size = new System.Drawing.Size(150, 45);
            this.Withdraw_Btn.TabIndex = 30;
            this.Withdraw_Btn.Text = "Withdraw";
            this.Withdraw_Btn.UseVisualStyleBackColor = true;
            this.Withdraw_Btn.Click += new System.EventHandler(this.Withdraw_Btn_Click);
            // 
            // Deposit_Btn
            // 
            this.Deposit_Btn.FlatAppearance.BorderSize = 0;
            this.Deposit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Deposit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deposit_Btn.ForeColor = System.Drawing.Color.LimeGreen;
            this.Deposit_Btn.Location = new System.Drawing.Point(301, 146);
            this.Deposit_Btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Deposit_Btn.Name = "Deposit_Btn";
            this.Deposit_Btn.Size = new System.Drawing.Size(150, 45);
            this.Deposit_Btn.TabIndex = 31;
            this.Deposit_Btn.Text = "Deposit";
            this.Deposit_Btn.UseVisualStyleBackColor = true;
            this.Deposit_Btn.Click += new System.EventHandler(this.Deposit_Btn_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(770, 555);
            this.Controls.Add(this.Deposit_Btn);
            this.Controls.Add(this.Withdraw_Btn);
            this.Controls.Add(this.WithdrawAmount_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DepoistAmount_TextBox);
            this.Controls.Add(this.label4);
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
            this.Name = "TransferForm";
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
        private System.Windows.Forms.Button Deposit_Btn;
        private System.Windows.Forms.Button Withdraw_Btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox WithdrawAmount_TextBox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DepoistAmount_TextBox;
        private System.Windows.Forms.Label label4;
    }
}