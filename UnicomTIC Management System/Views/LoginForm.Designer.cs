namespace UnicomTIC_Management_System.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblrole = new System.Windows.Forms.Label();
            this.lblu_name = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.chebox_pass = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Location = new System.Drawing.Point(176, 211);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(32, 13);
            this.lblrole.TabIndex = 0;
            this.lblrole.Text = "Role:";
            // 
            // lblu_name
            // 
            this.lblu_name.AutoSize = true;
            this.lblu_name.Location = new System.Drawing.Point(176, 262);
            this.lblu_name.Name = "lblu_name";
            this.lblu_name.Size = new System.Drawing.Size(63, 13);
            this.lblu_name.TabIndex = 1;
            this.lblu_name.Text = "User Name:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(275, 308);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(208, 20);
            this.txt_pass.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(275, 259);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(208, 20);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(176, 311);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(56, 13);
            this.lblpass.TabIndex = 4;
            this.lblpass.Text = "Password:";
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(275, 208);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(208, 21);
            this.comboBox_role.TabIndex = 5;
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(147, 386);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(139, 26);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login ";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // chebox_pass
            // 
            this.chebox_pass.AutoSize = true;
            this.chebox_pass.Location = new System.Drawing.Point(404, 334);
            this.chebox_pass.Name = "chebox_pass";
            this.chebox_pass.Size = new System.Drawing.Size(102, 17);
            this.chebox_pass.TabIndex = 7;
            this.chebox_pass.Text = "Show Password";
            this.chebox_pass.UseVisualStyleBackColor = true;
            this.chebox_pass.CheckedChanged += new System.EventHandler(this.chebox_pass_CheckedChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(362, 386);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(157, 26);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 138);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.chebox_pass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lblu_name);
            this.Controls.Add(this.lblrole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Label lblu_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox chebox_pass;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}