using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLUseC__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport(@"D:\code\vs\CouseWork.net\WindowsProgramming\CreateDLL\Release\CreateDLL.dll", EntryPoint = "factorial", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        extern static int factorial(int a);

        [DllImport(@"D:\code\vs\CouseWork.net\WindowsProgramming\CreateDLL\Release\CreateDLL.dll", EntryPoint = "sub", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = false, CallingConvention = CallingConvention.StdCall)]
        extern static int sub(int x, int y);
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            if (!string.IsNullOrEmpty(numText1.Text))
            {
                i = int.Parse(numText1.Text);
            }
            ansLabel1.Text = factorial(i).ToString();
            //Console.WriteLine(factorial(4));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            if (!string.IsNullOrEmpty(numText2.Text))
            {
                x = int.Parse(numText2.Text);
            }
            if (!string.IsNullOrEmpty(numText3.Text))
            {
                y = int.Parse(numText3.Text);
            }
            ansLabel2.Text = sub(x,y).ToString();
            //Console.WriteLine(sub(5,1));
        }
    }
}
