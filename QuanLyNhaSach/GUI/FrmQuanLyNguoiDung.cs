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
    public partial class FrmQuanLyNguoiDung : Form
    {
        NhanVienBLL nv = new NhanVienBLL();
        NhomNhanVienBLL nnv = new NhomNhanVienBLL();
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nv.LayTatCaNhanVien();
            dgvNhanVien.Columns["TenDangNhap"].Visible = false;
            dgvNhanVien.Columns["MatKhau"].Visible = false;
            dgvNhanVien.Columns["Id"].Visible = false;
            dgvNhanVien.Columns["HoatDong"].Visible = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            cbbLoaiNhanVien.DataSource = nnv.LayTatCaNhomNhanVien();
            cbbLoaiNhanVien.DisplayMember = "TenNhom";
            cbbLoaiNhanVien.ValueMember = "Id";
            cbbLoaiNhanVien.SelectedIndex = -1;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Resettxt()
        {
            lbMaKH.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                lbMaKH.Text = row.Cells["Id"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnthem.Enabled = false;
                txtTenDangNhap.Enabled = false;
                txtMatKhau.Enabled = false;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ kiện");
            }
            else
            {
                NhanVien a = new NhanVien();
                a.HoTen = txtHoTen.Text;
                a.TenDangNhap = txtTenDangNhap.Text;
                a.MatKhau = txtMatKhau.Text;
                a.Email = txtEmail.Text;
                a.SDT = txtSDT.Text;
                a.DiaChi = txtDiaChi.Text;
                a.HoatDong = true;

                nv.ThemNhanVien(a);
                FrmQuanLyNguoiDung_Load(sender, e);
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(lbMaKH.Text);
            nv.XoaNhanVien(manv);
            FrmQuanLyNguoiDung_Load(sender, e);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnthem.Enabled = true;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            Resettxt();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(lbMaKH.Text);
            string hoten = txtHoTen.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            nv.SuaThongTinNhanVien(manv, hoten, email, sdt, diachi);

            FrmQuanLyNguoiDung_Load(sender, e);

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnthem.Enabled = true;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            Resettxt();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTK.Text;

            dgvNhanVien.DataSource = nv.TimKiemNhanVien(tuKhoa);
        }
    }
}
