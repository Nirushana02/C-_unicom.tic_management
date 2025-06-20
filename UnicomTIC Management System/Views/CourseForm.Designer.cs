namespace UnicomTIC_Management_System.Views
{
    partial class CourseForm
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
            this.lbl_cname = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.lbl_end = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.btn_c_add = new System.Windows.Forms.Button();
            this.btn_c_update = new System.Windows.Forms.Button();
            this.btn_c_delete = new System.Windows.Forms.Button();
            this.dgv_course = new System.Windows.Forms.DataGridView();
            this.btn_del_all = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cname
            // 
            this.lbl_cname.AutoSize = true;
            this.lbl_cname.Location = new System.Drawing.Point(95, 127);
            this.lbl_cname.Name = "lbl_cname";
            this.lbl_cname.Size = new System.Drawing.Size(74, 13);
            this.lbl_cname.TabIndex = 0;
            this.lbl_cname.Text = "Course Name:";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(98, 192);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(58, 13);
            this.lbl_start.TabIndex = 2;
            this.lbl_start.Text = "Start Date:";
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(198, 127);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(159, 20);
            this.txt_cname.TabIndex = 4;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(98, 251);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(55, 13);
            this.lbl_end.TabIndex = 5;
            this.lbl_end.Text = "End Date:";
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(198, 186);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 20);
            this.dtp_start.TabIndex = 6;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(198, 249);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 20);
            this.dtp_end.TabIndex = 7;
            // 
            // btn_c_add
            // 
            this.btn_c_add.Location = new System.Drawing.Point(128, 289);
            this.btn_c_add.Name = "btn_c_add";
            this.btn_c_add.Size = new System.Drawing.Size(75, 23);
            this.btn_c_add.TabIndex = 8;
            this.btn_c_add.Text = "ADD";
            this.btn_c_add.UseVisualStyleBackColor = true;
            this.btn_c_add.Click += new System.EventHandler(this.btn_c_add_Click);
            // 
            // btn_c_update
            // 
            this.btn_c_update.Location = new System.Drawing.Point(282, 289);
            this.btn_c_update.Name = "btn_c_update";
            this.btn_c_update.Size = new System.Drawing.Size(75, 23);
            this.btn_c_update.TabIndex = 9;
            this.btn_c_update.Text = "UPDATE";
            this.btn_c_update.UseVisualStyleBackColor = true;
            this.btn_c_update.Click += new System.EventHandler(this.btn_c_update_Click);
            // 
            // btn_c_delete
            // 
            this.btn_c_delete.Location = new System.Drawing.Point(440, 289);
            this.btn_c_delete.Name = "btn_c_delete";
            this.btn_c_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_c_delete.TabIndex = 10;
            this.btn_c_delete.Text = "DELETE";
            this.btn_c_delete.UseVisualStyleBackColor = true;
            this.btn_c_delete.Click += new System.EventHandler(this.btn_c_delete_Click);
            // 
            // dgv_course
            // 
            this.dgv_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_course.Location = new System.Drawing.Point(186, 332);
            this.dgv_course.Name = "dgv_course";
            this.dgv_course.Size = new System.Drawing.Size(405, 185);
            this.dgv_course.TabIndex = 11;
            this.dgv_course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_course_CellContentClick);
            // 
            // btn_del_all
            // 
            this.btn_del_all.Location = new System.Drawing.Point(594, 289);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(99, 23);
            this.btn_del_all.TabIndex = 12;
            this.btn_del_all.Text = "DELETE ALL";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Course Details...";
            // 
            // CourseForm
            // 
            this.ClientSize = new System.Drawing.Size(821, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_del_all);
            this.Controls.Add(this.dgv_course);
            this.Controls.Add(this.btn_c_delete);
            this.Controls.Add(this.btn_c_update);
            this.Controls.Add(this.btn_c_add);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_cname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_sess_name;
        private System.Windows.Forms.Label lbl_sess_name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dgv_session;
        private System.Windows.Forms.Label lbl_cname;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button btn_c_add;
        private System.Windows.Forms.Button btn_c_update;
        private System.Windows.Forms.Button btn_c_delete;
        private System.Windows.Forms.DataGridView dgv_course;
        private System.Windows.Forms.Button btn_del_all;
        private System.Windows.Forms.Label label1;
    }
}