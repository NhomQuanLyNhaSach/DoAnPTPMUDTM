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
using System.Net;
using System.IO;

namespace GUI
{
    public partial class frmQLSach : Form
    {
        SachBLL sachbll = new SachBLL();
        TheLoaiBLL tlbll = new TheLoaiBLL();
        TacGiaBLL tgbll = new TacGiaBLL();
        NhaXuatBanBLL nxbbll = new NhaXuatBanBLL();
        public frmQLSach()
        {
            InitializeComponent();
        }
        void resetSach()
        {
            txtSoLuong.Clear();
            txtNamXuatBan.Clear();
            txtGia.Clear();
            cboTacGia.SelectedIndex = 0;
            cboNhaXuatBan.SelectedIndex = 0;
            cboTheLoai.SelectedIndex = 0;
            txtTenSach.Clear();
            picHinhAnh.Image = null;
            txtTenSach.Focus();
        }
        // Bắt đầu xử lý tabpage Sach
        void LoadTatCaSach()
        {
            dgvDSSach.DataSource = sachbll.LayTatCaSach();
        }
        public void Loadcombobox_TheLoai()
        {
            cboTheLoai.Items.Clear();

            cboTheLoai.DataSource = tlbll.LayTatCaTheLoai();
            cboTheLoai.DisplayMember = "Ten";
            cboTheLoai.ValueMember = "Id";
            cboTheLoai.SelectedIndex = 0;
        }
        public void Loadcombobox_TacGia()
        {
            cboTacGia.Items.Clear();

            cboTacGia.DataSource = tgbll.LayTatCaTacGia();
            cboTacGia.DisplayMember = "Ten";
            cboTacGia.ValueMember = "Id";
            cboTacGia.SelectedIndex = 0;
        }
        public void Loadcombobox_NXB()
        {
            cboNhaXuatBan.Items.Clear();

            cboNhaXuatBan.DataSource = nxbbll.LayTatCaNhaXuatBan();
            cboNhaXuatBan.DisplayMember = "Ten";
            cboNhaXuatBan.ValueMember = "Id";
            cboNhaXuatBan.SelectedIndex = 0;
        }
        void DinhDangDgvSach()
        {
            dgvDSSach.Columns[0].HeaderText = "Mã sách";
            dgvDSSach.Columns[1].HeaderText = "Tên sách";
            dgvDSSach.Columns[2].HeaderText = "Thể loại";
            dgvDSSach.Columns[3].HeaderText = "Tác giả";
            dgvDSSach.Columns[4].HeaderText = "Nhà xuất bản";
            dgvDSSach.Columns[5].HeaderText = "Năm xuất bản";
            dgvDSSach.Columns[6].HeaderText = "Số lượng";
            dgvDSSach.Columns[7].HeaderText = "Giá bán";
            dgvDSSach.Columns["HinhAnh"].Visible = false;
            dgvDSSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FrmQLSach_Load(object sender, EventArgs e)
        {
            txtTenSach.Focus();
            Loadcombobox_TheLoai();
            Loadcombobox_TacGia();
            Loadcombobox_NXB();
            LoadDanhSachTheLoai();
            LoadTatCaSach();
            LoadDanhSachNXB();
            LoadDanhSachTacGia();
            DinhDangDgvTacGia();
            DinhDangDgvNXB();
            DinhDangDgvSach();
            DinhDangDgvTheLoai();
        }
        private void DgvDSSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }
        private void BtnHuySach_Click(object sender, EventArgs e)
        {
            resetSach();
        }
        void LoadDanhSachSachTheoTheLoai()
        {
        }

        private void DgvDSSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSSach.CurrentRow.Index;
            txtTenSach.Text = dgvDSSach.Rows[i].Cells[1].Value?.ToString();
            cboTacGia.Text = dgvDSSach.Rows[i].Cells[3].Value?.ToString();
            cboTheLoai.Text = dgvDSSach.Rows[i].Cells[2].Value?.ToString();
            cboNhaXuatBan.Text = dgvDSSach.Rows[i].Cells[4].Value?.ToString();
            txtSoLuong.Text = dgvDSSach.Rows[i].Cells[6].Value?.ToString();
            txtNamXuatBan.Text = dgvDSSach.Rows[i].Cells[5].Value?.ToString();
            txtGia.Text = dgvDSSach.Rows[i].Cells[7].Value?.ToString();
            string imageUrl = dgvDSSach.Rows[i].Cells[8].Value?.ToString();

