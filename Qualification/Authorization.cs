using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SD = System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Qualification
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private string id;



        public void openConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

      

        private void enterButton_Click(object sender, EventArgs e)
        {
            string Login = loginTextBox.Text.ToString();
            string Password = passwordTextBox.Text.ToString();


            openConnection();

            if (Check(Login, Password))
            {
                MessageBox.Show("Вход успешен");
                FormAccountant frm = new FormAccountant();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный логин или пароль");
                Student frm = new Student();
                frm.Show();
            }
            closeConnection();


        }
        private Boolean Check(string login, string password)
        {
            DataTable table = new DataTable();
            string Login = login;
            string Password = password;

            Password = CreateMD5(Password);

            string commandString = $"select Логин, Пароль from Вход where Логин='{Login}' and Пароль='{Password}'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void deleteTextButton_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = " ";
            passwordTextBox.Text = " ";
        }
    }
}
