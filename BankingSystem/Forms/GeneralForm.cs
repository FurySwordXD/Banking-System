﻿using System;
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
        public Account account_data;

        public GeneralForm(LoginForm loginform, string acc_no)
        {
            InitializeComponent();
            account_data = new Account(acc_no);
            this.loginform = loginform;

            accountform = new AccountForm(account_data);
            transferform = new TransferForm(account_data);

            MainPanel.Controls.Add(accountform);
            accountform.Show();
            accountform.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(transferform);
            transferform.Hide();
            transferform.Dock = DockStyle.Fill;
        }

        private void LogOut()
        {
            this.Close();
            loginform.Show();
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
            Account_Btn.BackColor = Payments_Btn.BackColor = Bills_Btn.BackColor = eTax_Btn.BackColor = Color.FromArgb(20, 20, 20);
            accountform.Hide();
            transferform.Hide();
        }

        private void Account_Btn_Click(object sender, EventArgs e)
        {
            ClearSelectedButtons();
            Account_Btn.BackColor = Color.FromArgb(35, 35, 35);
            accountform.Show();
        }

        private void Payments_Btn_Click(object sender, EventArgs e)
        {
            ClearSelectedButtons();
            Payments_Btn.BackColor = Color.FromArgb(35, 35, 35);
            transferform.Show();
        }

        private void Bills_Btn_Click(object sender, EventArgs e)
        {
            ClearSelectedButtons();
            Bills_Btn.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void eTax_Btn_Click(object sender, EventArgs e)
        {
            ClearSelectedButtons();
            eTax_Btn.BackColor = Color.FromArgb(35, 35, 35);
        }
    }
}
