using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        // P/Invoke declarations
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;



        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowText(IntPtr hWnd, string lpString);
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int GetWindowText(IntPtr hWnd, string lpString, int nMaxCount);
        static IntPtr FindMinecraftWindow()
        {
            IntPtr hwnd = IntPtr.Zero;
            IntPtr prevHwnd = IntPtr.Zero;
            while (true)
            {
                prevHwnd = FindWindowEx(IntPtr.Zero, prevHwnd, null, null);
                if (prevHwnd == IntPtr.Zero) break;
                const int bufferSize = 256;
                string windowTitle = new string(' ', bufferSize);
                GetWindowText(prevHwnd, windowTitle, bufferSize);
                if (windowTitle.Contains("1.8.9"))
                {
                    hwnd = prevHwnd;
                    break;
                }
                else if (windowTitle.Contains("Cloud client"))
                {
                    hwnd = prevHwnd;
                    break;
                }
            }
            return hwnd;
        }
        static void ChangeWindowTitle(IntPtr hwnd, string title)
        {
            SetWindowText(hwnd, title);
        }

        public string v = "V1.1";
        public bool stream = false;
        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);
        const uint WDA_EXCLUDEFROMCAPTURE = 0x00000011;
        const uint WDA_NONE = 0x00000000;


        public Form1()
        {
            InitializeComponent();
            // Add event handlers for mouse events
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            labelversion.Text = v;
        }

        private void streamproof_CheckedChanged(object sender, EventArgs e)
        {
            stream = streamproof.Checked;
            if (stream)
            {
                SetWindowDisplayAffinity(this.Handle, WDA_EXCLUDEFROMCAPTURE);
            }
            else
            {
                SetWindowDisplayAffinity(this.Handle, WDA_NONE);
            }
        }

        private void WinRename_CheckedChanged(object sender, EventArgs e)
        {
            if (WinRename.Checked)
            {
                IntPtr minecraftWindow = FindMinecraftWindow();
                if (minecraftWindow != IntPtr.Zero)
                {
                    ChangeWindowTitle(minecraftWindow, "Cloud Client version " + v);
                    Console.WriteLine("Title changed successfully.");
                }
                else
                {
                    Console.WriteLine("Minecraft window not found.");
                }
            }
            else
            {
                IntPtr minecraftWindow = FindMinecraftWindow();
                if (minecraftWindow != IntPtr.Zero)
                {
                    ChangeWindowTitle(minecraftWindow, "Minecraft 1.8.9 ");
                    Console.WriteLine("Title changed successfully.");
                }
                else
                {
                    Console.WriteLine("Minecraft window not found.");
                }
            }
        }

        // Event handler for when mouse is pressed down on the form
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Event handler for when mouse is moved on the form
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - (this.Width / 2);
                this.Top += e.Y - (this.Height / 2);
            }
        }

        // Event handler for when mouse is released from the form
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Add any cleanup logic if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelversion_Click(object sender, EventArgs e)
        {
            // Add any necessary logic for label click event
        }



        private void CPSvalue_Click(object sender, EventArgs e)
        {

        }

        private void leftcps_Scroll(object sender, EventArgs e)
        {
            CPSvalue.Text = (leftcps.Value.ToString() + " ");
        }

        private void checkboxToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxToggle.Checked)
            {
                AutoClicker.Start();
            }
            else
            {
                AutoClicker.Stop();
            }
        }
        int min;
        int max;
        IntPtr hwnd;
        public string getactivewindowname()
        {
            try
            {
                var activatedHandle = GetForegroundWindow();
                Process[] processes = Process.GetProcesses();
                foreach (Process clsprocess in processes)
                {
                    if (activatedHandle == clsprocess.MainWindowHandle)
                    {
                        string proccessname = clsprocess.ProcessName;
                        return proccessname;

                    }
                }
            }
            catch
            {

            }
            return "";
        }
        private void Random_Tick(object sender, EventArgs e)
        {
            if (checkboxToggle.Checked)
            {
                min = leftcps.Value - 6;
                max = leftcps.Value + 6;
                Random rand = new Random();
                randomTrack.Value = (rand.Next(min, max));
            }
        }

        private async void AutoClicker_Tick(object sender, EventArgs e)
        {
            try
            {
                AutoClicker.Interval = 1000 / randomTrack.Value;

            }
            catch
            {

            }
            if (checkboxToggle.Checked)
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hwnd = FindWindow(null, process.MainWindowTitle);
                }
            }
            string currentwindow = getactivewindowname();
            if (currentwindow == null)
            {
                return;
            }
            else if (currentwindow.Contains("javaw"))
            {
                if (MouseButtons == MouseButtons.Left)
                {
                    PostMessage(hwnd, 0x0201, 0, 0);
                    await Task.Delay(10);
                    PostMessage(hwnd, 0x0202, 0, 0);
                }
            }
        }

        private void awot_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = awot.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TABS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