            if (imageUrl != null)
            {
                using (WebClient webClient = new WebClient())
                {
                    try
                    {
                        byte[] data = webClient.DownloadData(imageUrl);

                        using (MemoryStream memoryStream = new MemoryStream(data))
                        {
                            Image image = Image.FromStream(memoryStream);
                            picHinhAnh.Image = image;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
            else
            {
                picHinhAnh.Image = picHinhAnh.ErrorImage;
            }
        }

        private void BtnThemSach_Click(object sender, EventArgs e)
        {
            if(txtTenSach.Text == "")
            {
                MessageBox.Show("Tên sách không được bỏ trống");
                return;
            }
            if (txtNamXuatBan.Text == "")
            {
                MessageBox.Show("Năm xuất bản không được bỏ trống");
                return;
            }
            if (txtGia.Text == "")
            {
                MessageBox.Show("Giá không được bỏ trống");
                return;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng không được bỏ trống");
                return;
            }
            Sach s = new Sach();
            s.Ten = txtTenSach.Text;
            s.Id_TL = int.Parse(cboTheLoai.SelectedValue.ToString());
            s.Id_TG = int.Parse(cboTacGia.SelectedValue.ToString());
            s.Id_NXB = int.Parse(cboNhaXuatBan.SelectedValue.ToString());
            s.NamXuatBan = int.Parse(txtNamXuatBan.Text);
            s.GiaBan = int.Parse(txtGia.Text);
            s.SoLuong = int.Parse(txtSoLuong.Text);
            sachbll.ThemSach(s);
            MessageBox.Show("Thêm thành công");
            resetSach();
            LoadTatCaSach();
        }

        private void BtnSuaSach_Click(object sender, EventArgs e)
        {

        }

        private void BtnXoaSach_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
            //    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            //{
            //    try
            //    {
            //        string del_string = "delete SACH where MASACH = '" + txtMaSach.Text + "'";
            //        int kq = dbcon.execute_NonQuery(del_string);
            //        if (kq > 0)
            //            MessageBox.Show("Xóa thành công");
            //        else
            //            MessageBox.Show("Mã sách không tồn tại");
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Sửa thất bại");
            //    }
            //}
            LoadTatCaSach();
        }

        private void TabQLSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (tabQLSach.SelectedIndex == 3)
            //{
            //    LoadTatCaSach();
            //    Loadcombobox_TacGia();
            //    Loadcombobox_NXB();
            //    Loadcombobox_TheLoai();
            //    cboLoaiSach.SelectedIndex = 0;
            //}
        }

        private void TxtLocSach_TextChanged(object sender, EventArgs e)
        {
            //string sql;
            //if(rdoMaSach.Checked)
            //{
            //    sql = sql_select_sach + " and sh.MASACH like '%" + txtTimKiemSach.Text + "%'";
            //    HienThiDGV_Sach(sql);
            //}
            //if (rdoTenSach.Checked)
            //{
            //    sql = sql_select_sach + " and sh.TENSACH like N'%" + txtTimKiemSach.Text + "%'";
            //    HienThiDGV_Sach(sql);
            //}
        }
        // Kết thúc xử lý tabpage Sach

        // Bắt đầu xử lý tabpage thể loại
        void LoadDanhSachTheLoai()
        {
            dgvDSTheLoai.DataSource = tlbll.LayTatCaTheLoai();
        }
        void DinhDangDgvTheLoai()
        {
            dgvDSTheLoai.Columns[0].HeaderText = "Mã thể loại";
            dgvDSTheLoai.Columns[1].HeaderText = "Tên thể loại";
            dgvDSTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void resetTheLoai()
        {
            txtTenTheLoai.Clear();
        }

        private void BtnThemTheLoai_Click(object sender, EventArgs e)
        {
            txtTenTheLoai.Focus();
            if (txtTenTheLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thể loại");
                txtTenTheLoai.Focus();
                return;
            }
            
            TheLoai tl = new TheLoai();
            tl.Ten = txtTenTheLoai.Text;
            tlbll.ThemTheLoai(tl);
            MessageBox.Show("Thêm thành công");
            resetTheLoai();
            LoadDanhSachTheLoai();
        }

        private void BtnSuaTheLoai_Click(object sender, EventArgs e)
        {
            txtTenTheLoai.Focus();
            if (txtTenTheLoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thể loại");
                txtTenTheLoai.Focus();
                return;
            }
            
            int i = dgvDSTheLoai.CurrentRow.Index;
            int maTL = int.Parse(dgvDSTheLoai.Rows[i].Cells[0].Value?.ToString());
            TheLoai tl = new TheLoai();
            tl.Ten = txtTenTheLoai.Text;
            tlbll.SuaThongTinTheLoai(maTL,txtTenTheLoai.Text);
            MessageBox.Show("Sửa thành công");
            resetTheLoai();
            LoadDanhSachTheLoai();
        }


        private void BtnXoaTheLoai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                int i = dgvDSTheLoai.CurrentRow.Index;
                int maTL = int.Parse(dgvDSTheLoai.Rows[i].Cells[0].Value?.ToString());
                tlbll.XoaTheLoai(maTL);
                MessageBox.Show("Xóa thành công");
                resetTheLoai();
                LoadDanhSachTheLoai();
            }
        }

        private void BtnHuyTheLoai_Click(object sender, EventArgs e)
        {
            LoadDanhSachTheLoai();
            resetTheLoai();
        }

        private void DgvDSTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSTheLoai.CurrentRow.Index;
            txtTenTheLoai.Text = dgvDSTheLoai.Rows[i].Cells[1].Value?.ToString();
        }

        // Kết thúc xử lý tabpage thể loại

