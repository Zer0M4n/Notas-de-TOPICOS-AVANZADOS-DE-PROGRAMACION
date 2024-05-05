using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            InitializeTimer();

        }

        private Timer timer;
        private int velocidadX = 10, velocidadY = 10;
        private int contador = 0;

        

        public void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            MoveButton();

            // Crear un nuevo botón para la estela
            Button trailButton = new Button();
            trailButton.Size = button1.Size;
            trailButton.Location = new Point(button1.Left, button1.Top);
            trailButton.BackColor = Color.Black; // Color con transparencia
            trailButton.FlatStyle = FlatStyle.Flat;
            trailButton.FlatAppearance.BorderSize = 0;
            this.Controls.Add(trailButton);

            // Incrementar el contador
            contador++;

            // Borrar el botón de la estela cada 5 botones
            if (contador >= 5)
            {
                ClearTrail();
                contador = 0;
            }
        }

        public void MoveButton()
        {
            button1.Left += velocidadX;
            button1.Top += velocidadY;

            // Detectar los bordes
            if (button1.Left <= 0 || button1.Right >= ClientSize.Width)
            {
                velocidadX = -velocidadX;
            }
            if (button1.Top <= 0 || button1.Bottom >= ClientSize.Height)
            {
                velocidadY = -velocidadY;
            }
        }

        public void ClearTrail()
        {
            // Eliminar todos los botones de la estela
            foreach (Control control in this.Controls)
            {
                if (control is Button && control != button1)
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        



    }
}
