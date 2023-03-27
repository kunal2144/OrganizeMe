namespace OrganizeMe
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_form = new System.Windows.Forms.Panel();
            this.LoggingIn = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.LinkLabel();
            this.password = new System.Windows.Forms.TextBox();
            this.emailID = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.branding = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.login_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.branding.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_form
            // 
            this.login_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.login_form.Controls.Add(this.LoggingIn);
            this.login_form.Controls.Add(this.submit);
            this.login_form.Controls.Add(this.register);
            this.login_form.Controls.Add(this.password);
            this.login_form.Controls.Add(this.emailID);
            this.login_form.Dock = System.Windows.Forms.DockStyle.Right;
            this.login_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_form.Location = new System.Drawing.Point(327, 0);
            this.login_form.Margin = new System.Windows.Forms.Padding(0);
            this.login_form.Name = "login_form";
            this.login_form.Padding = new System.Windows.Forms.Padding(20);
            this.login_form.Size = new System.Drawing.Size(357, 361);
            this.login_form.TabIndex = 4;
            // 
            // LoggingIn
            // 
            this.LoggingIn.AutoSize = true;
            this.LoggingIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggingIn.ForeColor = System.Drawing.Color.White;
            this.LoggingIn.Location = new System.Drawing.Point(121, 238);
            this.LoggingIn.Name = "LoggingIn";
            this.LoggingIn.Size = new System.Drawing.Size(92, 20);
            this.LoggingIn.TabIndex = 6;
            this.LoggingIn.Text = "Logging in";
            this.LoggingIn.Visible = false;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(46)))), ((int)(((byte)(95)))));
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.Window;
            this.submit.Location = new System.Drawing.Point(112, 188);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 30);
            this.submit.TabIndex = 5;
            this.submit.Text = "Login";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.LinkArea = new System.Windows.Forms.LinkArea(3, 8);
            this.register.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.register.Location = new System.Drawing.Point(112, 238);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(125, 24);
            this.register.TabIndex = 5;
            this.register.TabStop = true;
            this.register.Text = "or Register now.";
            this.register.UseCompatibleTextRendering = true;
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(54, 136);
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
            this.emailID.Location = new System.Drawing.Point(54, 89);
            this.emailID.Multiline = false;
            this.emailID.Name = "emailID";
            this.emailID.Size = new System.Drawing.Size(241, 26);
            this.emailID.TabIndex = 0;
            this.emailID.Text = "Email ID";
            this.emailID.Enter += new System.EventHandler(this.placeholderDisappear);
            this.emailID.Leave += new System.EventHandler(this.placeholderAppear);
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
            this.branding.TabIndex = 5;
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.login_form);
            this.Controls.Add(this.branding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.login_form.ResumeLayout(false);
            this.login_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.branding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_form;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.LinkLabel register;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.RichTextBox emailID;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel branding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Label LoggingIn;
    }
}