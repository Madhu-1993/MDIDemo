using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public static int Empid { get; set; }
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);

        }
        //private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DepartmentForm departmentForm = new DepartmentForm();
        //    departmentForm.MdiParent= this;
        //    departmentForm.Show();
        //}

        //private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LoginForm loginForm = new LoginForm();
        //    loginForm.MdiParent = this;
        //    loginForm.Dock = DockStyle.Fill;
        //    loginForm.Show();
        //    // this.Hide();

        //}
        //private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    EmployeeForm employeeForm = new EmployeeForm();
        //    employeeForm.MdiParent = this;
        //    employeeForm.Show();
        //}
        //private void leaveApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LeaveForm leaveForm = new LeaveForm();
        //    leaveForm.MdiParent = this;
        //    leaveForm.Show();
        //}

        //private void timeSheetToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Sheetform sheetform = new Sheetform();
        //    sheetform.MdiParent = this;
        //    sheetform.Show();
        //}



        //private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.MdiParent;
            //form1.menuStrip1.Visible= true;
        }

        private void logInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            LoginForm loginForm = new LoginForm();
            loginForm.MdiParent = this;
           // loginForm.Dock = DockStyle.Fill;
            loginForm.Show();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select* from Employee where Empid=@Empid and Password=@Password";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Empid", Convert.ToInt32(txteid.Text));
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Form1.Empid = Convert.ToInt32(dr["Empid"]);
                        if (Convert.ToInt32(dr["Roleid"]) == 1)
                        {
                            // txtpassword.Text = dr["Password"].ToString();
                            MessageBox.Show("Login Successful!");

                            FirstPage fm = new FirstPage();
                            fm.Show();
                            //this.Hide();
                            //User.Authorized = true;
                            //this.Close();
                        }
                        else if (Convert.ToInt32(dr["Roleid"]) == 2)
                        {
                            Employee sheetform = new Employee();
                            sheetform.Show();
                        }
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Roleform roleform = new Roleform();
        //    roleform.MdiParent=this;
        //    roleform.Show();
        //}

        //private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Admin admin = new Admin();
        //    admin.MdiParent = this;
        //    admin.Show();
        //}

        //private void userToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    User user = new User();
        //    user.MdiParent = this;
        //    user.Show();
        //}
    }
}
