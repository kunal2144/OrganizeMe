namespace OrganizeMe
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.head = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.note4 = new System.Windows.Forms.Label();
            this.note3 = new System.Windows.Forms.Label();
            this.note2 = new System.Windows.Forms.Label();
            this.note1 = new System.Windows.Forms.Label();
            this.editor = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.TextBox();
            this.body.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.editor.SuspendLayout();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Margin = new System.Windows.Forms.Padding(0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1000, 80);
            this.head.TabIndex = 0;
            this.head.Text = "OrganizeMe";
            this.head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.head.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // body
            // 
            this.body.Controls.Add(this.sidebar);
            this.body.Controls.Add(this.editor);
            this.body.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.body.Location = new System.Drawing.Point(0, 80);
            this.body.Margin = new System.Windows.Forms.Padding(0);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(1000, 520);
            this.body.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.sidebar.Controls.Add(this.note4);
            this.sidebar.Controls.Add(this.note3);
            this.sidebar.Controls.Add(this.note2);
            this.sidebar.Controls.Add(this.note1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 520);
            this.sidebar.TabIndex = 2;
            // 
            // note4
            // 
            this.note4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.note4.Dock = System.Windows.Forms.DockStyle.Top;
            this.note4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.note4.Location = new System.Drawing.Point(0, 138);
            this.note4.Name = "note4";
            this.note4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.note4.Size = new System.Drawing.Size(200, 46);
            this.note4.TabIndex = 7;
            this.note4.Text = "Note 4";
            this.note4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // note3
            // 
            this.note3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.note3.Dock = System.Windows.Forms.DockStyle.Top;
            this.note3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.note3.Location = new System.Drawing.Point(0, 92);
            this.note3.Name = "note3";
            this.note3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.note3.Size = new System.Drawing.Size(200, 46);
            this.note3.TabIndex = 6;
            this.note3.Text = "Note 3";
            this.note3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // note2
            // 
            this.note2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.note2.Dock = System.Windows.Forms.DockStyle.Top;
            this.note2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.note2.Location = new System.Drawing.Point(0, 46);
            this.note2.Name = "note2";
            this.note2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.note2.Size = new System.Drawing.Size(200, 46);
            this.note2.TabIndex = 5;
            this.note2.Text = "Note 2";
            this.note2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // note1
            // 
            this.note1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.note1.Dock = System.Windows.Forms.DockStyle.Top;
            this.note1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.note1.Location = new System.Drawing.Point(0, 0);
            this.note1.Name = "note1";
            this.note1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.note1.Size = new System.Drawing.Size(200, 46);
            this.note1.TabIndex = 4;
            this.note1.Text = "Note 1";
            this.note1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.editor.Controls.Add(this.content);
            this.editor.Dock = System.Windows.Forms.DockStyle.Right;
            this.editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.Location = new System.Drawing.Point(200, 0);
            this.editor.Margin = new System.Windows.Forms.Padding(0);
            this.editor.Name = "editor";
            this.editor.Padding = new System.Windows.Forms.Padding(20);
            this.editor.Size = new System.Drawing.Size(800, 520);
            this.editor.TabIndex = 1;
            // 
            // content
            // 
            this.content.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.content.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.content.Location = new System.Drawing.Point(20, 20);
            this.content.Margin = new System.Windows.Forms.Padding(0);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(760, 480);
            this.content.TabIndex = 0;
            this.content.Text = resources.GetString("content.Text");
            // 
            // main
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(55)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.head);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.Text = "Notes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.body.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.editor.ResumeLayout(false);
            this.editor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel editor;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label note1;
        private System.Windows.Forms.Label note4;
        private System.Windows.Forms.Label note3;
        private System.Windows.Forms.Label note2;
    }
}

