using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pipe_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //服务端
        private void startButton_Click(object sender, EventArgs e)
        {
            Thread linkThread = new Thread(new ThreadStart(Link));
            linkThread.IsBackground = true;
            linkThread.Start();
            stageText.Text = "等待客户连接";
        }

        void Link()
        {
            NamedPipeServerStream pipeSeriver = new NamedPipeServerStream("testpipe");
            
            pipeSeriver.WaitForConnection();
            try
            {
                //StreamWriter sw = new StreamWriter(pipeSeriver);
                //sw.AutoFlush = true;
                //sw.WriteLine("hello world");
                //sw.Close();
                //Console.WriteLine("有人连接！");
                StreamReader sr = new StreamReader(pipeSeriver);
                //Console.WriteLine(sr.ReadToEnd());
                this.Invoke((MethodInvoker)delegate { stageText.Text = sr.ReadLine(); });
            }
            catch (IOException e1)
            {
                MessageBox.Show("ERROR: {0}", e1.Message);

            }
        }
    }
}
