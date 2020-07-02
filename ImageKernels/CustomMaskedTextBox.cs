using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageKernels
{
    public class CustomTextBox : System.Windows.Forms.TextBox
    {
        public CustomTextBox()
        {
        }

        protected override void OnTextChanged(EventArgs args)
        {
            string input = this.Text;
            var regex = @"^-?[0-9]\d{0,9}(\.\d{1,6})?$";

            var match = Regex.Match(input, regex, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                this.ForeColor = Color.Black;
            }
            else
            {
                this.ForeColor = Color.Red;
            }
        }
    }
}
