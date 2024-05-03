using PROYECTO_EQUIPO.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_EQUIPO
{
    public partial class Form1 : Form
    {
        //Movimiento del la barra
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        //variable para formas hijas
        private Form activeform;

        public Form1()
        {
            InitializeComponent();
        }

        public void Botones_Contol_Ventana()
        {

        }
        
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebordTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Borde_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Agrandar_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState= FormWindowState.Normal;
            }
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            if(this.WindowState!= FormWindowState.Minimized)
            {
                this.WindowState =FormWindowState.Minimized;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        bool menuExpand = false;

        private void menuTrantion_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                menuContainer.Height += 10;

                if(menuContainer.Height >= 154)
                {
                    menuTrantion.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 47 )
                {
                    menuTrantion.Stop();
                    menuExpand = false;
                }
                
            }
        }

        private void Tablas_Menu_Click(object sender, EventArgs e)
        {
            menuTrantion.Start();
        }

        bool sidebarExpand = true;
        private void sidebordTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 57)
                {
                    sidebarExpand = false;
                    sidebordTransition.Stop();

                }
                
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 197)
                {
                    sidebarExpand = true;
                    sidebordTransition.Stop();

                }
            }
        }

        //Metodo para las formas hijos
        private void Openchildform(Form childform , object sender)
        {
            if(activeform != null)
            {
                activeform.Close();
            }
            
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//tabla promocion
        {
            /*Tabla_Promocion waos = new Tabla_Promocion();   
            waos.MdiParent = this;
            waos.Show();*/
            //openChildFormInPanel(new Form2());

            openChildFormInPanel(new Tabla_Promocion());

        }

        private void button4_Click(object sender, EventArgs e)//tabla vivienda
        {
            openChildFormInPanel(new Tabla_Vivienda());
        }

        private void button5_Click(object sender, EventArgs e)//tabla empresa
        {
            openChildFormInPanel(new Tabla_Empresa());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
        //CAMBIO DE COLOR
        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Black;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
        }

        private void panelChildForm_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void Tablas_Menu_MouseEnter(object sender, EventArgs e)
        {
            Tablas_Menu.BackColor = Color.White;
            Tablas_Menu.ForeColor = Color.Black;
        }

        private void Tablas_Menu_MouseLeave(object sender, EventArgs e)
        {
            Tablas_Menu.BackColor = Color.Black;
            Tablas_Menu.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor= Color.Black;
            button3.ForeColor= Color.White;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {

            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
        }
    }//fin del codigo
}
