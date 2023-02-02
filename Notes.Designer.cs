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
            this.head = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.notesList = new System.Windows.Forms.Panel();
            this.note1 = new System.Windows.Forms.Label();
            this.noteButton = new System.Windows.Forms.Panel();
            this.newWorkNote = new System.Windows.Forms.Button();
            this.newPersonalNote = new System.Windows.Forms.Button();
            this.editor = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.searchNotes = new System.Windows.Forms.ComboBox();
            this.filter = new System.Windows.Forms.GroupBox();
            this.filter_personal = new System.Windows.Forms.RadioButton();
            this.filter_work = new System.Windows.Forms.RadioButton();
            this.body.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.notesList.SuspendLayout();
            this.noteButton.SuspendLayout();
            this.editor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.head.Dock = System.Windows.Forms.DockStyle.Left;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Margin = new System.Windows.Forms.Padding(0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(200, 80);
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
            this.notesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notesList.Location = new System.Drawing.Point(0, 62);
            this.notesList.Margin = new System.Windows.Forms.Padding(0);
            this.notesList.Name = "notesList";
            this.notesList.Size = new System.Drawing.Size(200, 458);
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
            this.noteButton.Controls.Add(this.newWorkNote);
            this.noteButton.Controls.Add(this.newPersonalNote);
            this.noteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.noteButton.Location = new System.Drawing.Point(0, 0);
            this.noteButton.Margin = new System.Windows.Forms.Padding(0);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(200, 62);
            this.noteButton.TabIndex = 5;
            // 
            // newWorkNote
            // 
            this.newWorkNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.newWorkNote.Dock = System.Windows.Forms.DockStyle.Left;
            this.newWorkNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWorkNote.ForeColor = System.Drawing.Color.White;
            this.newWorkNote.Location = new System.Drawing.Point(0, 0);
            this.newWorkNote.Margin = new System.Windows.Forms.Padding(0);
            this.newWorkNote.Name = "newWorkNote";
            this.newWorkNote.Size = new System.Drawing.Size(96, 62);
            this.newWorkNote.TabIndex = 2;
            this.newWorkNote.Text = "Work Note";
            this.newWorkNote.UseVisualStyleBackColor = false;
            this.newWorkNote.Click += new System.EventHandler(this.createNewNote_Click);
            // 
            // newPersonalNote
            // 
            this.newPersonalNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.newPersonalNote.Dock = System.Windows.Forms.DockStyle.Right;
            this.newPersonalNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPersonalNote.ForeColor = System.Drawing.Color.White;
            this.newPersonalNote.Location = new System.Drawing.Point(96, 0);
            this.newPersonalNote.Margin = new System.Windows.Forms.Padding(0);
            this.newPersonalNote.Name = "newPersonalNote";
            this.newPersonalNote.Size = new System.Drawing.Size(104, 62);
            this.newPersonalNote.TabIndex = 1;
            this.newPersonalNote.Text = "Personal Note\r\n";
            this.newPersonalNote.UseVisualStyleBackColor = false;
            this.newPersonalNote.Click += new System.EventHandler(this.createNewNote_Click);
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
            this.content.TabStop = false;
            this.content.Text = "Erase me and start noting!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchNotes);
            this.panel1.Controls.Add(this.filter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jump to a note";
            // 
            // searchNotes
            // 
            this.searchNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchNotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNotes.FormattingEnabled = true;
            this.searchNotes.Location = new System.Drawing.Point(245, 41);
            this.searchNotes.Name = "searchNotes";
            this.searchNotes.Size = new System.Drawing.Size(187, 24);
            this.searchNotes.TabIndex = 1;
            this.searchNotes.SelectedIndexChanged += new System.EventHandler(this.searchNotes_SelectedIndexChanged);
            // 
            // filter
            // 
            this.filter.Controls.Add(this.filter_personal);
            this.filter.Controls.Add(this.filter_work);
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.Color.White;
            this.filter.Location = new System.Drawing.Point(669, 2);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(122, 72);
            this.filter.TabIndex = 2;
            this.filter.TabStop = false;
            this.filter.Text = "Filter";
            // 
            // filter_personal
            // 
            this.filter_personal.AutoSize = true;
            this.filter_personal.Checked = true;
            this.filter_personal.Location = new System.Drawing.Point(6, 19);
            this.filter_personal.Name = "filter_personal";
            this.filter_personal.Size = new System.Drawing.Size(79, 20);
            this.filter_personal.TabIndex = 1;
            this.filter_personal.TabStop = true;
            this.filter_personal.Text = "Personal";
            this.filter_personal.UseVisualStyleBackColor = true;
            this.filter_personal.CheckedChanged += new System.EventHandler(this.filter_personal_CheckedChanged);
            // 
            // filter_work
            // 
            this.filter_work.AutoSize = true;
            this.filter_work.Location = new System.Drawing.Point(6, 40);
            this.filter_work.Name = "filter_work";
            this.filter_work.Size = new System.Drawing.Size(57, 20);
            this.filter_work.TabIndex = 2;
            this.filter_work.Text = "Work";
            this.filter_work.UseVisualStyleBackColor = true;
            // 
            // Notes
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(55)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.head);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Notes";
            this.Text = "Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notes_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.body.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.notesList.ResumeLayout(false);
            this.noteButton.ResumeLayout(false);
            this.editor.ResumeLayout(false);
            this.editor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
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
        private System.Windows.Forms.Button newPersonalNote;
        private System.Windows.Forms.Panel notesList;
        private System.Windows.Forms.Panel noteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox filter;
        private System.Windows.Forms.RadioButton filter_personal;
        private System.Windows.Forms.RadioButton filter_work;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox searchNotes;
        private System.Windows.Forms.Button newWorkNote;
    }
}

