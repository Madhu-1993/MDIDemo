namespace MDIDemo
{
    partial class Admin
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.txtadid = new System.Windows.Forms.TextBox();
            this.txteid = new System.Windows.Forms.TextBox();
            this.txtdid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adminid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deptid";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(123, 327);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(333, 327);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.UseVisualStyleBackColor = true;
            // 
            // txtadid
            // 
            this.txtadid.Location = new System.Drawing.Point(246, 83);
            this.txtadid.Name = "txtadid";
            this.txtadid.Size = new System.Drawing.Size(100, 20);
            this.txtadid.TabIndex = 5;
            // 
            // txteid
            // 
            this.txteid.Location = new System.Drawing.Point(246, 159);
            this.txteid.Name = "txteid";
            this.txteid.Size = new System.Drawing.Size(100, 20);
            this.txteid.TabIndex = 6;
            // 
            // txtdid
            // 
            this.txtdid.Location = new System.Drawing.Point(246, 240);
            this.txtdid.Name = "txtdid";
            this.txtdid.Size = new System.Drawing.Size(100, 20);
            this.txtdid.TabIndex = 7;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdid);
            this.Controls.Add(this.txteid);
            this.Controls.Add(this.txtadid);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.TextBox txtadid;
        private System.Windows.Forms.TextBox txteid;
        private System.Windows.Forms.TextBox txtdid;
    }
}