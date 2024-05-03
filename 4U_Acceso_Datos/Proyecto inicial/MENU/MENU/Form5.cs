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
    public partial class TABLA_MEDICAMENTOS : Form
    {
        public TABLA_MEDICAMENTOS()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"server= SNAKE\MSSQLSERVER01; Initial Catalog=MIBASE; integrated security=true");


        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //IDMEDICAMENTOS,NOMBRE_COMERCIAL,SUSTANCIA_QUE_SE_COMPONEN
            //Se cre el comando para dar  de altas el sistema
            SqlCommand altas = new SqlCommand
                ("insert into MEDICAMENTOS (IDMEDICAMENTOS,NOMBRE_COMERCIAL,SUSTANCIA_QUE_SE_COMPONEN) values(@IDMEDICAMENTOS,@NOMBRE_COMERCIAL,@SUSTANCIA_QUE_SE_COMPONEN)", conexion);

            //Obtiene  los valores de la txtbox
            altas.Parameters.AddWithValue("IDMEDICAMENTOS", textBox1.Text);
            altas.Parameters.AddWithValue("NOMBRE_COMERCIAL", textBox2.Text);
            altas.Parameters.AddWithValue("SUSTANCIA_QUE_SE_COMPONEN", textBox3.Text);
            

            conexion.Open();
            altas.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("MEDICAMENTO almacenado");

            //Limpiamos los txtbox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
          
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            string baja = "DELETE FROM MEDICAMENTOS WHERE IDMEDICAMENTO = @IDMEDICAMENTO";
            conexion.Open();

            SqlCommand cmdIns = new SqlCommand(baja, conexion);
            cmdIns.Parameters.Add("IDMEDICAMENTO", textBox1.Text);
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
                string consulta = "select * from MEDICAMENTOS";
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

            //IDMEDICAMENTOS,NOMBRE_COMERCIAL,SUSTANCIA_QUE_SE_COMPONEN
            string Modificar = "UPDATE MEDICAMENTOS SET NOMBRE_COMERCIAL=@NOMBRE_COMERCIAL, SUSTANCIA_QUE_SE_COMPONE=@SUSTANCIA_QUE_SE_COMPONEN;";
            SqlCommand Modi = new SqlCommand(Modificar, conexion);
            conexion.Open();
            try
            {
                Modi.Parameters.AddWithValue("@NOMBRRE_COMERCIAL", textBox2.Text);
                Modi.Parameters.AddWithValue("@SUSTANCIA_QUE_SE_COMPONEN", textBox3.Text);

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
            }

        }
        public void FILLDVG()
        {
            conexion.Open();
            string query = "Select * From MEDICAMENTOS";
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
    }
}
