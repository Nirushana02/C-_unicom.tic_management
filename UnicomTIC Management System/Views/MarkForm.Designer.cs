namespace UnicomTIC_Management_System.Views
{
    partial class MarkForm
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
            this.cmd_student = new System.Windows.Forms.ComboBox();
            this.cmd_exam = new System.Windows.Forms.ComboBox();
            this.lbl_student = new System.Windows.Forms.Label();
            this.lbl_exam = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_marks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_student
            // 
            this.cmd_student.FormattingEnabled = true;
            this.cmd_student.Location = new System.Drawing.Point(140, 72);
            this.cmd_student.Name = "cmd_student";
            this.cmd_student.Size = new System.Drawing.Size(198, 21);
            this.cmd_student.TabIndex = 0;
            // 
            // cmd_exam
            // 
            this.cmd_exam.FormattingEnabled = true;
            this.cmd_exam.Location = new System.Drawing.Point(140, 120);
            this.cmd_exam.Name = "cmd_exam";
            this.cmd_exam.Size = new System.Drawing.Size(198, 21);
            this.cmd_exam.TabIndex = 1;
            // 
            // lbl_student
            // 
            this.lbl_student.AutoSize = true;
            this.lbl_student.Location = new System.Drawing.Point(86, 75);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(44, 13);
            this.lbl_student.TabIndex = 2;
            this.lbl_student.Text = "Student";
            // 
            // lbl_exam
            // 
            this.lbl_exam.AutoSize = true;
            this.lbl_exam.Location = new System.Drawing.Point(86, 123);
            this.lbl_exam.Name = "lbl_exam";
            this.lbl_exam.Size = new System.Drawing.Size(33, 13);
            this.lbl_exam.TabIndex = 3;
            this.lbl_exam.Text = "Exam";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Location = new System.Drawing.Point(86, 172);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(35, 13);
            this.lbl_score.TabIndex = 4;
            this.lbl_score.Text = "Score";
            // 
            // txt_score
            // 
            this.txt_score.Location = new System.Drawing.Point(140, 169);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(198, 20);
            this.txt_score.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(78, 224);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(238, 224);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(88, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(401, 224);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_marks
            // 
            this.dgv_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marks.Location = new System.Drawing.Point(89, 271);
            this.dgv_marks.Name = "dgv_marks";
            this.dgv_marks.Size = new System.Drawing.Size(409, 164);
            this.dgv_marks.TabIndex = 9;
            this.dgv_marks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_marks_CellContentClick);
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 447);
            this.Controls.Add(this.dgv_marks);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_exam);
            this.Controls.Add(this.lbl_student);
            this.Controls.Add(this.cmd_exam);
            this.Controls.Add(this.cmd_student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            this.Load += new System.EventHandler(this.MarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmd_student;
        private System.Windows.Forms.ComboBox cmd_exam;
        private System.Windows.Forms.Label lbl_student;
        private System.Windows.Forms.Label lbl_exam;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_marks;
    }
}