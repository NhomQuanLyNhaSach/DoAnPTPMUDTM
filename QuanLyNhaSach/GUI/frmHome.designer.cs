namespace GUI
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel_left = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnQLMuonTra = new System.Windows.Forms.Button();
            this.btnQLDocGia = new System.Windows.Forms.Button();
            this.btnQLSach = new System.Windows.Forms.Button();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.picDangXuat = new System.Windows.Forms.PictureBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel_left.Controls.Add(this.label2);
            this.panel_left.Controls.Add(this.btnThongKe);
            this.panel_left.Controls.Add(this.btnAdmin);
            this.panel_left.Controls.Add(this.btnQLMuonTra);
            this.panel_left.Controls.Add(this.btnQLDocGia);
            this.panel_left.Controls.Add(this.btnQLSach);
            this.panel_left.Controls.Add(this.picHome);
            this.panel_left.Controls.Add(this.label1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(247, 877);
            this.panel_left.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 827);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designed by Quang Nhat";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThongKe.BackColor = System.Drawing.Color.Teal;
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(3, 541);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(241, 124);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "THỐNG KÊ BÁO CÁO";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(3, 671);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(241, 124);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "QUẢN TRỊ ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnQLMuonTra
            // 
            this.btnQLMuonTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLMuonTra.BackColor = System.Drawing.Color.Gold;
            this.btnQLMuonTra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLMuonTra.ForeColor = System.Drawing.Color.White;
            this.btnQLMuonTra.Location = new System.Drawing.Point(3, 411);
            this.btnQLMuonTra.Name = "btnQLMuonTra";
            this.btnQLMuonTra.Size = new System.Drawing.Size(241, 124);
            this.btnQLMuonTra.TabIndex = 2;
            this.btnQLMuonTra.Text = "QUẢN LÝ MƯỢN TRẢ";
            this.btnQLMuonTra.UseVisualStyleBackColor = false;
            this.btnQLMuonTra.Click += new System.EventHandler(this.BtnQLMuonTra_Click);
            // 
            // btnQLDocGia
            // 
            this.btnQLDocGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQLDocGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDocGia.ForeColor = System.Drawing.Color.White;
            this.btnQLDocGia.Location = new System.Drawing.Point(3, 281);
            this.btnQLDocGia.Name = "btnQLDocGia";
            this.btnQLDocGia.Size = new System.Drawing.Size(241, 124);
            this.btnQLDocGia.TabIndex = 1;
            this.btnQLDocGia.Text = "QUẢN LÝ ĐỘC GIẢ";
            this.btnQLDocGia.UseVisualStyleBackColor = false;
            this.btnQLDocGia.Click += new System.EventHandler(this.BtnQLDocGia_Click);
            // 
            // btnQLSach
            // 
            this.btnQLSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLSach.BackColor = System.Drawing.Color.Tomato;
            this.btnQLSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSach.ForeColor = System.Drawing.Color.White;
            this.btnQLSach.Location = new System.Drawing.Point(3, 151);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Size = new System.Drawing.Size(241, 124);
            this.btnQLSach.TabIndex = 0;
            this.btnQLSach.Text = "QUẢN LÝ SÁCH";
            this.btnQLSach.UseVisualStyleBackColor = false;
            this.btnQLSach.Click += new System.EventHandler(this.BtnQLSach_Click);
            // 
            // picHome
            // 
            this.picHome.Image = global::GUI.Properties.Resources.book_shelf;
            this.picHome.Location = new System.Drawing.Point(37, 12);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(179, 101);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.PicHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC  ";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel_top.Controls.Add(this.picDangXuat);
            this.panel_top.Controls.Add(this.picProfile);
            this.panel_top.Controls.Add(this.lblQuyen);
            this.panel_top.Controls.Add(this.lblTenNguoiDung);
            this.panel_top.Controls.Add(this.lblTieuDe);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(247, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1150, 113);
            this.panel_top.TabIndex = 1;
            // 
            // picDangXuat
            // 
            this.picDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picDangXuat.Image = global::GUI.Properties.Resources.logout1;
            this.picDangXuat.Location = new System.Drawing.Point(1040, 31);
            this.picDangXuat.Name = "picDangXuat";
            this.picDangXuat.Size = new System.Drawing.Size(100, 50);
            this.picDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDangXuat.TabIndex = 4;
            this.picDangXuat.TabStop = false;
            this.picDangXuat.Click += new System.EventHandler(this.PicDangXuat_Click);
            // 
            // picProfile
            // 
            this.picProfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picProfile.Image = global::GUI.Properties.Resources.profile;
            this.picProfile.Location = new System.Drawing.Point(759, 31);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(100, 50);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 3;
            this.picProfile.TabStop = false;
            // 
            // lblQuyen
            // 
            this.lblQuyen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.ForeColor = System.Drawing.Color.White;
            this.lblQuyen.Location = new System.Drawing.Point(865, 64);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(92, 23);
            this.lblQuyen.TabIndex = 2;
            this.lblQuyen.Text = "Chức vụ: ";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.White;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(865, 31);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(141, 23);
            this.lblTenNguoiDung.TabIndex = 1;
            this.lblTenNguoiDung.Text = "Tên người dùng";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(204, 40);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(462, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "TRANG CHỦ QUẢN LÝ THƯ VIỆN";
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.pictureBox3);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(247, 113);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1150, 764);
            this.panel_body.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::GUI.Properties.Resources.ThuVien20ty;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1150, 764);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 877);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHome_FormClosed);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnQLMuonTra;
        private System.Windows.Forms.Button btnQLDocGia;
        private System.Windows.Forms.Button btnQLSach;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picDangXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
    }
}