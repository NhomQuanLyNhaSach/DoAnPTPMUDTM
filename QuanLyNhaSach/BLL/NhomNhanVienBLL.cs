using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhomNhanVienBLL
    {
        QL_NhaSachDataContext context = new QL_NhaSachDataContext();
        public NhomNhanVienBLL() { }

        public List<NhomNhanVien> LayTatCaNhomNhanVien()
        {
            var query = from nnv in context.NhomNhanViens
                        select nnv;
            return query.ToList();
        }
    }
}
