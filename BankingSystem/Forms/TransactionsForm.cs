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
    public partial class TransactionsForm : Form
    {
        private Account account_data;
        private List<TranscationSlotForm> SentTranscationSlots, ReceivedTransactionSlots;
        public TransactionsForm(string acc_no)
        {
            InitializeComponent();
            TopLevel = false;
            account_data = new Account(acc_no);
            SentTranscationSlots = new List<TranscationSlotForm>();
            ReceivedTransactionSlots = new List<TranscationSlotForm>();
            UpdateData();
        }

        public void UpdateData()
        {
            account_data.Retrieve_Data();
            SentTranscationSlots.Clear();
            ReceivedTransactionSlots.Clear();
            ReceivedList.Controls.Clear();
            SentList.Controls.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataReader reader;

            TranscationSlotForm slot;
            cmd.CommandText = "SELECT * FROM TransactionsTable WHERE Sender_No = '" + account_data.Get_Account_No() + "'";
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                slot = new TranscationSlotForm(reader["Transaction_Id"].ToString(), reader["Amount"].ToString());
                SentTranscationSlots.Add(slot);
                SentList.Controls.Add(slot);
                slot.Show();
                slot.Dock = DockStyle.Top;
            }
            reader.Close();

            cmd.CommandText = "SELECT * FROM TransactionsTable WHERE Reciever_No = '" + account_data.Get_Account_No() + "'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                slot = new TranscationSlotForm(reader["Transaction_Id"].ToString(), reader["Amount"].ToString());
                ReceivedTransactionSlots.Add(slot);
                ReceivedList.Controls.Add(slot);
                slot.Show();
                slot.Dock = DockStyle.Top;
            }
            reader.Close();

            con.Close();
        }
    }
}
