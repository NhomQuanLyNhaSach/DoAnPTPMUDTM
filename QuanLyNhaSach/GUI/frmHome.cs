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
    public partial class frmHome : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        public bool isExit = true;
        public bool isQuyen = false;
        int manv;
        bool hoatdong;
        string hoten = "", diachi = "", email = "", sdt = "", tendangnhap = "", matkhau = "";

        public int Manv { get => manv; set => manv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public bool Hoatdong { get => hoatdong; set => hoatdong = value; }

        public frmHome(int manv, string hoten, string tendangnhap, string matkhau, string email, string sdt, string diachi, bool hoatdong)
        {
            InitializeComponent();
            this.manv = manv;
            this.hoten = hoten;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.Email = email;
            this.sdt = sdt;
            this.Diachi = diachi;
            this.hoatdong = hoatdong;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int maNV = this.Manv;
            string tag = clickedButton.Tag.ToString();
            int maManHinh = int.Parse(tag);

            bool coQuyen = nvbll.KiemTraQuyen(maNV, maManHinh);

            if (coQuyen)
            {
                isQuyen = coQuyen;
            }
            else
            {
                isQuyen = false;
            }
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
            lblEmail.Text = this.Email;
        }

        private void PicDangXuat_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Bạn có muốn đăng xuất không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isExit = false;
                isQuyen = false;
                this.Hide();
                frmDangNhap f = new frmDangNhap();
                f.ShowDialog();
            }
            
        }

        private void BtnQLSach_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            if (!isQuyen)
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
                return;
            }
            frmQLSach f = new frmQLSach();
            OpenChildForm(f);
            lblTieuDe.Text = btnQLSach.Text;
        }

        private void BtnQLDocGia_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            if (!isQuyen)
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
                return;
            }
            FrmQL_KhachHang f = new FrmQL_KhachHang();
            OpenChildForm(f);
            lblTieuDe.Text = btnQLKH.Text;
        }

        private void BtnQLMuonTra_Click(object sender, EventArgs e)
        {
            //frmQLMuonTra f = new frmQLMuonTra();
            //f.Hoten = Hoten;
            //OpenChildForm(f);
            //lblTieuDe.Text = btnQLMuonTra.Text;
        }

        private void BtnPhieuNhapHang_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            if (!isQuyen)
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
                return;
            }
            FrmPhieuNhapHang f = new FrmPhieuNhapHang();
            OpenChildForm(f);
            lblTieuDe.Text = btnPhieuNhapHang.Text;
        }

        private void BtnAdmin_Click_1(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            if (!isQuyen)
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
                return;
            }
            FrmQuanLyNguoiDung f = new FrmQuanLyNguoiDung();
            OpenChildForm(f);
            lblTieuDe.Text = btnAdmin.Text;
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
