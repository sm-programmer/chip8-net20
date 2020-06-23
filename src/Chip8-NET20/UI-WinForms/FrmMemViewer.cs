/**
    The CHIP-8 emulator: an implementation in C# using .NET Framework 2.0.
    Copyright (C) 2020  Felipe BF  <smprg.6502@gmail.com>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Chip8;

namespace Chip8_NET20
{
    public partial class FrmMemViewer : Form
    {
        private Computer _comp = null;
        public Computer Source
        {
            private get { return _comp; }
            set { _comp = value; }
        }

        public FrmMemViewer()
        {
            InitializeComponent();

            adjustByteCount();
        }

        private void adjustByteCount()
        {
            nudNoBytes.Maximum = memViewer.MaxByteCount;

            if (!chkManualSize.Checked || nudNoBytes.Value > memViewer.MaxByteCount)
                nudNoBytes.Value = memViewer.MaxByteCount;
        }

        private void FrmMemViewer_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                Location = new Point(
                    Owner.Location.X + (Owner.Width - Width) / 2,
                    Owner.Location.Y + (Owner.Height - Height) / 2
                );
            }

            cbMemType.SelectedIndex = 0;
        }

        private void FrmMemViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void cbMemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do not attempt to check memory of an undefined source!
            if (Source == null)
                return;

            switch (cbMemType.SelectedIndex)
            {
                // Main memory
                case 0:
                    memViewer.Source = (Memory)Source.Memory;
                    break;
                
                // Video memory
                case 1:
                    memViewer.Source = (Memory)Source.Screen.VideoRAM;
                    break;
            }
        }

        private void FrmMemViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbMemType.Focused || chkManualSize.Focused || nudNoBytes.Focused)
                return;

            memViewer.MemoryViewer_KeyDown(sender, e);
        }

        private void cbManualSize_CheckedChanged(object sender, EventArgs e)
        {
            nudNoBytes.Enabled = chkManualSize.Checked;
            memViewer.AutoAdjustWidth = !chkManualSize.Checked;
        }

        private void memViewer_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "MaxByteCount")
                adjustByteCount();
        }

        private void nudNoBytes_ValueChanged(object sender, EventArgs e)
        {
            if (!chkManualSize.Checked)
                return;

            memViewer.BytesPerLine = Decimal.ToInt32(nudNoBytes.Value);
        }
    }
}