namespace WinFormsApp1
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            EmpNameTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            EmpSal = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            EmpGenCb = new ComboBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            EmployeeList = new Guna.UI2.WinForms.Guna2DataGridView();
            EmpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label2 = new Label();
            EmpJoinDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            AddBtn = new Button();
            UpdateBtn = new Button();
            label8 = new Label();
            EmpDepTb = new ComboBox();
            DeleteBtn = new Button();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 100);
            panel1.TabIndex = 0;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Teal;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 698);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1264, 29);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            EmpNameTb.Location = new Point(71, 203);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(260, 35);
            EmpNameTb.TabIndex = 7;
            EmpNameTb.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(71, 170);
            label3.Name = "label3";
            label3.Size = new Size(172, 30);
            label3.TabIndex = 6;
            label3.Text = "Employee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(71, 250);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 10;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(71, 330);
            label5.Name = "label5";
            label5.Size = new Size(131, 30);
            label5.TabIndex = 12;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(71, 494);
            label6.Name = "label6";
            label6.Size = new Size(143, 30);
            label6.TabIndex = 14;
            label6.Text = "Date Of Birth";
            label6.Click += label6_Click;
            // 
            // EmpSal
            // 
            EmpSal.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            EmpSal.Location = new Point(71, 617);
            EmpSal.Name = "EmpSal";
            EmpSal.Size = new Size(260, 35);
            EmpSal.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(71, 584);
            label7.Name = "label7";
            label7.Size = new Size(73, 30);
            label7.TabIndex = 16;
            label7.Text = "Salary";
            label7.Click += label7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // EmpGenCb
            // 
            EmpGenCb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpGenCb.FormattingEnabled = true;
            EmpGenCb.Items.AddRange(new object[] { "Male", "Female", "Others" });
            EmpGenCb.Location = new Point(71, 283);
            EmpGenCb.Name = "EmpGenCb";
            EmpGenCb.Size = new Size(260, 33);
            EmpGenCb.TabIndex = 19;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(630, 272);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(240, 150);
            guna2DataGridView1.TabIndex = 20;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // EmployeeList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            EmployeeList.ColumnHeadersHeight = 4;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            EmployeeList.DefaultCellStyle = dataGridViewCellStyle6;
            EmployeeList.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeList.Location = new Point(413, 226);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowHeadersVisible = false;
            EmployeeList.Size = new Size(839, 361);
            EmployeeList.TabIndex = 21;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmployeeList.ThemeStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            EmployeeList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeeList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            EmployeeList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmployeeList.ThemeStyle.HeaderStyle.Height = 4;
            EmployeeList.ThemeStyle.ReadOnly = false;
            EmployeeList.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeeList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            EmployeeList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmployeeList.ThemeStyle.RowsStyle.Height = 25;
            EmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // EmpDOB
            // 
            EmpDOB.Checked = true;
            EmpDOB.CustomizableEdges = customizableEdges1;
            EmpDOB.FillColor = Color.Teal;
            EmpDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpDOB.Format = DateTimePickerFormat.Long;
            EmpDOB.Location = new Point(71, 527);
            EmpDOB.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            EmpDOB.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            EmpDOB.Name = "EmpDOB";
            EmpDOB.ShadowDecoration.CustomizableEdges = customizableEdges2;
            EmpDOB.Size = new Size(260, 40);
            EmpDOB.TabIndex = 22;
            EmpDOB.Value = new DateTime(2024, 9, 5, 15, 58, 37, 872);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(71, 411);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 23;
            label2.Text = "Join Date";
            // 
            // EmpJoinDate
            // 
            EmpJoinDate.Checked = true;
            EmpJoinDate.CustomizableEdges = customizableEdges3;
            EmpJoinDate.FillColor = Color.Teal;
            EmpJoinDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpJoinDate.Format = DateTimePickerFormat.Long;
            EmpJoinDate.Location = new Point(71, 444);
            EmpJoinDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            EmpJoinDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            EmpJoinDate.Name = "EmpJoinDate";
            EmpJoinDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EmpJoinDate.Size = new Size(260, 36);
            EmpJoinDate.TabIndex = 24;
            EmpJoinDate.Value = new DateTime(2024, 9, 5, 15, 58, 37, 872);
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.Transparent;
            AddBtn.Location = new Point(71, 658);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(111, 34);
            AddBtn.TabIndex = 25;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Teal;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Transparent;
            UpdateBtn.Location = new Point(220, 658);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(111, 34);
            UpdateBtn.TabIndex = 26;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(524, 103);
            label8.Name = "label8";
            label8.Size = new Size(266, 37);
            label8.TabIndex = 27;
            label8.Text = "Manage Employees";
            // 
            // EmpDepTb
            // 
            EmpDepTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpDepTb.FormattingEnabled = true;
            EmpDepTb.Items.AddRange(new object[] { "Cloud", "AI", "WEB DEV(JAVA)", "WEB DEV(C#)", "Testing", "HR", "General Staff", "Accountant", "HelpDesk " });
            EmpDepTb.Location = new Point(71, 363);
            EmpDepTb.Name = "EmpDepTb";
            EmpDepTb.Size = new Size(260, 33);
            EmpDepTb.TabIndex = 28;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.Transparent;
            DeleteBtn.Location = new Point(773, 617);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(111, 34);
            DeleteBtn.TabIndex = 29;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(1068, 110);
            label9.Name = "label9";
            label9.Size = new Size(59, 30);
            label9.TabIndex = 53;
            label9.Text = "Back";
            label9.Click += label9_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1018, 110);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 54;
            pictureBox5.TabStop = false;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 727);
            Controls.Add(pictureBox5);
            Controls.Add(label9);
            Controls.Add(DeleteBtn);
            Controls.Add(EmpDepTb);
            Controls.Add(label8);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(EmpJoinDate);
            Controls.Add(label2);
            Controls.Add(EmpDOB);
            Controls.Add(EmployeeList);
            Controls.Add(guna2DataGridView1);
            Controls.Add(EmpGenCb);
            Controls.Add(pictureBox1);
            Controls.Add(EmpSal);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(EmpNameTb);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Employees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox EmpNameTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox EmpSal;
        private Label label7;
        private PictureBox pictureBox1;
        private ComboBox EmpGenCb;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeList;
        private Guna.UI2.WinForms.Guna2DateTimePicker EmpDOB;
        private Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker EmpJoinDate;
        private Button AddBtn;
        private Button UpdateBtn;
        private Label label8;
        private ComboBox EmpDepTb;
        private Button DeleteBtn;
        private Label label9;
        private PictureBox pictureBox5;
    }
}