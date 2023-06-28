namespace MDIDemo
{
    partial class Sheetform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttimeid = new System.Windows.Forms.TextBox();
            this.txtintime = new System.Windows.Forms.TextBox();
            this.txtouttime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndalete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshoall = new System.Windows.Forms.Button();
            this.txteid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timesheetid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Outtime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Empid";
            // 
            // txttimeid
            // 
            this.txttimeid.Location = new System.Drawing.Point(259, 104);
            this.txttimeid.Name = "txttimeid";
            this.txttimeid.Size = new System.Drawing.Size(100, 20);
            this.txttimeid.TabIndex = 6;
            // 
            // txtintime
            // 
            this.txtintime.Location = new System.Drawing.Point(259, 150);
            this.txtintime.Name = "txtintime";
            this.txtintime.Size = new System.Drawing.Size(100, 20);
            this.txtintime.TabIndex = 7;
            // 
            // txtouttime
            // 
            this.txtouttime.Location = new System.Drawing.Point(259, 200);
            this.txtouttime.Name = "txtouttime";
            this.txtouttime.Size = new System.Drawing.Size(100, 20);
            this.txtouttime.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 360);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(200, 360);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(350, 360);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndalete
            // 
            this.btndalete.Location = new System.Drawing.Point(498, 360);
            this.btndalete.Name = "btndalete";
            this.btndalete.Size = new System.Drawing.Size(75, 23);
            this.btndalete.TabIndex = 15;
            this.btndalete.Text = "Delete";
            this.btndalete.UseVisualStyleBackColor = true;
            this.btndalete.Click += new System.EventHandler(this.btndalete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnshoall
            // 
            this.btnshoall.Location = new System.Drawing.Point(489, 83);
            this.btnshoall.Name = "btnshoall";
            this.btnshoall.Size = new System.Drawing.Size(107, 23);
            this.btnshoall.TabIndex = 18;
            this.btnshoall.Text = "Show All Record";
            this.btnshoall.UseVisualStyleBackColor = true;
            this.btnshoall.Click += new System.EventHandler(this.btnshoall_Click);
            // 
            // txteid
            // 
            this.txteid.Location = new System.Drawing.Point(259, 263);
            this.txteid.Name = "txteid";
            this.txteid.Size = new System.Drawing.Size(100, 20);
            this.txteid.TabIndex = 20;
            // 
            // Sheetform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txteid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnshoall);
            this.Controls.Add(this.btndalete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtouttime);
            this.Controls.Add(this.txtintime);
            this.Controls.Add(this.txttimeid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sheetform";
            this.Text = "Sheetform";
            this.Load += new System.EventHandler(this.Sheetform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttimeid;
        private System.Windows.Forms.TextBox txtintime;
        private System.Windows.Forms.TextBox txtouttime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndalete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshoall;
        private System.Windows.Forms.TextBox txteid;
    }
}