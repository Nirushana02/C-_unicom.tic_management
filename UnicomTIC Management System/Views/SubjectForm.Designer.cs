namespace UnicomTIC_Management_System.Views
{
    partial class SubjectForm
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb_course = new System.Windows.Forms.ComboBox();
            this.dgv_sub = new System.Windows.Forms.DataGridView();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sub)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(115, 172);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(263, 172);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(93, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(406, 172);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(88, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmb_course
            // 
            this.cmb_course.FormattingEnabled = true;
            this.cmb_course.Location = new System.Drawing.Point(210, 122);
            this.cmb_course.Name = "cmb_course";
            this.cmb_course.Size = new System.Drawing.Size(175, 21);
            this.cmb_course.TabIndex = 3;
            // 
            // dgv_sub
            // 
            this.dgv_sub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sub.Location = new System.Drawing.Point(90, 217);
            this.dgv_sub.Name = "dgv_sub";
            this.dgv_sub.Size = new System.Drawing.Size(440, 202);
            this.dgv_sub.TabIndex = 4;
            this.dgv_sub.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sub_CellContentClick);
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(210, 54);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(175, 20);
            this.txt_sub.TabIndex = 5;
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Location = new System.Drawing.Point(130, 57);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(77, 13);
            this.lbl_sub.TabIndex = 6;
            this.lbl_sub.Text = "Subject Name:";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Location = new System.Drawing.Point(130, 125);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(43, 13);
            this.lbl_course.TabIndex = 7;
            this.lbl_course.Text = "Course:";
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 447);
            this.Controls.Add(this.lbl_course);
            this.Controls.Add(this.lbl_sub);
            this.Controls.Add(this.txt_sub);
            this.Controls.Add(this.dgv_sub);
            this.Controls.Add(this.cmb_course);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_course;
        private System.Windows.Forms.DataGridView dgv_sub;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.Label lbl_course;
    }
}