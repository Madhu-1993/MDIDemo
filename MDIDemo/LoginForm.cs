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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MDIDemo
{
    public partial class LoginForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public LoginForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsaveclick_Click(object sender, EventArgs e)
        {

        }
        private void btnsignin_Click(object sender, EventArgs e)     //Update button
        {
               
                string qry = "select* from Employee where Empid=@Empid and Password=@Password";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Empid", Convert.ToInt32(txteid.Text));
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if(dr.Read())
                    {
                        if (Convert.ToInt32(dr["Roleid"]) == 1)
                        {
                            //MessageBox.Show("Login Successful!");
                            FirstPage fm = new FirstPage();
                            fm.Show();
                            
                        }
                        else if (Convert.ToInt32(dr["Roleid"]) == 2)
                        {

                            Employee employee = new Employee();
                            employee.Show();
                        }
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
                con.Close();
        }

        private void btnsignout_Click(object sender, EventArgs e)   //Delete Button
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