        // Bắt đầu xử lý tabpage nhà xuất bản
        void LoadDanhSachNXB()
        {
            dgvDSNhaXuatBan.DataSource = nxbbll.LayTatCaNhaXuatBan();
        }
        void DinhDangDgvNXB()
        {
            dgvDSNhaXuatBan.Columns[0].HeaderText = "Mã nhà xuất bản";
            dgvDSNhaXuatBan.Columns[1].HeaderText = "Tên nhà xuất bản";
            dgvDSNhaXuatBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void resetNXB()
        {
            txtTenNhaXuatBan.Clear();
        }

        private void BtnThemNhaXuatBan_Click(object sender, EventArgs e)
        {
            txtTenNhaXuatBan.Focus();
            if (txtTenNhaXuatBan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà xuất bản");
                txtTenTheLoai.Focus();
                return;
            }

            NhaXuatBan nxb = new NhaXuatBan();
            nxb.Ten = txtTenNhaXuatBan.Text;
            nxbbll.ThemNhaXuatBan(nxb);
            MessageBox.Show("Thêm thành công");
            resetNXB();
            LoadDanhSachNXB();
            resetNXB();
        }

        private void BtnSuaNhaXuatBan_Click(object sender, EventArgs e)
        {
            txtTenNhaXuatBan.Focus();
            if (txtTenNhaXuatBan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhà xuất bản");
                txtTenNhaXuatBan.Focus();
                return;
            }

            int i = dgvDSNhaXuatBan.CurrentRow.Index;
            int maNXB = int.Parse(dgvDSNhaXuatBan.Rows[i].Cells[0].Value?.ToString());
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.Ten = txtTenNhaXuatBan.Text;
            nxbbll.SuaThongTinNhaXuatBan(maNXB, txtTenNhaXuatBan.Text);
            MessageBox.Show("Sửa thành công");
            resetNXB();
            LoadDanhSachNXB();
        }

        private void BtnXoaNhaXuatBan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                int i = dgvDSNhaXuatBan.CurrentRow.Index;
                int maNXB = int.Parse(dgvDSNhaXuatBan.Rows[i].Cells[0].Value?.ToString());
                nxbbll.XoaNhaXuatBan(maNXB);
                MessageBox.Show("Xóa thành công");
                resetNXB();
                LoadDanhSachNXB();
            }
        }

        private void BtnHuyNhaXuatBan_Click(object sender, EventArgs e)
        {
            resetNXB();
            LoadDanhSachNXB();
        }

        private void DgvDSNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSNhaXuatBan.CurrentRow.Index;
            txtTenNhaXuatBan.Text = dgvDSNhaXuatBan.Rows[i].Cells[1].Value?.ToString();
        }
        // Kết thúc xử lý tabpage nhà xuất bản

        // Bắt đầu xử lý tabpage tác giả
        void LoadDanhSachTacGia()
        {
            dgvDSTacGia.DataSource = tgbll.LayTatCaTacGia();
        }
        void DinhDangDgvTacGia()
        {
            dgvDSTacGia.Columns[0].HeaderText = "Mã tác giả";
            dgvDSTacGia.Columns[1].HeaderText = "Tên tác giả";
            dgvDSTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void resetTacGia()
        {
            txtTenTG.Clear();
        }

        private void BtnThemTacGia_Click(object sender, EventArgs e)
        {
            txtTenTG.Focus();
            if (txtTenTG.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tác giả");
                txtTenTG.Focus();
                return;
            }

            TacGia tg = new TacGia();
            tg.Ten = txtTenTG.Text;
            tgbll.ThemTacGia(tg);
            MessageBox.Show("Thêm thành công");
            resetTacGia();
            LoadDanhSachTacGia();
        }

        private void BtnSuaTacGia_Click(object sender, EventArgs e)
        {
            txtTenTG.Focus();
            if (txtTenTG.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tác giả");
                txtTenTG.Focus();
                return;
            }

            int i = dgvDSTacGia.CurrentRow.Index;
            int maTG = int.Parse(dgvDSTacGia.Rows[i].Cells[0].Value?.ToString());
            TacGia tg = new TacGia();
            tg.Ten = txtTenTG.Text;
            tgbll.SuaThongTinTacGia(maTG, txtTenTG.Text);
            MessageBox.Show("Sửa thành công");
            resetTacGia();
            LoadDanhSachTacGia();
        }

        private void BtnXoaTacGia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    int i = dgvDSTacGia.CurrentRow.Index;
                    int maTG = int.Parse(dgvDSTacGia.Rows[i].Cells[0].Value?.ToString());
                    tgbll.XoaTacGia(maTG);
                    MessageBox.Show("Xóa thành công");
                    resetTacGia();
                    LoadDanhSachTacGia();
                }
            }
        }

        private void BtnHuyTacGia_Click(object sender, EventArgs e)
        {
            resetTacGia();
            LoadDanhSachTacGia();
        }

        private void DgvDSTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDSTacGia.CurrentRow.Index;
            txtTenTG.Text = dgvDSTacGia.Rows[i].Cells[1].Value?.ToString();
        }

        
        // Kết thúc xử lý tabpage tác giả
    }
}
