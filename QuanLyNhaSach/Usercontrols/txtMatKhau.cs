using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrols
{
    public class txtMatKhau: TextBox
    {
        private ErrorProvider errorProvider;

        public txtMatKhau()
        {
            // Khởi tạo ErrorProvider
            errorProvider = new ErrorProvider();

            // Sự kiện để kiểm tra mật khẩu khi người dùng rời khỏi ô nhập
            this.Leave += txtMatKhau_Leave;
            this.UseSystemPasswordChar = true;
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            string password = this.Text;

            if (password.Length < 8
                || !password.Any(char.IsDigit) // ít nhất một chữ số
                || !password.Any(char.IsUpper) // ít nhất một chữ cái viết hoa
                || !password.Any(char.IsLower) // ít nhất một chữ cái
                || !password.Any(ch => !char.IsLetterOrDigit(ch))) // ít nhất một ký tự đặc biệt
            {
                // Hiển thị thông báo lỗi
                errorProvider.SetError(this, "Mật khẩu phải có ít nhất 8 ký tự và chứa ít nhất một chữ cái, một chữ số, một chữ cái viết hoa và một ký tự đặc biệt.");
            }
            else
            {
                // Nếu hợp lệ, xóa thông báo lỗi
                errorProvider.SetError(this, "");
            }
        }
    }
}
