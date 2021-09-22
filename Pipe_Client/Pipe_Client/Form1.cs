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

        private void startButton_Click(object sender, EventArgs e)
        {
            NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "testpipe", PipeDirection.In);
            pipeClient.Connect();
            StreamReader sr = new StreamReader(pipeClient);
            stageText.Text = sr.ReadToEnd();
        }
    }
}
