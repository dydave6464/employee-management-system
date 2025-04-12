namespace WinFormsApp1
{
    partial class RegisterForm
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
            label1 = new Label();
            signup_btn = new Button();
            signup_showPass = new CheckBox();
            label3 = new Label();
            signup_password = new TextBox();
            label2 = new Label();
            signup_username = new TextBox();
            exit = new Label();
            signup_loginlink = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 52);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Register Account";
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(67, 48, 138);
            signup_btn.Cursor = Cursors.Hand;
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 72, 135);
            signup_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 48, 138);
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.ForeColor = SystemColors.ControlLightLight;
            signup_btn.Location = new Point(37, 247);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(96, 36);
            signup_btn.TabIndex = 15;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showPass.ForeColor = Color.White;
            signup_showPass.Location = new Point(147, 211);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(108, 19);
            signup_showPass.TabIndex = 14;
            signup_showPass.Text = "Show Password";
            signup_showPass.UseVisualStyleBackColor = true;
            signup_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(37, 161);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // signup_password
            // 
            signup_password.Location = new Point(37, 182);
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(218, 23);
            signup_password.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(37, 98);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            // 
            // signup_username
            // 
            signup_username.Location = new Point(37, 121);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(218, 23);
            signup_username.TabIndex = 10;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.Black;
            exit.Location = new Point(474, 9);
            exit.Name = "exit";
            exit.Size = new Size(15, 15);
            exit.TabIndex = 16;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // signup_loginlink
            // 
            signup_loginlink.AutoSize = true;
            signup_loginlink.Cursor = Cursors.Hand;
            signup_loginlink.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            signup_loginlink.ForeColor = SystemColors.Highlight;
            signup_loginlink.Location = new Point(37, 300);
            signup_loginlink.Name = "signup_loginlink";
            signup_loginlink.Size = new Size(115, 15);
            signup_loginlink.TabIndex = 18;
            signup_loginlink.Text = "Log In Your Account";
            signup_loginlink.Click += signup_loginlink_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 72, 135);
            ClientSize = new Size(501, 400);
            Controls.Add(signup_loginlink);
            Controls.Add(exit);
            Controls.Add(signup_btn);
            Controls.Add(signup_showPass);
            Controls.Add(label3);
            Controls.Add(signup_password);
            Controls.Add(label2);
            Controls.Add(signup_username);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button signup_btn;
        private CheckBox signup_showPass;
        private Label label3;
        private TextBox signup_password;
        private Label label2;
        private TextBox signup_username;
        private Label exit;
        private Label signup_loginlink;
    }
}