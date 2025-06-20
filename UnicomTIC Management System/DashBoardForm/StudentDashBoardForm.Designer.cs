namespace UnicomTIC_Management_System.DashBoardForm
{
    partial class StudentDashBoardForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_marks = new System.Windows.Forms.Button();
            this.btn_timetable = new System.Windows.Forms.Button();
            this.btn_room = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 25);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(956, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btn_marks);
            this.panel1.Controls.Add(this.btn_timetable);
            this.panel1.Controls.Add(this.btn_room);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 541);
            this.panel1.TabIndex = 1;
            // 
            // btn_marks
            // 
            this.btn_marks.Location = new System.Drawing.Point(32, 91);
            this.btn_marks.Name = "btn_marks";
            this.btn_marks.Size = new System.Drawing.Size(135, 23);
            this.btn_marks.TabIndex = 0;
            this.btn_marks.Text = "View Marks";
            this.btn_marks.UseVisualStyleBackColor = true;
            this.btn_marks.Click += new System.EventHandler(this.btn_marks_Click);
            // 
            // btn_timetable
            // 
            this.btn_timetable.Location = new System.Drawing.Point(32, 186);
            this.btn_timetable.Name = "btn_timetable";
            this.btn_timetable.Size = new System.Drawing.Size(135, 23);
            this.btn_timetable.TabIndex = 1;
            this.btn_timetable.Text = "View Timetable";
            this.btn_timetable.UseVisualStyleBackColor = true;
            this.btn_timetable.Click += new System.EventHandler(this.btn_timetable_Click);
            // 
            // btn_room
            // 
            this.btn_room.Location = new System.Drawing.Point(32, 286);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(135, 23);
            this.btn_room.TabIndex = 2;
            this.btn_room.Text = "View Room";
            this.btn_room.UseVisualStyleBackColor = true;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 25);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(798, 541);
            this.mainPanel.TabIndex = 2;
            // 
            // StudentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 566);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDashBoardForm";
            this.Text = "StudentDashBoardForm";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btn_marks;
        private System.Windows.Forms.Button btn_timetable;
        private System.Windows.Forms.Button btn_room;
    }
}