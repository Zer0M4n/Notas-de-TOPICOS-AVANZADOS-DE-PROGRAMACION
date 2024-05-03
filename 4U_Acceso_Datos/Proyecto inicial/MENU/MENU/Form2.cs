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
using System.Data.Sql;
using System.Data.OleDb;


namespace MENU
{
    public partial class TABLA_CIUDAD : Form
    {
        public TABLA_CIUDAD()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"server= SNAKE\MSSQLSERVER01; Initial Catalog=MIBASE; integrated security=true");

        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Se cre el comando para dar  de altas el sistema
            SqlCommand altas = new SqlCommand
                ("insert into CIUDAD (IDCIUDAD,NOMBRE,ESTADO,SUPERFICIE,HABITANTES) values(@IDCIUDAD,@NOMBRE,@ESTADO,@SUPERFICIE,@HABITANTES)", conexion);

            //Obtiene  los valores de la txtbox
            altas.Parameters.AddWithValue("IDCIUDAD",textBox1.Text);
            altas.Parameters.AddWithValue("NOMBRE",textBox2.Text);
            //altas.Parameters.AddWithValue("ESTADO",textBox3.Text);
            altas.Parameters.AddWithValue("SUPERFICIE",textBox4.Text);

            altas.Parameters.AddWithValue("HABITANTES", textBox5.Text);
            altas.Parameters.AddWithValue("ESTADO", comboBox1.Text);

            conexion.Open();
            altas.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("socio almacenado");

            //Limpiamos los txtbox
            textBox1.Clear();
            textBox2.Clear();
            
            textBox4.Clear();
            textBox5.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string baja = "DELETE FROM CIUDAD WHERE IDCIUDAD = @IDCIUDAD";
            conexion.Open();

           SqlCommand cmdIns = new SqlCommand(baja, conexion);
            cmdIns.Parameters.Add("IDCIUDAD", textBox1.Text);
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
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            //IDCIUDAD,NOMBRE,ESTADO,SUPERFICIE,HABITANTES
            string Modificar = "UPDATE CIUDAD SET NOMBRE=@NOMBRE, ESTADO=@ESTADO, SUPERFICIE=@SUPERFICIE, HABITANTES=@HABITANTES;";
            SqlCommand Modi = new SqlCommand(Modificar, conexion);
            conexion.Open();
            try
            {
                Modi.Parameters.AddWithValue("@NOMBRE", textBox2.Text);
                Modi.Parameters.AddWithValue("@ESTADO", comboBox1.Text);
                Modi.Parameters.AddWithValue("@SUPERFICIE", textBox4.Text);
                Modi.Parameters.AddWithValue("@HABITANTES", textBox5.Text);

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
                comboBox1 .Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }

        }
        
        public void FILLDVG()
        {
            conexion.Open();
            string query = "Select * From CIUDAD";
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

        private void View_DataBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
