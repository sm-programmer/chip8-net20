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
using System.Diagnostics;

using Notifiable;
using Chip8.DataStructures;

namespace Chip8
{
    public class Processor : Generic.Processor
    {
        private ushort opcode;

        private InstructionDictionary instructions;

        private ushort _i;
        public ushort I
        {
            get { return _i; }
            private set
            {
                _i = value;
                OnPropertyChanged("I");
            }
        }

        private ushort _pc;
        public ushort PC
        {
            get { return _pc; }
            private set
            {
                _pc = value;
                OnPropertyChanged("PC");
            }
        }

        private byte _delay_timer;
        public byte DelayTimer
        {
            get { return _delay_timer; }
            private set
            {
                _delay_timer = value;
                OnPropertyChanged("DelayTimer");
            }
        }

        private byte _sound_timer;
        public byte SoundTimer
        {
            get { return _sound_timer; }
            private set
            {
                _sound_timer = value;
                OnPropertyChanged("SoundTimer");
            }
        }

        private byte _sp;
        public byte SP
        {
            get { return _sp; }
            private set
            {
                _sp = value;
                OnPropertyChanged("SP");
            }
        }

        private NotifiableList<ushort> _stack;
        public NotifiableList<ushort> Stack
        {
            get { return _stack; }
            private set { _stack = value; }
        }

        private NotifiableList<byte> _v;
        public NotifiableList<byte> V
        {
            get { return _v; }
            private set { _v = value; }
        }

        private bool _modify_I;
        public bool ModifyI
        {
            get { return _modify_I; }
            set { _modify_I = value; }
        }

        private bool printed;

        private Memory _main_RAM;
        public Memory MainRAM
        {
            private get { return _main_RAM; }
            set { _main_RAM = value; }
        }

        private Memory _video_RAM;
        public Memory VideoRAM
        {
            private get { return _video_RAM; }
            set { _video_RAM = value; }
        }

        private Keyboard _kb;
        public Keyboard Keyboard
        {
            private get { return _kb; }
            set { _kb = value; }
        }

        private bool playing;

        private Buzzer _buzz;
        public Buzzer Buzzer
        {
            private get { return _buzz; }
            set { _buzz = value; }
        }

        private Random rnd;

        public Processor()
            : base()
        {
            instructions = new InstructionDictionary();
            initializeInstructions();

            Draw = true;

            ModifyI = false;

            printed = false;
            playing = false;

            Stack = new NotifiableList<ushort>();
            for (int i = 0; i < 16; i++)
                Stack.Add(0);

            V = new NotifiableList<byte>();
            for (int i = 0; i < 16; i++)
                V.Add(0);

            // Reset random number generator.
            rnd = new Random();
        }

        private ushort get_nibbles(ushort value, ushort pattern)
        {
            return get_nibbles(value, pattern, 0);
        }

        private ushort get_nibbles(ushort value, ushort pattern, int shift)
        {
            return (ushort)((value & pattern) >> shift);
        }

        private void initializeInstructions()
        {
            instructions["00E0"] = clearScreen;
            instructions["00EE"] = returnFromSubroutine;
            instructions["1XXX"] = jumpToAddress;
            instructions["2XXX"] = callSubroutineAtAddress;
            instructions["3XXX"] = skipIfRegEqualToConst;
            instructions["4XXX"] = skipIfRegNotEqualToConst;
            instructions["5XX0"] = skipIfRegEqualToReg;
            instructions["6XXX"] = loadConstToReg;
            instructions["7XXX"] = addConstToRegNoCarry;
            instructions["8XX0"] = loadRegToReg;
            instructions["8XX1"] = bitwiseOrRegToReg;
            instructions["8XX2"] = bitwiseAndRegToReg;
            instructions["8XX3"] = bitwiseXorRegToReg;
            instructions["8XX4"] = addRegToRegWithCarry;
            instructions["8XX5"] = subtractRegToTegWithBorrow;
            instructions["8XX6"] = rightShiftRegSpillCarry;
            instructions["8XX7"] = invertedSubtractRegToRegWithBorrow;
            instructions["8XXE"] = leftShiftRegSpillCarry;
            instructions["9XX0"] = skipIfRegNotEqualToReg;
            instructions["AXXX"] = loadIWithAddress;
            instructions["BXXX"] = jumpToAddressWithOffsetInReg0;
            instructions["CXXX"] = bitwiseAndRandomNumberAndConst;
            instructions["DXXX"] = drawSpriteAndDetectCollision;
            instructions["EX9E"] = skipIfKeypressNameInRegIsPressed;
            instructions["EXA1"] = skipIfKeypressNameInRegIsNotPressed;
            instructions["FX07"] = loadRegWithDelayValue;
            instructions["FX0A"] = waitForKeypressAndStoreNameInReg;
            instructions["FX15"] = loadDelayValueWithReg;
            instructions["FX18"] = loadSoundTimerWithReg;
            instructions["FX1E"] = addRegToI;
            instructions["FX29"] = loadFontSpriteStartToI;
            instructions["FX33"] = loadBCDOfRegToStartI;
            instructions["FX55"] = dumpRegsToMemoryStartingAtI;
            instructions["FX65"] = populateRegsFromMemoryStartingAtI;
            instructions["XXXX"] = unrecognizedInstruction;
        }

