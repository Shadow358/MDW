namespace RussianRouletteClient
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.gb_SignIn = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.buttonMinimizeForm = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.buttonMaximizeForm = new System.Windows.Forms.Button();
            this.gb_SignUp = new System.Windows.Forms.GroupBox();
            this.tb_RegNickname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_RegLastname = new System.Windows.Forms.TextBox();
            this.lbl_RegLastname = new System.Windows.Forms.Label();
            this.tb_RegFirstname = new System.Windows.Forms.TextBox();
            this.lbl_RegFirstname = new System.Windows.Forms.Label();
            this.lbl_RegRepeatPassword = new System.Windows.Forms.Label();
            this.tb_RegRepeatPassword = new System.Windows.Forms.TextBox();
            this.btn_RegClose = new System.Windows.Forms.Button();
            this.lbl_RegPassword = new System.Windows.Forms.Label();
            this.btn_RegSignUp = new System.Windows.Forms.Button();
            this.tb_RegEmail = new System.Windows.Forms.TextBox();
            this.tb_RegPassword = new System.Windows.Forms.TextBox();
            this.lbl_RegEmail = new System.Windows.Forms.Label();
            this.gb_SignIn.SuspendLayout();
            this.gb_SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Email
            // 
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Email.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(102, 27);
            this.tb_Email.Multiline = true;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(138, 25);
            this.tb_Email.TabIndex = 0;
            // 
            // tb_Password
            // 
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(102, 55);
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(138, 25);
            this.tb_Password.TabIndex = 1;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(57, 33);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(45, 19);
            this.lbl_Email.TabIndex = 2;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(30, 61);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(72, 19);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.Transparent;
            this.btn_SignIn.BackgroundImage = global::RussianRouletteClient.Properties.Resources.signin;
            this.btn_SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SignIn.FlatAppearance.BorderSize = 0;
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btn_SignIn.Location = new System.Drawing.Point(138, 80);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(90, 35);
            this.btn_SignIn.TabIndex = 4;
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackgroundImage = global::RussianRouletteClient.Properties.Resources.signup;
            this.btn_SignUp.FlatAppearance.BorderSize = 0;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btn_SignUp.Location = new System.Drawing.Point(26, 80);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(90, 35);
            this.btn_SignUp.TabIndex = 5;
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // gb_SignIn
            // 
            this.gb_SignIn.BackColor = System.Drawing.Color.Transparent;
            this.gb_SignIn.Controls.Add(this.btn_connect);
            this.gb_SignIn.Controls.Add(this.lbl_Password);
            this.gb_SignIn.Controls.Add(this.btn_SignUp);
            this.gb_SignIn.Controls.Add(this.tb_Email);
            this.gb_SignIn.Controls.Add(this.btn_SignIn);
            this.gb_SignIn.Controls.Add(this.tb_Password);
            this.gb_SignIn.Controls.Add(this.lbl_Email);
            this.gb_SignIn.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SignIn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gb_SignIn.Location = new System.Drawing.Point(10, 12);
            this.gb_SignIn.Name = "gb_SignIn";
            this.gb_SignIn.Size = new System.Drawing.Size(282, 121);
            this.gb_SignIn.TabIndex = 6;
            this.gb_SignIn.TabStop = false;
            this.gb_SignIn.Text = "Sign In";
            // 
            // btn_connect
            // 
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Location = new System.Drawing.Point(6, 19);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(21, 23);
            this.btn_connect.TabIndex = 8;
            this.btn_connect.Text = "c";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // buttonMinimizeForm
            // 
            this.buttonMinimizeForm.BackColor = System.Drawing.Color.White;
            this.buttonMinimizeForm.BackgroundImage = global::RussianRouletteClient.Properties.Resources.minimize;
            this.buttonMinimizeForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimizeForm.FlatAppearance.BorderSize = 0;
            this.buttonMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimizeForm.Location = new System.Drawing.Point(232, 2);
            this.buttonMinimizeForm.Name = "buttonMinimizeForm";
            this.buttonMinimizeForm.Size = new System.Drawing.Size(16, 16);
            this.buttonMinimizeForm.TabIndex = 10;
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
            this.buttonCloseForm.Location = new System.Drawing.Point(276, 2);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(16, 16);
            this.buttonCloseForm.TabIndex = 11;
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
            this.buttonMaximizeForm.Location = new System.Drawing.Point(254, 2);
            this.buttonMaximizeForm.Name = "buttonMaximizeForm";
            this.buttonMaximizeForm.Size = new System.Drawing.Size(16, 16);
            this.buttonMaximizeForm.TabIndex = 9;
            this.buttonMaximizeForm.UseVisualStyleBackColor = false;
            this.buttonMaximizeForm.Click += new System.EventHandler(this.buttonMaximizeForm_Click);
            // 
            // gb_SignUp
            // 
            this.gb_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.gb_SignUp.Controls.Add(this.tb_RegNickname);
            this.gb_SignUp.Controls.Add(this.label1);
            this.gb_SignUp.Controls.Add(this.tb_RegLastname);
            this.gb_SignUp.Controls.Add(this.lbl_RegLastname);
            this.gb_SignUp.Controls.Add(this.tb_RegFirstname);
            this.gb_SignUp.Controls.Add(this.lbl_RegFirstname);
            this.gb_SignUp.Controls.Add(this.lbl_RegRepeatPassword);
            this.gb_SignUp.Controls.Add(this.tb_RegRepeatPassword);
            this.gb_SignUp.Controls.Add(this.btn_RegClose);
            this.gb_SignUp.Controls.Add(this.lbl_RegPassword);
            this.gb_SignUp.Controls.Add(this.btn_RegSignUp);
            this.gb_SignUp.Controls.Add(this.tb_RegEmail);
            this.gb_SignUp.Controls.Add(this.tb_RegPassword);
            this.gb_SignUp.Controls.Add(this.lbl_RegEmail);
            this.gb_SignUp.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_SignUp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gb_SignUp.Location = new System.Drawing.Point(12, 139);
            this.gb_SignUp.Name = "gb_SignUp";
            this.gb_SignUp.Size = new System.Drawing.Size(282, 282);
            this.gb_SignUp.TabIndex = 7;
            this.gb_SignUp.TabStop = false;
            this.gb_SignUp.Text = "Sign Up";
            // 
            // tb_RegNickname
            // 
            this.tb_RegNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RegNickname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RegNickname.Location = new System.Drawing.Point(102, 104);
            this.tb_RegNickname.Multiline = true;
            this.tb_RegNickname.Name = "tb_RegNickname";
            this.tb_RegNickname.Size = new System.Drawing.Size(138, 20);
            this.tb_RegNickname.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nick name:";
            // 
            // tb_RegLastname
            // 
            this.tb_RegLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RegLastname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RegLastname.Location = new System.Drawing.Point(102, 78);
            this.tb_RegLastname.Multiline = true;
            this.tb_RegLastname.Name = "tb_RegLastname";
            this.tb_RegLastname.Size = new System.Drawing.Size(138, 20);
            this.tb_RegLastname.TabIndex = 11;
            // 
            // lbl_RegLastname
            // 
            this.lbl_RegLastname.AutoSize = true;
            this.lbl_RegLastname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RegLastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegLastname.Location = new System.Drawing.Point(26, 79);
            this.lbl_RegLastname.Name = "lbl_RegLastname";
            this.lbl_RegLastname.Size = new System.Drawing.Size(74, 19);
            this.lbl_RegLastname.TabIndex = 12;
            this.lbl_RegLastname.Text = "Last name:";
            // 
            // tb_RegFirstname
            // 
            this.tb_RegFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RegFirstname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RegFirstname.Location = new System.Drawing.Point(102, 52);
            this.tb_RegFirstname.Multiline = true;
            this.tb_RegFirstname.Name = "tb_RegFirstname";
            this.tb_RegFirstname.Size = new System.Drawing.Size(138, 20);
            this.tb_RegFirstname.TabIndex = 9;
            // 
            // lbl_RegFirstname
            // 
            this.lbl_RegFirstname.AutoSize = true;
            this.lbl_RegFirstname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RegFirstname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegFirstname.Location = new System.Drawing.Point(25, 53);
            this.lbl_RegFirstname.Name = "lbl_RegFirstname";
            this.lbl_RegFirstname.Size = new System.Drawing.Size(75, 19);
            this.lbl_RegFirstname.TabIndex = 10;
            this.lbl_RegFirstname.Text = "First name:";
            // 
            // lbl_RegRepeatPassword
            // 
            this.lbl_RegRepeatPassword.AutoSize = true;
            this.lbl_RegRepeatPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RegRepeatPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegRepeatPassword.Location = new System.Drawing.Point(31, 155);
            this.lbl_RegRepeatPassword.Name = "lbl_RegRepeatPassword";
            this.lbl_RegRepeatPassword.Size = new System.Drawing.Size(69, 32);
            this.lbl_RegRepeatPassword.TabIndex = 8;
            this.lbl_RegRepeatPassword.Text = "Repeat\r\nPassword:";
            // 
            // tb_RegRepeatPassword
            // 
            this.tb_RegRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RegRepeatPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RegRepeatPassword.Location = new System.Drawing.Point(102, 167);
            this.tb_RegRepeatPassword.Multiline = true;
            this.tb_RegRepeatPassword.Name = "tb_RegRepeatPassword";
            this.tb_RegRepeatPassword.Size = new System.Drawing.Size(138, 20);
            this.tb_RegRepeatPassword.TabIndex = 7;
            this.tb_RegRepeatPassword.UseSystemPasswordChar = true;
            // 
            // btn_RegClose
            // 
            this.btn_RegClose.BackgroundImage = global::RussianRouletteClient.Properties.Resources.no;
            this.btn_RegClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RegClose.FlatAppearance.BorderSize = 0;
            this.btn_RegClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegClose.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btn_RegClose.Location = new System.Drawing.Point(24, 232);
            this.btn_RegClose.Name = "btn_RegClose";
            this.btn_RegClose.Size = new System.Drawing.Size(90, 35);
            this.btn_RegClose.TabIndex = 6;
            this.btn_RegClose.UseVisualStyleBackColor = true;
            this.btn_RegClose.Click += new System.EventHandler(this.btn_RegClose_Click);
            // 
            // lbl_RegPassword
            // 
            this.lbl_RegPassword.AutoSize = true;
            this.lbl_RegPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RegPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegPassword.Location = new System.Drawing.Point(31, 134);
            this.lbl_RegPassword.Name = "lbl_RegPassword";
            this.lbl_RegPassword.Size = new System.Drawing.Size(69, 16);
            this.lbl_RegPassword.TabIndex = 3;
            this.lbl_RegPassword.Text = "Password:";
            // 
            // btn_RegSignUp
            // 
            this.btn_RegSignUp.BackgroundImage = global::RussianRouletteClient.Properties.Resources.yes;
            this.btn_RegSignUp.FlatAppearance.BorderSize = 0;
            this.btn_RegSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegSignUp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btn_RegSignUp.Location = new System.Drawing.Point(136, 232);
            this.btn_RegSignUp.Name = "btn_RegSignUp";
            this.btn_RegSignUp.Size = new System.Drawing.Size(90, 35);
            this.btn_RegSignUp.TabIndex = 5;
            this.btn_RegSignUp.UseVisualStyleBackColor = true;
            this.btn_RegSignUp.Click += new System.EventHandler(this.btn_RegSignUp_Click);
            // 
            // tb_RegEmail
            // 
            this.tb_RegEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RegEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RegEmail.Location = new System.Drawing.Point(102, 23);
            this.tb_RegEmail.Multiline = true;
            this.tb_RegEmail.Name = "tb_RegEmail";
            this.tb_RegEmail.Size = new System.Drawing.Size(138, 20);
            this.tb_RegEmail.TabIndex = 0;
            // 
            // tb_RegPassword
            // 
            this.tb_RegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_RegPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RegPassword.Location = new System.Drawing.Point(102, 130);
            this.tb_RegPassword.Multiline = true;
            this.tb_RegPassword.Name = "tb_RegPassword";
            this.tb_RegPassword.Size = new System.Drawing.Size(138, 20);
            this.tb_RegPassword.TabIndex = 1;
            this.tb_RegPassword.UseSystemPasswordChar = true;
            // 
            // lbl_RegEmail
            // 
            this.lbl_RegEmail.AutoSize = true;
            this.lbl_RegEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_RegEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegEmail.Location = new System.Drawing.Point(55, 24);
            this.lbl_RegEmail.Name = "lbl_RegEmail";
            this.lbl_RegEmail.Size = new System.Drawing.Size(45, 19);
            this.lbl_RegEmail.TabIndex = 2;
            this.lbl_RegEmail.Text = "Email:";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRouletteClient.Properties.Resources.signin_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 139);
            this.Controls.Add(this.buttonMinimizeForm);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonMaximizeForm);
            this.Controls.Add(this.gb_SignUp);
            this.Controls.Add(this.gb_SignIn);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "Russian Roulette";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.gb_SignIn.ResumeLayout(false);
            this.gb_SignIn.PerformLayout();
            this.gb_SignUp.ResumeLayout(false);
            this.gb_SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.GroupBox gb_SignIn;
        private System.Windows.Forms.GroupBox gb_SignUp;
        private System.Windows.Forms.Label lbl_RegPassword;
        private System.Windows.Forms.Button btn_RegSignUp;
        private System.Windows.Forms.TextBox tb_RegEmail;
        private System.Windows.Forms.TextBox tb_RegPassword;
        private System.Windows.Forms.Label lbl_RegEmail;
        private System.Windows.Forms.Button btn_RegClose;
        private System.Windows.Forms.Label lbl_RegRepeatPassword;
        private System.Windows.Forms.TextBox tb_RegRepeatPassword;
        private System.Windows.Forms.TextBox tb_RegNickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_RegLastname;
        private System.Windows.Forms.Label lbl_RegLastname;
        private System.Windows.Forms.TextBox tb_RegFirstname;
        private System.Windows.Forms.Label lbl_RegFirstname;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.Button buttonMinimizeForm;
        private System.Windows.Forms.Button buttonMaximizeForm;
    }
}

