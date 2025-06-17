namespace UnicomTIC_Management_System.DashBoardForm
{
    partial class StudentMarkForm
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
            this.dvg_viewmarks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_viewmarks)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_viewmarks
            // 
            this.dvg_viewmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_viewmarks.Location = new System.Drawing.Point(76, 108);
            this.dvg_viewmarks.Name = "dvg_viewmarks";
            this.dvg_viewmarks.Size = new System.Drawing.Size(489, 267);
            this.dvg_viewmarks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Student";
            // 
            // StudentMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvg_viewmarks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMarkForm";
            this.Text = "StudentMarkForm";
            this.Load += new System.EventHandler(this.StudentMarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_viewmarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvg_viewmarks;
        private System.Windows.Forms.Label label1;
    }
}