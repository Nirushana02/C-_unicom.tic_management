namespace UnicomTIC_Management_System
{
    partial class StudentForm
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.cmb_course = new System.Windows.Forms.ComboBox();
            this.dgv_stu = new System.Windows.Forms.DataGridView();
            this.btn_del_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(37, 189);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(110, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(207, 189);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(129, 23);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(393, 189);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 23);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(91, 76);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(78, 13);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Student Name:";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Location = new System.Drawing.Point(91, 136);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(43, 13);
            this.lbl_course.TabIndex = 5;
            this.lbl_course.Text = "Course:";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(210, 73);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(256, 20);
            this.txtBox_name.TabIndex = 6;
            // 
            // cmb_course
            // 
            this.cmb_course.FormattingEnabled = true;
            this.cmb_course.Items.AddRange(new object[] {
            "ICT",
            "English"});
            this.cmb_course.Location = new System.Drawing.Point(207, 133);
            this.cmb_course.Name = "cmb_course";
            this.cmb_course.Size = new System.Drawing.Size(259, 21);
            this.cmb_course.TabIndex = 8;
            // 
            // dgv_stu
            // 
            this.dgv_stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stu.Location = new System.Drawing.Point(94, 232);
            this.dgv_stu.Name = "dgv_stu";
            this.dgv_stu.Size = new System.Drawing.Size(450, 203);
            this.dgv_stu.TabIndex = 9;
            this.dgv_stu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_stu_CellContentClick);
            // 
            // btn_del_all
            // 
            this.btn_del_all.Location = new System.Drawing.Point(560, 189);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(89, 23);
            this.btn_del_all.TabIndex = 10;
            this.btn_del_all.Text = "DELETE ALL";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 447);
            this.Controls.Add(this.btn_del_all);
            this.Controls.Add(this.dgv_stu);
            this.Controls.Add(this.cmb_course);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.ComboBox cmb_course;
        private System.Windows.Forms.DataGridView dgv_stu;
        private System.Windows.Forms.Button btn_del_all;
    }
}