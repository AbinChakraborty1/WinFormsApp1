namespace WinFormsApp1
{
    partial class Salary
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            UpdateBtn = new Button();
            AddBtn = new Button();
            PeriodTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            EmpCb = new ComboBox();
            pictureBox1 = new PictureBox();
            AmountTb = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            DaysTb = new TextBox();
            label2 = new Label();
            label8 = new Label();
            LogOutLbl = new Label();
            label5 = new Label();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            SalaryLbl = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            SalaryList = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryLbl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Teal;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Transparent;
            UpdateBtn.Location = new Point(222, 526);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(111, 34);
            UpdateBtn.TabIndex = 43;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.Transparent;
            AddBtn.Location = new Point(73, 526);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(111, 34);
            AddBtn.TabIndex = 42;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // PeriodTb
            // 
            PeriodTb.Checked = true;
            PeriodTb.CustomizableEdges = customizableEdges1;
            PeriodTb.FillColor = Color.Teal;
            PeriodTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PeriodTb.Format = DateTimePickerFormat.Long;
            PeriodTb.Location = new Point(73, 374);
            PeriodTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            PeriodTb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            PeriodTb.Name = "PeriodTb";
            PeriodTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PeriodTb.Size = new Size(260, 36);
            PeriodTb.TabIndex = 41;
            PeriodTb.Value = new DateTime(2024, 9, 5, 15, 58, 37, 872);
            PeriodTb.ValueChanged += guna2DateTimePicker2_ValueChanged;
            // 
            // EmpCb
            // 
            EmpCb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpCb.FormattingEnabled = true;
            EmpCb.Items.AddRange(new object[] { "Male", "Female", "Others" });
            EmpCb.Location = new Point(73, 208);
            EmpCb.Name = "EmpCb";
            EmpCb.Size = new Size(260, 33);
            EmpCb.TabIndex = 38;
            EmpCb.SelectedIndexChanged += EmpCb_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.Teal;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.Enabled = false;
            AmountTb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            AmountTb.ForeColor = SystemColors.Window;
            AmountTb.Location = new Point(73, 462);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(260, 28);
            AmountTb.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(73, 429);
            label7.Name = "label7";
            label7.Size = new Size(160, 30);
            label7.TabIndex = 35;
            label7.Text = "Salary Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(73, 255);
            label4.Name = "label4";
            label4.Size = new Size(157, 30);
            label4.TabIndex = 32;
            label4.Text = "Days Attended";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(73, 175);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 30;
            label3.Text = "Employee ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 100);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(365, 28);
            label1.Name = "label1";
            label1.Size = new Size(553, 45);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // DaysTb
            // 
            DaysTb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            DaysTb.Location = new Point(73, 288);
            DaysTb.Name = "DaysTb";
            DaysTb.Size = new Size(260, 35);
            DaysTb.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(73, 341);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 40;
            label2.Text = "Period";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(637, 208);
            label8.Name = "label8";
            label8.Size = new Size(227, 37);
            label8.TabIndex = 44;
            label8.Text = "Manage Salaries";
            label8.Click += label8_Click;
            // 
            // LogOutLbl
            // 
            LogOutLbl.AutoSize = true;
            LogOutLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LogOutLbl.ForeColor = Color.Teal;
            LogOutLbl.Location = new Point(1005, 140);
            LogOutLbl.Name = "LogOutLbl";
            LogOutLbl.Size = new Size(59, 30);
            LogOutLbl.TabIndex = 60;
            LogOutLbl.Text = "Back";
            LogOutLbl.Click += LogOutLbl_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(876, 140);
            label5.Name = "label5";
            label5.Size = new Size(73, 30);
            label5.TabIndex = 59;
            label5.Text = "Salary";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(509, 142);
            label9.Name = "label9";
            label9.Size = new Size(117, 30);
            label9.TabIndex = 58;
            label9.Text = "Employees";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(955, 140);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 57;
            pictureBox5.TabStop = false;
            // 
            // SalaryLbl
            // 
            SalaryLbl.BackColor = Color.Transparent;
            SalaryLbl.Image = (Image)resources.GetObject("SalaryLbl.Image");
            SalaryLbl.Location = new Point(826, 137);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(44, 34);
            SalaryLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            SalaryLbl.TabIndex = 56;
            SalaryLbl.TabStop = false;
            SalaryLbl.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(637, 137);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 55;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(457, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(689, 142);
            label10.Name = "label10";
            label10.Size = new Size(131, 30);
            label10.TabIndex = 53;
            label10.Text = "Department";
            // 
            // SalaryList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            SalaryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SalaryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SalaryList.ColumnHeadersHeight = 4;
            SalaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SalaryList.DefaultCellStyle = dataGridViewCellStyle3;
            SalaryList.GridColor = Color.FromArgb(231, 229, 255);
            SalaryList.Location = new Point(457, 255);
            SalaryList.Name = "SalaryList";
            SalaryList.RowHeadersVisible = false;
            SalaryList.Size = new Size(632, 305);
            SalaryList.TabIndex = 61;
            SalaryList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.AlternatingRowsStyle.Font = null;
            SalaryList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SalaryList.ThemeStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            SalaryList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SalaryList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            SalaryList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SalaryList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SalaryList.ThemeStyle.HeaderStyle.Height = 4;
            SalaryList.ThemeStyle.ReadOnly = false;
            SalaryList.ThemeStyle.RowsStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SalaryList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            SalaryList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SalaryList.ThemeStyle.RowsStyle.Height = 25;
            SalaryList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 727);
            Controls.Add(SalaryList);
            Controls.Add(LogOutLbl);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(SalaryLbl);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(PeriodTb);
            Controls.Add(label2);
            Controls.Add(EmpCb);
            Controls.Add(pictureBox1);
            Controls.Add(AmountTb);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(DaysTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "salary";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryLbl).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button UpdateBtn;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker PeriodTb;
        private ComboBox EmpCb;
        private PictureBox pictureBox1;
        private TextBox AmountTb;
        private Label label7;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private TextBox DaysTb;
        private Label label2;
        private Label label8;
        private Label LogOutLbl;
        private Label label5;
        private Label label9;
        private PictureBox pictureBox5;
        private PictureBox SalaryLbl;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView SalaryList;
    }
}