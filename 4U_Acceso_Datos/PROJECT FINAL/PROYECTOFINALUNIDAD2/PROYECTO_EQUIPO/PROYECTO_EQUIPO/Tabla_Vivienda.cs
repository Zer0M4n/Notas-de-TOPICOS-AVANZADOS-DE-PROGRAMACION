using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_EQUIPO
{
    public partial class Tabla_Vivienda : Form
    {
        public Tabla_Vivienda()
        {
            InitializeComponent();
            conexion_combobox();
        }
        //Conexion sql
        SqlConnection conexion = new SqlConnection(@"server= .\SQLEXPRESS; Initial Catalog=BASE_TRABAJO; integrated security=true");

        /*IDCASA,SUPERFICIE,NUMHABITANTES,NUMBAÑO,PLANOVIVI,FOTO,PRECIO,TERRAZA,JARDIN,PISCINA,GARAJE,IDPROM*/
        int Terraza, JARDIN, PICINA, GARAJE;
        
        public void VALORES_BIT()
        {
            if(comboBox1.SelectedIndex == 0)
            {
                Terraza = 1;
            }
            else
            {
                Terraza = 0;
            }
            if (comboBox2.SelectedIndex == 0)
            {
                JARDIN = 1;
            }
            else
            {
                JARDIN= 0;
            }
            if (comboBox3.SelectedIndex == 0)
            {
                PICINA = 1;
            }
            else
            {
                PICINA= 0;
            }
            if (comboBox4.SelectedIndex == 0)
            {
                GARAJE = 1;
            }
            else
            {
                GARAJE= 0;
            }
        }
        public void conexion_combobox()
        {
            conexion.Open();
            string consulta = "select * from TABLAPROM";
            SqlCommand COMANDO = new SqlCommand(consulta, conexion);
            SqlDataReader LEC = COMANDO.ExecuteReader();
            while (LEC.Read())
            {
                comboBox5.Items.Add(LEC.GetInt32(0));
            }
            conexion.Close();
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            VALORES_BIT();
            //Se cre el comando para dar  de altas el sistema
            SqlCommand altas = new SqlCommand
                ("insert into TABLACASA (IDCASA,SUPERFICIE,NUMHABITANTES,NUMBAÑO,PLANOVIVI,FOTO,PRECIO,TERRAZA,JARDIN,PISCINA,GARAJE,IDPROM) " +
                "values(@IDCASA,@SUPERFICIE,@NUMHABITANTES,@NUMBAÑO,@PLANOVIVI,@FOTO,@PRECIO,@TERRAZA,@JARDIN,@PISCINA,@GARAJE,@IDPROM)", conexion);

            //Obtiene  los valores de la txtbox
            altas.Parameters.AddWithValue("IDCASA", textBox1.Text);
            altas.Parameters.AddWithValue("SUPERFICIE", textBox2.Text);
            altas.Parameters.AddWithValue("NUMHABITANTES", textBox3.Text);
            altas.Parameters.AddWithValue("NUMBAÑO", textBox4.Text);
            altas.Parameters.AddWithValue("PLANOVIVI", textBox5.Text);
            altas.Parameters.AddWithValue("FOTO", textBox6.Text);
            altas.Parameters.AddWithValue("PRECIO", textBox7.Text);
            altas.Parameters.AddWithValue("TERRAZA", Terraza);
            altas.Parameters.AddWithValue("JARDIN", JARDIN);
            altas.Parameters.AddWithValue("PISCINA",PICINA);
            altas.Parameters.AddWithValue("GARAJE", GARAJE);
            altas.Parameters.AddWithValue("IDPROM", comboBox5.Text);


            conexion.Open();
            altas.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Vivienda almacenado");

            //Limpiamos los txtbox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
        private void Eliminar_Click(object sender, EventArgs e)
        {


            string baja = "DELETE FROM TABLACASA WHERE IDCASA = @IDCASA";
            conexion.Open();

            SqlCommand cmdIns = new SqlCommand(baja, conexion);
            cmdIns.Parameters.Add("IDCASA", textBox1.Text);
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
            string query = "Select * From TABLACASA";
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
            //SUPERFICIE,NUMHABITANTES,NUMBAÑO,PLANOVIVI,FOTO,PRECIO,TERRAZA,JARDIN,PISCINA,GARAJE,IDPROM
            string Modificar = "UPDATE TABLACASA SET SUPERFICIE=@SUPERFICIE,NUMHABITANTES=@NUMHABITANTES,NUMBAÑO=@NUMBAÑO,PLANOVIVI=@PLANOVIVI,FOTO=@FOTO,PRECIO=@PRECIO,TERRAZA=@TERRAZA ,JARDIN=@JARDIN,PISCINA=@PISCINA,GARAJE=@GARAJE,IDPROM=@IDPROM;";
            SqlCommand Modi = new SqlCommand(Modificar, conexion);
            conexion.Open();
            try
            {
                
                Modi.Parameters.AddWithValue("SUPERFICIE", textBox2.Text);
                Modi.Parameters.AddWithValue("NUMHABITANTES", textBox3.Text);
                Modi.Parameters.AddWithValue("NUMBAÑO", textBox4.Text);
                Modi.Parameters.AddWithValue("PLANOVIVI", textBox5.Text);
                Modi.Parameters.AddWithValue("FOTO", textBox6.Text);
                Modi.Parameters.AddWithValue("PRECIO", textBox7.Text);
                Modi.Parameters.AddWithValue("TERRAZA", Terraza);
                Modi.Parameters.AddWithValue("JARDIN", JARDIN);
                Modi.Parameters.AddWithValue("PISCINA", PICINA);
                Modi.Parameters.AddWithValue("GARAJE", GARAJE);
                Modi.Parameters.AddWithValue("IDPROM", comboBox5.Text);



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
                textBox7.Text = " ";

            }
        }
        
        //Cambio de color
      
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void Tabla_Vivienda_Load(object sender, EventArgs e)
        {

        }
    }
}
