using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapHangBLL
    {
        QL_NhaSachDataContext context = new QL_NhaSachDataContext();

        public PhieuNhapHangBLL() { }

        public List<object> LayTatCaPhieuNhap()
        {
            var query = from pns in context.PhieuNhapSaches
                        join ncc in context.NhaCungCaps on pns.Id_NCC equals ncc.Id
                        join nv in context.NhanViens on pns.Id_NV equals nv.Id
                        select new
                        {
                            MaPhieuNhap = pns.Id,
                            MaNCC = pns.Id_NCC,
                            MaNV = pns.Id_NV,
                            NgayNhap = pns.NgayNhap,
                            TenNhaCungCap = ncc.HoTen,
                            TenNhanVien = nv.HoTen,
                            TongTien = pns.TongTien
                        };

            return query.ToList<object>();
        }
        public void ThemPhieuNhap(PhieuNhapSach phieuNhap)
        {
            context.PhieuNhapSaches.InsertOnSubmit(phieuNhap);
            context.SubmitChanges();
        }

        public void XoaPhieuNhap(int maPhieuNhap)
        {
            var phieuNhap = context.PhieuNhapSaches.SingleOrDefault(pns => pns.Id == maPhieuNhap);
            if (phieuNhap != null)
            {
                context.PhieuNhapSaches.DeleteOnSubmit(phieuNhap);
                context.SubmitChanges();
            }
        }

        public void SuaPhieuNhap(int maPhieuNhap, int ncc,int nv, int tt,DateTime nn)
        {
            var phieuNhap = context.PhieuNhapSaches.SingleOrDefault(pns => pns.Id == maPhieuNhap);
            if (phieuNhap != null)
            {
                phieuNhap.Id_NCC = ncc;
                phieuNhap.Id_NV = nv;
                phieuNhap.NgayNhap = nn;
                phieuNhap.TongTien = tt;

                context.SubmitChanges();
            }
        }
        public List<object> TimKiemPhieuNhap(string tuKhoa)
        {
            var query = from pns in context.PhieuNhapSaches
                        join ncc in context.NhaCungCaps on pns.Id_NCC equals ncc.Id
                        join nv in context.NhanViens on pns.Id_NV equals nv.Id
                        where pns.Id.ToString().Contains(tuKhoa) ||
                              ncc.HoTen.Contains(tuKhoa) ||
                              nv.HoTen.Contains(tuKhoa) ||
                              pns.TongTien.ToString().Contains(tuKhoa) ||
                              pns.NgayNhap.ToString().Contains(tuKhoa)
                        select new
                        {
                            MaPhieuNhap = pns.Id,
                            MaNCC = pns.Id_NCC,
                            MaNV = pns.Id_NV,
                            NgayNhap = pns.NgayNhap,
                            TenNhaCungCap = ncc.HoTen,
                            TenNhanVien = nv.HoTen,
                            TongTien = pns.TongTien
                        };

            return query.ToList<object>();
        }
    }
}
