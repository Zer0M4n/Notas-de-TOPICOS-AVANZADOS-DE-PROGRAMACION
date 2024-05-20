using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras_Hilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
        Thread[] hilos = new Thread[5];
        public void Meta()
        {

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            btn_Iniciar.Enabled = false;
            for (int i = 0; i < hilos.Length; i++)
            {
                hilos[i] = new Thread(Metodo);
                hilos[i].Name = "h" + i;
                hilos[i].Start();

            }
            btn_Iniciar.Enabled = true;

        }

        delegate void dele(PictureBox pb, int laY, int vel);
        public int random()
        {
            Random n = new Random();
            return n.Next(1, 15);
        }
        public void Metodo()
        {
            dele elDelegado = new dele(Mover);


            if (Thread.CurrentThread.Name.Equals("h0"))
            {
                elDelegado.Invoke(Moto_1, Moto_1.Location.Y, random());
            }
            else if (Thread.CurrentThread.Name.Equals("h1"))
            {
                elDelegado.Invoke(Moto_2, Moto_2.Location.Y, random());
            }
            else if (Thread.CurrentThread.Name.Equals("h2"))
            {
                elDelegado.Invoke(Moto_3, Moto_3.Location.Y, random());
            }
            else if (Thread.CurrentThread.Name.Equals("h3"))
            {
                elDelegado.Invoke(Moto_4, Moto_4.Location.Y, random());
            }
            else if (Thread.CurrentThread.Name.Equals("h4"))
            {
                elDelegado.Invoke(Moto_5, Moto_5.Location.Y, random());
            }

        }



        public void Mover(PictureBox pb, int laY, int vel)
        {
            for (int i = 0; i < 615; i++)
            {
                pb.Location = new Point(i, laY);

                if (Thread.CurrentThread.Name.Equals("h0"))
                {
                    Thread.Sleep(vel);

                }
                else if (Thread.CurrentThread.Name.Equals("h1"))
                {
                    Thread.Sleep(vel);
                }
                else if (Thread.CurrentThread.Name.Equals("h2"))
                {
                    Thread.Sleep(vel);
                }
                else if (Thread.CurrentThread.Name.Equals("h3"))
                {
                    Thread.Sleep(vel);
                }
                else if (Thread.CurrentThread.Name.Equals("h4"))
                {
                    Thread.Sleep(vel);
                }

            }
        }

        private void btn_Pausar_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < hilos.Length; i++)
            {
                hilos[i].Suspend();
            }


        }

        private void Btn_Reanudar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hilos.Length; i++)
            {
                hilos[i].Resume();
            }
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hilos.Length; i++)
            {
                hilos[i].Abort();
            }
            Moto_1.Location = new Point(18, 295);
            Moto_2.Location = new Point(18, 343);
            Moto_3.Location = new Point(18, 391);
            Moto_4.Location = new Point(18, 439);
            Moto_5.Location = new Point(18, 487);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
