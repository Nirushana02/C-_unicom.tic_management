namespace UnicomTIC_Management_System.Views
{
    partial class AdminDashBoardForm
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
            this.btn_mang_stu = new System.Windows.Forms.Button();
            this.btn_mang_lec = new System.Windows.Forms.Button();
            this.btn_mang_cou = new System.Windows.Forms.Button();
            this.btn_mang_timetable = new System.Windows.Forms.Button();
            this.btn_manag_exam = new System.Windows.Forms.Button();
            this.btn_manag_room = new System.Windows.Forms.Button();
            this.btn_manag_mark = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_manag_sub = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btn_manag_staff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mang_stu
            // 
            this.btn_mang_stu.Location = new System.Drawing.Point(12, 54);
            this.btn_mang_stu.Name = "btn_mang_stu";
            this.btn_mang_stu.Size = new System.Drawing.Size(132, 23);
            this.btn_mang_stu.TabIndex = 0;
            this.btn_mang_stu.Text = "Manage Students";
            this.btn_mang_stu.UseVisualStyleBackColor = true;
            this.btn_mang_stu.Click += new System.EventHandler(this.btn_mang_stu_Click);
            // 
            // btn_mang_lec
            // 
            this.btn_mang_lec.Location = new System.Drawing.Point(12, 131);
            this.btn_mang_lec.Name = "btn_mang_lec";
            this.btn_mang_lec.Size = new System.Drawing.Size(132, 23);
            this.btn_mang_lec.TabIndex = 1;
            this.btn_mang_lec.Text = "Manage Lectures";
            this.btn_mang_lec.UseVisualStyleBackColor = true;
            this.btn_mang_lec.Click += new System.EventHandler(this.btn_mang_lec_Click);
            // 
            // btn_mang_cou
            // 
            this.btn_mang_cou.Location = new System.Drawing.Point(12, 170);
            this.btn_mang_cou.Name = "btn_mang_cou";
            this.btn_mang_cou.Size = new System.Drawing.Size(132, 23);
            this.btn_mang_cou.TabIndex = 2;
            this.btn_mang_cou.Text = "Manage Courses";
            this.btn_mang_cou.UseVisualStyleBackColor = true;
            this.btn_mang_cou.Click += new System.EventHandler(this.btn_mang_cou_Click);
            // 
            // btn_mang_timetable
            // 
            this.btn_mang_timetable.Location = new System.Drawing.Point(12, 209);
            this.btn_mang_timetable.Name = "btn_mang_timetable";
            this.btn_mang_timetable.Size = new System.Drawing.Size(132, 23);
            this.btn_mang_timetable.TabIndex = 3;
            this.btn_mang_timetable.Text = "Manage TimeTable";
            this.btn_mang_timetable.UseVisualStyleBackColor = true;
            this.btn_mang_timetable.Click += new System.EventHandler(this.btn_mang_timetable_Click);
            // 
            // btn_manag_exam
            // 
            this.btn_manag_exam.Location = new System.Drawing.Point(12, 249);
            this.btn_manag_exam.Name = "btn_manag_exam";
            this.btn_manag_exam.Size = new System.Drawing.Size(132, 23);
            this.btn_manag_exam.TabIndex = 4;
            this.btn_manag_exam.Text = "Manage Exam";
            this.btn_manag_exam.UseVisualStyleBackColor = true;
            this.btn_manag_exam.Click += new System.EventHandler(this.btn_manag_exam_Click);
            // 
            // btn_manag_room
            // 
            this.btn_manag_room.Location = new System.Drawing.Point(12, 328);
            this.btn_manag_room.Name = "btn_manag_room";
            this.btn_manag_room.Size = new System.Drawing.Size(132, 23);
            this.btn_manag_room.TabIndex = 5;
            this.btn_manag_room.Text = "Manage Room";
            this.btn_manag_room.UseVisualStyleBackColor = true;
            this.btn_manag_room.Click += new System.EventHandler(this.btn_manag_room_Click);
            // 
            // btn_manag_mark
            // 
            this.btn_manag_mark.Location = new System.Drawing.Point(12, 289);
            this.btn_manag_mark.Name = "btn_manag_mark";
            this.btn_manag_mark.Size = new System.Drawing.Size(132, 23);
            this.btn_manag_mark.TabIndex = 6;
            this.btn_manag_mark.Text = "Manage Mark";
            this.btn_manag_mark.UseVisualStyleBackColor = true;
            this.btn_manag_mark.Click += new System.EventHandler(this.btn_manag_mark_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_manag_staff);
            this.panel1.Controls.Add(this.btn_manag_sub);
            this.panel1.Controls.Add(this.btn_mang_stu);
            this.panel1.Controls.Add(this.btn_manag_room);
            this.panel1.Controls.Add(this.btn_manag_mark);
            this.panel1.Controls.Add(this.btn_mang_lec);
            this.panel1.Controls.Add(this.btn_mang_cou);
            this.panel1.Controls.Add(this.btn_manag_exam);
            this.panel1.Controls.Add(this.btn_mang_timetable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 482);
            this.panel1.TabIndex = 7;
            // 
            // btn_manag_sub
            // 
            this.btn_manag_sub.Location = new System.Drawing.Point(12, 372);
            this.btn_manag_sub.Name = "btn_manag_sub";
            this.btn_manag_sub.Size = new System.Drawing.Size(132, 23);
            this.btn_manag_sub.TabIndex = 6;
            this.btn_manag_sub.Text = "Manage Subject";
            this.btn_manag_sub.UseVisualStyleBackColor = true;
            this.btn_manag_sub.Click += new System.EventHandler(this.btn_manag_sub_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(159, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 25);
            this.panel2.TabIndex = 8;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.IndianRed;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(673, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 20);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(159, 25);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(717, 457);
            this.mainPanel.TabIndex = 9;
            // 
            // btn_manag_staff
            // 
            this.btn_manag_staff.Location = new System.Drawing.Point(12, 93);
            this.btn_manag_staff.Name = "btn_manag_staff";
            this.btn_manag_staff.Size = new System.Drawing.Size(132, 23);
            this.btn_manag_staff.TabIndex = 7;
            this.btn_manag_staff.Text = "Manage Staff";
            this.btn_manag_staff.UseVisualStyleBackColor = true;
            this.btn_manag_staff.Click += new System.EventHandler(this.btn_manag_staff_Click);
            // 
            // AdminDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 482);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashBoardForm";
            this.Text = "AdminDashBoardForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mang_stu;
        private System.Windows.Forms.Button btn_mang_lec;
        private System.Windows.Forms.Button btn_mang_cou;
        private System.Windows.Forms.Button btn_mang_timetable;
        private System.Windows.Forms.Button btn_manag_exam;
        private System.Windows.Forms.Button btn_manag_room;
        private System.Windows.Forms.Button btn_manag_mark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_manag_sub;
        private System.Windows.Forms.Button btn_manag_staff;
    }
}