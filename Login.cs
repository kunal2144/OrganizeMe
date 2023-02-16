using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Postgrest.Constants;

namespace OrganizeMe
{
    public partial class Login : Form
    {

        Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+\w{2,4}$");
        //string connectionString = "SERVER=localhost;DATABASE=organizeMe;UID=root;PASSWORD=8136";

        public Login()
        {
            InitializeComponent();
        }

        private bool isFormDataValid()
        {
            if (emailID.Text.Equals("Email ID")
                || password.Text.Equals("Password"))
            {
                MessageBox.Show("Please fill in all the details.", "Error");
                return false;
            }
            else if (!emailRegex.IsMatch(emailID.Text))
            {
                MessageBox.Show("Invalid Email ID.", "Error");
                return false;
            }  

            return true;
        }

        private async Task<bool[]> checkLoginDetails()
        {
            bool emailExists = false;
            bool isValid = false;
            string hash = null;

            string url = "https://adkhafzctymlboywymzr.supabase.co";
            string key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();

            var result = await supabase.From<User>()
                .Select(x => new object[] { x.Email, x.Password})
                .Where(x => x.Email == emailID.Text)
                .Single();

            if (result != null)
            {
                emailExists = true;
                using (var md5Hash = MD5.Create())
                {
                    var sourceBytes = Encoding.UTF8.GetBytes(Convert.ToString(password.Text));
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);
                    hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                }

                if(result.Password == hash) isValid= true;
            }

            return new bool[] {emailExists, isValid};
        }

        private async void submit_Click(object sender, EventArgs e)
        {
            if (!isFormDataValid()) return;

            await checkLoginDetails();
            var res = await checkLoginDetails();

            //MySqlConnection connection = null;


            //try
            //{
            //    connection = new MySqlConnection(connectionString);
            //    MySqlDataReader reader;
            //    connection.Open();

            //    reader = new MySqlCommand("select * from user", connection).ExecuteReader();
            //    while (reader.Read())
            //    {
            //        if((string)reader.GetValue(1) == emailID.Text)
            //        {
            //            emailExists = true;
            //            using (var md5Hash = MD5.Create())
            //            {
            //                var sourceBytes = Encoding.UTF8.GetBytes(Convert.ToString(password.Text));
            //                var hashBytes = md5Hash.ComputeHash(sourceBytes);
            //                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

            //                if (hash == (string)reader.GetValue(2)) isValid= true;
            //            }
            //        }
            //    }
            //    reader.Close();
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (connection != null)
            //    {
            //        connection.Close();
            //    }
            //}

            if (!res[0])
            {
                MessageBox.Show("Email does not exist", "Error");
                return;
            }
            else
            {
                if (!res[1])
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
            //createDatabaseIfNotExists("SERVER=localhost;UID=root;PASSWORD=8136", "newDatabase");
        }

        //public void createDatabaseIfNotExists(string connectionString, string dbName)
        //{
        //    MySqlCommand cmd = null;
        //    string dir = Application.StartupPath;
        //    using (var connection = new MySqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        using (cmd = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS {dbName}", connection))
        //        {
        //            cmd.ExecuteNonQuery();
        //        }

        //        using (cmd = new MySqlCommand($"USE {dbName}", connection))
        //        {
        //            cmd.ExecuteNonQuery();
        //        }
        //        //here
        //        Debug.Write($@"{dir}\Assets\Dumps\10_02_43.sql");

        //        string sql = File.ReadAllText($@"{dir}\Assets\Dumps\10_02_43.sql");

        //        using (cmd = new MySqlCommand(sql, connection))
        //        {
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}
