using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHome : Form
    {
        public bool isExit = true;
        string manv = "", hoten = "", gioitinh = "", diachi = "", ngaysinh = "", email = "", tendangnhap = "", matkhau = "", quyen = "";

        public string Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public string Email { get => email; set => email = value; }

        public frmHome(string manv, string hoten, string gioitinh, string diachi, string ngaysinh, string email, string tendangnhap, string matkhau, string quyen)
        {
            InitializeComponent();
            this.Manv = manv;
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Ngaysinh = ngaysinh;
            this.Email = email;
            this.Tendangnhap = tendangnhap;
            this.Matkhau = matkhau;
            this.Quyen = quyen;
        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.No)
                    e.Cancel = true;
            }
        }


        private void FrmHome_Load(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text = this.Hoten;
            lblQuyen.Text += this.Quyen;
        }

        private void PicDangXuat_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Bạn có muốn đăng xuất không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isExit = false;
                this.Hide();
                frmDangNhap f = new frmDangNhap();
                f.ShowDialog();
            }
            
        }

        private void BtnQLSach_Click(object sender, EventArgs e)
        {
            //frmQLSach f = new frmQLSach();
            //OpenChildForm(f);
            //lblTieuDe.Text = btnQLSach.Text;
        }

        private void BtnQLDocGia_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmQLDocGia());
            //lblTieuDe.Text = btnQLDocGia.Text;
        }

        private void BtnQLMuonTra_Click(object sender, EventArgs e)
        {
            //frmQLMuonTra f = new frmQLMuonTra();
            //f.Hoten = Hoten;
            //OpenChildForm(f);
            //lblTieuDe.Text = btnQLMuonTra.Text;
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmReport());
            //lblTieuDe.Text = btnThongKe.Text;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            //if (Quyen != "Quản lý")
            //{
            //    MessageBox.Show("Bạn không có quyền truy cập");
            //    return;
            //}
            //OpenChildForm(new frmAdmin());
            //lblTieuDe.Text = btnAdmin.Text;
        }


        private void PicHome_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lblTieuDe.Text = "TRANG CHỦ QUẢN LÝ THƯ VIỆN";
        }

        
        
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childform);
            panel_body.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
    }
}
