namespace UnicomTIC_Management_System.Views
{
    partial class LectureForm
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
            this.lbl_lename = new System.Windows.Forms.Label();
            this.lbl_lec_add = new System.Windows.Forms.Label();
            this.btn_lec_add = new System.Windows.Forms.Button();
            this.btn_lec_update = new System.Windows.Forms.Button();
            this.btn_lec_delete = new System.Windows.Forms.Button();
            this.txt_lec_name = new System.Windows.Forms.TextBox();
            this.txt_lec_add = new System.Windows.Forms.TextBox();
            this.dgv_lecture = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lecture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lename
            // 
            this.lbl_lename.AutoSize = true;
            this.lbl_lename.Location = new System.Drawing.Point(68, 77);
            this.lbl_lename.Name = "lbl_lename";
            this.lbl_lename.Size = new System.Drawing.Size(38, 13);
            this.lbl_lename.TabIndex = 0;
            this.lbl_lename.Text = "Name:";
            // 
            // lbl_lec_add
            // 
            this.lbl_lec_add.AutoSize = true;
            this.lbl_lec_add.Location = new System.Drawing.Point(68, 127);
            this.lbl_lec_add.Name = "lbl_lec_add";
            this.lbl_lec_add.Size = new System.Drawing.Size(45, 13);
            this.lbl_lec_add.TabIndex = 1;
            this.lbl_lec_add.Text = "Address";
            // 
            // btn_lec_add
            // 
            this.btn_lec_add.Location = new System.Drawing.Point(71, 181);
            this.btn_lec_add.Name = "btn_lec_add";
            this.btn_lec_add.Size = new System.Drawing.Size(75, 23);
            this.btn_lec_add.TabIndex = 2;
            this.btn_lec_add.Text = "ADD";
            this.btn_lec_add.UseVisualStyleBackColor = true;
            this.btn_lec_add.Click += new System.EventHandler(this.btn_lec_add_Click);
            // 
            // btn_lec_update
            // 
            this.btn_lec_update.Location = new System.Drawing.Point(165, 181);
            this.btn_lec_update.Name = "btn_lec_update";
            this.btn_lec_update.Size = new System.Drawing.Size(75, 23);
            this.btn_lec_update.TabIndex = 3;
            this.btn_lec_update.Text = "UPDATE";
            this.btn_lec_update.UseVisualStyleBackColor = true;
            this.btn_lec_update.Click += new System.EventHandler(this.btn_lec_update_Click);
            // 
            // btn_lec_delete
            // 
            this.btn_lec_delete.Location = new System.Drawing.Point(260, 181);
            this.btn_lec_delete.Name = "btn_lec_delete";
            this.btn_lec_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_lec_delete.TabIndex = 4;
            this.btn_lec_delete.Text = "DELETE";
            this.btn_lec_delete.UseVisualStyleBackColor = true;
            this.btn_lec_delete.Click += new System.EventHandler(this.btn_lec_delete_Click);
            // 
            // txt_lec_name
            // 
            this.txt_lec_name.Location = new System.Drawing.Point(147, 77);
            this.txt_lec_name.Name = "txt_lec_name";
            this.txt_lec_name.Size = new System.Drawing.Size(174, 20);
            this.txt_lec_name.TabIndex = 5;
            // 
            // txt_lec_add
            // 
            this.txt_lec_add.Location = new System.Drawing.Point(147, 124);
            this.txt_lec_add.Name = "txt_lec_add";
            this.txt_lec_add.Size = new System.Drawing.Size(174, 20);
            this.txt_lec_add.TabIndex = 6;
            // 
            // dgv_lecture
            // 
            this.dgv_lecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lecture.Location = new System.Drawing.Point(71, 223);
            this.dgv_lecture.Name = "dgv_lecture";
            this.dgv_lecture.Size = new System.Drawing.Size(314, 200);
            this.dgv_lecture.TabIndex = 7;
            this.dgv_lecture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lecture_CellContentClick_1);
            // 
            // LectureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 447);
            this.Controls.Add(this.dgv_lecture);
            this.Controls.Add(this.txt_lec_add);
            this.Controls.Add(this.txt_lec_name);
            this.Controls.Add(this.btn_lec_delete);
            this.Controls.Add(this.btn_lec_update);
            this.Controls.Add(this.btn_lec_add);
            this.Controls.Add(this.lbl_lec_add);
            this.Controls.Add(this.lbl_lename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LectureForm";
            this.Text = "LectureForm";
            this.Load += new System.EventHandler(this.LectureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lecture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lename;
        private System.Windows.Forms.Label lbl_lec_add;
        private System.Windows.Forms.Button btn_lec_add;
        private System.Windows.Forms.Button btn_lec_update;
        private System.Windows.Forms.Button btn_lec_delete;
        private System.Windows.Forms.TextBox txt_lec_name;
        private System.Windows.Forms.TextBox txt_lec_add;
        private System.Windows.Forms.DataGridView dgv_lecture;
    }
}