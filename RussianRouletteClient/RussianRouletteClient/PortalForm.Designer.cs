namespace RussianRouletteClient
{
    partial class PortalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortalForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.lb_usersOnline = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Top10ListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMinimizeForm = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonMaximizeForm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.81545F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.18454F));
            this.tableLayoutPanel1.Controls.Add(this.typeBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_SendMessage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_usersOnline, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.13924F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.86076F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 474);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // typeBox
            // 
            this.typeBox.AcceptsReturn = true;
            this.typeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.Location = new System.Drawing.Point(3, 435);
            this.typeBox.Multiline = true;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(685, 35);
            this.typeBox.TabIndex = 1;
            this.typeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typeBox_KeyDown);
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.BackColor = System.Drawing.Color.Transparent;
            this.btn_SendMessage.BackgroundImage = global::RussianRouletteClient.Properties.Resources.chat;
            this.btn_SendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SendMessage.FlatAppearance.BorderSize = 0;
            this.btn_SendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendMessage.Location = new System.Drawing.Point(695, 435);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(140, 35);
            this.btn_SendMessage.TabIndex = 2;
            this.btn_SendMessage.UseVisualStyleBackColor = false;
            this.btn_SendMessage.Click += new System.EventHandler(this.btn_SendMessage_Click);
            // 
            // lb_usersOnline
            // 
            this.lb_usersOnline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_usersOnline.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usersOnline.FormattingEnabled = true;
            this.lb_usersOnline.ItemHeight = 15;
            this.lb_usersOnline.Location = new System.Drawing.Point(695, 3);
            this.lb_usersOnline.Name = "lb_usersOnline";
            this.lb_usersOnline.Size = new System.Drawing.Size(169, 420);
            this.lb_usersOnline.TabIndex = 3;
            this.lb_usersOnline.Click += new System.EventHandler(this.lb_usersOnline_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 425);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Top10ListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChatBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChatBox
            // 
            this.ChatBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ChatBox.Location = new System.Drawing.Point(3, 3);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ReadOnly = true;
            this.ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatBox.Size = new System.Drawing.Size(668, 394);
            this.ChatBox.TabIndex = 0;
            this.ChatBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Top10ListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Top 10 Players";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Top10ListBox
            // 
            this.Top10ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Top10ListBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Top10ListBox.FormattingEnabled = true;
            this.Top10ListBox.ItemHeight = 14;
            this.Top10ListBox.Location = new System.Drawing.Point(6, 6);
            this.Top10ListBox.Name = "Top10ListBox";
            this.Top10ListBox.Size = new System.Drawing.Size(665, 378);
            this.Top10ListBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem1,
            this.signOutToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // profileToolStripMenuItem1
            // 
            this.profileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1});
            this.profileToolStripMenuItem1.Name = "profileToolStripMenuItem1";
            this.profileToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.profileToolStripMenuItem1.Text = "Profile";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // signOutToolStripMenuItem1
            // 
            this.signOutToolStripMenuItem1.Name = "signOutToolStripMenuItem1";
            this.signOutToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.signOutToolStripMenuItem1.Text = "Sign Out";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // buttonMinimizeForm
            // 
            this.buttonMinimizeForm.BackColor = System.Drawing.Color.White;
            this.buttonMinimizeForm.BackgroundImage = global::RussianRouletteClient.Properties.Resources.minimize;
            this.buttonMinimizeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimizeForm.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeForm.Location = new System.Drawing.Point(839, 0);
            this.buttonMinimizeForm.Name = "buttonMinimizeForm";
            this.buttonMinimizeForm.Size = new System.Drawing.Size(16, 16);
            this.buttonMinimizeForm.TabIndex = 13;
            this.buttonMinimizeForm.UseVisualStyleBackColor = false;
            this.buttonMinimizeForm.Click += new System.EventHandler(this.buttonMinimizeForm_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.White;
            this.buttonCloseForm.BackgroundImage = global::RussianRouletteClient.Properties.Resources.close;
            this.buttonCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Location = new System.Drawing.Point(883, 0);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(16, 16);
            this.buttonCloseForm.TabIndex = 14;
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonMaximizeForm
            // 
            this.buttonMaximizeForm.BackColor = System.Drawing.Color.White;
            this.buttonMaximizeForm.BackgroundImage = global::RussianRouletteClient.Properties.Resources.maximize;
            this.buttonMaximizeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMaximizeForm.FlatAppearance.BorderSize = 0;
            this.buttonMaximizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximizeForm.Location = new System.Drawing.Point(861, 0);
            this.buttonMaximizeForm.Name = "buttonMaximizeForm";
            this.buttonMaximizeForm.Size = new System.Drawing.Size(16, 16);
            this.buttonMaximizeForm.TabIndex = 12;
            this.buttonMaximizeForm.UseVisualStyleBackColor = false;
            this.buttonMaximizeForm.Click += new System.EventHandler(this.buttonMaximizeForm_Click);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRouletteClient.Properties.Resources.portal_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.buttonMinimizeForm);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonMaximizeForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PortalForm";
            this.Text = "PortalForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PortalForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button btn_SendMessage;
        private System.Windows.Forms.ListBox lb_usersOnline;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox ChatBox;
        private System.Windows.Forms.ListBox Top10ListBox;
        private System.Windows.Forms.Button buttonMinimizeForm;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonMaximizeForm;
    }
}