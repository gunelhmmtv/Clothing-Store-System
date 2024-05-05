using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vallahson.Extentions
{
    static class TextBoxExtension
    {
        public static bool IsEmpty(this TextBox textBox)
            => string.IsNullOrEmpty(textBox.Text);

        public static bool IsGreaterThan(this TextBox textBox, int number)
            => Convert.ToDecimal(textBox.Text) > number;

        public static int ToInt(this TextBox textBox)
            => Convert.ToInt32(textBox.Text);

    }
}
