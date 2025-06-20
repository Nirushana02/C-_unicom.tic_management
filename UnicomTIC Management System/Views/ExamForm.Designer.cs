namespace UnicomTIC_Management_System.Views
{
    partial class ExamForm
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_exam = new System.Windows.Forms.DataGridView();
            this.txt_exam = new System.Windows.Forms.TextBox();
            this.cmb_sub = new System.Windows.Forms.ComboBox();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_del_all = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exam)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(141, 209);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(279, 209);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(97, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_exam
            // 
            this.dgv_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_exam.Location = new System.Drawing.Point(193, 266);
            this.dgv_exam.Name = "dgv_exam";
            this.dgv_exam.Size = new System.Drawing.Size(430, 209);
            this.dgv_exam.TabIndex = 2;
            this.dgv_exam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_exam_CellContentClick);
            // 
            // txt_exam
            // 
            this.txt_exam.Location = new System.Drawing.Point(374, 87);
            this.txt_exam.Name = "txt_exam";
            this.txt_exam.Size = new System.Drawing.Size(182, 20);
            this.txt_exam.TabIndex = 3;
            // 
            // cmb_sub
            // 
            this.cmb_sub.FormattingEnabled = true;
            this.cmb_sub.Items.AddRange(new object[] {
            "Programming",
            "UI Design",
            "Code Developer"});
            this.cmb_sub.Location = new System.Drawing.Point(374, 141);
            this.cmb_sub.Name = "cmb_sub";
            this.cmb_sub.Size = new System.Drawing.Size(182, 21);
            this.cmb_sub.TabIndex = 4;
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sub.Location = new System.Drawing.Point(261, 90);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(84, 16);
            this.lbl_sub.TabIndex = 5;
            this.lbl_sub.Text = "Exam Name:";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course.Location = new System.Drawing.Point(261, 144);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(58, 16);
            this.lbl_course.TabIndex = 6;
            this.lbl_course.Text = "Subject :";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(430, 209);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_del_all
            // 
            this.btn_del_all.Location = new System.Drawing.Point(589, 209);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(100, 23);
            this.btn_del_all.TabIndex = 8;
            this.btn_del_all.Text = "DELETE ALL";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Exam Details...";
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_del_all);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_sub);
            this.Controls.Add(this.cmb_sub);
            this.Controls.Add(this.txt_exam);
            this.Controls.Add(this.dgv_exam);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_exam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_exam;
        private System.Windows.Forms.TextBox txt_exam;
        private System.Windows.Forms.ComboBox cmb_sub;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_del_all;
        private System.Windows.Forms.Label label1;
    }
}