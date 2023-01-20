using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizeMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            registration_form.Select();
        }

        private void placeholderDisappear(object sender, EventArgs e)
        {
            if (((Control)sender).Name == "emailID" && ((Control)sender).Text == "Email ID") ((Control)sender).Text = "";
            if (((Control)sender).Name == "password" && ((Control)sender).Text == "Password") ((Control)sender).Text = "";
            if (((Control)sender).Name == "confirmPassword" && ((Control)sender).Text == "Confirm Password") ((Control)sender).Text = "";
            ((Control)sender).ForeColor = Color.Black;
        }

        private void placeholderAppear(object sender, EventArgs e)
        {
            if (((Control)sender).Name == "emailID" && ((Control)sender).Text == "") ((Control)sender).Text = "Email ID";
            if (((Control)sender).Name == "password" && ((Control)sender).Text == "") ((Control)sender).Text = "Password";
            if (((Control)sender).Name == "confirmPassword" && ((Control)sender).Text == "") ((Control)sender).Text = "Confirm Password";
            if (["Email ID", "Password", "Confirm Password"].contains(((Control)sender).Text)) ((Control)sender).ForeColor = Color.Gray;
        }
    }
}
