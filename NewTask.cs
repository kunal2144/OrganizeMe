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
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            panel1.Select();
        }

        private void placeholderDisappear(object sender, EventArgs e)
        {
            Control textBox = (Control)sender;

            switch (textBox.Name)
            {
                case "taskName":
                    if (textBox.Text == "Enter the task name")
                    {
                        textBox.Text = "";
                        textBox.ForeColor = Color.Black;
                    }
                    break;

                case "taskDesc":
                    if (textBox.Text == "Enter the task description")
                    {
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
                case "taskName":
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = "Enter the task name";
                        textBox.ForeColor = Color.Gray;
                    }
                    break;

                case "taskDesc":
                    if (textBox.Text == "")
                    {
                        textBox.Text = "Enter the task description";
                        textBox.ForeColor = Color.Gray;
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notes.instance.Show();
            this.Close();
        }
    }
}
