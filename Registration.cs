using MySqlConnector;
using Postgrest.Attributes;
using Postgrest.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace OrganizeMe
{
    public partial class Registration : Form
    {
        Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+\w{2,4}$");
        Regex passwordRegex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

        public Registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private bool isFormDataValid()
        {
            if (emailID.Text.Equals("Email ID")
                || password.Text.Equals("Password")
                || confirmPassword.Text.Equals("Confirm Password"))
            {
                MessageBox.Show("Please fill in all the details.", "Error");
                return false;
            }
            else if (!emailRegex.IsMatch(emailID.Text))
            {
                MessageBox.Show("Invalid Email ID.", "Error");
                return false;
            }
            else if (!passwordRegex.IsMatch(password.Text))
            {
                MessageBox.Show("Password should contain:\n" +
                    "At least 8 characters.\n" +
                    "At least 1 lowercase character.\n" +
                    "At least 1 uppercase character.\n" +
                    "At least 1 digit.\n" +
                    "At least 1 special character.\n", "Error");
                return false;
            }
            else if (!password.Text.Equals(confirmPassword.Text))
            {
                MessageBox.Show("Passwords do not match", "Error");
                password.Text = String.Empty;
                confirmPassword.Text = String.Empty;
                placeholderAppear(password, new EventArgs());
                placeholderAppear(confirmPassword, new EventArgs());
                return false;
            }
            else if (!terms.Checked)
            {
                MessageBox.Show("Please check the terms and conditions.", "Error");
                return false;
            }

            return true;
        }

        private async Task<bool> pushData()
        {
            string url = "https://adkhafzctymlboywymzr.supabase.co";
            string key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw";
            string hash = null;

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            var supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();

            using (var md5Hash = MD5.Create())
            {
                var sourceBytes = Encoding.UTF8.GetBytes(Convert.ToString(password.Text));
                var hashBytes = md5Hash.ComputeHash(sourceBytes);
                hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }

            User user = new User
            {
                Email = emailID.Text,
                Password = hash,
                CreatedAt = DateTime.Now,
            };

            await supabase.From<User>().Insert(user);

            user.Id = (await supabase.From<User>()
                .Select(x => new object[] { x.Id })
                .Where(x => x.Email == emailID.Text)
                .Single()).Id;

            User.CurrentUser = user;
            return true;
        }

        private async void submit_Click(object sender, EventArgs e)
        {
            if(!isFormDataValid()) return;

            await pushData();
            createNotesTable();

            Notes notes = new Notes();
            notes.Show();
            this.Hide();
        }

        private async void createNotesTable()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://adkhafzctymlboywymzr.supabase.co/rest/v1/rpc/create_notes_table");
            request.Headers.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");
            request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");
            var content = new StringContent($"{{ \"user_id\": {User.CurrentUser.Id} }}", null, "application/json");
            request.Content = content;
            await client.SendAsync(request);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
