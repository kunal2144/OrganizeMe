namespace OrganizeMe
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.title = new System.Windows.Forms.Label();
            this.registration_form = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.register = new System.Windows.Forms.Button();
            this.termsText = new System.Windows.Forms.LinkLabel();
            this.terms = new System.Windows.Forms.CheckBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.emailID = new System.Windows.Forms.RichTextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.branding = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
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
            this.title.Location = new System.Drawing.Point(0, 183);
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
            this.registration_form.Controls.Add(this.label3);
            this.registration_form.Controls.Add(this.dateTimePicker1);
            this.registration_form.Controls.Add(this.linkLabel1);
            this.registration_form.Controls.Add(this.register);
            this.registration_form.Controls.Add(this.termsText);
            this.registration_form.Controls.Add(this.terms);
            this.registration_form.Controls.Add(this.confirmPassword);
            this.registration_form.Controls.Add(this.password);
            this.registration_form.Controls.Add(this.emailID);
            this.registration_form.Dock = System.Windows.Forms.DockStyle.Right;
            this.registration_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_form.Location = new System.Drawing.Point(327, 0);
            this.registration_form.Margin = new System.Windows.Forms.Padding(0);
            this.registration_form.Name = "registration_form";
            this.registration_form.Padding = new System.Windows.Forms.Padding(20);
            this.registration_form.Size = new System.Drawing.Size(357, 361);
            this.registration_form.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(25, 30);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(61, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(245, 24);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account? Login.";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.Window;
            this.register.Location = new System.Drawing.Point(120, 264);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(121, 30);
            this.register.TabIndex = 5;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.submit_Click);
            // 
            // termsText
            // 
            this.termsText.AutoSize = true;
            this.termsText.ForeColor = System.Drawing.Color.White;
            this.termsText.LinkArea = new System.Windows.Forms.LinkArea(15, 20);
            this.termsText.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.termsText.Location = new System.Drawing.Point(59, 231);
            this.termsText.Name = "termsText";
            this.termsText.Size = new System.Drawing.Size(268, 24);
            this.termsText.TabIndex = 5;
            this.termsText.TabStop = true;
            this.termsText.Text = "I agree to the Terms and Conditions";
            this.termsText.UseCompatibleTextRendering = true;
            this.termsText.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.termsText_LinkClicked);
            // 
            // terms
            // 
            this.terms.AutoSize = true;
            this.terms.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.terms.ForeColor = System.Drawing.Color.White;
            this.terms.Location = new System.Drawing.Point(43, 233);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(15, 14);
            this.terms.TabIndex = 4;
            this.terms.UseVisualStyleBackColor = true;
            // 
            // confirmPassword
            // 
            this.confirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.confirmPassword.Location = new System.Drawing.Point(62, 143);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(241, 26);
            this.confirmPassword.TabIndex = 3;
            this.confirmPassword.Text = "Confirm Password";
            this.confirmPassword.Enter += new System.EventHandler(this.placeholderDisappear);
            this.confirmPassword.Leave += new System.EventHandler(this.placeholderAppear);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(62, 100);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(241, 26);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.placeholderDisappear);
            this.password.Leave += new System.EventHandler(this.placeholderAppear);
            // 
            // emailID
            // 
            this.emailID.BackColor = System.Drawing.SystemColors.Window;
            this.emailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailID.ForeColor = System.Drawing.Color.Gray;
            this.emailID.Location = new System.Drawing.Point(62, 59);
            this.emailID.Multiline = false;
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
            this.logo.Location = new System.Drawing.Point(114, 80);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // branding
            // 
            this.branding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.branding.Controls.Add(this.label2);
            this.branding.Controls.Add(this.label1);
            this.branding.Controls.Add(this.desc);
            this.branding.Controls.Add(this.logo);
            this.branding.Controls.Add(this.title);
            this.branding.Dock = System.Windows.Forms.DockStyle.Left;
            this.branding.Location = new System.Drawing.Point(0, 0);
            this.branding.Name = "branding";
            this.branding.Size = new System.Drawing.Size(327, 361);
            this.branding.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(213)))), ((int)(((byte)(177)))));
            this.label2.Location = new System.Drawing.Point(192, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "task";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(213)))), ((int)(((byte)(177)))));
            this.label1.Location = new System.Drawing.Point(107, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "lives,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.desc.Location = new System.Drawing.Point(1, 233);
            this.desc.Margin = new System.Windows.Forms.Padding(0);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(324, 34);
            this.desc.TabIndex = 3;
            this.desc.Text = "Simplifying lives, one task at a time.";
            this.desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registration
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(55)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.branding);
            this.Controls.Add(this.registration_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.registration_form.ResumeLayout(false);
            this.registration_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.branding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel registration_form;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel branding;
        private System.Windows.Forms.LinkLabel termsText;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.RichTextBox emailID;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox terms;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

