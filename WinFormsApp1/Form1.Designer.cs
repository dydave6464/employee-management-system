namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            register_link = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            exit = new Label();
            login_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            login_password = new TextBox();
            login_showPass = new CheckBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 72, 135);
            panel1.Controls.Add(register_link);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 400);
            panel1.TabIndex = 1;
            // 
            // register_link
            // 
            register_link.AutoSize = true;
            register_link.Cursor = Cursors.Hand;
            register_link.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            register_link.ForeColor = SystemColors.Highlight;
            register_link.Location = new Point(43, 310);
            register_link.Name = "register_link";
            register_link.Size = new Size(122, 15);
            register_link.TabIndex = 2;
            register_link.Text = "Register your account";
            register_link.Click += register_link_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(174, 15);
            label4.TabIndex = 1;
            label4.Text = "Employee Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee;
            pictureBox1.Location = new Point(53, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ControlText;
            exit.Location = new Point(474, 9);
            exit.Name = "exit";
            exit.Size = new Size(15, 15);
            exit.TabIndex = 2;
            exit.Text = "X";
            exit.Click += exit_Click_1;
            // 
            // login_username
            // 
            login_username.Location = new Point(220, 153);
            login_username.Name = "login_username";
            login_username.Size = new Size(218, 23);
            login_username.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 70);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 4;
            label1.Text = "Login Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(220, 130);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 193);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // login_password
            // 
            login_password.Location = new Point(220, 214);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(218, 23);
            login_password.TabIndex = 6;
            login_password.TextChanged += textBox2_TextChanged;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(330, 243);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(108, 19);
            login_showPass.TabIndex = 8;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(67, 48, 138);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 72, 135);
            login_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 72, 135);
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.ForeColor = SystemColors.ControlLightLight;
            login_btn.Location = new Point(220, 279);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(96, 36);
            login_btn.TabIndex = 9;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 400);
            Controls.Add(login_btn);
            Controls.Add(login_showPass);
            Controls.Add(label3);
            Controls.Add(login_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(login_username);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label exit;
        private TextBox login_username;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox login_password;
        private CheckBox login_showPass;
        private Button login_btn;
        private Label label4;
        private PictureBox pictureBox1;
        private Label register_link;
    }
}
