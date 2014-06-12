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
            this.gb_Game = new System.Windows.Forms.GroupBox();
            this.btn_Spin = new System.Windows.Forms.Button();
            this.btn_Fire = new System.Windows.Forms.Button();
            this.tb_GameChat = new System.Windows.Forms.TextBox();
            this.btn_SendMessage = new System.Windows.Forms.Button();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // gb_Game
            // 
            this.gb_Game.Location = new System.Drawing.Point(10, 41);
            this.gb_Game.Name = "gb_Game";
            this.gb_Game.Size = new System.Drawing.Size(580, 311);
            this.gb_Game.TabIndex = 0;
            this.gb_Game.TabStop = false;
            this.gb_Game.Text = "Game ";
            // 
            // btn_Spin
            // 
            this.btn_Spin.Location = new System.Drawing.Point(12, 12);
            this.btn_Spin.Name = "btn_Spin";
            this.btn_Spin.Size = new System.Drawing.Size(75, 23);
            this.btn_Spin.TabIndex = 1;
            this.btn_Spin.Text = "Spin";
            this.btn_Spin.UseVisualStyleBackColor = true;
            this.btn_Spin.Click += new System.EventHandler(this.btn_Spin_Click);
            // 
            // btn_Fire
            // 
            this.btn_Fire.Location = new System.Drawing.Point(517, 12);
            this.btn_Fire.Name = "btn_Fire";
            this.btn_Fire.Size = new System.Drawing.Size(75, 23);
            this.btn_Fire.TabIndex = 4;
            this.btn_Fire.Text = "Fire";
            this.btn_Fire.UseVisualStyleBackColor = true;
            this.btn_Fire.Click += new System.EventHandler(this.btn_Fire_Click);
            // 
            // tb_GameChat
            // 
            this.tb_GameChat.Location = new System.Drawing.Point(12, 487);
            this.tb_GameChat.Name = "tb_GameChat";
            this.tb_GameChat.Size = new System.Drawing.Size(459, 20);
            this.tb_GameChat.TabIndex = 5;
            // 
            // btn_SendMessage
            // 
            this.btn_SendMessage.Location = new System.Drawing.Point(477, 358);
            this.btn_SendMessage.Name = "btn_SendMessage";
            this.btn_SendMessage.Size = new System.Drawing.Size(115, 149);
            this.btn_SendMessage.TabIndex = 7;
            this.btn_SendMessage.Text = "Send Message";
            this.btn_SendMessage.UseVisualStyleBackColor = true;
            this.btn_SendMessage.Click += new System.EventHandler(this.btn_SendMessage_Click);
            // 
            // ChatBox
            // 
            this.ChatBox.Location = new System.Drawing.Point(12, 358);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ReadOnly = true;
            this.ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatBox.Size = new System.Drawing.Size(459, 121);
            this.ChatBox.TabIndex = 8;
            this.ChatBox.Text = "";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 519);
            this.Controls.Add(this.ChatBox);
            this.Controls.Add(this.btn_SendMessage);
            this.Controls.Add(this.tb_GameChat);
            this.Controls.Add(this.btn_Fire);
            this.Controls.Add(this.btn_Spin);
            this.Controls.Add(this.gb_Game);
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
    }
}