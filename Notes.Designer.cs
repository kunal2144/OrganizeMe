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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.head = new System.Windows.Forms.Label();
            this.body = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.noteButton = new System.Windows.Forms.Panel();
            this.newWorkNote = new System.Windows.Forms.Button();
            this.newPersonalNote = new System.Windows.Forms.Button();
            this.notesList = new System.Windows.Forms.Panel();
            this.note1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.info = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.editor = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.TextBox();
            this.noteContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteNote = new System.Windows.Forms.ToolStripMenuItem();
            this.exportNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.thisNote = new System.Windows.Forms.ToolStripMenuItem();
            this.allPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.allWorkNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.allNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.header = new System.Windows.Forms.Panel();
            this.searchNotesLabel = new System.Windows.Forms.Label();
            this.searchNotes = new System.Windows.Forms.ComboBox();
            this.filter = new System.Windows.Forms.GroupBox();
            this.filter_personal = new System.Windows.Forms.RadioButton();
            this.filter_work = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyContent = new System.Windows.Forms.TextBox();
            this.body.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.noteButton.SuspendLayout();
            this.notesList.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.editor.SuspendLayout();
            this.noteContextMenu.SuspendLayout();
            this.header.SuspendLayout();
            this.filter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // 
            // body
            // 
            this.body.Controls.Add(this.sidebar);
            this.body.Controls.Add(this.editor);
            this.body.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.body.Location = new System.Drawing.Point(0, 104);
            this.body.Margin = new System.Windows.Forms.Padding(0);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(1000, 496);
            this.body.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.sidebar.Controls.Add(this.noteButton);
            this.sidebar.Controls.Add(this.notesList);
            this.sidebar.Controls.Add(this.statusStrip1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 496);
            this.sidebar.TabIndex = 2;
            // 
            // noteButton
            // 
            this.noteButton.Controls.Add(this.newWorkNote);
            this.noteButton.Controls.Add(this.newPersonalNote);
            this.noteButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.noteButton.Location = new System.Drawing.Point(0, 0);
            this.noteButton.Margin = new System.Windows.Forms.Padding(0);
            this.noteButton.Name = "noteButton";
            this.noteButton.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.noteButton.Size = new System.Drawing.Size(200, 62);
            this.noteButton.TabIndex = 5;
            // 
            // newWorkNote
            // 
            this.newWorkNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.newWorkNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newWorkNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWorkNote.ForeColor = System.Drawing.Color.White;
            this.newWorkNote.Location = new System.Drawing.Point(0, 0);
            this.newWorkNote.Margin = new System.Windows.Forms.Padding(0);
            this.newWorkNote.Name = "newWorkNote";
            this.newWorkNote.Size = new System.Drawing.Size(100, 62);
            this.newWorkNote.TabIndex = 2;
            this.newWorkNote.TabStop = false;
            this.newWorkNote.Text = "Work Note";
            this.newWorkNote.UseVisualStyleBackColor = false;
            this.newWorkNote.Click += new System.EventHandler(this.createNewNote_Click);
            this.newWorkNote.MouseEnter += new System.EventHandler(this.newWorkNote_MouseEnter);
            this.newWorkNote.MouseLeave += new System.EventHandler(this.newWorkNote_MouseExit);
            // 
            // newPersonalNote
            // 
            this.newPersonalNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.newPersonalNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPersonalNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPersonalNote.ForeColor = System.Drawing.Color.White;
            this.newPersonalNote.Location = new System.Drawing.Point(100, 0);
            this.newPersonalNote.Margin = new System.Windows.Forms.Padding(0);
            this.newPersonalNote.Name = "newPersonalNote";
            this.newPersonalNote.Size = new System.Drawing.Size(100, 62);
            this.newPersonalNote.TabIndex = 1;
            this.newPersonalNote.TabStop = false;
            this.newPersonalNote.Text = "Personal Note\r\n";
            this.newPersonalNote.UseVisualStyleBackColor = false;
            this.newPersonalNote.Click += new System.EventHandler(this.createNewNote_Click);
            this.newPersonalNote.MouseEnter += new System.EventHandler(this.newPersonalNote_MouseEnter);
            this.newPersonalNote.MouseLeave += new System.EventHandler(this.newPersonalNote_MouseExit);
            // 
            // notesList
            // 
            this.notesList.AutoScroll = true;
            this.notesList.Controls.Add(this.note1);
            this.notesList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notesList.Location = new System.Drawing.Point(0, 62);
            this.notesList.Margin = new System.Windows.Forms.Padding(0);
            this.notesList.Name = "notesList";
            this.notesList.Size = new System.Drawing.Size(200, 412);
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
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info,
            this.infoProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(200, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 17);
            // 
            // infoProgress
            // 
            this.infoProgress.Name = "infoProgress";
            this.infoProgress.Size = new System.Drawing.Size(180, 16);
            this.infoProgress.Visible = false;
            // 
            // editor
            // 
            this.editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.editor.Controls.Add(this.emptyContent);
            this.editor.Controls.Add(this.content);
            this.editor.Dock = System.Windows.Forms.DockStyle.Right;
            this.editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor.Location = new System.Drawing.Point(200, 0);
            this.editor.Margin = new System.Windows.Forms.Padding(0);
            this.editor.Name = "editor";
            this.editor.Padding = new System.Windows.Forms.Padding(20);
            this.editor.Size = new System.Drawing.Size(800, 496);
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
            this.content.Size = new System.Drawing.Size(760, 456);
            this.content.TabIndex = 0;
            this.content.TabStop = false;
            this.content.Text = "Erase me and start noting!";
            // 
            // noteContextMenu
            // 
            this.noteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteNote,
            this.exportNotes});
            this.noteContextMenu.Name = "notesListContextMenu";
            this.noteContextMenu.Size = new System.Drawing.Size(137, 48);
            // 
            // deleteNote
            // 
            this.deleteNote.Name = "deleteNote";
            this.deleteNote.Size = new System.Drawing.Size(136, 22);
            this.deleteNote.Text = "Delete Note";
            this.deleteNote.Click += new System.EventHandler(this.deleteNote_Click);
            // 
            // exportNotes
            // 
            this.exportNotes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisNote,
            this.allPersonal,
            this.allWorkNotes,
            this.allNotes});
            this.exportNotes.Name = "exportNotes";
            this.exportNotes.Size = new System.Drawing.Size(136, 22);
            this.exportNotes.Text = "Export";
            // 
            // thisNote
            // 
            this.thisNote.Name = "thisNote";
            this.thisNote.Size = new System.Drawing.Size(168, 22);
            this.thisNote.Text = "This note";
            // 
            // allPersonal
            // 
            this.allPersonal.Name = "allPersonal";
            this.allPersonal.Size = new System.Drawing.Size(168, 22);
            this.allPersonal.Text = "All personal notes";
            // 
            // allWorkNotes
            // 
            this.allWorkNotes.Name = "allWorkNotes";
            this.allWorkNotes.Size = new System.Drawing.Size(168, 22);
            this.allWorkNotes.Text = "All work notes";
            // 
            // allNotes
            // 
            this.allNotes.Name = "allNotes";
            this.allNotes.Size = new System.Drawing.Size(168, 22);
            this.allNotes.Text = "All notes";
            this.allNotes.Click += new System.EventHandler(this.allNotes_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(20)))), ((int)(((byte)(41)))));
            this.header.Controls.Add(this.head);
            this.header.Controls.Add(this.searchNotesLabel);
            this.header.Controls.Add(this.searchNotes);
            this.header.Controls.Add(this.filter);
            this.header.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.header.Location = new System.Drawing.Point(0, 24);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1000, 80);
            this.header.TabIndex = 2;
            // 
            // searchNotesLabel
            // 
            this.searchNotesLabel.AutoSize = true;
            this.searchNotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNotesLabel.ForeColor = System.Drawing.Color.White;
            this.searchNotesLabel.Location = new System.Drawing.Point(469, 18);
            this.searchNotesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.searchNotesLabel.Name = "searchNotesLabel";
            this.searchNotesLabel.Size = new System.Drawing.Size(115, 20);
            this.searchNotesLabel.TabIndex = 3;
            this.searchNotesLabel.Text = "Jump to a note";
            // 
            // searchNotes
            // 
            this.searchNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchNotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.searchNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNotes.FormattingEnabled = true;
            this.searchNotes.Location = new System.Drawing.Point(434, 42);
            this.searchNotes.Name = "searchNotes";
            this.searchNotes.Size = new System.Drawing.Size(187, 24);
            this.searchNotes.TabIndex = 1;
            this.searchNotes.SelectedIndexChanged += new System.EventHandler(this.searchNotes_SelectedIndexChanged);
            this.searchNotes.MouseEnter += new System.EventHandler(this.searchNotes_MouseEnter);
            this.searchNotes.MouseLeave += new System.EventHandler(this.searchNotes_MouseExit);
            // 
            // filter
            // 
            this.filter.Controls.Add(this.filter_personal);
            this.filter.Controls.Add(this.filter_work);
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.Color.White;
            this.filter.Location = new System.Drawing.Point(872, 1);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(122, 72);
            this.filter.TabIndex = 2;
            this.filter.TabStop = false;
            this.filter.Text = "Filter";
            // 
            // filter_personal
            // 
            this.filter_personal.AutoSize = true;
            this.filter_personal.Location = new System.Drawing.Point(6, 19);
            this.filter_personal.Name = "filter_personal";
            this.filter_personal.Size = new System.Drawing.Size(79, 20);
            this.filter_personal.TabIndex = 1;
            this.filter_personal.Text = "Personal";
            this.filter_personal.UseVisualStyleBackColor = true;
            this.filter_personal.CheckedChanged += new System.EventHandler(this.filter_personal_CheckedChanged);
            this.filter_personal.MouseEnter += new System.EventHandler(this.filter_MouseEnter);
            this.filter_personal.MouseLeave += new System.EventHandler(this.searchNotes_MouseExit);
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
            this.filter_work.MouseEnter += new System.EventHandler(this.filter_MouseEnter);
            this.filter_work.MouseLeave += new System.EventHandler(this.filter_MouseExit);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.taskToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem});
            this.taskToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.taskToolStripMenuItem.Text = "Task";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newTaskToolStripMenuItem.Text = "New Task";
            this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.newTaskToolStripMenuItem_Click);
            // 
            // emptyContent
            // 
            this.emptyContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.emptyContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emptyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emptyContent.Enabled = false;
            this.emptyContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emptyContent.Location = new System.Drawing.Point(20, 20);
            this.emptyContent.Margin = new System.Windows.Forms.Padding(0);
            this.emptyContent.Multiline = true;
            this.emptyContent.Name = "emptyContent";
            this.emptyContent.Size = new System.Drawing.Size(760, 456);
            this.emptyContent.TabIndex = 1;
            this.emptyContent.TabStop = false;
            this.emptyContent.Visible = false;
            // 
            // Notes
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(55)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Notes";
            this.Text = "Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notes_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.body.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.noteButton.ResumeLayout(false);
            this.notesList.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.editor.ResumeLayout(false);
            this.editor.PerformLayout();
            this.noteContextMenu.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Panel editor;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Label note1;
        private System.Windows.Forms.Button newPersonalNote;
        private System.Windows.Forms.Panel notesList;
        private System.Windows.Forms.Panel noteButton;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.GroupBox filter;
        private System.Windows.Forms.RadioButton filter_personal;
        private System.Windows.Forms.RadioButton filter_work;
        private System.Windows.Forms.Label searchNotesLabel;
        private System.Windows.Forms.ComboBox searchNotes;
        private System.Windows.Forms.Button newWorkNote;
        private System.Windows.Forms.ContextMenuStrip noteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exportNotes;
        private System.Windows.Forms.ToolStripMenuItem deleteNote;
        private System.Windows.Forms.ToolStripMenuItem thisNote;
        private System.Windows.Forms.ToolStripMenuItem allPersonal;
        private System.Windows.Forms.ToolStripMenuItem allWorkNotes;
        private System.Windows.Forms.ToolStripMenuItem allNotes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel info;
        private System.Windows.Forms.ToolStripProgressBar infoProgress;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.TextBox emptyContent;
    }
}

