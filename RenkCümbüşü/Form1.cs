using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RenkCümbüşü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th;
        Thread th1;
        Random rnd;

        private void BtnKırmızı_Click(object sender, EventArgs e)
        {
            th = new Thread(thread);
            th.Start();
        }
        public void thread()
        {
            for (int i = 0; i < 100; i++)//100Adet
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 20, 20));//Burada 20,20 Değiştirdiğin zaman Kare DikDörtgen Oluyor Dene Gör Güzel
                //Burası Dikdörtgenin kalınlığı (Brushes.Blue, 4), Rakamı değiştir göreceksin
                Thread.Sleep(100);
            }
            MessageBox.Show("Kırmızı Renk Tamamlandı....");
        }
        public void threadb()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rnd.Next(0, this.Width), rnd.Next(0, this.Height), 20, 20));//Burada 20,20 Değiştirdiğin zaman Kare DikDörtgen Oluyor Dene Gör Güzel
                Thread.Sleep(100);
                //Burası Dikdörtgenin kalınlığı (Brushes.Blue, 4), Rakamı değiştir göreceksin
            }
            MessageBox.Show("Mavi Renk Tamamlandı.....");
        }
        private void BtnMavi_Click(object sender, EventArgs e)
        {
            th1 = new Thread(threadb);
            th1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }
    }
}
