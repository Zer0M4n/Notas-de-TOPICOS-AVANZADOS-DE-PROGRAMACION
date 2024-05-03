using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac
{
    public partial class Form1 : Form
    {
        //boton llamado juan
        private Button juan = new Button();
        public Form1()
        {
            boton();
            InitializeComponent();
            
        }
        //funcion de las propiedades del boton
        public void boton()
        {

            Controls.Add(juan);
            juan.Location = new System.Drawing.Point(300, 100);
            juan.Size = new System.Drawing.Size(100, 50);
            juan.BackColor = System.Drawing.Color.Orange;
            juan.Text = "juan";
            juan.Click += new EventHandler(click);
           

        }
        //funcion cuando se hace click
        private void click(object sender, EventArgs e)
        {
            this.Close();//cierra el pprograma
        }
       
    }
}
