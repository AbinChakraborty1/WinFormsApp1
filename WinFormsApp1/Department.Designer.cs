namespace WinFormsApp1
{
    partial class Departments
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            UpdateBtn = new Button();
            AddBtn = new Button();
            DepList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            DepNameTb = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            EmpLbl = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Teal;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = Color.Transparent;
            UpdateBtn.Location = new Point(220, 302);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(111, 34);
            UpdateBtn.TabIndex = 43;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.Transparent;
            AddBtn.Location = new Point(71, 302);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(111, 34);
            AddBtn.TabIndex = 42;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += button1_Click;
            // 
            // DepList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DepList.BackgroundColor = Color.Teal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DepList.ColumnHeadersHeight = 25;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DepList.DefaultCellStyle = dataGridViewCellStyle3;
            DepList.GridColor = Color.FromArgb(231, 229, 255);
            DepList.Location = new Point(410, 302);
            DepList.Name = "DepList";
            DepList.RowHeadersVisible = false;
            DepList.Size = new Size(769, 341);
            DepList.TabIndex = 38;
            DepList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DepList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DepList.ThemeStyle.BackColor = Color.Teal;
            DepList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DepList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DepList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DepList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DepList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DepList.ThemeStyle.HeaderStyle.Height = 25;
            DepList.ThemeStyle.ReadOnly = false;
            DepList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DepList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DepList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DepList.ThemeStyle.RowsStyle.Height = 25;
            DepList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DepList.CellContentClick += DepList_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // DepNameTb
            // 
            DepNameTb.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            DepNameTb.Location = new Point(71, 242);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(260, 35);
            DepNameTb.TabIndex = 29;
            DepNameTb.TextChanged += DepNameTb_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(71, 209);
            label3.Name = "label3";
            label3.Size = new Size(195, 30);
            label3.TabIndex = 28;
            label3.Text = "Department Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 100);
            panel1.TabIndex = 27;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(517, 181);
            label8.Name = "label8";
            label8.Size = new Size(297, 37);
            label8.TabIndex = 44;
            label8.Text = "Manage Departments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(629, 123);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 45;
            label2.Text = "Department";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(397, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(577, 118);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(766, 118);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(895, 121);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 49;
            pictureBox5.TabStop = false;
            // 
            // EmpLbl
            // 
            EmpLbl.AutoSize = true;
            EmpLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            EmpLbl.ForeColor = Color.Teal;
            EmpLbl.Location = new Point(449, 123);
            EmpLbl.Name = "EmpLbl";
            EmpLbl.Size = new Size(117, 30);
            EmpLbl.TabIndex = 50;
            EmpLbl.Text = "Employees";
            EmpLbl.Click += EmpLbl_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(816, 121);
            label5.Name = "label5";
            label5.Size = new Size(73, 30);
            label5.TabIndex = 51;
            label5.Text = "Salary";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(945, 122);
            label6.Name = "label6";
            label6.Size = new Size(84, 30);
            label6.TabIndex = 52;
            label6.Text = "Logout";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(718, 247);
            label7.Name = "label7";
            label7.Size = new Size(171, 30);
            label7.TabIndex = 53;
            label7.Text = "Department List";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Teal;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.Transparent;
            DeleteBtn.Location = new Point(146, 355);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(111, 34);
            DeleteBtn.TabIndex = 54;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 727);
            Controls.Add(DeleteBtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(EmpLbl);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(DepList);
            Controls.Add(pictureBox1);
            Controls.Add(DepNameTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateBtn;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DataGridView DepList;
        private PictureBox pictureBox1;
        private TextBox DepNameTb;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label label8;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label EmpLbl;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button DeleteBtn;
    }
}