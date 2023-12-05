using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrols
{
    public class txtHoTen:TextBox
    {
        private ErrorProvider errorProvider;

        public txtHoTen()
        {
            // Khởi tạo ErrorProvider
            errorProvider = new ErrorProvider();

            // Sự kiện để kiểm tra họ tên khi người dùng rời khỏi ô nhập
            this.Leave += txtHoTen_Leave;
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            string hoTen = this.Text;

            // Kiểm tra nếu họ tên chứa số hoặc ký tự đặc biệt
            if (hoTen.Any(char.IsDigit) || hoTen.Any(char.IsPunctuation) || hoTen.Any(char.IsSymbol))
            {
                // Hiển thị thông báo lỗi
                errorProvider.SetError(this, "Họ tên không được chứa số hoặc ký tự đặc biệt.");
            }
            else
            {
                // Nếu hợp lệ, xóa thông báo lỗi
                errorProvider.SetError(this, "");
            }
        }
    }
}
