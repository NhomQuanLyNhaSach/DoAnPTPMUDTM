using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrols
{
    public class txtEmail :TextBox
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public txtEmail()
        {
            this.Leave += TxtEmail_Leave;
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            string emailAddress = this.Text;

            // Kiểm tra định dạng email bằng cách sử dụng biểu thức chính quy
            if (IsValidEmail(emailAddress))
            {
                // Nếu định dạng email hợp lệ, xóa thông báo lỗi
                errorProvider.SetError(this, "");
            }
            else
            {
                // Hiển thị thông báo lỗi
                errorProvider.SetError(this, "Định dạng email không hợp lệ");
            }
        }

        // Hàm kiểm tra định dạng email sử dụng biểu thức chính quy
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
