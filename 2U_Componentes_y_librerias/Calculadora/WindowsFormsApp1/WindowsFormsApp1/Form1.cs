using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Calculadora.Form1 JUAN = new Calculadora.Form1();
        
        public Form1()

        {
            InitializeComponent();
            JUAN.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
