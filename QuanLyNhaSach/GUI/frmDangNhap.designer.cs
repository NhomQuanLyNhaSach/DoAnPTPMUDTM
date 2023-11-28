namespace GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblQuenMK = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkAnHienPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(126, 303);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(275, 21);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(118, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Black;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(160, 455);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(174, 41);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(91, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 1);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(91, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 1);
            this.panel2.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(126, 377);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.AutoSize = true;
            this.lblQuenMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMK.ForeColor = System.Drawing.Color.Black;
            this.lblQuenMK.Location = new System.Drawing.Point(267, 412);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(134, 22);
            this.lblQuenMK.TabIndex = 6;
            this.lblQuenMK.Text = "Quên mật khẩu?";
            this.lblQuenMK.Click += new System.EventHandler(this.LblQuenMK_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(150, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(91, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 367);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // chkAnHienPass
            // 
            this.chkAnHienPass.AutoSize = true;
            this.chkAnHienPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnHienPass.Location = new System.Drawing.Point(91, 411);
            this.chkAnHienPass.Name = "chkAnHienPass";
            this.chkAnHienPass.Size = new System.Drawing.Size(144, 26);
            this.chkAnHienPass.TabIndex = 10;
            this.chkAnHienPass.Text = "Hiện mật khẩu";
            this.chkAnHienPass.UseVisualStyleBackColor = true;
            this.chkAnHienPass.CheckedChanged += new System.EventHandler(this.ChkAnHienPass_CheckedChanged);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.chkAnHienPass);
            this.Controls.Add(this.lblQuenMK);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblQuenMK;
        private System.Windows.Forms.CheckBox chkAnHienPass;
    }
}

