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
    public partial class Sheetform : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int empid;

        public Sheetform()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString);
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Insert into TimeSheet values(@Intime,@Outtime,@Empid)";
                cmd = new SqlCommand(qry, con);
                //cmd.Parameters.AddWithValue("@Timesheetid", txttimeid.Text);
                cmd.Parameters.AddWithValue("@Intime", txtintime.Text);
                cmd.Parameters.AddWithValue("@Outtime", txtouttime.Text);
                cmd.Parameters.AddWithValue("@Empid", Convert.ToInt32(txteid.Text));
                //var Item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                //MessageBox.Show(Item);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res ==1)
                {
                    MessageBox.Show("Reocrd is inserted");
                    //LeaveForm fm = new LeaveForm();
                    //fm.Show();
                    //this.Hide();
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
            txttimeid.Clear();
            txtintime.Clear();
            txtouttime.Clear();
            //txteid.Clear();
           
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select*from TimeSheet where Timesheetid=@Timesheetid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Timesheetid", Convert.ToInt32(txttimeid.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtintime.Text = dr["Intime"].ToString();
                        txtouttime.Text = dr["Outtime"].ToString();
                        txteid.Text = dr["Empid"].ToString();
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Update TimeSheet set Intime=@Intime, Outtime=@Outtime,Empid=@Empid where Timesheetid=@Timesheetid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Intime", txtintime.Text);
                cmd.Parameters.AddWithValue("@Outtime", txtouttime.Text);
                cmd.Parameters.AddWithValue("@Empid", Convert.ToInt32(txteid.Text));
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res ==1)
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

        private void btndalete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Delete from TimeSheet where Timesheetid=@Timesheetid";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Timesheetid", Convert.ToInt32(txttimeid.Text));
                
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

        private void btnshoall_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select e.Empname, t.Intime,t.Outtime from Employee e join TimeSheet t on e.Empid=t.Empid";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        //empid = Convert.ToInt32(dr["Empid"]);
                        DataTable table = new DataTable();
                        table.Load(dr);
                        dataGridView1.DataSource = table;   //Alows data binding on windows forms
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

        private void Sheetform_Load(object sender, EventArgs e)
        {
            empid = Form1.Empid;
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    comboBox1.Items.Add("Sunday");
        //    comboBox1.Items.Add("Monday");
        //    comboBox1.Items.Add("Tuesday");
        //    comboBox1.Items.Add("Wednesday");
        //    comboBox1.Items.Add("Thursday");
        //    comboBox1.Items.Add("Friday");
        //    //comboBox1.Items.Add("Saturday");

        //}

        //private void Sheetform_Load(object sender, EventArgs e)
        //{
        //    comboBox1.Items.Add("weekdays");
        //}
    }
}
