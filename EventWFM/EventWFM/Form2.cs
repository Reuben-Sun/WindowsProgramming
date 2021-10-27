using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventWFM
{
    public partial class Form2 : Form
    {
        public delegate void TextEventHander(string strText);

        public TextEventHander textHander;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textHander != null)
            {
                textHander(textBox1.Text);

                Close();
            }
        }
    }
}
