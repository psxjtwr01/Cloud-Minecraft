using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // P/Invoke declarations
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
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

        public string v = "V1.0";
        public bool stream = false;
        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);
        const uint WDA_EXCLUDEFROMCAPTURE = 0x00000011;
        const uint WDA_NONE = 0x00000000;
        private Color[] rainbowColors = { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Violet };
        private int colorIndex = 0;
        private int nextColorIndex = 1;
        private const int transitionDuration = 2000; // Transition duration in milliseconds
        private DateTime transitionStartTime;
        private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            // Add event handlers for mouse events
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 50; // Update interval in milliseconds
            timer.AutoReset = true;
            timer.Elapsed += Timer_Tick;
            timer.Start();
            transitionStartTime = DateTime.Now;
        }

        private void Timer_Tick(object sender, ElapsedEventArgs e)
        {
            if (gamerMode.Checked)
            {
                TimeSpan elapsedTime = DateTime.Now - transitionStartTime;
                double transitionProgress = elapsedTime.TotalMilliseconds / transitionDuration;

                if (transitionProgress >= 1.0)
                {
                    colorIndex = nextColorIndex;
                    nextColorIndex = (nextColorIndex + 1) % rainbowColors.Length;
                    transitionStartTime = DateTime.Now;
                    Invalidate(); // Redraw the form only when the colors are changed
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (gamerMode.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    ChangeOutlineColor(control);
                }
            }
        }

        private void ChangeOutlineColor(Control control)
        {
            Color currentColor = InterpolateColor(rainbowColors[colorIndex], rainbowColors[nextColorIndex], 0); // Smooth transition not required in this method

            control.Paint += (sender, e) =>
            {
                Control c = (Control)sender;
                Pen pen = new Pen(currentColor, 2);
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, c.Width - 1, c.Height - 1));
            };
        }

        private Color InterpolateColor(Color color1, Color color2, double progress)
        {
            int red = (int)(color1.R + (color2.R - color1.R) * progress);
            int green = (int)(color1.G + (color2.G - color1.G) * progress);
            int blue = (int)(color1.B + (color2.B - color1.B) * progress);

            return Color.FromArgb(red, green, blue);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gamerMode.Checked)
            {

            }
            foreach (Control control in this.Controls)
            {
                ChangeOutlineColor(control); // Initially set to 0 to start from the first color
            }
        }
    }
}
