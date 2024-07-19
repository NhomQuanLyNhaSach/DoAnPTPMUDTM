using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaXuatBanBLL
    {
        QL_NhaSachDataContext context = new QL_NhaSachDataContext();

        public NhaXuatBanBLL() { }

        public List<NhaXuatBan> LayTatCaNhaXuatBan()
        {
            var query = from tl in context.NhaXuatBans
                        select tl;
            return query.ToList();
        }
        public void ThemNhaXuatBan(NhaXuatBan NhaXuatBan)
        {
            context.NhaXuatBans.InsertOnSubmit(NhaXuatBan);
            context.SubmitChanges();
        }

        public void XoaNhaXuatBan(int maNhaXuatBan)
        {
            var NhaXuatBan = context.NhaXuatBans.SingleOrDefault(tl => tl.Id == maNhaXuatBan);
            if (NhaXuatBan != null)
            {
                context.NhaXuatBans.DeleteOnSubmit(NhaXuatBan);
                context.SubmitChanges();
            }
        }

        public void SuaThongTinNhaXuatBan(int maNhaXuatBan, string tenNhaXuatBanMoi)
        {
            var NhaXuatBan = context.NhaXuatBans.SingleOrDefault(tl => tl.Id == maNhaXuatBan);
            if (NhaXuatBan != null)
            {
                NhaXuatBan.Ten = tenNhaXuatBanMoi;
                context.SubmitChanges();
            }
        }
    }
}
