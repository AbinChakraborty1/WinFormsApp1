using System.Data.SqlTypes;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text =="" || PasswordTb.Text=="")
            {
                MessageBox.Show("Missing Data!!!!");
            }
            else if(UNameTb.Text == "Abin" && PasswordTb.Text == "Password")
            {
                Employees obj = new Employees();
                obj.Show();
                this.Hide();
                Departments departments = new Departments();
                departments.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong User Name or password!!!");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }
    }
}
