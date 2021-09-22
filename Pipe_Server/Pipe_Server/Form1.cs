using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
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

        private void startButton_Click(object sender, EventArgs e)
        {
            NamedPipeServerStream pipeSeriver = new NamedPipeServerStream("testpipe", PipeDirection.Out);
            stageText.Text = "等待客户连接";
            pipeSeriver.WaitForConnection();
            try
            {
                StreamWriter sw = new StreamWriter(pipeSeriver);
                sw.AutoFlush = true;
                sw.WriteLine("hello world");
                sw.Close();

            }
            catch (IOException e1)
            {
                MessageBox.Show("ERROR: {0}", e1.Message);
                
            }
        }
    }
}
