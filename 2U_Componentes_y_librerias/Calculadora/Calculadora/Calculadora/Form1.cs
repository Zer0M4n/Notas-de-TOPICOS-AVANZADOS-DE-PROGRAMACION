using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        Double resultValue = 0;
        String operacion_clear = "";
        bool operacio_verifica = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_clik(object sender, EventArgs e)
        {
            if((Resultado_tctbox.Text == "0") || (operacio_verifica))
                Resultado_tctbox.Clear(); 

            operacio_verifica = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!Resultado_tctbox.Text.Contains("."))
                    Resultado_tctbox.Text = Resultado_tctbox.Text + button.Text;

            }
            else
                Resultado_tctbox.Text = Resultado_tctbox.Text + button.Text;
        }

        private void operador_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button18.PerformClick();
                operacion_clear = button.Text;
                salida.Text = resultValue + " " + operacion_clear;
                operacio_verifica = true;
            }
            else
            {

                operacion_clear = button.Text;
                resultValue = Double.Parse(Resultado_tctbox.Text);
                salida.Text = resultValue + " " + operacion_clear;
                operacio_verifica = true;
            }

            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Resultado_tctbox.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Resultado_tctbox.Text = "0";
            resultValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operacion_clear)
            {
                case "+":
                    Resultado_tctbox.Text = (resultValue + Double.Parse(Resultado_tctbox.Text)).ToString();
                    break;
                case "-":
                    Resultado_tctbox.Text = (resultValue - Double.Parse(Resultado_tctbox.Text)).ToString();
                    break;
                case "*":
                    Resultado_tctbox.Text = (resultValue * Double.Parse(Resultado_tctbox.Text)).ToString();
                    break;
                case "/":
                    Resultado_tctbox.Text = (resultValue / Double.Parse(Resultado_tctbox.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(Resultado_tctbox.Text);
            salida.Text = "";
        }

    }
}
