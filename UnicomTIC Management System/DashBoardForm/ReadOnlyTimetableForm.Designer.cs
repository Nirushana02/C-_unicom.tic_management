namespace UnicomTIC_Management_System.DashBoardForm
{
    partial class ReadOnlyTimetableForm
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
            this.dgv_timetable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_timetable
            // 
            this.dgv_timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_timetable.Location = new System.Drawing.Point(59, 110);
            this.dgv_timetable.Name = "dgv_timetable";
            this.dgv_timetable.Size = new System.Drawing.Size(517, 295);
            this.dgv_timetable.TabIndex = 0;
            // 
            // ReadOnlyTimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 457);
            this.Controls.Add(this.dgv_timetable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReadOnlyTimetableForm";
            this.Text = "ReadOnlyTimetableForm";
            this.Load += new System.EventHandler(this.ReadOnlyTimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_timetable;
    }
}