using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Postgrest.Constants;
using static Supabase.Functions.Client;

namespace OrganizeMe
{
    public partial class Login : Form
    {

        Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+\w{2,4}$");
        Timer timer;
        int ellipsisCount = 0;

        public static Login instance = null;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            instance = this;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            login_form.Select();
            register.TabStop = false;

            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += animateEllipsis;
            
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
                
            //var client = new HttpClient();
            //var request = new HttpRequestMessage(HttpMethod.Post, "https://adkhafzctymlboywymzr.supabase.co/rest/v1/rpc/create_notes_table");
            //request.Headers.Add("apikey", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");
            //request.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFka2hhZnpjdHltbGJveXd5bXpyIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NzY0NzQ4OTgsImV4cCI6MTk5MjA1MDg5OH0.Q49X9_w-6pCSQ36uIJqrNHXas0gZHJhjnS0omVhNpZw");
            //var content = new StringContent("{ \"user_id\": 12345 }", null, "application/json");
            //request.Content = content;
            //var response = await client.SendAsync(request);
            //response.EnsureSuccessStatusCode();
            //Console.WriteLine(await response.Content.ReadAsStringAsync());


            var result = await supabase.From<User>()
                .Select(x => new object[] { x.Id, x.Email, x.Password, x.CreatedAt})
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

                if(result.Password == hash)
                {
                    isValid = true;
                    User.CurrentUser = result;
                }
            }

            return new bool[] {emailExists, isValid};
        }



        private async void submit_Click(object sender, EventArgs e)
        {
            if (isFormDataValid())
            {
                submit.Enabled = false;
                register.Visible = false;
                LoggingIn.Visible = true;
                timer.Start();

                await checkLoginDetails();
                var res = await checkLoginDetails();

                if (res[0] && res[1])
                {
                    Notes notes = new Notes();
                    await notes.fetchNotes();
                    notes.Show();
                    this.Hide();
                }

                submit.Enabled = true;
                register.Visible = true;
                LoggingIn.Visible = false;
                LoggingIn.Text = "Logging in";
                timer.Stop();

                if (!res[0]) MessageBox.Show("Email does not exist", "Error");
                else if (!res[1]) MessageBox.Show("Wrong password", "Error");
            }
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

        private void animateEllipsis(object sender, EventArgs e)
        {
            if(ellipsisCount >= 3)
            {
                ellipsisCount = 0;
                LoggingIn.Text = "Logging in";
            }
            else
            {
                LoggingIn.Text += ".";
                ellipsisCount++;
            }
        }
    }
}
