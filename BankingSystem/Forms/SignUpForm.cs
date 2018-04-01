using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Threading;

namespace BankingSystem
{
    public partial class SignUpForm : Form
    {
        private string userid = "" , password = "", account_no = "", account_type = "", name = "", email = "";

        private LoginForm loginForm;
        public SignUpForm(LoginForm loginform)
        {
            InitializeComponent();
            this.loginForm = loginform;
        }


        public string EncryptDecrypt(string text)
        {
            string key = "X";

            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                result.Append((char)((uint)text[c] ^ (uint)key[c % key.Length]));

            return result.ToString();
        }

        private bool Input_IsValid()
        {
            return !(userid.Contains("\"") || userid.Contains("\'") || password.Contains("\"") || password.Contains("\'"));
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }

        private void Animate()
        {
            for (int i = 0; i <= 100; i++)
            {
                bunifuCircleProgressbar1.Value = i;
                Application.DoEvents();
                Thread.Sleep(10);
            }
        }
        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            if(AccountNumber_Textbox.Text != "" && UserID_Textbox.Text != "" && Password_Textbox.Text != "" && RePassword_Textbox.Text != "" && Email_Textbox.Text != "" && Name_Textbox.Text != "" && Checkbox.Checked == true)
            {
                account_no = AccountNumber_Textbox.Text;
                account_type = AccountType_DropDown.selectedValue;
                userid = UserID_Textbox.Text;
                password = Password_Textbox.Text;
                name = Name_Textbox.Text;
                email = Email_Textbox.Text;
                if (Password_Textbox.Text != RePassword_Textbox.Text)
                {
                    MessageBox.Show("Passwords must match!");
                    return;
                }
                if(!Input_IsValid())
                {
                    MessageBox.Show("Invaid inputs...");
                    return;
                }
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
                con.Open();
                SqlDataAdapter sql_data_adapter1 = new SqlDataAdapter("Select Count(*) from AuthenticationTable where UserID = '" + userid + "'", con);
                SqlDataAdapter sql_data_adapter2 = new SqlDataAdapter("Select Count(*) from AccountTable where Account_No = '" + account_no + "'", con);
                DataTable dt = new DataTable();
                sql_data_adapter1.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Account already exists");
                }
                sql_data_adapter2.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Account already exists");
                }
                else
                {
                    string c = "INSERT into AuthenticationTable(UserID,Password,Account_No) VALUES('" + userid + "','" + EncryptDecrypt(password) + "','" + account_no +"')";
                    SqlCommand cmd = new SqlCommand(c, con);
                    cmd.ExecuteNonQuery();
                    c = "INSERT into AccountTable(Account_No,Account_Type,Name,Email) VALUES('" + account_no + "','" + name + "','" + name + "','" + email + "')";
                    cmd = new SqlCommand(c, con);
                    cmd.ExecuteNonQuery();
                    loginForm.Show();
                    Animate();
                    MessageBox.Show("Account created successfully!");
                    con.Close();
                    Close();
                }
                con.Close();
            }
            else
            {

                MessageBox.Show("Please fill in all details!");
            }
        }
    }
}
