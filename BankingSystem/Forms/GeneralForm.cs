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
    public partial class GeneralForm : Form
    {
        private LoginForm loginform;
        private AccountForm accountform;
        private TransferForm transferform;
        private TransactionsForm transactionsform;

        public GeneralForm(LoginForm loginform, string acc_no)
        {
            InitializeComponent();
            this.loginform = loginform;

            accountform = new AccountForm(acc_no);
            transferform = new TransferForm(acc_no);
            transactionsform = new TransactionsForm(acc_no);

            MainPanel.Controls.Add(accountform);
            accountform.Show();
            accountform.Dock = DockStyle.Fill;
            Account_Btn.BackColor = Color.FromArgb(35, 35, 35);

            MainPanel.Controls.Add(transferform);
            transferform.Hide();
            transferform.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(transactionsform);
            transactionsform.Hide();
            transactionsform.Dock = DockStyle.Fill;
        }

        private void LogOut()
        {
            loginform.Show();
            Close();
        }


        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void Menu_Btn_Click(object sender, EventArgs e)
        {
            NavigationPanel.Visible = false;
            MainPanel.Visible = false;
            if (NavigationPanel.Width > 100)
            {
                NavigationPanel.Width = 80;
                ParticlesTransition.ShowSync(NavigationPanel);
                HorizontalTransition.ShowSync(MainPanel);
            }
            else
            {
                NavigationPanel.Width = 230;
                HorizontalTransition.ShowSync(NavigationPanel);
                ParticlesTransition.ShowSync(MainPanel);
            }
        }
        private void ClearSelectedButtons()
        {
            Account_Btn.BackColor = Payments_Btn.BackColor = Transactions_Btn.BackColor = eTax_Btn.BackColor = Color.FromArgb(20, 20, 20);
            accountform.Hide();
            transferform.Hide();
            transactionsform.Hide();
        }

        private void Account_Btn_Click(object sender, EventArgs e)
        {
            ClearSelectedButtons();
            Account_Btn.BackColor = Color.FromArgb(35, 35, 35);
            accountform.Show();
            accountform.UpdateData();
        }

        private void Payments_Btn_Click(object sender, EventArgs e)
        {
            ClearSelectedButtons();
            Payments_Btn.BackColor = Color.FromArgb(35, 35, 35);
            transferform.Show();
        }

        private void Transactions_Btn_Click(object sender, EventArgs e)
        {
            ClearSelectedButtons();
            Transactions_Btn.BackColor = Color.FromArgb(35, 35, 35);
            transactionsform.UpdateData();
            transactionsform.Show();
        }

        private void eTax_Btn_Click(object sender, EventArgs e)
        {
            ClearSelectedButtons();
            eTax_Btn.BackColor = Color.FromArgb(35, 35, 35);
        }

    }
}
