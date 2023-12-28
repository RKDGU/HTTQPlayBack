using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using InputSimulatorStandard;
using System.IO;


namespace HTTQ_PlayBack
{
    public partial class HTTQPlayBack : Form
    {
        // ############################################################################# start of the Program initiator // currently working 
        public HTTQPlayBack()
        {
            InitializeComponent();
            RichTextBoxDebug.Text = "Testing this";
            ButtonHookProcess.BackColor = Color.Red;
        }
        // ############################################################################# end of the Program initiator


        // ############################################################################# start of Memory Reader // currently working 
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);
        const int PROCESS_WM_READ = 0x0010;
        public static Process HTTQProcess;
        public static IntPtr processHandle;
        private void ButtonHookProcess_Click(object sender, EventArgs e) //actually not needed
        {
            try
            {
                HTTQProcess = Process.GetProcessesByName("MaiDFXvr_bleu")[0];
                processHandle = OpenProcess(PROCESS_WM_READ, false, HTTQProcess.Id);
                if (HTTQProcess.Handle != null)
                {
                    ButtonHookProcess.BackColor = Color.Green;
                    ButtonLoadTable.BackColor = Color.Red;
                    ButtonRecordTable.BackColor = Color.Green;
                    ButtonLoadTable.Enabled = true;
                    ButtonRecordTable.Enabled = true;
                }
            }
            catch
            {
                ButtonHookProcess.BackColor = Color.Red;
                ButtonLoadTable.Enabled = false;
                ButtonRecordTable.Enabled = false;
                MessageBox.Show("The process was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        public static int GetFrameCount()
        {
            int bytesRead = 0;
            byte[] buffer = new byte[4];
            ReadProcessMemory((int)processHandle, 0x625E80, buffer, buffer.Length, ref bytesRead);
            int FrameCountInMethod = BitConverter.ToInt32(buffer, 0);
            return FrameCountInMethod;
        }
        public static int GetGameTimeCount()
        {
            int bytesRead = 0;
            byte[] buffer = new byte[4];
            ReadProcessMemory((int)processHandle, 0x7B2FE4, buffer, buffer.Length, ref bytesRead);
            int GameTimeInMethod = BitConverter.ToInt32(buffer, 0);
            return GameTimeInMethod;
        }
        public static float GetCoordinatesX()
        {
            int bytesRead = 0;
            byte[] buffer = new byte[4];
            IntPtr Address = (IntPtr)0x756E64;
            ReadProcessMemory((int)processHandle, 0x03A9A5F0 + 0x0 + 0x14 + 0xC + 0x0 + 0x340 + 0x84 + 0x288, buffer, buffer.Length, ref bytesRead);
            //ReadProcessMemory((int)processHandle, 0x03EAEAB4, buffer, buffer.Length, ref bytesRead);
            float CoordinatesInMethod = BitConverter.ToSingle(buffer, 0);
            return CoordinatesInMethod;
        }
        // ############################################################################# end of Memory Reader


        // ############################################################################# start of KeyInput Helper // currently working
        //play inputs
        public static void SendKeyDownUp()//0
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.UP);
        }
        public static void SendKeyUpUp()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.UP);
        }
        public static void SendKeyDownDown()//1
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.DOWN);
        }
        public static void SendKeyUpDown()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.DOWN);
        }
        public static void SendKeyDownLeft()//2
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.LEFT);
        }
        public static void SendKeyUpLeft()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.LEFT);
        }
        public static void SendKeyDownRight()//3
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.RIGHT);
        }
        public static void SendKeyUpRight()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.RIGHT);
        }
        public static void SendKeyDownLShift()//4
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.LSHIFT);
        }
        public static void SendKeyUpLShift()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.LSHIFT);
        }
        public static void SendKeyDownLControl()//5
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.LCONTROL);
        }
        public static void SendKeyUpLControl()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.LCONTROL);
        }
        public static void SendKeyDownQ()//6
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.LEFT);
        }
        public static void SendKeyUpQ()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.VK_Q);
        }
        public static void SendKeyDownE()//7
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.VK_E);
        }
        public static void SendKeyUpE()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.VK_E);
        }
        public static void SendKeyDownSpace()//8
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.SPACE);
        }
        public static void SendKeyUpSpace()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.SPACE);
        }
        public static void SendKeyDownX()//9
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.VK_X);
        }
        public static void SendKeyUpX()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.VK_X);
        }
        public static void SendKeyDownZ()//10
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.VK_Z);
        }
        public static void SendKeyUpZ()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.VK_Z);
        }
        public static void SendKeyDownDelete()//11
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.DELETE);
        }
        public static void SendKeyUpDelete()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.DELETE);
        }
        public static void SendKeyDownEnter()//12
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.RETURN);
        }
        public static void SendKeyUpEnter()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.RETURN);
        }
        public static void SendKeyDownTab()//13
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.TAB);
        }
        public static void SendKeyUpTab()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.TAB);
        }
        public static void SendKeyDownNum0()//14
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.NUMPAD0);
        }
        public static void SendKeyUpNum0()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.NUMPAD0);
        }
        public static void SendKeyDownEsc()//15
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.ESCAPE);
        }
        public static void SendKeyUpEsc()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.ESCAPE);
        }
        public static void SendKeyDownHome()//16
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyDown(InputSimulatorStandard.Native.VirtualKeyCode.HOME);
        }
        public static void SendKeyUpHome()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.HOME);
        }
        public static void SendKeysUp()
        {
            var sim = new InputSimulator();
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.LCONTROL);
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.UP);
            sim.Keyboard.KeyUp(InputSimulatorStandard.Native.VirtualKeyCode.LSHIFT);
        }

        //record Inputs
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int keyCode);
        private enum KeyStates
        {
            None = 0,
            Down = 1,
            Toggled = 2
        }
        private static KeyStates GetKeyState(Keys key)
        {
            KeyStates state = KeyStates.None;

            short retVal = GetKeyState((int)key);

            //If the high-order bit is 1, the key is down
            //otherwise, it is up.
            if ((retVal & 0x8000) == 0x8000)
                state |= KeyStates.Down;

            //If the low-order bit is 1, the key is toggled.
            if ((retVal & 1) == 1)
                state |= KeyStates.Toggled;

            return state;
        }
        public static bool IsKeyDown(Keys key)
        {
            return KeyStates.Down == (GetKeyState(key) & KeyStates.Down);
        }
        public static bool IsKeyToggled(Keys key)
        {
            return KeyStates.Toggled == (GetKeyState(key) & KeyStates.Toggled);
        }
        // ############################################################################# end of KeyInput Helper


        // ############################################################################# start of CSV Table Helper // currently working
        public static string TablePath;
        public static int[,] ReadTable()
        {
            int TableSize = GetTableSize();
            int[,] InputTable = new int[17, TableSize];
            TextReader reader = File.OpenText(TablePath);
            string Line = reader.ReadLine();
            string[] LineArray = Line.Split(';');
            int Row = 0;

            while (Row != TableSize-1)
            {
                Line = reader.ReadLine();
                LineArray = Line.Split(';');
                int Collum = 0;
                while (Collum != 17)
                {
                    InputTable[Collum, Row] = int.Parse(LineArray[Collum]);
                    Collum++;
                }
                Row++;
            }
            return InputTable;
        }
        public static int GetTableSize()
        {
            int TableSize = 0;
            TextReader reader = File.OpenText(TablePath);
            string Line = reader.ReadLine();
            while (Line != null)
            { 
                Line = reader.ReadLine();
                TableSize++;
            }
            return TableSize;
        }
        // ############################################################################# end of CSV Table Helper


        // ############################################################################# start of Set Active Window Helper // currently working 
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32.dll")]
        private static extern IntPtr SetActiveWindow(IntPtr hwnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private static void FocusHTTQWindow()
        {
            // set focus back to and show application for faster input
            // SW_RESTORE = 9
            ShowWindow(HTTQProcess.MainWindowHandle, 9);
            SetForegroundWindow(HTTQProcess.MainWindowHandle);
            SetActiveWindow(HTTQProcess.MainWindowHandle);
        }
        // ############################################################################# end of Set Active Window Helper


        // ############################################################################# start of Forms Inputs
        private void ButtonPlayTable_Click(object sender, EventArgs e)
        {
                ButtonPlayTable.BackColor = Color.Yellow;
                ButtonLoadTable.BackColor = Color.Orange;
                ButtonRecordTable.BackColor = Color.Orange;
                ButtonPlayTable.Enabled = false;
                ButtonLoadTable.Enabled = false;
                ButtonRecordTable.Enabled = false;
                StopVariable = 0;
                int TableSize = GetTableSize();
                ProgressBarFrameCount.Maximum = TableSize;
                ProgressBarFrameCount.Value = 0;
                backgroundPlay.RunWorkerAsync();
        }

        private void ButtonStopTable_Click(object sender, EventArgs e)
        {
            StopVariable = 1;
            //backgroundPlay.CancelAsync();//not working
            SendKeysUp();
            ButtonRecordTable.Enabled = true;

            ButtonRecordTable.BackColor = Color.Green;
            ButtonLoadTable.Enabled = true;
            if (ButtonLoadTable.BackColor != Color.Red)
            {
                ButtonPlayTable.Enabled = true;
                ButtonPlayTable.BackColor = Color.Green;
            }
        }

        private void ButtonLoadTable_Click(object sender, EventArgs e)
        {
            TablePath = @TextBoxTableSourcePath.Text;
            try
            {
                TextReader reader = File.OpenText(TablePath);
                ButtonLoadTable.BackColor = Color.Green;
                ButtonPlayTable.Enabled = true;
                ButtonPlayTable.BackColor = Color.Green;
                ButtonStopTable.Enabled = true;
                int TableSize = GetTableSize();
                LabelFrameCounter.Text = "0/"+(TableSize-1).ToString();
            }
            catch
            {
                ButtonLoadTable.BackColor = Color.Red;
                ButtonPlayTable.Enabled = false;
                ButtonStopTable.Enabled = false;
                MessageBox.Show("The Input Table was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void TextBoxTableSourcePath_TextChanged(object sender, EventArgs e)
        {
            ButtonLoadTable.BackColor = Color.Red;
            ButtonPlayTable.BackColor = Color.Red;
            ButtonPlayTable.Enabled = false;
            ButtonStopTable.Enabled = false;
        }

        private void ButtonRecordTable_Click(object sender, EventArgs e)
        {
            StopVariable = 0;
            ButtonRecordTable.Enabled = false;
            ButtonPlayTable.Enabled = false;
            ButtonRecordTable.BackColor = Color.Yellow;
            ButtonPlayTable.BackColor = Color.Orange;
            ButtonStopTable.Enabled = true;
            backgroundRecord.RunWorkerAsync();
        }
        private void RichTextBoxDebug_Click(object sender, EventArgs e)
        {
            float X = GetCoordinatesX();
            RichTextBoxDebug.Text = X.ToString();
        }

        // ############################################################################# end of Forms Inputs


        // ############################################################################# start of Runtime Loop

        public static int StopVariable;
        private void backgroundPlay_DoWork(object sender, DoWorkEventArgs e) // cancellation is not working
        {
            FocusHTTQWindow();
            int[,] InputTable = ReadTable();
            int TableSize = GetTableSize();
            int TableCount = 0;
            int FrameCount = GetFrameCount();
            if (checkBoxGT.Checked == true)
            {
                FrameCount = GetGameTimeCount();
            }
            int oldFrameCount = FrameCount;

            // Attempted the Program to wait to get similar starting conditions, didn't work for menueing
            //while (FrameCount <= 1500)
            //{
            //   FrameCount = GetGameTimeCount();
            //}


            //int n = 0; //Debug
            while (TableCount != TableSize && StopVariable != 1)
            {
                if (checkBoxInfo.Checked == true)
                {
                    this.Invoke(new Action(() =>
                    {
                        ProgressBarFrameCount.Value = ProgressBarFrameCount.Value + 1;
                        LabelFrameCounter.Text = (TableCount.ToString() + "/" + (TableSize - 1).ToString());
                        var lines = RichTextBoxNextInputs.Lines;
                        lines[0] = "U D L R Ru Ju SR SL Ac Sw Cb CM Ma In FP Me Mp " + FrameCount.ToString();
                        lines[1] = InputTable[0, TableCount].ToString() + " " +
                        InputTable[1, TableCount].ToString() + " " +
                        InputTable[2, TableCount].ToString() + " " +
                        InputTable[3, TableCount].ToString() + " " +
                        InputTable[4, TableCount].ToString() + "  " +
                        InputTable[5, TableCount].ToString() + "  " +
                        InputTable[6, TableCount].ToString() + "  " +
                        InputTable[7, TableCount].ToString() + "  " +
                        InputTable[8, TableCount].ToString() + "  " +
                        InputTable[9, TableCount].ToString() + "  " +
                        InputTable[10, TableCount].ToString() + "  " +
                        InputTable[11, TableCount].ToString() + "  " +
                        InputTable[12, TableCount].ToString() + "  " +
                        InputTable[13, TableCount].ToString() + "  " +
                        InputTable[14, TableCount].ToString() + "  " +
                        InputTable[15, TableCount].ToString() + "  " +
                        InputTable[16, TableCount].ToString();
                        if (TableCount != TableSize - 1)
                        {
                            lines[2] = InputTable[0, TableCount + 1].ToString() + " " +
                            InputTable[1, TableCount + 1].ToString() + " " +
                            InputTable[2, TableCount + 1].ToString() + " " +
                            InputTable[3, TableCount + 1].ToString() + " " +
                            InputTable[4, TableCount + 1].ToString() + "  " +
                            InputTable[5, TableCount + 1].ToString() + "  " +
                            InputTable[6, TableCount + 1].ToString() + "  " +
                            InputTable[7, TableCount + 1].ToString() + "  " +
                            InputTable[8, TableCount + 1].ToString() + "  " +
                            InputTable[9, TableCount + 1].ToString() + "  " +
                            InputTable[10, TableCount + 1].ToString() + "  " +
                            InputTable[11, TableCount + 1].ToString() + "  " +
                            InputTable[12, TableCount + 1].ToString() + "  " +
                            InputTable[13, TableCount + 1].ToString() + "  " +
                            InputTable[14, TableCount + 1].ToString() + "  " +
                            InputTable[15, TableCount + 1].ToString() + "  " +
                            InputTable[16, TableCount + 1].ToString();
                        };
                        if (TableCount != TableSize - 1 && TableCount != TableSize - 2)
                        {
                            lines[3] = InputTable[0, TableCount + 1].ToString() + " " +
                            InputTable[1, TableCount + 2].ToString() + " " +
                            InputTable[2, TableCount + 2].ToString() + " " +
                            InputTable[3, TableCount + 2].ToString() + " " +
                            InputTable[4, TableCount + 2].ToString() + "  " +
                            InputTable[5, TableCount + 2].ToString() + "  " +
                            InputTable[6, TableCount + 2].ToString() + "  " +
                            InputTable[7, TableCount + 2].ToString() + "  " +
                            InputTable[8, TableCount + 2].ToString() + "  " +
                            InputTable[9, TableCount + 2].ToString() + "  " +
                            InputTable[10, TableCount + 2].ToString() + "  " +
                            InputTable[11, TableCount + 2].ToString() + "  " +
                            InputTable[12, TableCount + 2].ToString() + "  " +
                            InputTable[13, TableCount + 2].ToString() + "  " +
                            InputTable[14, TableCount + 2].ToString() + "  " +
                            InputTable[15, TableCount + 2].ToString() + "  " +
                            InputTable[16, TableCount + 2].ToString();
                        };
                        if (TableCount != TableSize - 1 && TableCount != TableSize - 2 && TableCount != TableSize - 3)
                        {
                            lines[4] = InputTable[0, TableCount + 1].ToString() + " " +
                            InputTable[1, TableCount + 3].ToString() + " " +
                            InputTable[2, TableCount + 3].ToString() + " " +
                            InputTable[3, TableCount + 3].ToString() + " " +
                            InputTable[4, TableCount + 3].ToString() + "  " +
                            InputTable[5, TableCount + 3].ToString() + "  " +
                            InputTable[6, TableCount + 3].ToString() + "  " +
                            InputTable[7, TableCount + 3].ToString() + "  " +
                            InputTable[8, TableCount + 3].ToString() + "  " +
                            InputTable[9, TableCount + 3].ToString() + "  " +
                            InputTable[10, TableCount + 3].ToString() + "  " +
                            InputTable[11, TableCount + 3].ToString() + "  " +
                            InputTable[12, TableCount + 3].ToString() + "  " +
                            InputTable[13, TableCount + 3].ToString() + "  " +
                            InputTable[14, TableCount + 3].ToString() + "  " +
                            InputTable[15, TableCount + 3].ToString() + "  " +
                            InputTable[16, TableCount + 3].ToString();
                        };
                        if (TableCount != TableSize - 1 && TableCount != TableSize - 2 && TableCount != TableSize - 3 && TableCount != TableSize - 4)
                        {
                            lines[5] = InputTable[0, TableCount + 1].ToString() + " " +
                            InputTable[1, TableCount + 4].ToString() + " " +
                            InputTable[2, TableCount + 4].ToString() + " " +
                            InputTable[3, TableCount + 4].ToString() + " " +
                            InputTable[4, TableCount + 4].ToString() + "  " +
                            InputTable[5, TableCount + 4].ToString() + "  " +
                            InputTable[6, TableCount + 4].ToString() + "  " +
                            InputTable[7, TableCount + 4].ToString() + "  " +
                            InputTable[8, TableCount + 4].ToString() + "  " +
                            InputTable[9, TableCount + 4].ToString() + "  " +
                            InputTable[10, TableCount + 4].ToString() + "  " +
                            InputTable[11, TableCount + 4].ToString() + "  " +
                            InputTable[12, TableCount + 4].ToString() + "  " +
                            InputTable[13, TableCount + 4].ToString() + "  " +
                            InputTable[14, TableCount + 4].ToString() + "  " +
                            InputTable[15, TableCount + 4].ToString() + "  " +
                            InputTable[16, TableCount + 4].ToString();
                        };
                        if (TableCount != TableSize - 1 && TableCount != TableSize - 2 && TableCount != TableSize - 3 && TableCount != TableSize - 4 && TableCount != TableSize - 5)
                        {
                            lines[6] = InputTable[0, TableCount + 1].ToString() + " " +
                            InputTable[1, TableCount + 5].ToString() + " " +
                            InputTable[2, TableCount + 5].ToString() + " " +
                            InputTable[3, TableCount + 5].ToString() + " " +
                            InputTable[4, TableCount + 5].ToString() + "  " +
                            InputTable[5, TableCount + 5].ToString() + "  " +
                            InputTable[6, TableCount + 5].ToString() + "  " +
                            InputTable[7, TableCount + 5].ToString() + "  " +
                            InputTable[8, TableCount + 5].ToString() + "  " +
                            InputTable[9, TableCount + 5].ToString() + "  " +
                            InputTable[10, TableCount + 5].ToString() + "  " +
                            InputTable[11, TableCount + 5].ToString() + "  " +
                            InputTable[12, TableCount + 5].ToString() + "  " +
                            InputTable[13, TableCount + 5].ToString() + "  " +
                            InputTable[14, TableCount + 5].ToString() + "  " +
                            InputTable[15, TableCount + 5].ToString() + "  " +
                            InputTable[16, TableCount + 5].ToString();
                        };
                        RichTextBoxNextInputs.Lines = lines;
                    }));
                }

                while (oldFrameCount == FrameCount && StopVariable != 1) //waiting for the next Frame
                {
                    if (checkBoxGT.Checked == true)
                    {
                        FrameCount = GetGameTimeCount();
                    }
                    else
                    {
                        FrameCount = GetFrameCount();
                    }
                    //n++; // Debug
                    if (backgroundPlay.CancellationPending)
                    {
                        e.Cancel = true; //for cancellation not working
                        return;
                    }
                };
                if (InputTable[0, TableCount] == 1)
                {
                    SendKeyDownUp();
                }
                else
                {
                    SendKeyUpUp();
                }
                if (InputTable[1, TableCount] == 1)
                {
                    SendKeyDownDown();
                }
                else
                {
                    SendKeyUpDown();
                }
                if (InputTable[2, TableCount] == 1)
                {
                    SendKeyDownLeft();
                }
                else
                {
                    SendKeyUpLeft();
                }
                if (InputTable[3, TableCount] == 1)
                {
                    SendKeyDownRight();
                }
                else
                {
                    SendKeyUpRight();
                }
                if (InputTable[4, TableCount] == 1)
                {
                    SendKeyDownLShift();
                }
                else
                {
                    SendKeyUpLShift();
                }
                if (InputTable[5, TableCount] == 1)
                {
                    SendKeyDownLControl();
                }
                else
                {
                    SendKeyUpLControl();
                }
                if (InputTable[6, TableCount] == 1)
                {
                    SendKeyDownQ();
                }
                else
                {
                    SendKeyUpQ();
                }
                if (InputTable[7, TableCount] == 1)
                {
                    SendKeyDownE();
                }
                else
                {
                    SendKeyUpE();
                }
                if (InputTable[8, TableCount] == 1)
                {
                    SendKeyDownSpace();
                }
                else
                {
                    SendKeyUpSpace();
                }
                if (InputTable[9, TableCount] == 1)
                {
                    SendKeyDownX();
                }
                else
                {
                    SendKeyUpX();
                }
                if (InputTable[10, TableCount] == 1)
                {
                    SendKeyDownZ();
                }
                else
                {
                    SendKeyUpZ();
                }
                if (InputTable[11, TableCount] == 1)
                {
                    SendKeyDownDelete();
                }
                else
                {
                    SendKeyUpDelete();
                }
                if (InputTable[12, TableCount] == 1)
                {
                    SendKeyDownEnter();
                }
                else
                {
                    SendKeyUpEnter();
                }
                if (InputTable[13, TableCount] == 1)
                {
                    SendKeyDownTab();
                }
                else
                {
                    SendKeyUpTab();
                }
                if (InputTable[14, TableCount] == 1)
                {
                    SendKeyDownNum0();
                }
                else
                {
                    SendKeyUpNum0();
                }
                if (InputTable[15, TableCount] == 1)
                {
                    SendKeyDownEsc();
                }
                else
                {
                    SendKeyUpEsc();
                }
                if (InputTable[16, TableCount] == 1)
                {
                    SendKeyDownHome();
                }
                else
                {
                    SendKeyUpHome();
                }
                TableCount++;
                oldFrameCount = FrameCount;
                //Console.WriteLine(FrameCount.ToString() + " / " + n.ToString());
            }
            SendKeysUp();
            this.Invoke(new Action(() =>
            {
                ButtonPlayTable.BackColor = Color.Green;
                ButtonLoadTable.BackColor = Color.Green;
                ButtonRecordTable.BackColor = Color.Green;
                ButtonPlayTable.Enabled = true;
                ButtonLoadTable.Enabled = true;
                ButtonRecordTable.Enabled = true;
            }));
        }

        private void backgroundPlay_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }


        private void backgroundRecord_DoWork(object sender, DoWorkEventArgs e)
        {
            var RecCSV = new StringBuilder();
            int FrameCount = GetFrameCount();
            if (checkBoxGT.Checked == true)
            {
               FrameCount = GetGameTimeCount();
            }
            int oldFrameCount = FrameCount;
            int[] Input = new int[17];
            RecCSV.AppendLine("Up/Up;Down/Down;Left/Left;Right/Right;Run/Lshift;Jump/Lcontrol;SideStepR/Q;SideStepL/E;Action/Space;Sword/X;Crossbow/Z;ChooseMagic/Delete;Magic/Enter;Inventory/Tab;FPV/Num0;Menu/Esc;Map/Home;--;FrameCount;X");

            // Attempted the Program to wait to get similar starting conditions, didn't work for menueing
            //while (FrameCount <= 1500)
            //{
            //    FrameCount = GetGameTimeCount();
            //}

            while (StopVariable != 1)
            {
                while (oldFrameCount == FrameCount && StopVariable != 1) //waiting for the next Frame
                {
                    if(checkBoxGT.Checked == true) 
                    {
                        FrameCount = GetGameTimeCount();
                    } 
                    else
                    {
                        FrameCount = GetFrameCount();
                    }
                    //n++; // Debug
                };
                oldFrameCount = FrameCount;

                if (IsKeyDown(Keys.Up) == true)
                {
                    Input[0] = 1;
                }
                else
                {
                    Input[0] = 0;
                }
                if (IsKeyDown(Keys.Down) == true)
                {
                    Input[1] = 1;
                }
                else
                {
                    Input[1] = 0;
                }
                if (IsKeyDown(Keys.Left) == true)
                {
                    Input[2] = 1;
                }
                else
                {
                    Input[2] = 0;
                }
                if (IsKeyDown(Keys.Right) == true)
                {
                    Input[3] = 1;
                }
                else
                {
                    Input[3] = 0;
                }
                if (IsKeyDown(Keys.LShiftKey) == true)
                {
                    Input[4] = 1;
                }
                else
                {
                    Input[4] = 0;
                }
                if (IsKeyDown(Keys.LControlKey) == true)
                {
                    Input[5] = 1;
                }
                else
                {
                    Input[5] = 0;
                }
                if (IsKeyDown(Keys.Q) == true)
                {
                    Input[6] = 1;
                }
                else
                {
                    Input[6] = 0;
                }
                if (IsKeyDown(Keys.E) == true)
                {
                    Input[7] = 1;
                }
                else
                {
                    Input[7] = 0;
                }
                if (IsKeyDown(Keys.Space) == true)
                {
                    Input[8] = 1;
                }
                else
                {
                    Input[8] = 0;
                }
                if (IsKeyDown(Keys.X) == true)
                {
                    Input[9] = 1;
                }
                else
                {
                    Input[9] = 0;
                }
                if (IsKeyDown(Keys.Z) == true)
                {
                    Input[10] = 1;
                }
                else
                {
                    Input[10] = 0;
                }
                if (IsKeyDown(Keys.Delete) == true)
                {
                    Input[11] = 1;
                }
                else
                {
                    Input[11] = 0;
                }
                if (IsKeyDown(Keys.Return) == true)
                {
                    Input[12] = 1;
                }
                else
                {
                    Input[12] = 0;
                }
                if (IsKeyDown(Keys.Tab) == true)
                {
                    Input[13] = 1;
                }
                else
                {
                    Input[13] = 0;
                }
                if (IsKeyDown(Keys.NumPad0) == true)
                {
                    Input[14] = 1;
                }
                else
                {
                    Input[14] = 0;
                }
                if (IsKeyDown(Keys.Escape) == true)
                {
                    Input[15] = 1;
                }
                else
                {
                    Input[15] = 0;
                }
                if (IsKeyDown(Keys.Home) == true)
                {
                    Input[16] = 1;
                }
                else
                {
                    Input[16] = 0;
                }
                float X = GetCoordinatesX();
                var newLine = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15};{16};{17};{18};{19}", Input[0], Input[1], Input[2], Input[3], Input[4], Input[5], Input[6], Input[7], Input[8], Input[9], Input[10], Input[11], Input[12], Input[13], Input[14], Input[15], Input[16]," ", FrameCount, X);
                RecCSV.AppendLine(newLine);
            }
            File.WriteAllText(TextBoxTableRecordPath.Text, RecCSV.ToString());
        }




        // ############################################################################# end of Runtime Loop
    }
}
