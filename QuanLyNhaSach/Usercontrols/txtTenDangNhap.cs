using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrols
{
    public class txtTenDangNhap : TextBox
    {
        private ErrorProvider errorProvider;

        public txtTenDangNhap()
        {
            // Khởi tạo ErrorProvider
            errorProvider = new ErrorProvider();

            // Sự kiện để kiểm tra tên đăng nhập khi người dùng rời khỏi ô nhập
            this.Leave += txtTenDangNhap_Leave;
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            string tenDangNhap = this.Text;

            // Kiểm tra nếu tên đăng nhập chứa ký tự đặc biệt hoặc khoảng trắng
            if (ContainsSpecialCharactersOrWhitespace(tenDangNhap))
            {
                // Hiển thị thông báo lỗi
                errorProvider.SetError(this, "Tên đăng nhập không được chứa ký tự đặc biệt hoặc khoảng trắng.");
            }
            else
            {
                // Nếu hợp lệ, xóa thông báo lỗi
                errorProvider.SetError(this, "");
            }
        }

        // Hàm kiểm tra xem tên đăng nhập có chứa ký tự đặc biệt hoặc khoảng trắng hay không
        private bool ContainsSpecialCharactersOrWhitespace(string input)
        {
            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c) || char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    return true; // Chứa ký tự đặc biệt hoặc khoảng trắng
                }
            }
            return false; // Không chứa ký tự đặc biệt hoặc khoảng trắng
        }
    }
}
