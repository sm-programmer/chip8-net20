using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace UIControls
{
    public class AddressNumericUpDown : NumericUpDown
    {
        public AddressNumericUpDown()
            : base()
        {
            Hexadecimal = true;
        }

        protected override void UpdateEditText()
        {
            ushort val = (ushort) (
                (Value <= Minimum)
                    ? Minimum
                    : (Value >= Maximum)
                        ? Maximum
                        : Value
            );

            Text = String.Format("0x{0:X4}", val);
        }
    }
}
