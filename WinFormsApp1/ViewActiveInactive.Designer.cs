namespace WinFormsApp1
{
    partial class ViewActiveInactive
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            AE_dashboard = new Label();
            IE_dashboard = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.active_employee1;
            pictureBox1.Location = new Point(15, 41);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.inactive_employee1;
            pictureBox2.Location = new Point(15, 171);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 125);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 2;
            label1.Text = "Active Employees";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 255);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 3;
            label2.Text = "Inactive Employees";
            // 
            // AE_dashboard
            // 
            AE_dashboard.AutoSize = true;
            AE_dashboard.ForeColor = Color.White;
            AE_dashboard.Location = new Point(158, 125);
            AE_dashboard.Name = "AE_dashboard";
            AE_dashboard.Size = new Size(17, 20);
            AE_dashboard.TabIndex = 4;
            AE_dashboard.Text = "0";
            // 
            // IE_dashboard
            // 
            IE_dashboard.AutoSize = true;
            IE_dashboard.ForeColor = Color.White;
            IE_dashboard.Location = new Point(158, 255);
            IE_dashboard.Name = "IE_dashboard";
            IE_dashboard.Size = new Size(17, 20);
            IE_dashboard.TabIndex = 5;
            IE_dashboard.Text = "0";
            // 
            // ViewActiveInactive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(85, 72, 135);
            Controls.Add(IE_dashboard);
            Controls.Add(AE_dashboard);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewActiveInactive";
            Size = new Size(205, 312);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label AE_dashboard;
        private Label IE_dashboard;
    }
}
