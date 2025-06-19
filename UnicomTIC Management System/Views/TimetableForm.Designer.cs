namespace UnicomTIC_Management_System.Views
{
    partial class TimetableForm
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
            this.combo_room = new System.Windows.Forms.ComboBox();
            this.combo_sbu = new System.Windows.Forms.ComboBox();
            this.lbl_sub = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_room = new System.Windows.Forms.Label();
            this.dgv_timetable = new System.Windows.Forms.DataGridView();
            this.txt_time = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(43, 227);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(166, 227);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(288, 227);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // combo_room
            // 
            this.combo_room.FormattingEnabled = true;
            this.combo_room.Location = new System.Drawing.Point(156, 173);
            this.combo_room.Name = "combo_room";
            this.combo_room.Size = new System.Drawing.Size(183, 21);
            this.combo_room.TabIndex = 3;
            // 
            // combo_sbu
            // 
            this.combo_sbu.FormattingEnabled = true;
            this.combo_sbu.Items.AddRange(new object[] {
            "ICT",
            "Java",
            "JavaScript"});
            this.combo_sbu.Location = new System.Drawing.Point(156, 88);
            this.combo_sbu.Name = "combo_sbu";
            this.combo_sbu.Size = new System.Drawing.Size(183, 21);
            this.combo_sbu.TabIndex = 4;
            // 
            // lbl_sub
            // 
            this.lbl_sub.AutoSize = true;
            this.lbl_sub.Location = new System.Drawing.Point(54, 91);
            this.lbl_sub.Name = "lbl_sub";
            this.lbl_sub.Size = new System.Drawing.Size(76, 13);
            this.lbl_sub.TabIndex = 5;
            this.lbl_sub.Text = "Select Subject";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(54, 129);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(51, 13);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "Time Slot";
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.Location = new System.Drawing.Point(54, 173);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(35, 13);
            this.lbl_room.TabIndex = 7;
            this.lbl_room.Text = "Room";
            // 
            // dgv_timetable
            // 
            this.dgv_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_timetable.Location = new System.Drawing.Point(398, 78);
            this.dgv_timetable.Name = "dgv_timetable";
            this.dgv_timetable.Size = new System.Drawing.Size(266, 289);
            this.dgv_timetable.TabIndex = 8;
            this.dgv_timetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_timetable_CellContentClick);
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(156, 129);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(183, 20);
            this.txt_time.TabIndex = 9;
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 447);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.dgv_timetable);
            this.Controls.Add(this.lbl_room);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_sub);
            this.Controls.Add(this.combo_sbu);
            this.Controls.Add(this.combo_room);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            this.Load += new System.EventHandler(this.TimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox combo_room;
        private System.Windows.Forms.ComboBox combo_sbu;
        private System.Windows.Forms.Label lbl_sub;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.DataGridView dgv_timetable;
        private System.Windows.Forms.TextBox txt_time;
    }
}