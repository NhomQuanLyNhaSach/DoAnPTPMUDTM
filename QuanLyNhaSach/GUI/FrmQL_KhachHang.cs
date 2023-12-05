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
    public partial class FrmQL_KhachHang : Form
    {
        KhachHangBLL kh = new KhachHangBLL();
        public FrmQL_KhachHang()
        {
            InitializeComponent();
        }

        private void FrmQL_KhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = kh.LayTatKhachHang();
            dgvKhachHang.Columns["TenDangNhap"].Visible = false;
            dgvKhachHang.Columns["MatKhau"].Visible = false;
            dgvKhachHang.Columns["Id"].Visible = false;
            dgvKhachHang.Columns["DaXoa"].Visible = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Resettxt()
        {
            lbMaKH.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
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
                KhachHang a = new KhachHang();
                a.HoTen = txtHoTen.Text;
                a.TenDangNhap = txtTenDangNhap.Text;
                a.MatKhau = txtMatKhau.Text;
                a.Email = txtEmail.Text;
                a.SDT = txtSDT.Text;
                a.DiaChi = txtDiaChi.Text;
                a.DaXoa = false;

                kh.ThemKhachHang(a);
                FrmQL_KhachHang_Load(sender, e);
                txtTenDangNhap.Text ="";
                txtMatKhau.Text = "";
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(lbMaKH.Text);
            kh.XoaKhachHang(makh);
            FrmQL_KhachHang_Load(sender, e);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnthem.Enabled = true;
            txtTenDangNhap.Enabled = true;
            txtMatKhau.Enabled = true;
            Resettxt();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int makh = int.Parse(lbMaKH.Text);
            string hoten = txtHoTen.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            kh.SuaThongTinKhachHang(makh,hoten,email,sdt,diachi);

            FrmQL_KhachHang_Load(sender,e);

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

            dgvKhachHang.DataSource = kh.TimKiemKhachHang(tuKhoa);
        }
    }
}
