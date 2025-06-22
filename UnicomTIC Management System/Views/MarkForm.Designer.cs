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
            this.cmd_exam = new System.Windows.Forms.ComboBox();
            this.lbl_student = new System.Windows.Forms.Label();
            this.lbl_exam = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_marks = new System.Windows.Forms.DataGridView();
            this.btn_del_all = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_subject = new System.Windows.Forms.ComboBox();
            this.lbl_sub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_exam
            // 
            this.cmd_exam.FormattingEnabled = true;
            this.cmd_exam.Location = new System.Drawing.Point(172, 202);
            this.cmd_exam.Name = "cmd_exam";
            this.cmd_exam.Size = new System.Drawing.Size(198, 21);
            this.cmd_exam.TabIndex = 1;
            // 
            // lbl_student
            // 
            this.lbl_student.AutoSize = true;
            this.lbl_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student.Location = new System.Drawing.Point(86, 138);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(58, 16);
            this.lbl_student.TabIndex = 2;
            this.lbl_student.Text = "Student :";
            // 
            // lbl_exam
            // 
            this.lbl_exam.AutoSize = true;
            this.lbl_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exam.Location = new System.Drawing.Point(86, 205);
            this.lbl_exam.Name = "lbl_exam";
            this.lbl_exam.Size = new System.Drawing.Size(47, 16);
            this.lbl_exam.TabIndex = 3;
            this.lbl_exam.Text = "Exam :";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(452, 141);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(49, 16);
            this.lbl_score.TabIndex = 4;
            this.lbl_score.Text = "Score :";
            // 
            // txt_score
            // 
            this.txt_score.Location = new System.Drawing.Point(525, 138);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(198, 20);
            this.txt_score.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(109, 262);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(259, 262);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(88, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(393, 262);
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
            this.dgv_marks.Location = new System.Drawing.Point(161, 315);
            this.dgv_marks.Name = "dgv_marks";
            this.dgv_marks.Size = new System.Drawing.Size(409, 164);
            this.dgv_marks.TabIndex = 9;
            this.dgv_marks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_marks_CellContentClick);
            // 
            // btn_del_all
            // 
            this.btn_del_all.Location = new System.Drawing.Point(539, 262);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(89, 23);
            this.btn_del_all.TabIndex = 10;
            this.btn_del_all.Text = "DELETE ALL";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(172, 138);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(198, 20);
            this.txt_name.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Students Marks..";
            // 
            // cmb_subject
            // 
            this.cmb_subject.FormattingEnabled = true;
            this.cmb_subject.Location = new System.Drawing.Point(525, 202);
            this.cmb_subject.Name = "cmb_subject";
            this.cmb_subject.Size = new System.Drawing.Size(198, 21);
            this.cmb_subject.TabIndex = 14;
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub.Location = new System.Drawing.Point(452, 205);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(58, 16);
            this.lbl_sub.TabIndex = 15;
            this.lbl_sub.Text = "Subject :";
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 529);
            this.Controls.Add(this.lbl_sub);
            this.Controls.Add(this.cmb_subject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_del_all);
            this.Controls.Add(this.dgv_marks);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_exam);
            this.Controls.Add(this.lbl_student);
            this.Controls.Add(this.cmd_exam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            this.Load += new System.EventHandler(this.MarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmd_exam;
        private System.Windows.Forms.Label lbl_student;
        private System.Windows.Forms.Label lbl_exam;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgv_marks;
        private System.Windows.Forms.Button btn_del_all;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_subject;
        private System.Windows.Forms.Label lbl_sub;
    }
}