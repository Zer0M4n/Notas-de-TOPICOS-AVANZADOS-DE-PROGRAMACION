using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace MENU
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            TABLA_CIUDAD WAOS = new TABLA_CIUDAD();
            WAOS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TABLA_FARMACIA WAOS = new TABLA_FARMACIA();
            WAOS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TABALA_PROPIETARIOS WAOS = new TABALA_PROPIETARIOS();
            WAOS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TABLA_MEDICAMENTOS WAOS = new TABLA_MEDICAMENTOS();
            WAOS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TABLA_CLIENTES WAOS = new TABLA_CLIENTES();
            WAOS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int opcio = comboBox1.SelectedIndex;
            switch(opcio)
            {
                case 0:
                    TABLA_CIUDAD waos = new TABLA_CIUDAD();
                    waos.Show();
                    break;
                case 1:
                    
                    TABLA_MEDICAMENTOS yes = new TABLA_MEDICAMENTOS();
                    yes.Show();
                    break;
                case 2:
                    TABALA_PROPIETARIOS waoss = new TABALA_PROPIETARIOS();
                    waoss.Show();
                    break;
                case 3:
                    TABLA_FARMACIA x = new TABLA_FARMACIA();
                    x.Show();

                    break;
                case 4:
                    TABLA_CLIENTES no = new TABLA_CLIENTES();
                    no.Show();
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
