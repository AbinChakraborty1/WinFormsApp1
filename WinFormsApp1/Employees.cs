using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Employees : Form
    {
        Functions con;
        public Employees()
        {
            InitializeComponent();
            con = new Functions();
            ShowEmp();
            GetDepartment();
        }
        private void ShowEmp()
        {
            string Query = "Select * from EmpTbl";
            EmployeeList.DataSource = con.GetData(Query);
        }
        public void GetDepartment()
        {
            string Query = "Select * from DepartmentTbl";
            EmpDepTb.DisplayMember = con.GetData(Query).Columns["DepName"].ToString();
            EmpDepTb.ValueMember = con.GetData(Query).Columns["DepId"].ToString();
            EmpDepTb.DataSource = con.GetData(Query);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpDepTb.SelectedIndex == -1 || EmpSal.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = EmpGenCb.SelectedItem.ToString();
                    int Dept = Convert.ToInt32(EmpDepTb.SelectedValue.ToString());
                    string JDate = EmpJoinDate.Value.ToString();
                    string DOB = EmpDOB.Value.ToString();
                    int Salary = Convert.ToInt32(EmpSal.Text);

                    string Query = "Insert into EmpTbl values('{0}','{1}',{2},'{3}','{4}','{5}')";
                    Query = string.Format(Query, Name, Gender, Dept, JDate, DOB, Salary);
                    con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Added!!!");
                    EmpNameTb.Text = "";
                    EmpSal.Text = "";
                    EmpDepTb.SelectedIndex = -1;
                    EmpGenCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {

                    String Query = "delete from EmpTbl where EmpId ={0}";
                    Query = string.Format(Query, key);
                    con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Deleted!!!");
                    EmpNameTb.Text = "";
                    EmpSal.Text = "";
                    EmpDepTb.SelectedIndex = -1;
                    EmpGenCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || EmpGenCb.SelectedIndex == -1 || EmpDepTb.SelectedIndex == -1 || EmpSal.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    String Name = EmpNameTb.Text;
                    String Gender = EmpGenCb.SelectedItem.ToString();
                    int Dept = Convert.ToInt32(EmpDepTb.SelectedValue.ToString());
                    String JDate = EmpJoinDate.Value.ToString();
                    String DOB = EmpDOB.Value.ToString();
                    int Salary = Convert.ToInt32(EmpSal.Text);

                    String Query = "update EmpTbl set EmpName ='{0}',EmpGen ='{1}',EmpDep = {2},EmpJDate = '{3}',EmpDOB = '{4}',EmpSal = '{5}' where EmpId= '{6}'";
                    Query = string.Format(Query, Name, Gender, Dept, JDate, DOB, Salary, key);
                    con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Employee Updated!!!");
                    EmpNameTb.Text = "";
                    EmpSal.Text = "";
                    EmpDepTb.SelectedIndex = -1;
                    EmpGenCb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            EmpGenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            EmpDepTb.Text = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            EmpDOB.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            EmpJoinDate.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            EmpSal.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show();
            this.Hide();
        }
    }
}
