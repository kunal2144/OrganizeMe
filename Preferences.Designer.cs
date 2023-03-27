namespace OrganizeMe
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.headings = new System.Windows.Forms.Panel();
            this.others = new System.Windows.Forms.Label();
            this.profile = new System.Windows.Forms.Label();
            this.general = new System.Windows.Forms.Label();
            this.generalPref = new System.Windows.Forms.Panel();
            this.fontChange = new System.Windows.Forms.Button();
            this.currentFont = new System.Windows.Forms.Label();
            this.font = new System.Windows.Forms.Label();
            this.profilePref = new System.Windows.Forms.Panel();
            this.profilePlaceholder = new System.Windows.Forms.Label();
            this.othersPref = new System.Windows.Forms.Panel();
            this.otherPlaceholder = new System.Windows.Forms.Label();
            this.pref = new System.Windows.Forms.Panel();
            this.headings.SuspendLayout();
            this.generalPref.SuspendLayout();
            this.profilePref.SuspendLayout();
            this.othersPref.SuspendLayout();
            this.pref.SuspendLayout();
            this.SuspendLayout();
            // 
            // headings
            // 
            this.headings.AutoScroll = true;
            this.headings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.headings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headings.Controls.Add(this.others);
            this.headings.Controls.Add(this.profile);
            this.headings.Controls.Add(this.general);
            this.headings.Dock = System.Windows.Forms.DockStyle.Left;
            this.headings.Location = new System.Drawing.Point(0, 0);
            this.headings.Name = "headings";
            this.headings.Size = new System.Drawing.Size(108, 431);
            this.headings.TabIndex = 0;
            // 
            // others
            // 
            this.others.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.others.Dock = System.Windows.Forms.DockStyle.Top;
            this.others.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.others.ForeColor = System.Drawing.Color.White;
            this.others.Location = new System.Drawing.Point(0, 66);
            this.others.Name = "others";
            this.others.Size = new System.Drawing.Size(106, 33);
            this.others.TabIndex = 5;
            this.others.Text = "Others";
            this.others.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profile
            // 
            this.profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.ForeColor = System.Drawing.Color.White;
            this.profile.Location = new System.Drawing.Point(0, 33);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(106, 33);
            this.profile.TabIndex = 4;
            this.profile.Text = "Profile";
            this.profile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // general
            // 
            this.general.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.general.Dock = System.Windows.Forms.DockStyle.Top;
            this.general.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.general.ForeColor = System.Drawing.Color.White;
            this.general.Location = new System.Drawing.Point(0, 0);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(106, 33);
            this.general.TabIndex = 3;
            this.general.Text = "General";
            this.general.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generalPref
            // 
            this.generalPref.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.generalPref.Controls.Add(this.fontChange);
            this.generalPref.Controls.Add(this.currentFont);
            this.generalPref.Controls.Add(this.font);
            this.generalPref.Dock = System.Windows.Forms.DockStyle.Left;
            this.generalPref.Location = new System.Drawing.Point(0, 0);
            this.generalPref.Name = "generalPref";
            this.generalPref.Size = new System.Drawing.Size(556, 431);
            this.generalPref.TabIndex = 1;
            this.generalPref.Tag = "prefPanel";
            // 
            // fontChange
            // 
            this.fontChange.AutoSize = true;
            this.fontChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fontChange.ForeColor = System.Drawing.Color.White;
            this.fontChange.Location = new System.Drawing.Point(58, 12);
            this.fontChange.Name = "fontChange";
            this.fontChange.Size = new System.Drawing.Size(63, 25);
            this.fontChange.TabIndex = 2;
            this.fontChange.Text = "Change";
            this.fontChange.UseVisualStyleBackColor = true;
            this.fontChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentFont
            // 
            this.currentFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentFont.ForeColor = System.Drawing.Color.White;
            this.currentFont.Location = new System.Drawing.Point(0, 34);
            this.currentFont.Name = "currentFont";
            this.currentFont.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.currentFont.Size = new System.Drawing.Size(556, 33);
            this.currentFont.TabIndex = 1;
            this.currentFont.Text = "Microsoft Sans Serif, Regular 12pt";
            // 
            // font
            // 
            this.font.Dock = System.Windows.Forms.DockStyle.Top;
            this.font.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.font.ForeColor = System.Drawing.Color.White;
            this.font.Location = new System.Drawing.Point(0, 0);
            this.font.Name = "font";
            this.font.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.font.Size = new System.Drawing.Size(556, 34);
            this.font.TabIndex = 0;
            this.font.Text = "Font";
            // 
            // profilePref
            // 
            this.profilePref.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.profilePref.Controls.Add(this.profilePlaceholder);
            this.profilePref.Dock = System.Windows.Forms.DockStyle.Left;
            this.profilePref.Location = new System.Drawing.Point(1112, 0);
            this.profilePref.Name = "profilePref";
            this.profilePref.Size = new System.Drawing.Size(556, 431);
            this.profilePref.TabIndex = 3;
            this.profilePref.Tag = "prefPanel";
            // 
            // profilePlaceholder
            // 
            this.profilePlaceholder.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePlaceholder.ForeColor = System.Drawing.Color.White;
            this.profilePlaceholder.Location = new System.Drawing.Point(0, 0);
            this.profilePlaceholder.Name = "profilePlaceholder";
            this.profilePlaceholder.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.profilePlaceholder.Size = new System.Drawing.Size(556, 34);
            this.profilePlaceholder.TabIndex = 3;
            this.profilePlaceholder.Text = "Profile Preferences";
            // 
            // othersPref
            // 
            this.othersPref.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.othersPref.Controls.Add(this.otherPlaceholder);
            this.othersPref.Dock = System.Windows.Forms.DockStyle.Left;
            this.othersPref.Location = new System.Drawing.Point(556, 0);
            this.othersPref.Name = "othersPref";
            this.othersPref.Size = new System.Drawing.Size(556, 431);
            this.othersPref.TabIndex = 4;
            this.othersPref.Tag = "prefPanel";
            // 
            // otherPlaceholder
            // 
            this.otherPlaceholder.Dock = System.Windows.Forms.DockStyle.Top;
            this.otherPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherPlaceholder.ForeColor = System.Drawing.Color.White;
            this.otherPlaceholder.Location = new System.Drawing.Point(0, 0);
            this.otherPlaceholder.Name = "otherPlaceholder";
            this.otherPlaceholder.Padding = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.otherPlaceholder.Size = new System.Drawing.Size(556, 34);
            this.otherPlaceholder.TabIndex = 4;
            this.otherPlaceholder.Text = "Other Preferences";
            // 
            // pref
            // 
            this.pref.Controls.Add(this.profilePref);
            this.pref.Controls.Add(this.othersPref);
            this.pref.Controls.Add(this.generalPref);
            this.pref.Dock = System.Windows.Forms.DockStyle.Left;
            this.pref.Location = new System.Drawing.Point(108, 0);
            this.pref.Name = "pref";
            this.pref.Size = new System.Drawing.Size(553, 431);
            this.pref.TabIndex = 5;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 431);
            this.Controls.Add(this.pref);
            this.Controls.Add(this.headings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.headings.ResumeLayout(false);
            this.generalPref.ResumeLayout(false);
            this.generalPref.PerformLayout();
            this.profilePref.ResumeLayout(false);
            this.othersPref.ResumeLayout(false);
            this.pref.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headings;
        private System.Windows.Forms.Panel generalPref;
        private System.Windows.Forms.Label font;
        private System.Windows.Forms.Label others;
        private System.Windows.Forms.Label profile;
        private System.Windows.Forms.Label general;
        private System.Windows.Forms.Button fontChange;
        private System.Windows.Forms.Label currentFont;
        private System.Windows.Forms.Panel profilePref;
        private System.Windows.Forms.Panel othersPref;
        private System.Windows.Forms.Panel pref;
        private System.Windows.Forms.Label profilePlaceholder;
        private System.Windows.Forms.Label otherPlaceholder;
    }
}