using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        QL_NhaSachDataContext context = new QL_NhaSachDataContext();

        public NhanVienBLL() { }

        public bool KiemTraQuyen(int maNV, int maManHinh)
        {
            var query = from pq in context.PhanQuyens
                        join nn in context.NhanVienNhomNhanViens on pq.Id_Nhom equals nn.Id_Nhom
                        where nn.Id_ND == maNV && pq.CoQuyen.Value == true && pq.Id_MH == maManHinh
                        select pq;

            return query.Any();
        }

        public List<NhanVien> LayTatCaNhanVien()
        {
            var query = from nv in context.NhanViens
                        select nv;
            return query.ToList();
        }

        public NhanVien LayNhanVienDangNhap(string tenDangNhap, string matKhau)
        {
            var query = from nv in context.NhanViens
                        where nv.TenDangNhap == tenDangNhap
                        select nv;
            var nhanvien = query.FirstOrDefault();
            if (nhanvien != null)
            {
                string hashedPasswordFromDatabase = nhanvien.MatKhau;

                bool isPasswordMatched = BCrypt.Net.BCrypt.Verify(matKhau, hashedPasswordFromDatabase);

                if (isPasswordMatched)
                {
                    return nhanvien;
                }
            }

            return null;
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            context.NhanViens.InsertOnSubmit(nhanVien);
            context.SubmitChanges();
        }

        public void SuaThongTinNhanVien(int maNhanVien, string tenMoi, string emailMoi, string sdtMoi, string diaChiMoi)
        {
            var nhanVien = context.NhanViens.SingleOrDefault(nv => nv.Id == maNhanVien);
            if (nhanVien != null)
            {
                nhanVien.HoTen = tenMoi;
                nhanVien.Email = emailMoi;
                nhanVien.SDT = sdtMoi;
                nhanVien.DiaChi = diaChiMoi;

                context.SubmitChanges();
            }
        }

        public void XoaNhanVien(int maNhanVien)
        {
            var nhanVien = context.NhanViens.SingleOrDefault(nv => nv.Id == maNhanVien);
            if (nhanVien != null)
            {
                context.NhanViens.DeleteOnSubmit(nhanVien);
                context.SubmitChanges();
            }
        }
        public List<NhanVien> TimKiemNhanVien(string tuKhoa)
        {
            var query = from nv in context.NhanViens
                        where nv.HoTen.Contains(tuKhoa)
                        select nv;

            return query.ToList();
        }
        public List<NhanVien> LayTatCaNhanVienKho()
        {
            var query = from nv in context.NhanViens
                        where nv.NhanVienNhomNhanViens.Any(nnv => nnv.Id_Nhom == 3)
                        select nv;
            return query.ToList();
        }
    }
}
