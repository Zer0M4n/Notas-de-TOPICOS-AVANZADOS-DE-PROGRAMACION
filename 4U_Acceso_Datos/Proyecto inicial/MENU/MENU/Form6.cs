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

namespace MENU
{
    public partial class TABLA_CLIENTES : Form
    {
        public TABLA_CLIENTES()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server= SNAKE\MSSQLSERVER01; Initial Catalog=MIBASE; integrated security=true");


        private void btn_Guardar_Click(object sender, EventArgs e)
        {


            //Se cre el comando para dar  de altas el sistema
            SqlCommand altas = new SqlCommand
                ("insert into CLIENTES (IDCLIENTES,NOMBRE,CORREO,DIRECCION,RFC,TELEFONO) values(@IDCLIENTES,@NOMBRE,@CORREO,@DIRECCION,RFC,@TELEFONO)", conexion);

            //Obtiene  los valores de la txtbox
            altas.Parameters.AddWithValue("IDCLIENTES", textBox1.Text);
            altas.Parameters.AddWithValue("NOMBRE", textBox2.Text);
            altas.Parameters.AddWithValue("CORREO", textBox3.Text);
            altas.Parameters.AddWithValue("DIRECCION", textBox4.Text);

            altas.Parameters.AddWithValue("RFC", textBox5.Text);
            altas.Parameters.AddWithValue("TELEFONO",textBox6.Text);


            conexion.Open();
            altas.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("socio almacenado");

            //Limpiamos los txtbox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            string baja = "DELETE FROM CLIENTES1928 WHERE IDCLIENTES = @IDCLIENTES";
            conexion.Open();

            SqlCommand cmdIns = new SqlCommand(baja, conexion);
            cmdIns.Parameters.Add("IDCLIENTES", textBox1.Text);
            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;
            textBox1.Clear();

            //sw limpia

            conexion.Close();

            MessageBox.Show("Se a eliminado");
        }
        public void Actualizacion()
        {

            try
            {
                string consulta = "select * from CLIENTES";
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

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            //IDCLIENTES,NOMBRE,CORREO,DIRECCION,RFC,TELEFONO
            string Modificar = "UPDATE CLIENTES SET NOMBRE=@NOMBRE, CORREO=@CORREO, DIRECCION=@DIRECCION, RFC=@RFC, TELEFONO=@TELEFONO;";
            SqlCommand Modi = new SqlCommand(Modificar, conexion);
            conexion.Open();
            try
            {
                Modi.Parameters.AddWithValue("@NOMBRE", textBox2.Text);
                Modi.Parameters.AddWithValue("@CORREO", textBox3.Text);
                Modi.Parameters.AddWithValue("@DIRECCION", textBox4.Text);
                Modi.Parameters.AddWithValue("@RFC", textBox5.Text);
                Modi.Parameters.AddWithValue("@TELEFONO",textBox6.Text);

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
                textBox5.Text = " ";
                textBox6.Text = " ";
            }

        }
        public void FILLDVG()
        {
            conexion.Open();
            string query = "Select * From CLIENTES";
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            View_DataBase.DataSource = dt;
            conexion.Close();


        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            FILLDVG();
        }

        private void btn_Salida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
