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

namespace PROYECTO_EQUIPO
{
    public partial class Tabla_Empresa : Form
    {
        public Tabla_Empresa()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server= .\SQLEXPRESS; Initial Catalog=BASE_TRABAJO; integrated security=true");
        /*IDEMPRESAS,NOMBRE,TIPO,DIRECCION,TELEFONO,FAX,CORREOELEC,IMPORTECONTRATO*/
        private void Guardar_Click(object sender, EventArgs e)
        {
            //Se cre el comando para dar  de altas el sistema
            SqlCommand altas = new SqlCommand
                ("insert into TABLAEMPRESA (IDEMPRESAS,NOMBRE,TIPO,DIRECCION,TELEFONO,FAX,CORREOELEC,IMPORTECONTRATO) " +
                "values(@IDEMPRESAS,@NOMBRE,@TIPO,@DIRECCION,@TELEFONO,@FAX,@CORREOELEC,@IMPORTECONTRATO)", conexion);

            //Obtiene  los valores de la txtbox
            altas.Parameters.AddWithValue("IDEMPRESAS", textBox1.Text);
            altas.Parameters.AddWithValue("NOMBRE", textBox2.Text);
            altas.Parameters.AddWithValue("TIPO", textBox3.Text);
            altas.Parameters.AddWithValue("DIRECCION", textBox4.Text);

            altas.Parameters.AddWithValue("TELEFONO", textBox5.Text);

            altas.Parameters.AddWithValue("FAX", textBox6.Text);

            altas.Parameters.AddWithValue("CORREOELEC", textBox7.Text);

            altas.Parameters.AddWithValue("IMPORTECONTRATO", textBox8.Text);

            conexion.Open();
            altas.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("EMPRESA almacenado");

            //Limpiamos los txtbox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {


            string baja = "DELETE FROM TABLAEMPRESA WHERE IDEMPRESAS = @IDEMPRESAS";
            conexion.Open();

            SqlCommand cmdIns = new SqlCommand(baja, conexion);
            cmdIns.Parameters.Add("IDEMPRESAS", textBox1.Text);
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
            string query = "Select * From TABLAEMPRESA";
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
                string consulta = "select * from TABLAEMPRESA";
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


            //IDEMPRESAS,NOMBRE,TIPO,DIRECCION,TELEFONO,FAX,CORREOELEC,IMPORTECONTRAT
            string Modificar = "UPDATE TABLAEMPRESA SET IDEMPRESAS=@IDEMPRESAS,NOMBRE=@NOMBRE,TIPO=@TIPO,DIRECCION=@DIRECCION,TELEFONO=@TELEFONO,FAX=@FAX,CORREOELEC=@CORREOELEC,IMPORTECONTRAT=@IMPORTECONTRAT ;";
            SqlCommand Modi = new SqlCommand(Modificar, conexion);
            conexion.Open();
            try
            {

                Modi.Parameters.AddWithValue("NOMBRE", textBox2.Text);
                Modi.Parameters.AddWithValue("TIPO", textBox3.Text);
                Modi.Parameters.AddWithValue("DIRECCION", textBox4.Text);

                Modi.Parameters.AddWithValue("TELEFONO", textBox5.Text);
                Modi.Parameters.AddWithValue("FAX", textBox6.Text);
                Modi.Parameters.AddWithValue("CORREOELEC", textBox7.Text);
                Modi.Parameters.AddWithValue("IMPORTECONTRAT", textBox8.Text);




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


        //Cambio Color

        private void Guardar_MouseEnter(object sender, EventArgs e)
        {
            Guardar.BackColor = Color.White;
            Guardar.ForeColor = Color.Black;
        }

        private void Guardar_MouseLeave(object sender, EventArgs e)
        {
            Guardar.BackColor = Color.Black;
            Guardar.ForeColor = Color.White;
        }

        private void Eliminar_MouseEnter(object sender, EventArgs e)
        {

            Eliminar.BackColor = Color.White;
            Eliminar.ForeColor = Color.Black;
        }

        private void Eliminar_MouseLeave(object sender, EventArgs e)
        {
            Eliminar.BackColor = Color.Black;
            Eliminar.ForeColor = Color.White;
        }

        private void Consultar_MouseEnter(object sender, EventArgs e)
        {

            Consultar.BackColor = Color.White;
            Consultar.ForeColor = Color.Black;
        }

        private void Consultar_MouseLeave(object sender, EventArgs e)
        {
            Consultar.BackColor = Color.Black;
            Consultar.ForeColor = Color.White;
        }

        private void Modificar_MouseEnter(object sender, EventArgs e)
        {

            Modificar.BackColor = Color.White;
            Modificar.ForeColor = Color.Black;
        }

        private void Modificar_MouseLeave(object sender, EventArgs e)
        {
            Modificar.BackColor = Color.Black;
            Modificar.ForeColor = Color.White;
        }
    }
}
