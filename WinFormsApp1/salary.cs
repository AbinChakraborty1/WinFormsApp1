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
    public partial class Salary : Form
    {
        Functions con;
        public Salary()
        {
            InitializeComponent();
            con = new Functions();
            ShowSalaries();
            GetEmployees();
        }
        public void GetEmployees()
        {
            string Query = "Select * from EmpTbl";
            EmpCb.DisplayMember = con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = con.GetData(Query);
        }
        int DSal = 0;
        string Period = "";
        public void GetSalary()
        {
            string Query = "Select EmpSal from EmpTbl where EmpId = {0} ";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }

            //MessageBox.Show("" + DSal);
            //EmpCb.DataSource = con.GetData(Query);
            if (DaysTb.Text == "")
            {
                AmountTb.Text = "" + (d * DSal);
            }
            else if (Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days can not be greater than 31");
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "" + (d * DSal);

            }
        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "Select * from SalaryTbl";
                SalaryList.DataSource = con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void EmpCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }
        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + " " + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);

                    int Days = Convert.ToInt32(DaysTb.Text);

                    string Query = "Insert into SalaryTbl values({0},{1},'{2}',{3},'{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString, Days, Period, Amount, DateTime.Today.Date);
                    con.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Salary paid!!!");
                    DaysTb.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LogOutLbl_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show();
            this.Hide();
        }
    }
}
