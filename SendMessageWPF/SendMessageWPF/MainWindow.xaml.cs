using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendMessageWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("User32.dll", EntryPoint = "SendMessage")]

        private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, ref COPYDATASTRUCT lParam);
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData; // 任意值

            public int cbData;    // 指定lpData内存区域的字节数

            [MarshalAs(UnmanagedType.LPStr)]

            public string lpData; // 发送给目标窗口所在进程的数据

        }
;

        const int WM_COPYDATA = 0x004A;



        public MainWindow()
        {

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = contentText.Text;

            // 枚举进程

            Process[] procs = Process.GetProcesses();

            foreach (Process p in procs)

            {

                if (p.ProcessName.Equals("ReceiveMessageWPF"))

                {
                    // 获取目标进程句柄

                    IntPtr hWnd = p.MainWindowHandle;

                    // 封装消息

                    byte[] sarr = System.Text.Encoding.Default.GetBytes(s);

                    int len = sarr.Length;

                    COPYDATASTRUCT cds2 = new COPYDATASTRUCT();

                    cds2.dwData = (IntPtr)0;

                    cds2.cbData = len + 1;

                    cds2.lpData = s;

                    // 发送消息

                    SendMessage(hWnd, WM_COPYDATA, IntPtr.Zero, ref cds2);

                }

            }

        }
    }
}
