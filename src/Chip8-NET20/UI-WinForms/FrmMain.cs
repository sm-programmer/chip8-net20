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
using System.IO;

namespace Chip8_NET20
{
    enum Command
    {
        LoadProgram = 0,
        Start,
        Stop,
        ColdReset,
        WarmReset
    }

    public partial class FrmMain : Form
    {
        private Chip8.Computer comp;

        private Dictionary<Command, ToolStripItem[]> compositeCommands;

        private ToolStripMenuItem[] availableFonts;
        private ToolStripMenuItem[] availableBuzzers;
        private ToolStripMenuItem[] availableSpeeds;

        private FrmMemViewer frmMemViewer;

        public FrmMain()
        {
            InitializeComponent();

            availableFonts = new ToolStripMenuItem[]
            {
                itemFontDefault, itemFontAlt, itemFont7Seg, itemFontLowercase
            };

            availableBuzzers = new ToolStripMenuItem[]
            {
                itemBuzz736Square, itemBuzz787Sine
            };

            availableSpeeds = new ToolStripMenuItem[]
            {
                itemSpeedSlow, itemSpeedNormal, itemSpeedFast
            };

            compositeCommands = new Dictionary<Command,ToolStripItem[]>();
            compositeCommands.Add(Command.LoadProgram, new ToolStripItem[] {itemLoadProg, btnLoadProg});
            compositeCommands.Add(Command.Start, new ToolStripItem[] { itemStart, btnStart });
            compositeCommands.Add(Command.Stop, new ToolStripItem[] { itemStop, btnStop });
            compositeCommands.Add(Command.ColdReset, new ToolStripItem[] { itemColdReset, btnColdReset });
            compositeCommands.Add(Command.WarmReset, new ToolStripItem[] { itemWarmReset, btnWarmReset });

            init_computer();

            frmMemViewer = new FrmMemViewer();
            frmMemViewer.Source = comp;
        }

        private void init_computer()
        {
            comp = new Chip8.Computer();

            comp.Buzzer = new Chip8.Buzzer();
            comp.Display = disp.Display;
            comp.Oscillator = new Display.Oscillator(60);

            itemClearScrStart.PerformClick();

            itemFontDefault.PerformClick();
            itemBuzz736Square.PerformClick();
            itemSpeedNormal.PerformClick();

            comp.Oscillator.Start();

            lblStatus.Text = "This is the CHIP-8 emulator.";
        }

        private void enable_cmd(Command cmd, bool enabled)
        {
            ToolStripItem[] items = new ToolStripItem[] { };
            compositeCommands.TryGetValue(cmd, out items);

            foreach (ToolStripItem item in items)
                item.Enabled = enabled;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMemViewer.Dispose();
            comp.Oscillator.Stop();
            disp.MemoryCleanup();
        }

        private void OnLoadProgram(object sender, EventArgs e)
        {
            bool previousState = comp.Oscillator.EmulationStarted;

            if (previousState)
                itemStop.PerformClick();

            DialogResult result = openFileDialog.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                if (previousState)
                    itemStart.PerformClick();

                return;
            }

            itemColdReset.PerformClick();

            comp.ProgramPath = openFileDialog.FileName;

            enable_cmd(Command.Start, true);

            lblStatus.Text = "Program \"" + Path.GetFileName(comp.ProgramPath) + "\" successfully loaded!";
        }

        private void OnComputerStart(object sender, EventArgs e)
        {
            enable_cmd(Command.Start, false);
            enable_cmd(Command.Stop, true);

            comp.Oscillator.EmulationStarted = true;

            lblStatus.Text = "CHIP-8 emulation successfully started.";
        }

        private void OnComputerStop(object sender, EventArgs e)
        {
            enable_cmd(Command.Start, true);
            enable_cmd(Command.Stop, false);

            comp.Oscillator.EmulationStarted = false;

            lblStatus.Text = "CHIP-8 emulation successfully stopped.";
        }

        private void OnComputerColdReset(object sender, EventArgs e)
        {
            if (comp.Oscillator.EmulationStarted)
                itemStop.PerformClick();

            enable_cmd(Command.Start, false);

            comp.PowerCycle();

            lblStatus.Text = "The CHIP-8 has been cold reset.";
        }

        private void OnComputerWarmReset(object sender, EventArgs e)
        {
            bool emuStarted = comp.Oscillator.EmulationStarted;

            enable_cmd(Command.Start, !emuStarted && comp.ProgramPath != null);
            enable_cmd(Command.Stop, emuStarted && comp.ProgramPath != null);

            comp.Restart();

            lblStatus.Text = "The CHIP-8 has been warm reset.";
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void itemClearScrStart_CheckedChanged(object sender, EventArgs e)
        {
            comp.SetOptionFlag(Chip8.Computer.Options.ClearScreenOnReset, itemClearScrStart.Checked);

            lblStatus.Text = (itemClearScrStart.Checked)
                    ? "The screen will now be cleared on reset."
                    : "The screen will NOT be cleared on reset.";
        }

        private void itemModifyI_CheckedChanged(object sender, EventArgs e)
        {
            comp.SetOptionFlag(Chip8.Computer.Options.ModifyIOnFX55AndFX65, itemModifyI.Checked);

            lblStatus.Text = (itemModifyI.Checked)
                    ? "The I register will now be modified after instructions FX55 and FX65 execute."
                    : "The I register will now be left intact after instructions FX55 and FX65 execute.";
        }

        private void itemFont_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmiSender = sender as ToolStripMenuItem;

            foreach (ToolStripMenuItem item in availableFonts)
                item.Checked = false;

            tsmiSender.Checked = true;

            comp.FontPath = Application.StartupPath + "\\" + (string) tsmiSender.Tag;

            lblStatus.Text = "System font \"" + tsmiSender.Text + "\" has been successfully loaded!";
        }

        private void itemBuzzer_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmiSender = sender as ToolStripMenuItem;

            foreach (ToolStripMenuItem item in availableBuzzers)
                item.Checked = false;

            tsmiSender.Checked = true;

            comp.Buzzer.SoundPath = Application.StartupPath + "\\" + (string) tsmiSender.Tag;

            lblStatus.Text = "Buzzer \"" + tsmiSender.Text + "\" has been successfully set!";
        }

        private void itemSpeed_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmiSender = sender as ToolStripMenuItem;

            foreach (ToolStripMenuItem item in availableSpeeds)
                item.Checked = false;

            tsmiSender.Checked = true;

            comp.Processor.Speed = Int32.Parse(tsmiSender.Tag.ToString());

            lblStatus.Text = "Processor speed successfully set at " + comp.Processor.Speed.ToString() + " Hz.";
        }

        private void itemShowDevTools_CheckedChanged(object sender, EventArgs e)
        {
            menuDev.Visible = itemShowDevTools.Checked;

            foreach (ToolStripItem item in menuDev.DropDownItems)
                item.Enabled = itemShowDevTools.Checked;
        }

        private void itemDevMemViewer_Click(object sender, EventArgs e)
        {
            if (!frmMemViewer.Visible)
                frmMemViewer.Show(this);
            else
                frmMemViewer.Focus();
        }

        private void itemAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog(this);
        }
    }
}