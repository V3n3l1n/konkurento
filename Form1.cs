using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        Thread th1;
        Random rdm;
        Random rdm1;
        Thread th2;
        Random rdm2;
        Thread th3;
        Random rdm3;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(thread);
            th.Start();
        }

        public void thread()
        {
            for (int i = 0; i < 3; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Black, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 40, 20)); //Rectangle Figure
                Thread.Sleep(3);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            th1 = new Thread(thread1);
            th1.Start();
        }

        public void thread1()
        {
            for (int i = 0; i < 4; i++)
            {
                this.CreateGraphics().FillPolygon(Brushes.Blue, new Point[] { new Point(150, 100), new Point(100, 200), new Point(200, 200) }); //Triangle Figure 
                Thread.Sleep(2);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            th2 = new Thread(thread2);
            th2.Start();
        }

        public void thread2()
        {
            for (int i = 0; i < 5; i++)
            {
                this.CreateGraphics().DrawEllipse(new Pen(Brushes.Green, 4), new Rectangle(rdm2.Next(120, this.Width), rdm2.Next(120, this.Height), 15, 15)); //Circle Figure
                Thread.Sleep(4);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            th3 = new Thread(thread3);
            th3.Start();
        }

        public void thread3()
        {
            for (int i = 0; i < 6; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm3.Next(70, this.Width), rdm3.Next(70, this.Height), 10, 10)); //Square Figure
                Thread.Sleep(10);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            rdm = new Random();
            rdm1 = new Random();
            rdm2 = new Random();
            rdm3 = new Random();
        }
    }
}
