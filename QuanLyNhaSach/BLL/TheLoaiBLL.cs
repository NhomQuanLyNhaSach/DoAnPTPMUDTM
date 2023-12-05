using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TheLoaiBLL
    {
        QL_NhaSachDataContext context = new QL_NhaSachDataContext();

        public TheLoaiBLL() { }

        public List<TheLoai> LayTatCaTheLoai()
        {
            var query = from tl in context.TheLoais
                        select tl;
            return query.ToList();
        }
        public void ThemTheLoai(TheLoai theLoai)
        {
            context.TheLoais.InsertOnSubmit(theLoai);
            context.SubmitChanges();
        }

        public void XoaTheLoai(int maTheLoai)
        {
            var theLoai = context.TheLoais.SingleOrDefault(tl => tl.Id == maTheLoai);
            if (theLoai != null)
            {
                context.TheLoais.DeleteOnSubmit(theLoai);
                context.SubmitChanges();
            }
        }

        public void SuaThongTinTheLoai(int maTheLoai, string tenTheLoaiMoi)
        {
            var theLoai = context.TheLoais.SingleOrDefault(tl => tl.Id == maTheLoai);
            if (theLoai != null)
            {
                theLoai.Ten = tenTheLoaiMoi;
                context.SubmitChanges();
            }
        }
    }
}
