using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIDemo
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void leaveFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LeaveForm leaveForm = new LeaveForm();
            leaveForm.MdiParent = this;
            leaveForm.Show();
        }

        private void timeSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sheetform sheetform = new Sheetform();
            sheetform.MdiParent = this;
            sheetform.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            
        }
    }
}
