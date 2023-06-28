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
using static System.Net.Mime.MediaTypeNames;

namespace MDIDemo
{
    public partial class Admin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Admin()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
             
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string qry = "select* from Employee where Empid=@Empid, Deptid=@Deptid";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Empid", Convert.ToInt32(txteid.Text));
            cmd.Parameters.AddWithValue("@Deptid", txtadid.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                EmployeeForm emp = new EmployeeForm();
                emp.Show();
                this.Hide();

                DepartmentForm dep = new DepartmentForm();
                dep.Show();
                this.Hide();

                //((Form1)this.MdiParent).timeShiftToolStripMenuItem_Click.Visible=false;
                //((Form1)this.MdiParent).leaveFormToolStripMenuItem_Click.Visible = false;
            }


            else
            {
                MessageBox.Show("User does not exist");
            }

            dr.Close();

        }

        public void Admin_Load(object sender, EventArgs e)
        {
            
        }
    }

    //private void btnlogout_Click(object sender, EventArgs e)
    //{

    //}
}

