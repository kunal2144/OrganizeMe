using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizeMe
{
    public partial class Login : Form
    {

        Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+\w{2,4}$");
        string connectionString = "SERVER=localhost;DATABASE=organizeMe;UID=root;PASSWORD=8136";

        public Login()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (emailID.Text.Equals("Email ID")
                || password.Text.Equals("Password"))
            {
                MessageBox.Show("Please fill in all the details.", "Error");
                return;
            }
            else if (!emailRegex.IsMatch(emailID.Text))
            {
                MessageBox.Show("Invalid Email ID.", "Error");
                return;
            }

            MySqlConnection connection = null;
            bool emailExists = false;
            bool isValid = false;

            try
            {
                connection = new MySqlConnection(connectionString);
                MySqlDataReader reader;
                connection.Open();

                reader = new MySqlCommand("select * from user", connection).ExecuteReader();
                while (reader.Read())
                {
                    if((string)reader.GetValue(1) == emailID.Text)
                    {
                        emailExists = true;
                        using (var md5Hash = MD5.Create())
                        {
                            var sourceBytes = Encoding.UTF8.GetBytes(Convert.ToString(password.Text));
                            var hashBytes = md5Hash.ComputeHash(sourceBytes);
                            var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                            if (hash == (string)reader.GetValue(2)) isValid= true;
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            if (!emailExists)
            {
                MessageBox.Show("Email does not exist", "Error");
                return;
            } 
            else
            {
                if(!isValid)
                {
                    MessageBox.Show("Wrong password", "Error");
                    return;
                }
            }

            Notes notes = new Notes();

            notes.Show();
            this.Hide();
        }

        private void placeholderDisappear(object sender, EventArgs e)
        {
            Control textBox = (Control)sender;

            switch (textBox.Name)
            {
                case "emailID":
                    if (textBox.Text == "Email ID")
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                    }
                    break;

                case "password":
                    if (textBox.Text == "Password")
                    {
                        ((TextBox)textBox).PasswordChar = '*';
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                    }
                    break;
            }
        }

        private void placeholderAppear(object sender, EventArgs e)
        {
            Control textBox = (Control)sender;

            switch (textBox.Name)
            {
                case "emailID":
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = "Email ID";
                        textBox.ForeColor = Color.Gray;
                    }
                    break;

                case "password":
                    if (textBox.Text == "")
                    {
                        ((TextBox)textBox).PasswordChar = '\0';
                        textBox.Text = "Password";
                        textBox.ForeColor = Color.Gray;
                    }
                    break;
            }
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Closed += (s, args) => this.Close();
            registration.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            login_form.Select();
            register.TabStop = false;
        }
    }
}
