using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankingSystem
{
    public partial class TransferForm : Form
    {
        private Account account_data;
        public TransferForm(string acc_no)
        {
            InitializeComponent();
            TopLevel = false;
            account_data = new Account(acc_no);
        }

        private void Pay_Btn_Click(object sender, EventArgs e)
        {
            account_data.Retrieve_Data();
            if (account_data.Pay(Receiver_No_Textbox.Text, Convert.ToSingle(Amount_TextBox.Text)))
            {
                MessageBox.Show("Transfer Successful!");
            }
            else
                MessageBox.Show("Invalid Account No. or Insufficient funds...");
        }

        private void Deposit_Btn_Click(object sender, EventArgs e)
        {
            account_data.Retrieve_Data();
            if (account_data.AddFunds(Convert.ToSingle(DepoistAmount_TextBox.Text)))
                MessageBox.Show("Added Funds Succesfully!");
            else
                MessageBox.Show("Could not add funds...");
        }

        private void Withdraw_Btn_Click(object sender, EventArgs e)
        {
            account_data.Retrieve_Data();
            if (account_data.WithdrawFunds(Convert.ToSingle(WithdrawAmount_TextBox.Text)))
                MessageBox.Show("Withdrew Funds Succesfully!");
            else
                MessageBox.Show("Insufficient funds... ");
        }
    }
}
