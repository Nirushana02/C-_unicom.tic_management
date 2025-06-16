namespace UnicomTIC_Management_System.DashBoardForm
{
    partial class StaffDashBoardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btn_exam = new System.Windows.Forms.Button();
            this.btn_timetable = new System.Windows.Forms.Button();
            this.btn_room = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_course = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btn_course);
            this.panel2.Controls.Add(this.btn_room);
            this.panel2.Controls.Add(this.btn_timetable);
            this.panel2.Controls.Add(this.btn_exam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 418);
            this.panel2.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(174, 25);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(686, 418);
            this.mainPanel.TabIndex = 2;
            // 
            // btn_exam
            // 
            this.btn_exam.Location = new System.Drawing.Point(21, 67);
            this.btn_exam.Name = "btn_exam";
            this.btn_exam.Size = new System.Drawing.Size(127, 23);
            this.btn_exam.TabIndex = 0;
            this.btn_exam.Text = "Manage Exam";
            this.btn_exam.UseVisualStyleBackColor = true;
            // 
            // btn_timetable
            // 
            this.btn_timetable.Location = new System.Drawing.Point(21, 146);
            this.btn_timetable.Name = "btn_timetable";
            this.btn_timetable.Size = new System.Drawing.Size(127, 23);
            this.btn_timetable.TabIndex = 1;
            this.btn_timetable.Text = "Manage Timetable";
            this.btn_timetable.UseVisualStyleBackColor = true;
            // 
            // btn_room
            // 
            this.btn_room.Location = new System.Drawing.Point(21, 227);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(127, 23);
            this.btn_room.TabIndex = 2;
            this.btn_room.Text = "Manage Room";
            this.btn_room.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(815, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(33, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_course
            // 
            this.btn_course.Location = new System.Drawing.Point(21, 302);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(127, 23);
            this.btn_course.TabIndex = 3;
            this.btn_course.Text = "Manage Course";
            this.btn_course.UseVisualStyleBackColor = true;
            // 
            // StaffDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 443);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDashBoardForm";
            this.Text = "StaffDashBoardForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_room;
        private System.Windows.Forms.Button btn_timetable;
        private System.Windows.Forms.Button btn_exam;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btn_course;
    }
}