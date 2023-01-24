namespace OrganizeMe
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.head = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.notesList = new System.Windows.Forms.Panel();
            this.note1 = new System.Windows.Forms.Label();
            this.noteButton = new System.Windows.Forms.Panel();
            this.createNewNote = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.Panel();
            this.content1 = new System.Windows.Forms.TextBox();
            this.body.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.notesList.SuspendLayout();
            this.noteButton.SuspendLayout();
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
            this.sidebar.Controls.Add(this.notesList);
            this.sidebar.Controls.Add(this.noteButton);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 520);
            this.sidebar.TabIndex = 2;
            // 
            // notesList
            // 
            this.notesList.Controls.Add(this.note1);
            this.notesList.Dock = System.Windows.Forms.DockStyle.Top;
            this.notesList.Location = new System.Drawing.Point(0, 46);
            this.notesList.Margin = new System.Windows.Forms.Padding(0);
            this.notesList.Name = "notesList";
            this.notesList.Size = new System.Drawing.Size(200, 474);
            this.notesList.TabIndex = 6;
            // 
            // note1
            // 
            this.note1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
            this.note1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.note1.Dock = System.Windows.Forms.DockStyle.Top;
            this.note1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.note1.Location = new System.Drawing.Point(0, 0);
            this.note1.Margin = new System.Windows.Forms.Padding(0);
            this.note1.Name = "note1";
            this.note1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.note1.Size = new System.Drawing.Size(200, 46);
            this.note1.TabIndex = 4;
            this.note1.Text = "Note 1";
            this.note1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.note1.Click += new System.EventHandler(this.loadNote);
            // 
            // noteButton
            // 
            this.noteButton.Controls.Add(this.createNewNote);
            this.noteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.noteButton.Location = new System.Drawing.Point(0, 0);
            this.noteButton.Margin = new System.Windows.Forms.Padding(0);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(200, 46);
            this.noteButton.TabIndex = 5;
            // 
            // createNewNote
            // 
            this.createNewNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.createNewNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.createNewNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.createNewNote.ForeColor = System.Drawing.Color.White;
            this.createNewNote.Location = new System.Drawing.Point(0, 0);
            this.createNewNote.Margin = new System.Windows.Forms.Padding(0);
            this.createNewNote.Name = "createNewNote";
            this.createNewNote.Size = new System.Drawing.Size(200, 46);
            this.createNewNote.TabIndex = 1;
            this.createNewNote.Text = "New Note";
            this.createNewNote.UseVisualStyleBackColor = false;
            this.createNewNote.Click += new System.EventHandler(this.createNewNote_Click);
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.editor.Controls.Add(this.content1);
            this.editor.Dock = System.Windows.Forms.DockStyle.Right;
            this.editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.Location = new System.Drawing.Point(200, 0);
            this.editor.Margin = new System.Windows.Forms.Padding(0);
            this.editor.Name = "editor";
            this.editor.Padding = new System.Windows.Forms.Padding(20);
            this.editor.Size = new System.Drawing.Size(800, 520);
            this.editor.TabIndex = 1;
            // 
            // content1
            // 
            this.content1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.content1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.content1.Location = new System.Drawing.Point(20, 20);
            this.content1.Margin = new System.Windows.Forms.Padding(0);
            this.content1.Multiline = true;
            this.content1.Name = "content1";
            this.content1.Size = new System.Drawing.Size(760, 480);
            this.content1.TabIndex = 0;
            this.content1.TabStop = false;
            this.content1.Text = resources.GetString("content1.Text");
            // 
            // main
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(55)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.head);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.body.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.notesList.ResumeLayout(false);
            this.noteButton.ResumeLayout(false);
            this.editor.ResumeLayout(false);
            this.editor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel editor;
        private System.Windows.Forms.TextBox content1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label note1;
        private System.Windows.Forms.Button createNewNote;
        private System.Windows.Forms.Panel notesList;
        private System.Windows.Forms.Panel noteButton;
    }
}

