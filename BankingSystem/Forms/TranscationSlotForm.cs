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
    public partial class TranscationSlotForm : Form
    {
        public TranscationSlotForm(string Transaction_Id, string amount)
        {
            InitializeComponent();
            TopLevel = false;
            TransactionId_Label.Text = Transaction_Id;
            Amount_Label.Text = amount;
        }
    }
}
