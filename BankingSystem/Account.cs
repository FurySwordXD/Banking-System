using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

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
            Retrieve_Data();
        }

        public void Retrieve_Data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from AccountTable where Account_No = '" + account_no +"'", con);
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
            reader.Close();
            con.Close();
        }

        public string Get_Account_Type() { return account_type; }
        public string Get_Account_No() { return account_no; }
        public string Get_Name() { return name; }
        public string Get_Email() { return email; }
        public float Get_Credit() { return credit; }
        public float Get_Debit() { return debit; }

        private void AddTransaction(float amount, string sender_no, string reciever_no)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataReader reader;

            int id = 0;
            cmd.CommandText = "SELECT TOP 1 * FROM TransactionsTable ORDER BY Transaction_Id DESC";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = Convert.ToInt32(reader["Transaction_Id"].ToString()) + 1;
                Console.WriteLine("id: " + id);
            }
            reader.Close();

            cmd.CommandText = "INSERT into TransactionsTable(Transaction_Id,Sender_No,Reciever_No,Amount) VALUES('" + id + "','" + sender_no + "','" + reciever_no + "','" + amount + "')";
            cmd.ExecuteNonQuery();

            con.Close();
        }
        public bool AddFunds(float amount)
        {
            if (amount > 0)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                credit = credit + amount;
                cmd.CommandText = "UPDATE AccountTable SET Credit = '" + credit + "' where Account_No = '" + account_no + "'";
                cmd.ExecuteNonQuery();
                AddTransaction(amount, null, account_no);
                return true;
            }
            return false;
        }

        public bool WithdrawFunds(float amount)
        {
            if (amount > 0 && amount <= credit)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                credit = credit - amount;
                cmd.CommandText = "UPDATE AccountTable SET Credit = '" + credit + "' where Account_No = '" + account_no + "'";
                cmd.ExecuteNonQuery();
                AddTransaction(amount, account_no, null);
                return true;
            }
            return false;
        }

        public bool Pay(string acc_no, float amount)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlDataReader reader;
            SqlDataAdapter sql_data_adapter = new SqlDataAdapter("Select Count(*) from AccountTable where Account_No = '" + acc_no + "'", con);
            DataTable dt = new DataTable();
            sql_data_adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (amount <= credit)
                {
                    credit = credit - amount;

                    cmd.CommandText = "UPDATE AccountTable SET Credit = '" + credit + "' where Account_No = '" + account_no + "'";
                    cmd.ExecuteNonQuery();

                    float reciever_credit = 0;
                    cmd.CommandText = "SELECT * from AccountTable where Account_No = '" + acc_no + "'";
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    reciever_credit = Convert.ToSingle(reader["Credit"].ToString());
                    reader.Close();

                    cmd.CommandText = "UPDATE AccountTable SET Credit = '" + (reciever_credit + amount) + "' where Account_No = '" + acc_no + "'";
                    cmd.ExecuteNonQuery();
                    AddTransaction(amount, account_no, acc_no);
                    
                    con.Close();
                    return true;
                }
            }
            return false;
        }
    }
}
