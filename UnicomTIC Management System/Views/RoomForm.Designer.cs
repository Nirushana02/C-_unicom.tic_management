namespace UnicomTIC_Management_System.Views
{
    partial class RoomForm
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_rname = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.dgv_room = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_del_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(73, 71);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(69, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Room Name:";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(402, 70);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(65, 13);
            this.lbl_type.TabIndex = 1;
            this.lbl_type.Text = "Room Type:";
            // 
            // txt_rname
            // 
            this.txt_rname.Location = new System.Drawing.Point(148, 68);
            this.txt_rname.Name = "txt_rname";
            this.txt_rname.Size = new System.Drawing.Size(159, 20);
            this.txt_rname.TabIndex = 2;
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(473, 67);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(163, 21);
            this.cmb_type.TabIndex = 3;
            // 
            // dgv_room
            // 
            this.dgv_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_room.Location = new System.Drawing.Point(136, 184);
            this.dgv_room.Name = "dgv_room";
            this.dgv_room.Size = new System.Drawing.Size(363, 190);
            this.dgv_room.TabIndex = 4;
            this.dgv_room.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_room_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(118, 131);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(254, 131);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(381, 131);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_del_all
            // 
            this.btn_del_all.Location = new System.Drawing.Point(502, 131);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(86, 23);
            this.btn_del_all.TabIndex = 8;
            this.btn_del_all.Text = "DELETE ALL";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 447);
            this.Controls.Add(this.btn_del_all);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_room);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.txt_rname);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox txt_rname;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.DataGridView dgv_room;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_del_all;
    }
}