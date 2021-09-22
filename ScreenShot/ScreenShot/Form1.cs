using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

       

        static ManualResetEvent capture_terminate_e = new ManualResetEvent(false);
        static ManualResetEvent capture_this_one_e = new ManualResetEvent(false);
        static ManualResetEvent[] me_cap = new ManualResetEvent[2];
        
        static void Capture_screen()
        {
            
            int s_width = Screen.PrimaryScreen.Bounds.Width;
            int s_height = Screen.PrimaryScreen.Bounds.Height;
            Bitmap b_1 = new Bitmap(s_width, s_height);
            Graphics g = Graphics.FromImage(b_1);
            me_cap[0] = capture_terminate_e;
            me_cap[1] = capture_this_one_e;

            //String init_dir_fn = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //String dest_fn = null;
            int index = 0;
            while (true)
            {
                int i = ManualResetEvent.WaitAny(me_cap, -1);

                if(i == 1)
                {
                    Console.WriteLine("截图！");
                    string fn = @"C:\Users\28240\Desktop\1\a" + index++ + ".bmp";
                    g.CopyFromScreen(0, 0, 0, 0, new Size(s_width, s_height));
                    b_1.Save(fn, System.Drawing.Imaging.ImageFormat.Bmp);
                    capture_this_one_e.Reset();
                }
                else if(i == 0)
                {
                    Console.WriteLine("结束！");
                    g.Dispose();
                    b_1.Dispose();
                    break;
                }
                
                
            }
            
           
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Thread drawThread = new Thread(new ThreadStart(Capture_screen));
            drawThread.IsBackground = true;
            drawThread.Start();
            capture_terminate_e.Reset();
            Console.WriteLine("进程开始！");
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            capture_terminate_e.Set();
        }

        private void shootButton_Click(object sender, EventArgs e)
        {
            capture_this_one_e.Set();

        }
    }
}
