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
        
        private string userid = "", password = "";

        public LoginForm()
        {
            InitializeComponent();
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
            SignUpForm form = new SignUpForm(this);
            form.Show();
            this.Hide();
        }

        private void LogIn_Btn_Click(object sender, EventArgs e)
        {
            if (Input_IsValid())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming\VisualStudio\C#\Banking-System\BankingSystem\BankingDatabase.mdf;Integrated Security=True");
                con.Open();
                SqlDataAdapter sql_data_adapter = new SqlDataAdapter("Select Count(*) from AuthenticationTable where UserID = '" + userid + "' and Password = '" + password + "'", con);
                DataTable dt = new DataTable();
                sql_data_adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //MessageBox.Show("Logging in...");
                    SqlCommand cmd = new SqlCommand("SELECT * from AuthenticationTable where UserID = '" + userid + "' and Password = '" + password + "'", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    UserID_Textbox.Text = Password_Textbox.Text = userid = password = "";
                    while(reader.Read())
                        OpenClient(reader["Account_No"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password...");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Input...");
            }
        }

        private void OpenClient(string acc_no)
        {
            GeneralForm form = new GeneralForm(this, acc_no);
            form.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
