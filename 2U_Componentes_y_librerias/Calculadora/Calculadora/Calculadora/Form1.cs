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


namespace Calculadora
{
    
    public partial class Form1 : Form
    {
        //Movimiento del la barra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        //Varibles
        Double resultado = 0;
        bool valor_Entrada = false;
        public string Primer_Numero, Segundo_Numero;
        string operacion = string.Empty;
        
        public Form1()
        {
            InitializeComponent();

        }
        

        private void pnl_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }//Control de la ventana

        private void BtnNum_click(object sender, EventArgs e)//Contolas los numeros y cosas relacionados a este
        {
            if(Pantalla_Principal_TxtBox.Text == "0" || valor_Entrada)
            {
                Pantalla_Principal_TxtBox.Text = string.Empty;
            }

            valor_Entrada = false;
            Button btn_Numeros = (Button)sender;

            if(btn_Numeros.Text == ".")
            {
                if(!Pantalla_Principal_TxtBox.Text.Contains("."))
                {
                    Pantalla_Principal_TxtBox.Text = Pantalla_Principal_TxtBox.Text + btn_Numeros.Text;
                }
                
            }
            else
            {
                Pantalla_Principal_TxtBox.Text = Pantalla_Principal_TxtBox.Text + btn_Numeros.Text;

            }

        }

        private void Math_Operaciones(object sender, EventArgs e)//Controla las botones con operaciones matematicas y la pantalla
        {
            if(resultado != 0)
            {
                Btn_Igual.PerformClick();
            }
            else
            {
                resultado = Double.Parse(Pantalla_Principal_TxtBox.Text);
            }

            Button btn_Operadores = (Button)sender;

            operacion = btn_Operadores.Text;

            valor_Entrada = true;

            if(Pantalla_Principal_TxtBox.Text != "0")
            {
                Pantalla_Secundaria_TxtBox.Text = Primer_Numero = $"{resultado} {operacion}";
                Pantalla_Principal_TxtBox.Text = string.Empty;
                
            }


        }

        private void Btn_Igual_Click(object sender, EventArgs e)
        {
            Segundo_Numero = Pantalla_Principal_TxtBox.Text;
            Pantalla_Secundaria_TxtBox.Text = $"{Pantalla_Secundaria_TxtBox.Text}{Pantalla_Principal_TxtBox.Text} =";

            if(Pantalla_Principal_TxtBox.Text != string.Empty)
            {
                if (Pantalla_Principal_TxtBox.Text == "0")
                {
                    Pantalla_Secundaria_TxtBox.Text = string.Empty;   
                }

                switch(operacion)
                {
                    case "+" :
                        Pantalla_Principal_TxtBox.Text = (resultado + Double.Parse(Pantalla_Principal_TxtBox.Text)).ToString();
                        Pantalla_Historial_RichBox.AppendText($"{Primer_Numero}{Segundo_Numero} = {Pantalla_Principal_TxtBox.Text} \n");

                        break;

                    case "-":
                        Pantalla_Principal_TxtBox.Text = (resultado - Double.Parse(Pantalla_Principal_TxtBox.Text)).ToString();
                        Pantalla_Historial_RichBox.AppendText($"{Primer_Numero}{Segundo_Numero} = {Pantalla_Principal_TxtBox.Text} \n");

                        break;

                    case "/":
                        Pantalla_Principal_TxtBox.Text = (resultado / Double.Parse(Pantalla_Principal_TxtBox.Text)).ToString();
                        Pantalla_Historial_RichBox.AppendText($"{Primer_Numero}{Segundo_Numero} = {Pantalla_Principal_TxtBox.Text} \n");

                        break;
                    
                    case "*":
                        Pantalla_Principal_TxtBox.Text = (resultado * Double.Parse(Pantalla_Principal_TxtBox.Text)).ToString();
                        Pantalla_Historial_RichBox.AppendText($"{Primer_Numero}{Segundo_Numero} = {Pantalla_Principal_TxtBox.Text} \n");

                        break;

                    default:
                        Pantalla_Secundaria_TxtBox.Text = $"{Pantalla_Principal_TxtBox.Text} = ";
                        break;
                }

                resultado = double.Parse(Pantalla_Principal_TxtBox.Text);
                operacion = string.Empty;

            }

        }

