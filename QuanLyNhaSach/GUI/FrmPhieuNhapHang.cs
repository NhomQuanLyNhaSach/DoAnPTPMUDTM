using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FrmPhieuNhapHang : Form
    {
        PhieuNhapHangBLL pn = new PhieuNhapHangBLL();
        NhanVienBLL nv = new NhanVienBLL();
        NhaCungCapBLL ncc = new NhaCungCapBLL();

        public FrmPhieuNhapHang()
        {
            InitializeComponent();
        }

        private void FrmPhieuNhapHang_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = pn.LayTatCaPhieuNhap();
            //dgvKhachHang.Columns["TenDangNhap"].Visible = false;
            //dgvKhachHang.Columns["MatKhau"].Visible = false;
            dgvPhieuNhap.Columns["MaPhieuNhap"].Visible = false;
            dgvPhieuNhap.Columns["MaNCC"].Visible = false;
            dgvPhieuNhap.Columns["MaNV"].Visible = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cbbNCC.DataSource = ncc.LayTatCaNhaCungCap();
            cbbNCC.DisplayMember = "HoTen";
            cbbNCC.ValueMember = "Id";
            cbbNV.DataSource = nv.LayTatCaNhanVienKho();
            cbbNV.DisplayMember = "HoTen";
            cbbNV.ValueMember = "Id";
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
                lbPN.Text = row.Cells["MaPhieuNhap"].Value.ToString();
                DateTime.TryParse(row.Cells["NgayNhap"].Value?.ToString(), out DateTime ngayNhap);
                dtNgayNhap.Value = ngayNhap;
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                cbbNCC.SelectedValue = row.Cells["MaNCC"].Value;
                cbbNV.SelectedValue = row.Cells["MaNV"].Value;


                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnthem.Enabled = false;
                
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (dtNgayNhap.Value == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng chọn ngày nhập hợp lệ");
            }
            else if (cbbNCC.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp");
            }
            else if (cbbNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên");
            }
            else if (string.IsNullOrWhiteSpace(txtTongTien.Text) || !int.TryParse(txtTongTien.Text, out int tongTien)) // Kiểm tra Tổng tiền có giá trị hợp lệ hay không
            {
                MessageBox.Show("Vui lòng nhập giá trị tổng tiền hợp lệ");
            }
            else
            {
                PhieuNhapSach a = new PhieuNhapSach();
                a.NgayNhap = dtNgayNhap.Value;
                a.Id_NCC = (int)cbbNCC.SelectedValue;
                a.Id_NV= (int)cbbNV.SelectedValue;
                a.TongTien = int.Parse(txtTongTien.Text);

                pn.ThemPhieuNhap(a);

                FrmPhieuNhapHang_Load(sender, e);

                lbPN.Text = "";
                cbbNCC.SelectedIndex = -1;
                cbbNV.SelectedIndex = -1;
                txtTongTien.Text = "";
                dtNgayNhap.Value = DateTime.Now;

                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnthem.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int mapn = int.Parse(lbPN.Text);
            pn.XoaPhieuNhap(mapn);
            FrmPhieuNhapHang_Load(sender, e);

            lbPN.Text = "";
            cbbNCC.SelectedIndex = -1;
            cbbNV.SelectedIndex = -1;
            txtTongTien.Text = "";
            dtNgayNhap.Value = DateTime.Now;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnthem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int mapn = int.Parse(lbPN.Text);
            int mancc = (int)cbbNCC.SelectedValue;
            int manv = (int)cbbNV.SelectedValue;
            int tt = int.Parse(txtTongTien.Text);
            DateTime nn = dtNgayNhap.Value;

            pn.SuaPhieuNhap(mapn, mancc, manv, tt, nn);

            FrmPhieuNhapHang_Load(sender, e);

            lbPN.Text = "";
            cbbNCC.SelectedIndex = -1; 
            cbbNV.SelectedIndex = -1;  
            txtTongTien.Text = "";
            dtNgayNhap.Value = DateTime.Now;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnthem.Enabled = true;

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTK.Text;

            dgvPhieuNhap.DataSource = pn.TimKiemPhieuNhap(tuKhoa);
            dgvPhieuNhap.Columns["MaPhieuNhap"].Visible = false;
            dgvPhieuNhap.Columns["MaNCC"].Visible = false;
            dgvPhieuNhap.Columns["MaNV"].Visible = false;
        }
    }
}
