using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMessageWFM
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcesses();
            foreach (Process p in procs)
            {
                if (p.ProcessName.Equals("ReceiveMessageWFM"))
                {
                    IntPtr hWnd = p.MainWindowHandle;
                    int data = Convert.ToInt32(textBox1.Text);         
                    SendMessage(hWnd, WM_KEYDOWN, (IntPtr)data, (IntPtr)0);
                    Thread.Sleep(1000);
                    SendMessage(hWnd, WM_KEYUP, (IntPtr)0, (IntPtr)0);
                }
            }
        }
    }
}