        private void btn_Historial_Click(object sender, EventArgs e)
        {
            pnl_Historial.Height = (pnl_Historial.Height == 5) ? pnl_Historial.Height = 350 : 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Limpieza_Historial_Click(object sender, EventArgs e)
        {
            Pantalla_Historial_RichBox.Clear();
            if(Pantalla_Historial_RichBox.Text == string.Empty)
            {
                MessageBox.Show("No hay historial");
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            if (Pantalla_Principal_TxtBox.Text.Length > 0)
            {
                Pantalla_Principal_TxtBox.Text = Pantalla_Principal_TxtBox.Text.Remove(Pantalla_Principal_TxtBox.Text.Length - 1,1);

                if (Pantalla_Principal_TxtBox.Text == string.Empty)
                {
                    Pantalla_Principal_TxtBox.Text = "0";
                }
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            Pantalla_Principal_TxtBox.Text = "0";
            Pantalla_Secundaria_TxtBox.Text = string.Empty;
            resultado = 0;
        }


        private void btn_Ce_Click(object sender, EventArgs e)
        {
            Pantalla_Principal_TxtBox.Text = "0";

        }

        private void Operaciones_Especiales_click(object sender, EventArgs e)
        {
            Button btn_Espcial = (Button)sender;

            operacion = btn_Espcial.Text;

            switch (operacion)
            {
                case "%":
                    Pantalla_Secundaria_TxtBox.Text = $"%{Pantalla_Principal_TxtBox.Text}";
                    Pantalla_Principal_TxtBox.Text = Convert.ToString(Convert.ToDouble(Pantalla_Principal_TxtBox.Text) / Convert.ToDouble(100) );

                    break;

                case "²√":
                    Pantalla_Secundaria_TxtBox.Text = $"√{Pantalla_Principal_TxtBox.Text}";
                    Pantalla_Principal_TxtBox.Text = Convert.ToString(Math.Sqrt(Double.Parse(Pantalla_Principal_TxtBox.Text)));
                    break;

                case "x³":
                    Pantalla_Secundaria_TxtBox.Text = $"√{Pantalla_Principal_TxtBox.Text}";
                    Pantalla_Principal_TxtBox.Text = Convert.ToString(Math.Pow(Double.Parse(Pantalla_Principal_TxtBox.Text), 3));
                    break;

                case "³√":
                    Pantalla_Secundaria_TxtBox.Text = $"³√{Pantalla_Principal_TxtBox.Text}";
                    Pantalla_Principal_TxtBox.Text = Convert.ToString(Math.Pow(Double.Parse(Pantalla_Principal_TxtBox.Text), 1/3));
                    
                    break;

                case "x²":
                    Pantalla_Secundaria_TxtBox.Text = $"{Pantalla_Principal_TxtBox.Text}";
                    Pantalla_Principal_TxtBox.Text = Convert.ToString(Math.Pow(Double.Parse(Pantalla_Principal_TxtBox.Text), 2));
                    break;
                case "+/-":
                    Pantalla_Principal_TxtBox.Text = Convert.ToString(-1 * Convert.ToDouble(Pantalla_Principal_TxtBox.Text));
                    break;
                default:

                    break;
            }

            Pantalla_Historial_RichBox.AppendText($"{Pantalla_Secundaria_TxtBox.Text}{Pantalla_Principal_TxtBox.Text}\n");

        }//Operaciones especiales

        private void Pantalla_Principal_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_Titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Historial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pantalla_Historial_RichBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pantalla_Secundaria_TxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Control_Ventana_Click(object sender, EventArgs e)
        {
            Button btn_Ventana = (Button)sender;
            string Nombre_Ventana = "";
            Nombre_Ventana = btn_Ventana.Text;

            switch (Nombre_Ventana) 
            {
                case "minimize":
                    if (this.WindowState != FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Minimized;
                    }
                    break;
              
                case "Cerrar":
                    Application.Exit();
                    break;
            }
            
        }//Funcionalidad del los botones de la ventana


    }
}
