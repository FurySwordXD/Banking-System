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
        public TransferForm(Account acc_data)
        {
            InitializeComponent();
            account_data = acc_data;
        }

        private void Pay_Btn_Click(object sender, EventArgs e)
        {
            if (account_data.Pay(Receiver_No_Textbox.Text, Convert.ToSingle(Amount_TextBox.Text)))
            {
                MessageBox.Show("Transfer Successful!");
            }
            else
                MessageBox.Show("Insufficient Funds...");
        }
    }
}
