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
            this.btnPhieuNhapHang = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnQLDonHang = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLSach = new System.Windows.Forms.Button();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.picDangXuat = new System.Windows.Forms.PictureBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel_left.Controls.Add(this.label2);
            this.panel_left.Controls.Add(this.btnThongKe);
            this.panel_left.Controls.Add(this.btnPhieuNhapHang);
            this.panel_left.Controls.Add(this.btnAdmin);
            this.panel_left.Controls.Add(this.btnQLDonHang);
            this.panel_left.Controls.Add(this.btnQLKH);
            this.panel_left.Controls.Add(this.btnQLSach);
            this.panel_left.Controls.Add(this.picHome);
            this.panel_left.Controls.Add(this.label1);
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(247, 877);
            this.panel_left.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 828);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designed by Quang Nhat";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThongKe.BackColor = System.Drawing.Color.Teal;
            this.btnThongKe.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(3, 586);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(241, 102);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Tag = "5";
            this.btnThongKe.Text = "THỐNG KÊ BÁO CÁO";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPhieuNhapHang
            // 
            this.btnPhieuNhapHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPhieuNhapHang.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPhieuNhapHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnPhieuNhapHang.Location = new System.Drawing.Point(3, 478);
            this.btnPhieuNhapHang.Name = "btnPhieuNhapHang";
            this.btnPhieuNhapHang.Size = new System.Drawing.Size(241, 102);
            this.btnPhieuNhapHang.TabIndex = 3;
            this.btnPhieuNhapHang.Tag = "4";
            this.btnPhieuNhapHang.Text = "PHIẾU NHẬP HÀNG";
            this.btnPhieuNhapHang.UseVisualStyleBackColor = false;
            this.btnPhieuNhapHang.Click += new System.EventHandler(this.BtnPhieuNhapHang_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(3, 694);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(241, 102);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Tag = "6";
            this.btnAdmin.Text = "QUẢN TRỊ ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click_1);
            // 
            // btnQLDonHang
            // 
            this.btnQLDonHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLDonHang.BackColor = System.Drawing.Color.Gold;
            this.btnQLDonHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDonHang.ForeColor = System.Drawing.Color.White;
            this.btnQLDonHang.Location = new System.Drawing.Point(3, 370);
            this.btnQLDonHang.Name = "btnQLDonHang";
            this.btnQLDonHang.Size = new System.Drawing.Size(241, 102);
            this.btnQLDonHang.TabIndex = 2;
            this.btnQLDonHang.Tag = "3";
            this.btnQLDonHang.Text = "QUẢN LÝ ĐƠN HÀNG";
            this.btnQLDonHang.UseVisualStyleBackColor = false;
            this.btnQLDonHang.Click += new System.EventHandler(this.BtnQLMuonTra_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQLKH.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.ForeColor = System.Drawing.Color.White;
            this.btnQLKH.Location = new System.Drawing.Point(3, 262);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(241, 102);
            this.btnQLKH.TabIndex = 1;
            this.btnQLKH.Tag = "2";
            this.btnQLKH.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.btnQLKH.UseVisualStyleBackColor = false;
            this.btnQLKH.Click += new System.EventHandler(this.BtnQLDocGia_Click);
            // 
            // btnQLSach
            // 
            this.btnQLSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLSach.BackColor = System.Drawing.Color.Tomato;
            this.btnQLSach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSach.ForeColor = System.Drawing.Color.White;
            this.btnQLSach.Location = new System.Drawing.Point(3, 154);
            this.btnQLSach.Name = "btnQLSach";
            this.btnQLSach.Size = new System.Drawing.Size(241, 102);
            this.btnQLSach.TabIndex = 0;
            this.btnQLSach.Tag = "1";
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
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC  ";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel_top.Controls.Add(this.panel_left);
            this.panel_top.Controls.Add(this.picDangXuat);
            this.panel_top.Controls.Add(this.picProfile);
            this.panel_top.Controls.Add(this.lblEmail);
            this.panel_top.Controls.Add(this.lblTenNguoiDung);
            this.panel_top.Controls.Add(this.lblTieuDe);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1397, 113);
            this.panel_top.TabIndex = 1;
            // 
            // picDangXuat
            // 
            this.picDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picDangXuat.Image = global::GUI.Properties.Resources.logout1;
            this.picDangXuat.Location = new System.Drawing.Point(1287, 31);
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
            this.picProfile.Location = new System.Drawing.Point(941, 31);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(100, 50);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 3;
            this.picProfile.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(1047, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email: ";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.White;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(1047, 31);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(169, 24);
            this.lblTenNguoiDung.TabIndex = 1;
            this.lblTenNguoiDung.Text = "Tên người dùng";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(358, 31);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(473, 34);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "TRANG CHỦ QUẢN LÝ NHÀ SÁCH";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::GUI.Properties.Resources.ThuVien20ty;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1151, 771);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 768);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "DANH MỤC  ";
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.BackColor = System.Drawing.Color.Tomato;
            this.button6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(3, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(241, 102);
            this.button6.TabIndex = 0;
            this.button6.Tag = "1";
            this.button6.Text = "QUẢN LÝ SÁCH";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.BtnQLSach_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 102);
            this.button5.TabIndex = 1;
            this.button5.Tag = "2";
            this.button5.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.BtnQLDocGia_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 102);
            this.button4.TabIndex = 2;
            this.button4.Tag = "3";
            this.button4.Text = "QUẢN LÝ ĐƠN HÀNG";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnQLMuonTra_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 581);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 102);
            this.button3.TabIndex = 3;
            this.button3.Tag = "6";
            this.button3.Text = "QUẢN TRỊ ADMIN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtnAdmin_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 102);
            this.button2.TabIndex = 3;
            this.button2.Tag = "4";
            this.button2.Text = "PHIẾU NHẬP HÀNG";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnPhieuNhapHang_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 102);
            this.button1.TabIndex = 3;
            this.button1.Tag = "5";
            this.button1.Text = "THỐNG KÊ BÁO CÁO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 715);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Designed by Quang Nhat";
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.Controls.Add(this.pictureBox3);
            this.panel_body.Location = new System.Drawing.Point(246, 113);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1151, 771);
            this.panel_body.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 878);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sách";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnQLDonHang;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLSach;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.PictureBox picDangXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnPhieuNhapHang;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_body;
    }
}