namespace OrganizeMe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.registration_form = new System.Windows.Forms.Panel();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.termsText = new System.Windows.Forms.LinkLabel();
            this.terms = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.emailID = new System.Windows.Forms.RichTextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.branding = new System.Windows.Forms.Panel();
            this.desc = new System.Windows.Forms.LinkLabel();
            this.registration_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.branding.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.title.Location = new System.Drawing.Point(0, 189);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(327, 53);
            this.title.TabIndex = 0;
            this.title.Text = "OrganizeMe";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registration_form
            // 
            this.registration_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.registration_form.Controls.Add(this.confirmPassword);
            this.registration_form.Controls.Add(this.password);
            this.registration_form.Controls.Add(this.termsText);
            this.registration_form.Controls.Add(this.terms);
            this.registration_form.Controls.Add(this.submit);
            this.registration_form.Controls.Add(this.emailID);
            this.registration_form.Dock = System.Windows.Forms.DockStyle.Right;
            this.registration_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_form.Location = new System.Drawing.Point(322, 0);
            this.registration_form.Margin = new System.Windows.Forms.Padding(0);
            this.registration_form.Name = "registration_form";
            this.registration_form.Padding = new System.Windows.Forms.Padding(20);
            this.registration_form.Size = new System.Drawing.Size(362, 361);
            this.registration_form.TabIndex = 1;
            // 
            // confirmPassword
            // 
            this.confirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.confirmPassword.Location = new System.Drawing.Point(66, 173);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(241, 26);
            this.confirmPassword.TabIndex = 7;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(66, 129);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(241, 26);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            // 
            // termsText
            // 
            this.termsText.AutoSize = true;
            this.termsText.ForeColor = System.Drawing.Color.White;
            this.termsText.LinkArea = new System.Windows.Forms.LinkArea(15, 20);
            this.termsText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.termsText.Location = new System.Drawing.Point(66, 216);
            this.termsText.Name = "termsText";
            this.termsText.Size = new System.Drawing.Size(268, 24);
            this.termsText.TabIndex = 5;
            this.termsText.TabStop = true;
            this.termsText.Text = "I agree to the Terms and Conditions";
            this.termsText.UseCompatibleTextRendering = true;
            // 
            // terms
            // 
            this.terms.AutoSize = true;
            this.terms.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.terms.ForeColor = System.Drawing.Color.White;
            this.terms.Location = new System.Drawing.Point(45, 218);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(15, 14);
            this.terms.TabIndex = 4;
            this.terms.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(123, 250);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 30);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // emailID
            // 
            this.emailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailID.ForeColor = System.Drawing.Color.Gray;
            this.emailID.Location = new System.Drawing.Point(66, 86);
            this.emailID.Margin = new System.Windows.Forms.Padding(0);
            this.emailID.Name = "emailID";
            this.emailID.Size = new System.Drawing.Size(241, 26);
            this.emailID.TabIndex = 0;
            this.emailID.Text = "Email ID";
            this.emailID.Enter += new System.EventHandler(this.placeholderDisappear);
            this.emailID.Leave += new System.EventHandler(this.placeholderAppear);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(114, 86);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // branding
            // 
            this.branding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.branding.Controls.Add(this.desc);
            this.branding.Controls.Add(this.logo);
            this.branding.Controls.Add(this.title);
            this.branding.Dock = System.Windows.Forms.DockStyle.Left;
            this.branding.Location = new System.Drawing.Point(0, 0);
            this.branding.Name = "branding";
            this.branding.Size = new System.Drawing.Size(327, 361);
            this.branding.TabIndex = 3;
            // 
            // desc
            // 
            this.desc.DisabledLinkColor = System.Drawing.Color.White;
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.White;
            this.desc.LinkArea = new System.Windows.Forms.LinkArea(30, 3);
            this.desc.LinkColor = System.Drawing.Color.Aqua;
            this.desc.Location = new System.Drawing.Point(22, 242);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(281, 20);
            this.desc.TabIndex = 3;
            this.desc.TabStop = true;
            this.desc.Text = "A truly powerful and flexible PIM App";
            this.desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.desc.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(55)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.branding);
            this.Controls.Add(this.registration_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.registration_form.ResumeLayout(false);
            this.registration_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.branding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel registration_form;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel branding;
        private System.Windows.Forms.LinkLabel desc;
        private System.Windows.Forms.LinkLabel termsText;
        private System.Windows.Forms.CheckBox terms;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox emailID;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox password;
    }
}

