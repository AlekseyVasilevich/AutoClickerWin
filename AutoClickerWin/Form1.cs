using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MouseEventsArgs = System.Windows.Forms.MouseEventArgs;


namespace AutoClickerWin
{
    public partial class AutoClicker : Form
    {
        private const int WH_KEYBOARD_LL = 13;
        private LowLevelKeyboardProcDelegate m_callback;
        private IntPtr m_hHook;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(IntPtr lpModuleName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr LowLevelKeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var khs = (KeyboardHookStruct)
                          Marshal.PtrToStructure(lParam,
                          typeof(KeyboardHookStruct));
                if (Convert.ToInt32("" + wParam) == 256)
                {
                    if ((int)khs.VirtualKeyCode == 123)//F12
                    {
                        ButtonStop.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 113)//F2
                    {
                        ButtonStart.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                    if ((int)khs.VirtualKeyCode == 114)//F3
                    {
                        ButtonPickLoc.PerformClick();
                        WindowState = FormWindowState.Normal;
                    }
                }
            }
            return CallNextHookEx(m_hHook, nCode, wParam, lParam);
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            public readonly int VirtualKeyCode;
            public readonly int ScanCode;
            public readonly int Flags;
            public readonly int Time;
            public readonly IntPtr ExtraInfo;
        }
        private delegate IntPtr LowLevelKeyboardProcDelegate(
            int nCode, IntPtr wParam, IntPtr lParam);

        public void SetHook()
        {
            m_callback = LowLevelKeyboardHookProc;
            m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL, m_callback, GetModuleHandle(IntPtr.Zero), 0);
        }
        public void Unhook()
        {
            UnhookWindowsHookEx(m_hHook);
        }

        //[DllImport("user32.dll")]
        //static extern bool GetCursorPos(ref Point lpPoint);
        //static protected long totalPixels = 0;
        //static protected int diffX;
        //static protected int diffY;
        //bool isStart = false;




        //hooks for mouse
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        //absolut normalized coordinates
        private const int MOUSEEVENTS_ABSOLUTE = 0x8000;
        //press left button
        private const int MOUSEEVENTS_LEFTDOWN = 0x0002;
        //up left button
        private const int MOUSEEVENTS_LEFTUP = 0x0004;
        //press right button
        private const int MOUSEEVENTS_RIGHTDOWN = 0x0008;
        //up right button
        private const int MOUSEEVENTS_RIGHTUP = 0x0010;
        //mouse cursor movement
        private const int MOUSEEVENTS_MOVE = 0x0001;

        // determine the cursor position
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        static protected long totalPixals = 0;
        static protected int diffX;
        static protected int diffY;

        static public bool _isStart = false;
        public AutoClicker()
        {
            InitializeComponent();
            SetHook();
            this.Focus();
        }

        private void ButtonDouble_CheckedChanged(object sender, EventArgs e)
        {

        }

        // button to close app
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //button to role app
        private void RollButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // move window
        Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            _isStart = false;
            TextBoxForMins.Text = "0";
            TextBoxForSecs.Text = "0";
            TextBoxForX.Text = "0";
            TextBoxForY.Text = "0";
        }

        private void TextBoxForMins_KeyDown(object sender, KeyEventArgs e)
        {
            //if (Keyboard.IsKeyDown(Key.Back) && TextBoxForMins.Text.Length > 0)
            //{
            //    TextBoxForMins.Text = TextBoxForMins.Text.Substring(0, TextBoxForMins.Text.Length - 1);
            //}
        }

        private void TextBoxForMins_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if(!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void TextBoxForSecs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        // function to determine cursor position
        private void ButtonPickLoc_Click(object sender, EventArgs e)
        {
            Point defPnt = new Point();
            GetCursorPos(ref defPnt);
            TextBoxForX.Text = defPnt.X.ToString();
            TextBoxForY.Text = defPnt.Y.ToString();
        }

        async private void ButtonStart_Click(object sender, EventArgs e)
        {
            _isStart = true;
            Size resolution = Screen.PrimaryScreen.Bounds.Size;
            int X = 65535 / resolution.Width * Convert.ToInt32(TextBoxForX.Text);
            int Y = 65535 / resolution.Height * Convert.ToInt32(TextBoxForY.Text);

            while(_isStart)
            {
                if(ButtonLeft.Checked == true && ButtonOne.Checked == true)
                {
                    //перемещаем мышку на заданные координаты 
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_MOVE, X, Y, 0, 0);
                    //нажимаем левую кнопку мыши 1 раз
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_LEFTDOWN | MOUSEEVENTS_LEFTUP, X, Y, 0, 0);
                }
                if (ButtonLeft.Checked == true && ButtonDouble.Checked == true)
                {
                    //перемещаем мышку на заданные координаты 
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_MOVE, X, Y, 0, 0);
                    //нажимаем левую кнопку мыши 2 раза
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_LEFTDOWN | MOUSEEVENTS_LEFTUP, X, Y, 0, 0);
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_LEFTDOWN | MOUSEEVENTS_LEFTUP, X, Y, 0, 0);
                }
                if (ButtonRight.Checked == true && ButtonOne.Checked == true)
                {
                    //перемещаем мышку на заданные координаты 
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_MOVE, X, Y, 0, 0);
                    //нажимаем правую кнопку мыши 1 раз
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_RIGHTDOWN | MOUSEEVENTS_RIGHTUP, X, Y, 0, 0);
                }
                if (ButtonRight.Checked == true && ButtonDouble.Checked == true)
                {
                    //перемещаем мышку на заданные координаты 
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_MOVE, X, Y, 0, 0);
                    //нажимаем правую кнопку мыши 2 раза
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_RIGHTDOWN | MOUSEEVENTS_RIGHTUP, X, Y, 0, 0);
                    mouse_event(MOUSEEVENTS_ABSOLUTE | MOUSEEVENTS_RIGHTDOWN | MOUSEEVENTS_RIGHTUP, X, Y, 0, 0);
                }
                await Task.Delay(60000 * Convert.ToInt32(TextBoxForMins.Text) + 1000 * Convert.ToInt32(TextBoxForSecs.Text));
            }
        }

        private void ButtonLeft_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            if(ButtonLeft.Checked == false)
            {
                ButtonLeft.Checked = true;
                ButtonRight.Checked = false;
            }
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            if(ButtonRight.Checked == false)
            {
                ButtonRight.Checked = true;
                ButtonLeft.Checked = false;
            }
        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            if(ButtonOne.Checked == false)
            {
                ButtonOne.Checked = true;
                ButtonDouble.Checked = false;
            }
        }

        private void ButtonDouble_Click(object sender, EventArgs e)
        {
            if(ButtonDouble.Checked == false)
            {
                ButtonDouble.Checked = true;
                ButtonOne.Checked = false;
            }
        }
    }
}
