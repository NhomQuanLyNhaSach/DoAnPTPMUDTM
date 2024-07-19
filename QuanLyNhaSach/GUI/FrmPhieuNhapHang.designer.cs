namespace GUI
{
    partial class FrmPhieuNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnthem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongTien = new Usercontrols.txtChiNhapSo();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPN = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(16, 294);
            this.dgvPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(1035, 245);
            this.dgvPhieuNhap.TabIndex = 0;
            this.dgvPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthem,
            this.btnXoa,
            this.btnSua});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnthem
            // 
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(58, 24);
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 24);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày Nhập:";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNhap.Location = new System.Drawing.Point(212, 135);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(319, 29);
            this.dtNgayNhap.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng Tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(677, 138);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(236, 29);
            this.txtTongTien.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nhà Cung Cấp:";
            // 
            // cbbNV
            // 
            this.cbbNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(212, 206);
            this.cbbNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(319, 32);
            this.cbbNV.TabIndex = 17;
            // 
            // cbbNCC
            // 
            this.cbbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(723, 206);
            this.cbbNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(191, 32);
            this.cbbNCC.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mã Phiếu Nhập:";
            // 
            // lbPN
            // 
            this.lbPN.AutoSize = true;
            this.lbPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPN.Location = new System.Drawing.Point(264, 74);
            this.lbPN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPN.Name = "lbPN";
            this.lbPN.Size = new System.Drawing.Size(0, 24);
            this.lbPN.TabIndex = 20;
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(517, 70);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(396, 29);
            this.txtTK.TabIndex = 22;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(411, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tìm Kiếm:";
            // 
            // FrmPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbPN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.cbbNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPhieuNhapHang";
            this.Text = "FrmPhieuNhapHang";
            this.Load += new System.EventHandler(this.FrmPhieuNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnthem;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Label label1;
        private Usercontrols.txtChiNhapSo txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPN;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label8;
    }
}