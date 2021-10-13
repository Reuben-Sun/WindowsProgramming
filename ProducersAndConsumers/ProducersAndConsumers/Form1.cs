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

namespace ProducersAndConsumers
{
    public partial class Form1 : Form
    {
        static Mutex mutex = new Mutex();   //互斥信号量
        static Semaphore empty = new Semaphore(10, 10);     //Semaphore(初始值，最大值)
        static Semaphore full = new Semaphore(0, 10);
        static int[] buffer = new int[10];      //大小为10的缓冲池
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int proNum = 1;
            if (!string.IsNullOrEmpty(producerText.Text))
            {
                proNum = int.Parse(producerText.Text);
            }
            int conNum = 1;
            if (!string.IsNullOrEmpty(consumerText.Text))
            {
                conNum = int.Parse(consumerText.Text);
            }
            for(int i = 0; i < proNum; i++)
            {
                new Thread(new ThreadStart(Producer)).Start();
            }
            for(int i = 0; i < conNum; i++)
            {
                new Thread(new ThreadStart(Customer)).Start();
            }
        }
        static uint ppointer = 0;
        private static void Producer()  //生产者
        {

            int temp;
            while (true)
            {
                empty.WaitOne();    //P(empty)
                mutex.WaitOne();    //P(mutex)
                //将一个产品送进缓冲区
                temp = rand.Next(1, 100);
                buffer[ppointer] = temp;
                Console.WriteLine("Producer works at {0} with {1}", ppointer, temp);
                ppointer = (ppointer + 1) % 10;
                mutex.ReleaseMutex();   //V(mutex)
                full.Release();         //V(full)
                Thread.Sleep(400);
            }
        }

        static uint cpointer = 0;
        private static void Customer()  //消费者
        {
            
            int temp;
            while (true)
            {
                full.WaitOne();     //P(full)
                mutex.WaitOne();    //P(mutex)
                //从缓冲区取一个产品
                temp = buffer[cpointer];
                Console.WriteLine("Customer gains at {0} with {1}", cpointer, temp);
                cpointer = (cpointer + 1) % 10;
                mutex.ReleaseMutex();   //V(mutex)
                empty.Release();        //V(empty)
                Thread.Sleep(400);
            }
        }
    }
}
