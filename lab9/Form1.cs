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

namespace lab9
{
    public partial class Form : System.Windows.Forms.Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private object locker = new object();
        public static int cnt_threads = 0;
        public Form()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lock (locker)
            {
                if (cnt_threads < maxNum.Value)
                {
                    cnt_threads++;
                    Thread thread = new Thread(new ThreadStart(new Circle(Convert.ToInt32(lifeTime.Value)*50, canvasBox).Draw));
                    thread.Start();
                }
            }
        }
    }

    class Circle
    {
        Random rnd = new Random();
        Graphics draw;
        int time, rndX, rndY, r = 0;
        Pen pen, penDelete;

        public Circle(int t, PictureBox canvas)
        {
            var border = 3;
            time = t;
            draw = canvas.CreateGraphics();
            rndX = rnd.Next(0, canvas.Width);
            rndY = rnd.Next(0, canvas.Height);
            pen = new Pen(Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)), border);
            penDelete = new Pen(canvas.BackColor, border);
        }

        public void Draw()
        {
            int interval = rnd.Next(1, 5);
            for (int i = 0; i < time; i++)
            {
                draw.DrawEllipse(penDelete, rndX - r / 2, rndY - r / 2, r, r);
                r+=interval;
                draw.DrawEllipse(pen, rndX - r / 2, rndY - r / 2, r, r);
                Thread.Sleep(30);
            }
            draw.DrawEllipse(penDelete, rndX - r / 2, rndY - r / 2, r, r);
            Interlocked.Decrement(ref Form.cnt_threads);
        }
    }
}


    
