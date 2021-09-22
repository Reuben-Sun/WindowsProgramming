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

namespace Pipe_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //客户端
        private void startButton_Click(object sender, EventArgs e)
        {
            NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "testpipe");
            pipeClient.Connect();
            //StreamReader sr = new StreamReader(pipeClient);
            //Console.WriteLine(sr.ReadToEnd());
            StreamWriter sr = new StreamWriter(pipeClient);
            sr.AutoFlush = true;
            if(textBox1.Text != null)
            {
                sr.WriteLine(textBox1.Text);
            }
            
            sr.Close();
            

        }
    }
}
