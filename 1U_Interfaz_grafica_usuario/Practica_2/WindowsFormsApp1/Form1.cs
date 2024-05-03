using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int velocidadX = 10, velocidadY = 10;
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MoveButton();

            // Crear un nuevo botón para la estela
            BotonElipse trailButton = new BotonElipse();
            trailButton.Size = botonElipse1.Size;
            trailButton.Location = new Point(botonElipse1.Left, botonElipse1.Top);
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

        private void MoveButton()
        {
            botonElipse1.Left += velocidadX;
            botonElipse1.Top += velocidadY;

            // Detectar los bordes
            if (botonElipse1.Left <= 0 || botonElipse1.Right >= ClientSize.Width)
            {
                velocidadX = -velocidadX;
            }
            if (botonElipse1.Top <= 0 || botonElipse1.Bottom >= ClientSize.Height)
            {
                velocidadY = -velocidadY;
            }
        }

        private void ClearTrail()
        {
            // Eliminar todos los botones de la estela
            foreach (Control control in this.Controls)
            {
                if (control is Button && control != botonElipse1)
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        private void botonElipse1_Click(object sender, EventArgs e)
        {
            // Acción al hacer clic en el botón
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        
    }
}
