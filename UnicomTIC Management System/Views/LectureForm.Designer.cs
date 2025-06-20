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
            this.btn_del_all = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lecture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lename
            // 
            this.lbl_lename.AutoSize = true;
            this.lbl_lename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lename.Location = new System.Drawing.Point(237, 97);
            this.lbl_lename.Name = "lbl_lename";
            this.lbl_lename.Size = new System.Drawing.Size(47, 16);
            this.lbl_lename.TabIndex = 0;
            this.lbl_lename.Text = "Name:";
            // 
            // lbl_lec_add
            // 
            this.lbl_lec_add.AutoSize = true;
            this.lbl_lec_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lec_add.Location = new System.Drawing.Point(237, 146);
            this.lbl_lec_add.Name = "lbl_lec_add";
            this.lbl_lec_add.Size = new System.Drawing.Size(61, 16);
            this.lbl_lec_add.TabIndex = 1;
            this.lbl_lec_add.Text = "Address:";
            // 
            // btn_lec_add
            // 
            this.btn_lec_add.Location = new System.Drawing.Point(133, 208);
            this.btn_lec_add.Name = "btn_lec_add";
            this.btn_lec_add.Size = new System.Drawing.Size(106, 23);
            this.btn_lec_add.TabIndex = 2;
            this.btn_lec_add.Text = "ADD";
            this.btn_lec_add.UseVisualStyleBackColor = true;
            this.btn_lec_add.Click += new System.EventHandler(this.btn_lec_add_Click);
            // 
            // btn_lec_update
            // 
            this.btn_lec_update.Location = new System.Drawing.Point(301, 208);
            this.btn_lec_update.Name = "btn_lec_update";
            this.btn_lec_update.Size = new System.Drawing.Size(106, 23);
            this.btn_lec_update.TabIndex = 3;
            this.btn_lec_update.Text = "UPDATE";
            this.btn_lec_update.UseVisualStyleBackColor = true;
            this.btn_lec_update.Click += new System.EventHandler(this.btn_lec_update_Click);
            // 
            // btn_lec_delete
            // 
            this.btn_lec_delete.Location = new System.Drawing.Point(470, 208);
            this.btn_lec_delete.Name = "btn_lec_delete";
            this.btn_lec_delete.Size = new System.Drawing.Size(106, 23);
            this.btn_lec_delete.TabIndex = 4;
            this.btn_lec_delete.Text = "DELETE";
            this.btn_lec_delete.UseVisualStyleBackColor = true;
            this.btn_lec_delete.Click += new System.EventHandler(this.btn_lec_delete_Click);
            // 
            // txt_lec_name
            // 
            this.txt_lec_name.Location = new System.Drawing.Point(366, 97);
            this.txt_lec_name.Name = "txt_lec_name";
            this.txt_lec_name.Size = new System.Drawing.Size(174, 20);
            this.txt_lec_name.TabIndex = 5;
            // 
            // txt_lec_add
            // 
            this.txt_lec_add.Location = new System.Drawing.Point(366, 143);
            this.txt_lec_add.Name = "txt_lec_add";
            this.txt_lec_add.Size = new System.Drawing.Size(174, 20);
            this.txt_lec_add.TabIndex = 6;
            // 
            // dgv_lecture
            // 
            this.dgv_lecture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lecture.Location = new System.Drawing.Point(176, 282);
            this.dgv_lecture.Name = "dgv_lecture";
            this.dgv_lecture.Size = new System.Drawing.Size(431, 205);
            this.dgv_lecture.TabIndex = 7;
            this.dgv_lecture.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lecture_CellContentClick_1);
            // 
            // btn_del_all
            // 
            this.btn_del_all.Location = new System.Drawing.Point(627, 208);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(106, 23);
            this.btn_del_all.TabIndex = 8;
            this.btn_del_all.Text = "DELETE ALL";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lecture Details...";
            // 
            // LectureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_del_all);
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
        private System.Windows.Forms.Button btn_del_all;
        private System.Windows.Forms.Label label1;
    }
}