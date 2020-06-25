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

namespace Chip8
{
    public delegate void CycleSteppedEventHandler(object sender);

    public abstract class Oscillator : Generic.Oscillator
    {
        public event CycleSteppedEventHandler CycleStepped;

        private int countFreq = 0;

        private Display _disp;
        public Display Display
        {
            get { return _disp; }
            set { _disp = value; }
        }

        private Processor _proc;
        public Processor Processor
        {
            get { return _proc; }
            set { _proc = value; }
        }

        private bool _emu_start;
        public bool EmulationStarted
        {
            get { return _emu_start; }
            set { _emu_start = value; }
        }

        public Oscillator()
            : this(0)
        {
        }

        public Oscillator(int freq)
            : base(freq)
        {
            _emu_start = false;
        }

        public override void CycleCompleted()
        {
            if (Processor == null)
                return;

            if (EmulationStarted)
            {
                if (Monostable)
                    Processor.ExecuteCycles(1);
                else
                    Processor.ExecuteCycles((int)(Processor.Speed / Frequency));
            }

            if (Processor.Draw)
            {
                Processor.Draw = false;

                if (Display != null)
                    Display.Update();
            }

            if (++countFreq == Frequency)
                countFreq = 0;

            if (EmulationStarted && Monostable)
                OnCycleStepped();
        }

        protected void OnCycleStepped()
        {
            CycleSteppedEventHandler handler = CycleStepped;
            if (handler != null)
                handler(this);
        }

        public abstract void Start();
        public abstract void Stop();
    }
}
