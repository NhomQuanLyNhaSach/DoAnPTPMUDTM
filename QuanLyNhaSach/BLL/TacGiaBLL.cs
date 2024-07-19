using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TacGiaBLL
    {
        QL_NhaSachDataContext context = new QL_NhaSachDataContext();

        public TacGiaBLL() { }

        public List<TacGia> LayTatCaTacGia()
        {
            var query = from tg in context.TacGias
                        select tg;
            return query.ToList();
        }

        public void ThemTacGia(TacGia tacGia)
        {
            context.TacGias.InsertOnSubmit(tacGia);
            context.SubmitChanges();
        }

        public void XoaTacGia(int maTacGia)
        {
            var tacGia = context.TacGias.SingleOrDefault(tg => tg.Id == maTacGia);
            if (tacGia != null)
            {
                context.TacGias.DeleteOnSubmit(tacGia);
                context.SubmitChanges();
            }
        }

        public void SuaThongTinTacGia(int maTacGia, string tenTacGiaMoi)
        {
            var tacGia = context.TacGias.SingleOrDefault(tg => tg.Id == maTacGia);
            if (tacGia != null)
            {
                tacGia.Ten = tenTacGiaMoi;
                context.SubmitChanges();
            }
        }
    }
}
