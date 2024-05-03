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
    public partial class TABALA_PROPIETARIOS : Form
    {
        public TABALA_PROPIETARIOS()
        {
            InitializeComponent();
            conexion_combobox();
        }

        
        SqlConnection conexion = new SqlConnection(@"server= SNAKE\MSSQLSERVER01; Initial Catalog=MIBASE; integrated security=true");
        public void conexion_combobox()
        {
            conexion.Open();
            string consulta = "select * from CIUDAD";
            SqlCommand COMANDO = new SqlCommand(consulta, conexion);
            SqlDataReader LEC = COMANDO.ExecuteReader();
            while (LEC.Read())
            {
                comboBox1.Items.Add(LEC.GetInt32(0));
            }
            conexion.Close();
        }

        private void btn_Guardar_Click_1(object sender, EventArgs e)
        {

            //Se cre el comando para dar  de altas el sistema
            SqlCommand altas = new SqlCommand
                ("insert into PROPIETARIOS (IDPROPIETARIOS,NOMBRE,DOMICILIO,CALLE,NUMEROCALLE,CODIGOPOSTAL,IDCIUDAD) values(@IDPROPIETARIOS,@NOMBRE,@DOMICILIO,@CALLE,@NUMEROCALLE,@CODIGOPOSTAL,@IDCIUDAD)", conexion);

            //Obtiene  los valores de la txtbox
            altas.Parameters.AddWithValue("IDPROPIETARIOS", textBox1.Text);
            altas.Parameters.AddWithValue("NOMBRE", textBox2.Text);
            altas.Parameters.AddWithValue("DOMICILIO", textBox3.Text);
            altas.Parameters.AddWithValue("CALLE", textBox4.Text);

            altas.Parameters.AddWithValue("NUMEROCALLE", textBox5.Text);
            altas.Parameters.AddWithValue("CODIGOPOSTAL", textBox6.Text);
            altas.Parameters.AddWithValue("IDCIUDAD", comboBox1.Text);


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
            textBox6.Clear();
            
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {

            string baja = "DELETE FROM CIUDAD WHERE IDPROPIETARIOS = @IDPROPIETARIOS";
            conexion.Open();

            SqlCommand cmdIns = new SqlCommand(baja, conexion);
            cmdIns.Parameters.Add("IDPROPIETARIOS", textBox1.Text);
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
                string consulta = "select * from ciudades";
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

        private void btn_Modificar_Click_1(object sender, EventArgs e)
        {

            //IDPROPIETARIOS,NOMBRE,DOMICILIO,CALLE,NUMEROCALLE,CODIGOPOSTAL,IDCIUDAD
            string Modificar = "UPDATE CIUDAD SET NOMBRE=@NOMBRE, DOMICILIO=@DOMICILIO, CALLE=@CALLE, NUMEROCALLE=@NUMEROCALLE, CODIGOPOSTA=@CODIGOPOSTAL, IDCIUDAD=@IDCIUDAD;";
            SqlCommand Modi = new SqlCommand(Modificar, conexion);
            conexion.Open();
            try
            {
                Modi.Parameters.AddWithValue("@NOMBRE", textBox2.Text);
                Modi.Parameters.AddWithValue("@DOMICILIO", textBox3.Text);
                Modi.Parameters.AddWithValue("@CALLE", textBox4.Text);
                Modi.Parameters.AddWithValue("@NUMEROCALLE", textBox5.Text);
                Modi.Parameters.AddWithValue("@CODIGOPOSTAL", textBox6.Text);
                Modi.Parameters.AddWithValue("@IDCIUDAD", comboBox1.Text);

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
                comboBox1.Text = " ";
            }

        }

        private void btn_Consultar_Click_1(object sender, EventArgs e)
        {
            FILLDVG();
        }
        public void FILLDVG()
        {
            conexion.Open();
            string query = "Select * From PROPIETARIOS";
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            View_DataBase.DataSource = dt;
            conexion.Close();


        }
        private void btn_Salida_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TABALA_PROPIETARIOS_Load(object sender, EventArgs e)
        {

        }
    }
}
