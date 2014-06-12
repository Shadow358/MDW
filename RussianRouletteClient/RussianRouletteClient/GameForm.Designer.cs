namespace RussianRouletteClient
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gb_Game = new System.Windows.Forms.GroupBox();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Fire = new System.Windows.Forms.Button();
            this.tb_GameChat = new System.Windows.Forms.TextBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.buttonMinimizeForm = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonMaximizeForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gb_Game
            // 
            this.gb_Game.BackColor = System.Drawing.Color.Transparent;
            this.gb_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Game.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Game.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gb_Game.Location = new System.Drawing.Point(10, 41);
            this.gb_Game.Name = "gb_Game";
            this.gb_Game.Size = new System.Drawing.Size(580, 311);
            this.gb_Game.TabIndex = 0;
            this.gb_Game.TabStop = false;
            this.gb_Game.Text = "Game ";
            // 
            // btn_Spin
            // 
            this.btn_Spin.BackColor = System.Drawing.Color.Transparent;
            this.btn_Spin.BackgroundImage = global::RussianRouletteClient.Properties.Resources.spin;
            this.btn_Spin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Spin.FlatAppearance.BorderSize = 0;
            this.btn_Spin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spin.Location = new System.Drawing.Point(240, 2);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(35, 42);
            this.btn_Spin.TabIndex = 1;
            this.btn_Spin.UseVisualStyleBackColor = false;
            this.btn_Spin.Click += new System.EventHandler(this.btn_Spin_Click);
            // 
            // btn_Fire
            // 
            this.btn_Fire.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fire.BackgroundImage = global::RussianRouletteClient.Properties.Resources.fire;
            this.btn_Fire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fire.FlatAppearance.BorderSize = 0;
            this.btn_Fire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fire.Location = new System.Drawing.Point(290, 2);
            this.btn_Fire.Name = "btn_Fire";
            this.btn_Fire.Size = new System.Drawing.Size(32, 42);
            this.btn_Fire.TabIndex = 4;
            this.btn_Fire.UseVisualStyleBackColor = false;
            this.btn_Fire.Click += new System.EventHandler(this.btn_Fire_Click);
            // 
            // tb_GameChat
            // 
            this.tb_GameChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_GameChat.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GameChat.Location = new System.Drawing.Point(12, 487);
            this.tb_GameChat.Multiline = true;
            this.tb_GameChat.Name = "tb_GameChat";
            this.tb_GameChat.Size = new System.Drawing.Size(459, 20);
            this.tb_GameChat.TabIndex = 5;
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.BackColor = System.Drawing.Color.Transparent;
            this.btn_SendMessage.BackgroundImage = global::RussianRouletteClient.Properties.Resources.game_chat;
            this.btn_SendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SendMessage.FlatAppearance.BorderSize = 0;
            this.btn_SendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendMessage.Location = new System.Drawing.Point(477, 358);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(110, 150);
            this.btn_SendMessage.TabIndex = 7;
            this.btn_SendMessage.UseVisualStyleBackColor = false;
            this.btn_SendMessage.Click += new System.EventHandler(this.btn_SendMessage_Click);
            // 
            // ChatBox
            // 
            this.ChatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatBox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ChatBox.Location = new System.Drawing.Point(12, 358);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ReadOnly = true;
            this.ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatBox.Size = new System.Drawing.Size(459, 121);
            this.ChatBox.TabIndex = 8;
            this.ChatBox.Text = "";
            // 
            // buttonMinimizeForm
            // 
            this.buttonMinimizeForm.BackColor = System.Drawing.Color.White;
            this.buttonMinimizeForm.BackgroundImage = global::RussianRouletteClient.Properties.Resources.minimize;
            this.buttonMinimizeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimizeForm.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeForm.Location = new System.Drawing.Point(540, 2);
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
            this.buttonCloseForm.Location = new System.Drawing.Point(584, 2);
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
            this.buttonMaximizeForm.Location = new System.Drawing.Point(562, 2);
            this.buttonMaximizeForm.Name = "buttonMaximizeForm";
            this.buttonMaximizeForm.Size = new System.Drawing.Size(16, 16);
            this.buttonMaximizeForm.TabIndex = 12;
            this.buttonMaximizeForm.UseVisualStyleBackColor = false;
            this.buttonMaximizeForm.Click += new System.EventHandler(this.buttonMaximizeForm_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRouletteClient.Properties.Resources.game_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 519);
            this.Controls.Add(this.buttonMinimizeForm);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonMaximizeForm);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.tb_GameChat);
            this.Controls.Add(this.btn_Fire);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.gb_Game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Spin;
        private System.Windows.Forms.Button btn_Fire;
        private System.Windows.Forms.TextBox tb_GameChat;
        private System.Windows.Forms.Button btn_SendMessage;
        protected System.Windows.Forms.GroupBox gb_Game;
        private System.Windows.Forms.RichTextBox ChatBox;
        private System.Windows.Forms.Button buttonMinimizeForm;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonMaximizeForm;
    }
}