        private void clearScreen()
        {
            // 00E0: Clears the screen.
            Debug.WriteLine("CLS");

            if (VideoRAM != null)
                VideoRAM.Clear();

            Draw = true;
            PC += 2;
        }

        private void returnFromSubroutine()
        {
            // 00EE: Returns from subroutine.
            Debug.WriteLine("RET");

            if (SP == 0)
                throw new Exception("Stack underflow.");

            PC = Stack[--SP];
            PC += 2;
        }

        private void jumpToAddress()
        {
            // 1NNN: Jump to location NNN.
            Debug.Print("JP 0x{0:X4}", get_nibbles(opcode, (ushort)0x0FFF).ToString());

            PC = get_nibbles(opcode, (ushort)0x0FFF);
        }

        private void callSubroutineAtAddress()
        {
            // 2NNN: Calls the subroutine at address NNN.
            Debug.Print("CALL 0x{0:X4}", get_nibbles(opcode, (ushort)0x0FFF).ToString());

            if (SP == 15)
                throw new Exception("Stack overflow.");

            Stack[SP++] = PC;
            PC = get_nibbles(opcode, (ushort)0x0FFF);
        }

        private void skipIfRegEqualToConst()
        {
            // 3XKK: If register VX contains the value KK, increment PC by 2. 
            Debug.Print("SE V{0:X}, 0x{1:X2}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00FF).ToString());

            if (V[get_nibbles(opcode, (ushort)0x0F00, 8)] == get_nibbles(opcode, (ushort)0x00FF))
                PC += 2;

            PC += 2;
        }

        private void skipIfRegNotEqualToConst()
        {
            // 4XKK: If register VX doesn't contain the value KK, increment PC by 2. 
            Debug.Print("SNE V{0:X}, 0x{1:X2}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00FF).ToString());

            if (V[get_nibbles(opcode, (ushort)0x0F00, 8)] != get_nibbles(opcode, (ushort)0x00FF))
                PC += 2;

            PC += 2;
        }

        private void skipIfRegEqualToReg()
        {
            // 5XY0: If registers VX and VY are equal, increment PC by 2.
            Debug.Print("SE V{0:X}, V{1:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            if (V[get_nibbles(opcode, (ushort)0x0F00, 8)] == V[get_nibbles(opcode, (ushort)0x00F0, 4)])
                PC += 2;

            PC += 2;
        }

        private void loadConstToReg()
        {
            // 6XKK: Put the value KK into register VX.
            Debug.Print("LD V{0:X}, 0x{1:X2}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00FF).ToString());

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] = (byte)get_nibbles(opcode, (ushort)0x00FF);
            PC += 2;
        }

        private void addConstToRegNoCarry()
        {
            // 7XKK: Add the value KK to register VX. (No carry generated.)
            Debug.Print("ADD V{0:X}, 0x{1:X2}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00FF).ToString());

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] += (byte)get_nibbles(opcode, (ushort)0x00FF);
            PC += 2;
        }

        private void loadRegToReg()
        {
            // 8XY0: Stores the value of register VY in register VX.
            Debug.Print("LD V{0:X}, V{1:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] = V[get_nibbles(opcode, (ushort)0x00F0, 4)];
            PC += 2;
        }

        private void bitwiseOrRegToReg()
        {
            // 8XY1: Perform bitwise OR between registers VX and VY.
            //       Store the result in register VX.
            Debug.Print("OR V{0:X}, V{1:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] |= V[get_nibbles(opcode, (ushort)0x00F0, 4)];
            PC += 2;
        }

        private void bitwiseAndRegToReg()
        {
            // 8XY2: Perform bitwise AND between registers VX and VY.
            //       Store the result in register VX.
            Debug.Print("AND V{0:X}, V{1:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] &= V[get_nibbles(opcode, (ushort)0x00F0, 4)];
            PC += 2;
        }

        private void bitwiseXorRegToReg()
        {
            // 8XY3: Perform bitwise XOR between registers VX and VY.
            //       Store the result in register VX.
            Debug.Print("XOR V{0:X}, V{1:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] ^= V[get_nibbles(opcode, (ushort)0x00F0, 4)];
            PC += 2;
        }

        private void addRegToRegWithCarry()
        {
            // 8XY4: Add the values of registers VX and VY.
            //       Store the result in register VX.
            //       If VX + VY > 0xFF, set VF = 1; otherwise, set VF = 0.
            Debug.Print("ADD V{0:X}, V{1:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            if ((ushort)V[get_nibbles(opcode, (ushort)0x0F00, 8)] + V[get_nibbles(opcode, (ushort)0x00F0, 4)] > 0xFF)
                V[0xF] = 1;
            else
                V[0xF] = 0;

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] += V[get_nibbles(opcode, (ushort)0x00F0, 4)];
            PC += 2;
        }

        private void subtractRegToTegWithBorrow()
        {
            // 8XY5: Subtract the value of register VY from register VX.
            //       Store the result in register VX.
            //       If VX > VY, set VF = 1; otherwise, set VF = 0.
            Debug.Print("SUB V{0:X}, V{1:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            if (V[get_nibbles(opcode, (ushort)0x0F00, 8)] > V[get_nibbles(opcode, (ushort)0x00F0, 4)])
                V[0xF] = 1;
            else
                V[0xF] = 0;

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] -= V[get_nibbles(opcode, (ushort)0x00F0, 4)];
            PC += 2;
        }

        private void rightShiftRegSpillCarry()
        {
            // 8XY6: Shift register VX 1 position to the right.
            //       Set VF to the LSB of VX before the shift.
            Debug.Print("SHR V{0:X} {{, V{1:X}}}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            V[0xF] = (byte)((V[get_nibbles(opcode, (ushort)0x0F00, 8)]) & 0x1);

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] >>= 1;
            PC += 2;
        }

        private void invertedSubtractRegToRegWithBorrow()
        {
            // 8XY7: Subtract the value of register VX from register VY.
            //       Store the result in register VX.
            //       If VY > VX, set VF = 1; otherwise, set VF = 0.
            Debug.Print("SUBN V{0:X}, V{1:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            if (V[get_nibbles(opcode, (ushort)0x00F0, 4)] > V[get_nibbles(opcode, (ushort)0x0F00, 8)])
                V[0xF] = 1;
            else
                V[0xF] = 0;

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] = (byte)(V[get_nibbles(opcode, (ushort)0x00F0, 4)] - V[get_nibbles(opcode, (ushort)0x0F00, 8)]);
            PC += 2;
        }

        private void leftShiftRegSpillCarry()
        {
            // 8XYE: Shift register VX 1 position to the left.
            //       Set VF to the MSB of VX before the shift.
            Debug.Print("SHL V{0:X} {{, V{1:X}}}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            V[0xF] = (byte)(((V[get_nibbles(opcode, (ushort)0x0F00, 8)]) & 0x80) >> 7);
            V[get_nibbles(opcode, (ushort)0x0F00, 8)] <<= 1;
            PC += 2;
        }

        private void skipIfRegNotEqualToReg()
        {
            // 9XY0: If registers VX and VY are not equal, increment PC by 2.
            Debug.Print("SNE V{0:X}, V{1:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString());

            if (V[get_nibbles(opcode, (ushort)0x0F00, 8)] != V[get_nibbles(opcode, (ushort)0x00F0, 4)])
                PC += 2;

            PC += 2;
        }

        private void loadIWithAddress()
        {
            // ANNN: Sets I to the address NNN.
            Debug.Print("LD I, 0x{0:X4}", get_nibbles(opcode, (ushort)0x0FFF).ToString());

            I = get_nibbles(opcode, (ushort)0x0FFF);
            PC += 2;
        }

        private void jumpToAddressWithOffsetInReg0()
        {
            // BNNN: Jump to location NNN + the value of register V0.
            Debug.Print("JP V0, 0x{0:X4}", get_nibbles(opcode, (ushort)0x0FFF).ToString());

            PC = (ushort)(get_nibbles(opcode, (ushort)0x0FFF) + V[0]);
        }

        private void bitwiseAndRandomNumberAndConst()
        {
            // CXKK: Generate a random number between 0x00 and 0xFF.
            //       Perform a bitwise AND between this number and the value KK.
            //       Store the result in register VX.
            Debug.Print("RND V{0:X}, 0x{1:X2}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00FF).ToString());

            int randNum = rnd.Next(256);
            V[get_nibbles(opcode, (ushort)0x0F00, 8)] = (byte)(randNum & get_nibbles(opcode, (ushort)0x00FF));

            PC += 2;
        }

        private void drawSpriteAndDetectCollision()
        {
            // DXYN: Draw a sprite on the screen.
            //       Sprite data starts at the address stored in I.
            //       "N" bytes of data are read in total.
            //       The sprite is painted at coordinates (VX, VY).
            //       The screen contents are XORed with the sprite data.
            //       If any pixels are erased, set VF = 1; otherwise, set VF = 0.
            //       Any part of the sprite going outside the screen wraps around.
            Debug.Print("DRW V{0:X}, V{1:X}, 0x{2:X2}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString(), get_nibbles(opcode, (ushort)0x00F0, 4).ToString(), get_nibbles(opcode, (ushort)0x000F).ToString());

            if (VideoRAM == null)
            {
                PC += 2;
                return;
            }

            byte x0 = V[get_nibbles(opcode, (ushort)0x0F00, 8)];
            byte y0 = V[get_nibbles(opcode, (ushort)0x00F0, 4)];
            byte h = (byte)get_nibbles(opcode, (ushort)0x000F);

            byte pixel;
            int screen_pos;

            int xf, yf;

            V[0xF] = 0;

            for (int y = 0; y < h; y++)
            {
                pixel = MainRAM[I + y];

                for (int x = 0; x < 8; x++)
                {
                    if ((pixel & (0x80 >> x)) != 0)
                    {
                        xf = (x0 + x) % 64;
                        yf = (y0 + y) % 32;

                        screen_pos = (64 * yf) + xf;

                        if (VideoRAM[screen_pos] == 1)
                            V[0xF] = 1;

                        VideoRAM[screen_pos] ^= 1;
                    }
                }
            }

            Draw = true;
            PC += 2;
        }

        private void skipIfKeypressNameInRegIsPressed()
        {
            // EX9E: Checks if a key is pressed and its name is in register VX.
            //       If so, the next instruction is skipped.
            Debug.Print("SKP V{0:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            if (Keyboard == null)
            {
                PC += 2;
                return;
            }

            if (Keyboard.GetKeyState(V[get_nibbles(opcode, (ushort)0x0F00, 8)]))
                PC += 2;

            PC += 2;
        }

        private void skipIfKeypressNameInRegIsNotPressed()
        {
            // EXA1: Checks if the key with name in register VX is NOT pressed.
            //       If so, the next instruction is skipped.
            Debug.Print("SKNP V{0:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            if (Keyboard == null)
            {
                PC += 2;
                return;
            }

            if (!Keyboard.GetKeyState(V[get_nibbles(opcode, (ushort)0x0F00, 8)]))
                PC += 2;

            PC += 2;
        }

        private void loadRegWithDelayValue()
        {
            // FX07: Sets register VX to the current delay timer value.
            Debug.Print("LD V{0:X}, DT", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            V[get_nibbles(opcode, (ushort)0x0F00, 8)] = DelayTimer;
            PC += 2;
        }

        private void waitForKeypressAndStoreNameInReg()
        {
            // FX0A: Wait for a key press, then store its name in register VX.
            if (!printed)
            {
                Debug.Print("LD V{0:X}, K", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());
                printed = true;
            }

            if (Keyboard == null)
            {
                printed = false;
                PC += 2;
                return;
            }

            int last_keycode;
            if ((last_keycode = Keyboard.LastKeyIndex) == Keyboard.NoKeyPress)
                return; //break;

            printed = false;
            V[get_nibbles(opcode, (ushort)0x0F00, 8)] = (byte)last_keycode;

            // Avoid getting the key "stuck" for an entire display refresh!
            Keyboard.ClearLastIndex();

            PC += 2;
        }

        private void loadDelayValueWithReg()
        {
            // FX15: Sets the delay timer to the value stored in register VX.
            Debug.Print("LD DT, V{0:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            DelayTimer = V[get_nibbles(opcode, (ushort)0x0F00, 8)];
            PC += 2;
        }

        private void loadSoundTimerWithReg()
        {
            // FX18: Sets the sound timer to the value stored in register VX.
            Debug.Print("LD ST, V{0:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            SoundTimer = V[get_nibbles(opcode, (ushort)0x0F00, 8)];

            // The sound should immedately start playing,
            // BUT only if the value is different from zero.
            if (SoundTimer != 0)
            {
                playing = true;

                if (Buzzer != null)
                    Buzzer.Play();
            }

            PC += 2;
        }

        private void addRegToI()
        {
            // FX1E: Adds the value of the register VX to I.
            Debug.Print("ADD I, V{0:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            I += V[get_nibbles(opcode, (ushort)0x0F00, 8)];
            PC += 2;
        }

        private void loadFontSpriteStartToI()
        {
            // FX29: Sets I to the start of a predefined sprite's data.
            //       Predefined sprites are hexadecimal digits 0-F.
            //       The value of register VX indicates the sprite to use.
            Debug.Print("LD F, V{0:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            // As digits are 5 bytes long...
            I = (ushort)(5 * V[get_nibbles(opcode, (ushort)0x0F00, 8)]);
            PC += 2;
        }

        private void loadBCDOfRegToStartI()
        {
            // FX33: Store the BCD representation of VX in memory.
            //       The hundreds digit is stored at address I.
            //       The tens digit is stored at address I, +1.
            //       The units digit is stored at address I, +2.
            Debug.Print("LD B, V{0:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            MainRAM[I] = (byte)(V[get_nibbles(opcode, (ushort)0x0F00, 8)] / 100);
            MainRAM[I + 1] = (byte)((V[get_nibbles(opcode, (ushort)0x0F00, 8)] / 10) % 10);
            MainRAM[I + 2] = (byte)(V[get_nibbles(opcode, (ushort)0x0F00, 8)] % 10);
            PC += 2;
        }

        private void dumpRegsToMemoryStartingAtI()
        {
            // FX55: Copy the values of registers V0 through VX in memory.
            //       The destination starts at the address stored in I.
            Debug.Print("LD [I], V{0:X}", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            int noRegs = get_nibbles(opcode, (ushort)0x0F00, 8);

            for (int r = 0; r <= noRegs; r++)
                MainRAM[I + r] = V[r];

            // Per mattmik, I reg. should reflect the counting.
            // BEWARE: Game TICTAC doesn't work if counting is reflected!
            if (ModifyI)
                I += (ushort)(noRegs + 1);

            PC += 2;
        }

        private void populateRegsFromMemoryStartingAtI()
        {
            // FX65: Populate registers V0 through VX with data in memory.
            //       The source starts at the address stored in I.
            Debug.Print("LD V{0:X}, [I]", get_nibbles(opcode, (ushort)0x0F00, 8).ToString());

            int noRegs = get_nibbles(opcode, (ushort)0x0F00, 8);

            for (int r = 0; r <= noRegs; r++)
                V[r] = MainRAM[I + r];

            // Per mattmik, I reg. should reflect the counting.
            // BEWARE: Game TICTAC doesn't work if counting is reflected!
            if (ModifyI)
                I += (ushort)(noRegs + 1);

            PC += 2;
        }

        private void unrecognizedInstruction()
        {
            Debug.Print("Unknown opcode 0x{0:X4}.", opcode.ToString());
            PC += 2;
        }

        public override void Reset()
        {
            // Reset pointers and opcode register.
            PC = 0x200;
            opcode = 0;
            I = 0;
            SP = 0;

            // Clear stack and registers.
            for (int i = 0; i < 16; i++)
                Stack[i] = 0;
            for (int i = 0; i < 16; i++)
                V[i] = 0;

            // Reset timers.
            DelayTimer = 0;
            SoundTimer = 0;
        }

        public override void ExecuteCycles(int noCycles)
        {
            ExecuteCycles(noCycles, true);
        }

        public void ExecuteCycles(int noCycles, bool updateTimers)
        {
            if (noCycles <= 0)
                return;

            for (int i = 0; i < noCycles; i++)
                cycle_step();

            if (updateTimers)
                update_timers();
        }

        private void cycle_step()
        {
            // No code can be executed if no RAM is present at all! :P
            if (MainRAM == null)
                return;

            // Fetch opcode. (Big Endian, no boundary checking.)
            opcode = (ushort)((MainRAM[PC] << 8) | MainRAM[PC + 1]);

            // Decode and execute opcode.
            InstructionHandler instHandler = null;
            instructions.TryGetValue(opcode, out instHandler);

            //Debug.WriteLine(instHandler.Method.Name);

            if (instHandler != null)
                instHandler();
        }

        private void update_timers()
        {
            if (DelayTimer > 0)
                --DelayTimer;

            if (SoundTimer > 0)
                --SoundTimer;
            else if (playing)
            {
                playing = false;

                if (Buzzer != null)
                    Buzzer.Stop();
            }
        }
    }
}
