namespace WinFormsApp1
{
    partial class DashBoardForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            exit = new Label();
            label1 = new Label();
            label2 = new Label();
            logout_pic = new PictureBox();
            panel2 = new Panel();
            status_cb = new ComboBox();
            position_cb = new ComboBox();
            label9 = new Label();
            clear_btn = new Button();
            employee_picture = new PictureBox();
            import_btn = new Button();
            delete_btn = new Button();
            update_btn = new Button();
            add_btn = new Button();
            panel4 = new Panel();
            viewActiveInactive1 = new ViewActiveInactive();
            active_inactive_btn = new Button();
            salary_tb = new TextBox();
            label8 = new Label();
            label7 = new Label();
            contact_tb = new TextBox();
            label6 = new Label();
            gender_cb = new ComboBox();
            label5 = new Label();
            fullname_tb = new TextBox();
            label4 = new Label();
            emp_tb = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logout_pic).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employee_picture).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 72, 135);
            panel1.Controls.Add(exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 28);
            panel1.TabIndex = 0;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(1237, 3);
            exit.Name = "exit";
            exit.Size = new Size(19, 20);
            exit.TabIndex = 2;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 23);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1183, 763);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Sign Out";
            // 
            // logout_pic
            // 
            logout_pic.Cursor = Cursors.Hand;
            logout_pic.Image = Properties.Resources.log_out;
            logout_pic.Location = new Point(1162, 763);
            logout_pic.Margin = new Padding(3, 4, 3, 4);
            logout_pic.Name = "logout_pic";
            logout_pic.Size = new Size(27, 20);
            logout_pic.SizeMode = PictureBoxSizeMode.Zoom;
            logout_pic.TabIndex = 2;
            logout_pic.TabStop = false;
            logout_pic.Click += logout_pic_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(status_cb);
            panel2.Controls.Add(position_cb);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(clear_btn);
            panel2.Controls.Add(employee_picture);
            panel2.Controls.Add(import_btn);
            panel2.Controls.Add(delete_btn);
            panel2.Controls.Add(update_btn);
            panel2.Controls.Add(add_btn);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(active_inactive_btn);
            panel2.Controls.Add(salary_tb);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(contact_tb);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(gender_cb);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(fullname_tb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(emp_tb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(logout_pic);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 28);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1257, 789);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // status_cb
            // 
            status_cb.FormattingEnabled = true;
            status_cb.Items.AddRange(new object[] { "Active", "Inactive" });
            status_cb.Location = new Point(629, 101);
            status_cb.Name = "status_cb";
            status_cb.Size = new Size(241, 28);
            status_cb.TabIndex = 28;
            // 
            // position_cb
            // 
            position_cb.FormattingEnabled = true;
            position_cb.Items.AddRange(new object[] { "Software Developer", "Web Developer", "Mobile Application Developer", "Data Analyst", "Database Administrator", "Network Engineer", "DevOps Engineer", "Cybersecurity", "IT Manager" });
            position_cb.Location = new Point(629, 44);
            position_cb.Name = "position_cb";
            position_cb.Size = new Size(241, 28);
            position_cb.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(466, 101);
            label9.Name = "label9";
            label9.Size = new Size(65, 23);
            label9.TabIndex = 25;
            label9.Text = "Status :";
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.FromArgb(85, 72, 135);
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.FlatAppearance.BorderSize = 0;
            clear_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(67, 48, 138);
            clear_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 48, 138);
            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_btn.ForeColor = Color.White;
            clear_btn.Location = new Point(784, 169);
            clear_btn.Margin = new Padding(3, 4, 3, 4);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(86, 31);
            clear_btn.TabIndex = 24;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // employee_picture
            // 
            employee_picture.Location = new Point(1104, 60);
            employee_picture.Margin = new Padding(3, 4, 3, 4);
            employee_picture.Name = "employee_picture";
            employee_picture.Size = new Size(122, 119);
            employee_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            employee_picture.TabIndex = 23;
            employee_picture.TabStop = false;
            // 
            // import_btn
            // 
            import_btn.Cursor = Cursors.Hand;
            import_btn.Location = new Point(1104, 184);
            import_btn.Margin = new Padding(3, 4, 3, 4);
            import_btn.Name = "import_btn";
            import_btn.Size = new Size(122, 31);
            import_btn.TabIndex = 22;
            import_btn.Text = "Import";
            import_btn.UseVisualStyleBackColor = true;
            import_btn.Click += import_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.FromArgb(85, 72, 135);
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(67, 48, 138);
            delete_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 48, 138);
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(679, 169);
            delete_btn.Margin = new Padding(3, 4, 3, 4);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(86, 31);
            delete_btn.TabIndex = 21;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.FromArgb(85, 72, 135);
            update_btn.Cursor = Cursors.Hand;
            update_btn.FlatAppearance.BorderSize = 0;
            update_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(67, 48, 138);
            update_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 48, 138);
            update_btn.FlatStyle = FlatStyle.Flat;
            update_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(574, 169);
            update_btn.Margin = new Padding(3, 4, 3, 4);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(86, 31);
            update_btn.TabIndex = 20;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(85, 72, 135);
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(67, 48, 138);
            add_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 48, 138);
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(470, 169);
            add_btn.Margin = new Padding(3, 4, 3, 4);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(86, 31);
            add_btn.TabIndex = 19;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(viewActiveInactive1);
            panel4.Location = new Point(893, 80);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 312);
            panel4.TabIndex = 18;
            // 
            // viewActiveInactive1
            // 
            viewActiveInactive1.BackColor = Color.FromArgb(85, 72, 135);
            viewActiveInactive1.Location = new Point(0, -5);
            viewActiveInactive1.Margin = new Padding(3, 5, 3, 5);
            viewActiveInactive1.Name = "viewActiveInactive1";
            viewActiveInactive1.Size = new Size(205, 312);
            viewActiveInactive1.TabIndex = 0;
            // 
            // active_inactive_btn
            // 
            active_inactive_btn.BackColor = Color.FromArgb(85, 72, 135);
            active_inactive_btn.Cursor = Cursors.Hand;
            active_inactive_btn.FlatAppearance.BorderSize = 0;
            active_inactive_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(67, 48, 138);
            active_inactive_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(67, 48, 138);
            active_inactive_btn.FlatStyle = FlatStyle.Flat;
            active_inactive_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            active_inactive_btn.ForeColor = Color.White;
            active_inactive_btn.Location = new Point(893, 44);
            active_inactive_btn.Margin = new Padding(3, 4, 3, 4);
            active_inactive_btn.Name = "active_inactive_btn";
            active_inactive_btn.Size = new Size(205, 33);
            active_inactive_btn.TabIndex = 17;
            active_inactive_btn.Text = "Active/Inactive Employees";
            active_inactive_btn.UseVisualStyleBackColor = false;
            active_inactive_btn.Click += active_inactive_btn_Click;
            // 
            // salary_tb
            // 
            salary_tb.Location = new Point(193, 292);
            salary_tb.Margin = new Padding(3, 4, 3, 4);
            salary_tb.Name = "salary_tb";
            salary_tb.Size = new Size(244, 27);
            salary_tb.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(466, 48);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 14;
            label8.Text = "Position :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 293);
            label7.Name = "label7";
            label7.Size = new Size(69, 23);
            label7.TabIndex = 13;
            label7.Text = "Salary : ";
            // 
            // contact_tb
            // 
            contact_tb.Location = new Point(193, 231);
            contact_tb.Margin = new Padding(3, 4, 3, 4);
            contact_tb.Name = "contact_tb";
            contact_tb.Size = new Size(244, 27);
            contact_tb.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 232);
            label6.Name = "label6";
            label6.Size = new Size(147, 23);
            label6.TabIndex = 11;
            label6.Text = "Contact Number :";
            // 
            // gender_cb
            // 
            gender_cb.FormattingEnabled = true;
            gender_cb.Items.AddRange(new object[] { "Male", "Female", "Others" });
            gender_cb.Location = new Point(193, 169);
            gender_cb.Margin = new Padding(3, 4, 3, 4);
            gender_cb.Name = "gender_cb";
            gender_cb.Size = new Size(244, 28);
            gender_cb.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 171);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 9;
            label5.Text = "Gender : ";
            // 
            // fullname_tb
            // 
            fullname_tb.Location = new Point(193, 108);
            fullname_tb.Margin = new Padding(3, 4, 3, 4);
            fullname_tb.Name = "fullname_tb";
            fullname_tb.Size = new Size(244, 27);
            fullname_tb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 108);
            label4.Name = "label4";
            label4.Size = new Size(141, 23);
            label4.TabIndex = 7;
            label4.Text = "Full Name          :";
            // 
            // emp_tb
            // 
            emp_tb.Location = new Point(193, 44);
            emp_tb.Margin = new Padding(3, 4, 3, 4);
            emp_tb.Name = "emp_tb";
            emp_tb.Size = new Size(244, 27);
            emp_tb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 48);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 5;
            label3.Text = "EmployeeID       :";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(14, 445);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1230, 309);
            panel3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(85, 72, 135);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1195, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // DashBoardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 817);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoardForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logout_pic).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employee_picture).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox logout_pic;
        private Label label2;
        private Label exit;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox emp_tb;
        private Label label4;
        private ComboBox gender_cb;
        private Label label5;
        private TextBox fullname_tb;
        private Label label6;
        private Label label7;
        private TextBox contact_tb;
        private TextBox salary_tb;
        private Label label8;
        private Button active_inactive_btn;
        private Panel panel4;
        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button import_btn;
        private PictureBox employee_picture;
        private ViewActiveInactive viewActiveInactive1;
        private Button clear_btn;
        private Label label9;
        private ComboBox status_cb;
        private ComboBox position_cb;
    }
}