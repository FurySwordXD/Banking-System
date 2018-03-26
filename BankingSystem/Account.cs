using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingSystem
{
    class Account
    {

        private string account_no;
        private string account_type;
        private string name;
        private string email;
        private float credit;
        private float debit;
        private float balance;

        public Account(string acc_no)
        {
            account_no = acc_no;
        }

        public void Retrieve_Data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from AccountTable where Account_No = " + account_no, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                account_type = reader["Account_Type"].ToString();
                name = reader["Name"].ToString();
                email = reader["Email"].ToString();
                credit = Convert.ToSingle(reader["Credit"].ToString());
                debit = Convert.ToSingle(reader["Debit"].ToString());
                balance = credit - debit;
            }
            con.Close();
        }

        public string Get_Account_Type() { return account_type; }
        public string Get_Account_No() { return account_no; }
        public string Get_Name() { return name; }
        public string Get_Email() { return email; }
        public float Get_Credit() { return credit; }
        public float Get_Debit() { return debit; }
    }
}
