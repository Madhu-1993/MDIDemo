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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MDIDemo
{
    public partial class LeaveForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public static int Statusid { get; set; }
        public static string Empname { get;set; }
        int empid;
        int statusid;
        public LeaveForm()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);

            SqlDataAdapter da = new SqlDataAdapter("select *from Status", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            combobox1.DataSource = dt;
            combobox1.DisplayMember = "Showstatus";
            combobox1.ValueMember = "Statusid";
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{

        //}


        //private void btnupdate_Click(object sender, EventArgs e)
        //{

        //}

        //private void btndelete_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnShowAll_Click(object sender, EventArgs e)
        //{

        //}

        public void btnsaveclick_Click(object sender, EventArgs e)
        {
            try
            {                
                string qry = "Insert into LeaveApplication values (@Empid,@Fromdate,@Todate,@Leavetype,@ReasonOfLeave,@Statusid)";
                cmd = new SqlCommand(qry, con);
               // dr = cmd.ExecuteReader();
                cmd.Parameters.AddWithValue("@Empid", Convert.ToInt32(txtempid.Text));
                cmd.Parameters.AddWithValue("@Fromdate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Todate", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@Leavetype", Convert.ToInt32(txtlevetype.Text));
                cmd.Parameters.AddWithValue("@ReasonOfLeave", txtReson.Text);
                cmd.Parameters.AddWithValue("@Statusid", Convert.ToInt32(combobox1.SelectedValue));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Reocrd is inserted");
                }
                else
                {
                    MessageBox.Show("Record not Inserted");
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

        private void ClearForm()
        {
            txtleaveid.Clear();
            txteid.Clear();
            txtromdate.Clear();
            txttodate.Clear();
            txtleavetype.Clear();
            txtreason.Clear();
        }
        public void btnsearchclick_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select*from LeaveApplication where Leaveid=@Leaveid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Leaveid", Convert.ToInt32(txtlid.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtempid.Text = dr["Empid"].ToString();
                        dateTimePicker1.Text = dr["Fromdate"].ToString();
                        dateTimePicker2.Text = dr["Todate"].ToString();
                        txtlevetype.Text = dr["Leavetype"].ToString();
                        txtReson.Text = dr["ReasonOfLeave"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
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

        public void btnupdateclick_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Update LeaveApplication set Fromdate=@Fromdate,Todate=@Todate,Leavetype=@Leavetype,ReasonOfLeave=@ReasonOfLeave,Statusid=@Statusid where Leaveid=@Leaveid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Empid", Convert.ToInt32(txtempid.Text));
                cmd.Parameters.AddWithValue("@Fromdate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Todate", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@Leavetype", Convert.ToInt32(txtleavetype.Text));
                cmd.Parameters.AddWithValue("@ReasonOfLeave", txtreason.Text);
                cmd.Parameters.AddWithValue("@Status_Id", (combobox1.SelectedValue));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Reocrd is updated");
                    ClearForm();
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


        public void btndeleteclick_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Delete from LeaveApplication where Leaveid=@Leaveid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Leaveid", Convert.ToInt32(txtlid.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    MessageBox.Show("Reocrd is Deleted");
                    ClearForm();
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


        public void btnshoall_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select l.Leaveid, e.Empname, l.Fromdate, l.Todate, l.Leavetype, l.ReasonOfLeave, s.Showstatus  \r\nfrom LeaveApplication l join Employee e on e.Empid=l.Empid\r\njoin Status s on s.Statusid=l.Statusid;";
                cmd = new SqlCommand(qry, con);
                //cmd.Parameters.AddWithValue("@Leaveid", Convert.ToInt32(txtlid.Text));
                //cmd.Parameters.AddWithValue("@Empid", empid);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                       
                        DataTable table = new DataTable();
                        table.Load(dr);
                        dataGridView1.DataSource = table;   //Alows data binding on windows forms
                        MessageBox.Show("Record Found");

                    }
                }
                else
                {
                    MessageBox.Show("Record not Found");
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

        private void LeaveForm_Load(object sender, EventArgs e)
        {
            empid = Form1.Empid;
            
            try
            {
                string qry = "select * from Balancesheet where Empid=@Empid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Empid", empid);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        label14.Text = dr["Totalleaves"].ToString();
                        label16.Text = dr["Leavestaken"].ToString();
                        label18.Text = dr["BalanceLeaves"].ToString();

                    }
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


        private void Totlevs_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
