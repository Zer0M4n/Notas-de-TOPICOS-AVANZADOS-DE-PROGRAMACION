using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_EQUIPO.FORMS
{
    public partial class Tabla_Promocion : Form
    {
        public Tabla_Promocion()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Tabla_Promocion_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Guardar.BackColor = Color.White;
            Guardar.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

            Guardar.BackColor = Color.Black;
            Guardar.ForeColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Eliminar.BackColor = Color.White;
            Eliminar.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Eliminar.BackColor = Color.Black;
            Eliminar.ForeColor = Color.White;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            Consultar.BackColor = Color.White;
            Consultar.ForeColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Consultar.BackColor = Color.Black;
            Consultar.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Modificar.BackColor = Color.White;
            Modificar.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Modificar.BackColor = Color.Black;
            Modificar.ForeColor = Color.White;
        }

        SqlConnection conexion = new SqlConnection(@"server= SNAKE.\SQLEXPRESS; Initial Catalog=BASE_TRABAJO; integrated security=true");
        /*IDPROM,NOMBREPROM,POBLACION,PLANOSITUACI*/
        private void Guardar_Click(object sender, EventArgs e)
        {
            //Se cre el comando para dar  de altas el sistema
            SqlCommand altas = new SqlCommand
                ("insert into TABLAPROM (IDPROM,NOMBREPROM,POBLACION,PLANOSITUACI) " +
                "values(@IDPROM,@NOMBREPROM,@POBLACION,@PLANOSITUACI)", conexion);

            //Obtiene  los valores de la txtbox
            altas.Parameters.AddWithValue("IDPROM", textBox1.Text);
            altas.Parameters.AddWithValue("NOMBREPROM", textBox2.Text);
            altas.Parameters.AddWithValue("POBLACION", textBox4.Text);
            altas.Parameters.AddWithValue("PLANOSITUACI", textBox3.Text);

            conexion.Open();
            altas.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("promocion almacenado");

            //Limpiamos los txtbox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            string baja = "DELETE FROM TABLAPROM WHERE IDPROM = @IDPROM";
            conexion.Open();

            SqlCommand cmdIns = new SqlCommand(baja, conexion);
            cmdIns.Parameters.Add("IDPROM", textBox1.Text);
            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;
            textBox1.Clear();

            //sw limpia

            conexion.Close();

            MessageBox.Show("Se a eliminado");
        }
        public void FILLDVG()
        {
            conexion.Open();
            string query = "Select * From TABLAPROM";
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            View_DataBase.DataSource = dt;
            conexion.Close();


        }
        private void Consultar_Click(object sender, EventArgs e)
        {
            FILLDVG();
        }

        public void Actualizacion()
        {

            try
            {
                string consulta = "select * from TABLACASA";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                View_DataBase.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron recuperar los datos" + ex.Message);
            }
        }
        private void Modificar_Click(object sender, EventArgs e)
        {

            //IDPROM,NOMBREPROM,POBLACION,PLANOSITUACI
            string Modificar = "UPDATE TABLAPROM SET NOMBREPROM=@NOMBREPROM,POBLACION=@POBLACION,PLANOSITUACI=@PLANOSITUACI ;";
            SqlCommand Modi = new SqlCommand(Modificar, conexion);
            conexion.Open();
            try
            {

                Modi.Parameters.AddWithValue("NOMBREPROM", textBox2.Text);
                Modi.Parameters.AddWithValue("POBLACION", textBox3.Text);
                Modi.Parameters.AddWithValue("PLANOSITUACI", textBox4.Text);
               



                Modi.ExecuteNonQuery();
                MessageBox.Show("Modificacion realizada con exito");
                Actualizacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la modificacion!!!!! " + ex);
            }
            finally
            {
                conexion.Close();
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
            }


        }

     
    }
}
