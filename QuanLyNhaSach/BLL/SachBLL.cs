using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SachBLL
    {
        QL_NhaSachDataContext context = new QL_NhaSachDataContext();

        public SachBLL() { }

        public List<object> LayTatCaSach()
        {
            var query = from s in context.Saches
                        join tl in context.TheLoais on s.Id_TL equals tl.Id
                        join tg in context.TacGias on s.Id_TG equals tg.Id
                        join nxb in context.NhaXuatBans on s.Id_NXB equals nxb.Id
                        orderby s.Id descending
                        select new
                        {
                            MaSach = s.Id,
                            TenSach = s.Ten,
                            TenTL = tl.Ten,
                            TenTG = tg.Ten,
                            TenNXB = nxb.Ten,
                            NamXuatBan = s.NamXuatBan,
                            SoLuong = s.SoLuong,
                            GiaBan = s.GiaBan,
                            HinhAnh = s.HinhAnh
                        };

            return query.ToList<object>();
        }

        public void ThemSach(Sach sach)
        {
            context.Saches.InsertOnSubmit(sach);
            context.SubmitChanges();
        }

        public void XoaSach(int maSach)
        {
            var sach = context.Saches.SingleOrDefault(s => s.Id == maSach);
            if (sach != null)
            {
                sach.DaXoa = true;
                context.SubmitChanges();
            }
        }

        public void SuaThongTinSach(int maSach, string tenSachMoi, int maTheLoaiMoi, int maTacGiaMoi, int maNhaCungCapMoi, int giaMoi)
        {
            var sach = context.Saches.SingleOrDefault(s => s.Id == maSach);
            if (sach != null)
            {
                sach.Ten = tenSachMoi;
                sach.Id_TL = maTheLoaiMoi;
                sach.Id_TG = maTacGiaMoi;
                sach.Id_NXB = maNhaCungCapMoi;
                sach.GiaBan = giaMoi;
                context.SubmitChanges();
            }
        }
    }
}
