using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrols
{
    public class txtChiNhapSo:TextBox
    {
        private ErrorProvider errorProvider;

        public txtChiNhapSo()
        {
            errorProvider = new ErrorProvider();

            this.KeyPress += txtChiNhapSo_KeyPress;
            this.TextChanged += txtChiNhapSo_TextChanged;
        }

        private void txtChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider.SetError(this, "Vui lòng chỉ nhập số.");
            }
            else
            {
                errorProvider.SetError(this, "");
            }
        }

        private void txtChiNhapSo_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(this, "");
        }
    }
}
