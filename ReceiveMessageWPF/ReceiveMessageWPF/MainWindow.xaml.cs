﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReceiveMessageWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int WM_COPYDATA = 0x004A;
        public MainWindow()
        {
            InitializeComponent();
        }
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData; // 任意值

            public int cbData;    // 指定lpData内存区域的字节数

            [MarshalAs(UnmanagedType.LPStr)]

            public string lpData; // 发送给目标窗口所在进程的数据

        }
        protected override void OnSourceInitialized(EventArgs e)

        {
            base.OnSourceInitialized(e);

            HwndSource hwndSource = PresentationSource.FromVisual(this) as HwndSource;

            if (hwndSource != null)

            {
                IntPtr handle = hwndSource.Handle;

                hwndSource.AddHook(new HwndSourceHook(WndProc));

            }

        }

        IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)

        {
            if (msg == WM_COPYDATA)

            {
                COPYDATASTRUCT cds = (COPYDATASTRUCT)Marshal.PtrToStructure(lParam, typeof(COPYDATASTRUCT)); // 接收封装的消息

                string rece = cds.lpData; // 获取消息内容

                // 自定义行为


               
                contentLabel.Content = rece;


            }
            return hwnd;


        }
    }
}
