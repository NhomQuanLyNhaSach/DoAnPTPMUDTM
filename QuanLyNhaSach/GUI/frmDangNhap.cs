using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!");
                txtPassword.Focus();
                return;
            }
            string tenDangNhap = txtUserName.Text;
            string matKhau = txtPassword.Text;

            NhanVien nv = nvbll.LayNhanVienDangNhap(tenDangNhap, matKhau);
            if (nv == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                return;
            }
            if (!nv.HoatDong.Value)
            {
                MessageBox.Show("Tài khoản đã ngừng hoạt động!");
                return;
            }
            frmHome f = new frmHome(nv.Id, nv.HoTen, nv.TenDangNhap, nv.MatKhau, nv.Email, nv.SDT, nv.DiaChi, nv.HoatDong.Value);
            this.Hide();
            f.ShowDialog();
        }

        private void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LblQuenMK_Click(object sender, EventArgs e)
        {
            //frmQuenMatKhau f = new frmQuenMatKhau();
            //f.ShowDialog();
        }

        private void ChkAnHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
