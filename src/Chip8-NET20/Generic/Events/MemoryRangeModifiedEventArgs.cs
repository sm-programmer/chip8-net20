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
using System.Text;

namespace Generic.Events
{
	public class MemoryRangeModifiedEventArgs
	{
        private int _start;
        public int Start
        {
            get { return _start; }
            set { _start = value; }
        }

        private int _end;
        public int End
        {
            get { return _end; }
            set { _end = value; }
        }

        public MemoryRangeModifiedEventArgs(int start, int end)
        {
            Start = start;
            End = end;
        }
	}
}
