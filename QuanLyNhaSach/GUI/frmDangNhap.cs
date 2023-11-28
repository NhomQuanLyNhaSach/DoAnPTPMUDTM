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

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            //if(txtUserName.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
            //    txtUserName.Focus();
            //    return;
            //}
            //if (txtPassword.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập mật khẩu!");
            //    txtPassword.Focus();
            //    return;
            //}
            //string sql = "select * from NHANVIEN where TENDANGNHAP = '" + txtUserName.Text + "' and MATKHAU = '" + txtPassword.Text + "'";
            //int kq = dbcon.execute_NonQuery(sql);
            //DataTable dt = dbcon.getDataTable(sql, "tblNHANVIEN");
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    frmHome f = new frmHome(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(),
            //                            dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), 
            //                            dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), 
            //                            dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(),
            //                            dt.Rows[0][8].ToString());
            //    this.Hide();
            //    f.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtUserName.Focus();
            //}

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
