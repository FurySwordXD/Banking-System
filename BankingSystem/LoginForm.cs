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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Programming\VisualStudio\C#\BankingSystem\BankingSystem\BankingSystem\BankingDatabase.mdf;Integrated Security=True");

        private string userid = "", password = "";

        public LoginForm()
        {
            InitializeComponent();
            con.Open();
        }

        private void Password_Textbox_OnValueChanged(object sender, EventArgs e)
        {
            password = Password_Textbox.Text;
        }

        private void UserID_Textbox_OnValueChanged(object sender, EventArgs e)
        {
            userid = UserID_Textbox.Text;
        }

        private bool Input_IsValid()
        {
            return !(userid == "" || userid.Contains("\"") || userid.Contains("\'") || password == "" || password.Contains("\"") || password.Contains("\'"));
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            if (Input_IsValid())
            {
                SqlDataAdapter sql_data_adapter = new SqlDataAdapter("Select Count(*) from AuthenticationTable where UserID = '" + userid + "'", con);
                DataTable dt = new DataTable();
                sql_data_adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Account already exists");
                }
                else
                {
                    string c = "INSERT into AuthenticationTable(UserID,Password) VALUES('" + userid + "','" + password + "')";
                    SqlCommand cmd = new SqlCommand(c, con);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Invalid Input...");
                OpenClient();
            }
        }

        private void LogIn_Btn_Click(object sender, EventArgs e)
        {
            if (Input_IsValid())
            {
                SqlDataAdapter sql_data_adapter = new SqlDataAdapter("Select Count(*) from AuthenticationTable where UserID = '" + userid + "' and Password = '" + password + "'", con);
                DataTable dt = new DataTable();
                sql_data_adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //MessageBox.Show("Logging in...");
                    UserID_Textbox.Text = Password_Textbox.Text = userid = password = "";
                    OpenClient();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password...");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input...");
            }
        }

        private void OpenClient()
        {
            GeneralForm form = new GeneralForm(this);
            form.Show();
            this.Hide();
        }
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
