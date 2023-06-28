namespace MDIDemo
{
    partial class LeaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsaveclick = new System.Windows.Forms.Button();
            this.btnsearchclick = new System.Windows.Forms.Button();
            this.btnupdateclick = new System.Windows.Forms.Button();
            this.btndeleteclick = new System.Windows.Forms.Button();
            this.btnshoall = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtlid = new System.Windows.Forms.TextBox();
            this.txtlevetype = new System.Windows.Forms.TextBox();
            this.txtReson = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Totlevs = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.levetaken = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.balleves = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtempid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.combobox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsaveclick
            // 
            this.btnsaveclick.Location = new System.Drawing.Point(37, 406);
            this.btnsaveclick.Name = "btnsaveclick";
            this.btnsaveclick.Size = new System.Drawing.Size(75, 23);
            this.btnsaveclick.TabIndex = 0;
            this.btnsaveclick.Text = "Save";
            this.btnsaveclick.UseVisualStyleBackColor = true;
            this.btnsaveclick.Click += new System.EventHandler(this.btnsaveclick_Click);
            // 
            // btnsearchclick
            // 
            this.btnsearchclick.Location = new System.Drawing.Point(190, 406);
            this.btnsearchclick.Name = "btnsearchclick";
            this.btnsearchclick.Size = new System.Drawing.Size(75, 23);
            this.btnsearchclick.TabIndex = 1;
            this.btnsearchclick.Text = "Search";
            this.btnsearchclick.UseVisualStyleBackColor = true;
            this.btnsearchclick.Click += new System.EventHandler(this.btnsearchclick_Click);
            // 
            // btnupdateclick
            // 
            this.btnupdateclick.Location = new System.Drawing.Point(344, 406);
            this.btnupdateclick.Name = "btnupdateclick";
            this.btnupdateclick.Size = new System.Drawing.Size(75, 23);
            this.btnupdateclick.TabIndex = 2;
            this.btnupdateclick.Text = "Update";
            this.btnupdateclick.UseVisualStyleBackColor = true;
            this.btnupdateclick.Click += new System.EventHandler(this.btnupdateclick_Click);
            // 
            // btndeleteclick
            // 
            this.btndeleteclick.Location = new System.Drawing.Point(510, 406);
            this.btndeleteclick.Name = "btndeleteclick";
            this.btndeleteclick.Size = new System.Drawing.Size(75, 23);
            this.btndeleteclick.TabIndex = 3;
            this.btndeleteclick.Text = "Delete";
            this.btndeleteclick.UseVisualStyleBackColor = true;
            this.btndeleteclick.Click += new System.EventHandler(this.btndeleteclick_Click);
            // 
            // btnshoall
            // 
            this.btnshoall.Location = new System.Drawing.Point(490, 79);
            this.btnshoall.Name = "btnshoall";
            this.btnshoall.Size = new System.Drawing.Size(75, 23);
            this.btnshoall.TabIndex = 4;
            this.btnshoall.Text = "Show All Leaves";
            this.btnshoall.UseVisualStyleBackColor = true;
            this.btnshoall.Click += new System.EventHandler(this.btnshoall_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Leaveid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Empid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fromdate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Todate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Leavetype";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "ReasonOfLeave";
            // 
            // txtlid
            // 
            this.txtlid.Location = new System.Drawing.Point(190, 35);
            this.txtlid.Name = "txtlid";
            this.txtlid.Size = new System.Drawing.Size(100, 20);
            this.txtlid.TabIndex = 11;
            // 
            // txtlevetype
            // 
            this.txtlevetype.Location = new System.Drawing.Point(190, 253);
            this.txtlevetype.Name = "txtlevetype";
            this.txtlevetype.Size = new System.Drawing.Size(100, 20);
            this.txtlevetype.TabIndex = 15;
            // 
            // txtReson
            // 
            this.txtReson.Location = new System.Drawing.Point(190, 311);
            this.txtReson.Name = "txtReson";
            this.txtReson.Size = new System.Drawing.Size(100, 20);
            this.txtReson.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Totlevs
            // 
            this.Totlevs.AutoSize = true;
            this.Totlevs.Location = new System.Drawing.Point(663, 131);
            this.Totlevs.Name = "Totlevs";
            this.Totlevs.Size = new System.Drawing.Size(62, 13);
            this.Totlevs.TabIndex = 19;
            this.Totlevs.Text = "Totalleaves";
            this.Totlevs.Click += new System.EventHandler(this.Totlevs_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(771, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // levetaken
            // 
            this.levetaken.AutoSize = true;
            this.levetaken.Location = new System.Drawing.Point(663, 179);
            this.levetaken.Name = "levetaken";
            this.levetaken.Size = new System.Drawing.Size(69, 13);
            this.levetaken.TabIndex = 21;
            this.levetaken.Text = "Leavestaken";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(771, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "label16";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // balleves
            // 
            this.balleves.AutoSize = true;
            this.balleves.Location = new System.Drawing.Point(663, 224);
            this.balleves.Name = "balleves";
            this.balleves.Size = new System.Drawing.Size(81, 13);
            this.balleves.TabIndex = 23;
            this.balleves.Text = "BalanceLeaves";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(771, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "label18";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtempid
            // 
            this.txtempid.Location = new System.Drawing.Point(190, 95);
            this.txtempid.Name = "txtempid";
            this.txtempid.Size = new System.Drawing.Size(100, 20);
            this.txtempid.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Statusid";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // combobox1
            // 
            this.combobox1.FormattingEnabled = true;
            this.combobox1.Location = new System.Drawing.Point(190, 362);
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(121, 21);
            this.combobox1.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(190, 217);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // LeaveForm
            // 
            this.ClientSize = new System.Drawing.Size(872, 490);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.combobox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.balleves);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.levetaken);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Totlevs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtReson);
            this.Controls.Add(this.txtlevetype);
            this.Controls.Add(this.txtlid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnshoall);
            this.Controls.Add(this.btndeleteclick);
            this.Controls.Add(this.btnupdateclick);
            this.Controls.Add(this.btnsearchclick);
            this.Controls.Add(this.btnsaveclick);
            this.Name = "LeaveForm";
            this.Load += new System.EventHandler(this.LeaveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtleaveid;
        private System.Windows.Forms.TextBox txteid;
        private System.Windows.Forms.TextBox txtromdate;
        private System.Windows.Forms.TextBox txttodate;
        private System.Windows.Forms.TextBox txtleavetype;
        private System.Windows.Forms.TextBox txtreason;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Button btnsaveclick;
        private System.Windows.Forms.Button btnsearchclick;
        private System.Windows.Forms.Button btnupdateclick;
        private System.Windows.Forms.Button btndeleteclick;
        private System.Windows.Forms.Button btnshoall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtlid;
        private System.Windows.Forms.TextBox txtlevetype;
        private System.Windows.Forms.TextBox txtReson;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Totlevs;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label levetaken;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label balleves;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtempid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combobox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}