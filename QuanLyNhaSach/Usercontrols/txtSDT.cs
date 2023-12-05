using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrols
{
    public class txtSDT:TextBox
    {
        private ErrorProvider errorProvider;

        public txtSDT()
        {
            // Khởi tạo ErrorProvider
            errorProvider = new ErrorProvider();

            // Thêm sự kiện TextChanged để kiểm tra từng ký tự nhập vào
            this.TextChanged += txtSDT_TextChanged;

            // Sự kiện để kiểm tra số điện thoại khi người dùng rời khỏi ô nhập
            this.Leave += txtSDT_Leave;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra từng ký tự trong văn bản
            foreach (char c in this.Text)
            {
                // Kiểm tra nếu ký tự không phải là số
                if (!char.IsDigit(c))
                {
                    errorProvider.SetError(this, "Vui lòng chỉ nhập số.");
                    return;
                }
            }

            // Kiểm tra độ dài của chuỗi
            if (this.Text.Length > 15)
            {
                errorProvider.SetError(this, "Số điện thoại không được quá 15 ký tự.");
            }
            else
            {
                // Nếu không có lỗi, xóa thông báo lỗi
                errorProvider.SetError(this, "");
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            // Kiểm tra số điện thoại có đúng định dạng không
            if (this.Text.Length > 0 && !IsPhoneNumberValid(this.Text))
            {
                // Hiển thị thông báo lỗi
                errorProvider.SetError(this, "Số điện thoại không hợp lệ.");
            }
            else
            {
                // Nếu hợp lệ, xóa thông báo lỗi
                errorProvider.SetError(this, "");
            }
        }

        // Hàm kiểm tra định dạng số điện thoại
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Định dạng cho phép: không quá 15 ký tự
            return phoneNumber.Length <= 15;
        }
    }
}
