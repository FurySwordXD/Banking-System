using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class AccountForm : Form
    {
        public AccountForm(Account account_data)
        {
            InitializeComponent();
            this.TopLevel = false;
            account_data.Retrieve_Data();
            Account_NoLabel.Text = account_data.Get_Account_No().ToString();
            Account_TypeLabel.Text = account_data.Get_Account_Type();
            NameLabel.Text = account_data.Get_Name();
            EmailLabel.Text = account_data.Get_Email();
            CreditLabel.Text = account_data.Get_Credit().ToString();
            DebitLabel.Text = account_data.Get_Debit().ToString();
            BalanceLabel.Text = (account_data.Get_Credit() - account_data.Get_Debit()).ToString();
        }
    }
}
