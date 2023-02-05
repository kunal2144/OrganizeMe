using MySqlConnector;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OrganizeMe
{
    public partial class Registration : Form
    {
        Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+\w{2,4}$");
        Regex passwordRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        string connectionString = "SERVER=localhost;DATABASE=organizeMe;UID=root;PASSWORD=8136";

        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            registration_form.Select();
            termsText.TabStop = false;
        }   

        private void placeholderDisappear(object sender, EventArgs e)
        {
            Control textBox = (Control)sender;

            switch(textBox.Name)
            {
                case "emailID":
                    if(textBox.Text == "Email ID")
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

                case "confirmPassword":
                    if (textBox.Text == "Confirm Password")
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

                case "confirmPassword":
                    if (textBox.Text == "")
                    {
                        ((TextBox)textBox).PasswordChar = '\0';
                        textBox.Text = "Confirm Password";
                        textBox.ForeColor = Color.Gray;
                    }
                    break;
            }
        }

        private void termsText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Terms_of_service");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (emailID.Text.Equals("Email ID")
                || password.Text.Equals("Password")
                || confirmPassword.Text.Equals("Confirm Password"))
            {
                MessageBox.Show("Please fill in all the details.", "Error");
                return;
            }
            else if (!emailRegex.IsMatch(emailID.Text))
            {
                MessageBox.Show("Invalid Email ID.", "Error");
                return;
            }
            else if (!passwordRegex.IsMatch(password.Text))
            {
                MessageBox.Show("Password should contain:\n" +
                    "At least 8 characters.\n" +
                    "At least 1 lowercase character.\n" +
                    "At least 1 uppercase character.\n" +
                    "At least 1 digit.\n" +
                    "At least 1 special character.\n", "Error");
                return;
            }
            else if (!password.Text.Equals(confirmPassword.Text))
            {
                MessageBox.Show("Passwords do not match", "Error");
                password.Text = String.Empty;
                confirmPassword.Text = String.Empty;
                placeholderAppear(password, new EventArgs());
                placeholderAppear(confirmPassword, new EventArgs());
                return;
            }
            else if(!terms.Checked)
            {
                MessageBox.Show("Please check the terms and conditions.", "Error");
                return;
            }

            MySqlConnection connection = null;

            try
            {
                connection = new MySqlConnection(connectionString);
                MySqlDataReader reader;
                connection.Open();
                string hash = null;

                using (var md5Hash = MD5.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(Convert.ToString(password.Text));
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);
                    hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                }

                reader = new MySqlCommand("insert into user values (null, '" + emailID.Text + "', '" + hash + "')", connection).ExecuteReader();
                while (reader.Read()) { }
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

            this.Hide();
            Notes notes = new Notes();
            notes.Closed += (s, args) => this.Close();
            notes.Show();
        }
    }
}
