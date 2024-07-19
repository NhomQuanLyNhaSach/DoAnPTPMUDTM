using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        QL_NhaSachDataContext context = new QL_NhaSachDataContext();

        public NhaCungCapBLL() { }

        public List<NhaCungCap> LayTatCaNhaCungCap()
        {
            var query = from ncc in context.NhaCungCaps
                        select ncc;
            return query.ToList();
        }
        public void ThemNhaCungCap(NhaCungCap nhaCungCap)
        {
            context.NhaCungCaps.InsertOnSubmit(nhaCungCap);
            context.SubmitChanges();
        }

        public void XoaNhaCungCap(int maNhaCungCap)
        {
            var nhaCungCap = context.NhaCungCaps.SingleOrDefault(ncc => ncc.Id == maNhaCungCap);
            if (nhaCungCap != null)
            {
                context.NhaCungCaps.DeleteOnSubmit(nhaCungCap);
                context.SubmitChanges();
            }
        }

        public void SuaThongTinNhaCungCap(int maNhaCungCap, string tenNhaCungCapMoi, string emailMoi, string sdtMoi, string diaChiMoi)
        {
            var nhaCungCap = context.NhaCungCaps.SingleOrDefault(ncc => ncc.Id == maNhaCungCap);
            if (nhaCungCap != null)
            {
                nhaCungCap.HoTen = tenNhaCungCapMoi;
                nhaCungCap.Email = emailMoi;
                nhaCungCap.SDT = sdtMoi;
                nhaCungCap.DiaChi = diaChiMoi;
                context.SubmitChanges();
            }
        }
    }
}
