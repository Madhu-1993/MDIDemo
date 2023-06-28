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
    public partial class EmployeeForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public EmployeeForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select *from Role", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Rolename";
            comboBox1.ValueMember = "Roleid";

            SqlDataAdapter da2 = new SqlDataAdapter("select *from Department", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Deptname";
            comboBox2.ValueMember = "Deptid";

            SqlDataAdapter da3 = new SqlDataAdapter("select *from Balancesheet", con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ClearForm()
        {
            txteid.Clear();
            txtename.Clear();
            //txtdeptid.Clear();
            txtsalary.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Employee values(@Empname,@Deptid,@Salary,@Password,@Roleid)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Empname", txtename.Text);
                cmd.Parameters.AddWithValue("@Deptid", Convert.ToInt32(comboBox2.SelectedValue));
                cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32(txtsalary.Text));
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                cmd.Parameters.AddWithValue("@Roleid", Convert.ToInt32(comboBox1.SelectedValue));

                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Record inserted");
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select*from Employee where Empid=@Empid";
                cmd=new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Empid",Convert.ToInt32(txteid.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txtename.Text = dr["Empname"].ToString();
                        //txtdeptid.Text = dr["Deptid"].ToString();
                        txtsalary.Text = dr["Salary"].ToString();
                        txtpassword.Text = dr["Password"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "Update Employee set Empname=@Empname,Deptid=@Deptid,Salary=@Salary,Password=@Password, Roleid=@Roleid where Empid=@Empid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Empid", Convert.ToInt32(txteid.Text));
                cmd.Parameters.AddWithValue("@Empname", txtename.Text);
                cmd.Parameters.AddWithValue("@Deptid", Convert.ToInt32(comboBox2.SelectedValue));
                cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32(txtsalary.Text));
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                cmd.Parameters.AddWithValue("@Roleid", Convert.ToInt32(comboBox1.SelectedValue));

                con.Open();
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Record Updated");
                    ClearForm();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Delete form Employee where Empid=@Empid";
                cmd= new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Empid", Convert.ToInt32(txteid.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Record Deleted");
                    ClearForm();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select e.Empname, e.Deptid, e.Salary, e.Password, r.Rolename from Employee e join\r\nRole r on e.Roleid=r.Roleid";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        DataTable table = new DataTable();
                        table.Load(dr);
                        Data.DataSource = table;
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
