using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        QL_NhaSachDataContext context = new QL_NhaSachDataContext();

        public KhachHangBLL() { }

        public List<KhachHang> LayTatKhachHang()
        {
            var query = from kh in context.KhachHangs
                        select kh;
            return query.ToList();
        }

        public List<KhachHang> TimKiemKhachHang(string tuKhoa)
        {
            var query = from kh in context.KhachHangs
                        where kh.HoTen.Contains(tuKhoa) || kh.Email.Contains(tuKhoa) || kh.SDT.Contains(tuKhoa) || kh.DiaChi.Contains(tuKhoa)
                        select kh;

            return query.ToList();
        }

        public void ThemKhachHang(KhachHang khachHang)
        {
            context.KhachHangs.InsertOnSubmit(khachHang);
            context.SubmitChanges();
        }
        public void XoaKhachHang(int maKhachHang)
        {
            var khachHang = context.KhachHangs.SingleOrDefault(kh => kh.Id == maKhachHang);
            if (khachHang != null)
            {
                context.KhachHangs.DeleteOnSubmit(khachHang);
                context.SubmitChanges();
            }
        }

        public void SuaThongTinKhachHang(int maKhachHang, string tenMoi, string emailMoi, string sdtMoi, string diaChiMoi)
        {
            var khachhang = context.KhachHangs.SingleOrDefault(kh => kh.Id == maKhachHang);
            if (khachhang != null)
            {
                khachhang.HoTen = tenMoi;
                khachhang.Email = emailMoi;
                khachhang.SDT = sdtMoi;
                khachhang.DiaChi = diaChiMoi;
                context.SubmitChanges();
            }
        }
    }
}
