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
    public partial class DepartmentForm : Form
    {
      SqlConnection con;
      SqlCommand cmd;
      SqlDataReader dr;
        public DepartmentForm()
        {
            InitializeComponent();
            con=new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
        }

        public void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string qry="insert into Department values(@Deptname)";
                cmd = new SqlCommand(qry, con);
               // cmd.Parameters.AddWithValue("@Deptid", Convert.ToInt32(txtDeptid.Text));
                cmd.Parameters.AddWithValue("@Deptname", txtDeptname.Text);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Record Inserted");
                    //EmployeeForm fm = new EmployeeForm();
                    //fm.Show();
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
        private void ClearForm()
        {
            txtDeptid.Clear();
            txtDeptname.Clear();
        }
        public void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String qry = "select *from Department where Deptid=@Deptid";
                cmd= new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Deptid", Convert.ToInt32(txtDeptid.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        txtDeptname.Text = dr["Deptname"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not Found");
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
        public void button3_Click(object sender, EventArgs e) //Update butoon
        {
            try
            {
                string qry = "Update Department set Deptname=@Deptname where Deptid=@Deptid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Deptid", Convert.ToInt32(txtDeptid.Text));
                cmd.Parameters.AddWithValue("@Deptname", txtDeptid.Text);
                con.Close();
                int res=cmd.ExecuteNonQuery();
                if (res > 0)
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

        public void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from Department where Deptid=@Deptid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Deptid", Convert.ToInt32(txtDeptid.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if(res>0)
                {
                    MessageBox.Show("Record deleted");
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

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from Department";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        DataTable table = new DataTable();
                        table.Load(dr);
                        Data.DataSource = table;   //Alows data binding on windows forms
                    }
                }
                else
                {
                    MessageBox.Show("Record not Foud");
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
    }
}
