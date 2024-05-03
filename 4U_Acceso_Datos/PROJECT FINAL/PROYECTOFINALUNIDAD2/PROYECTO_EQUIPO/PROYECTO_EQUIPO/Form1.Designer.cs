namespace PROYECTO_EQUIPO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Borde_Menu = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.titulo_barra = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.Btn_Agrandar = new System.Windows.Forms.Button();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tablas_Menu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menuTrantion = new System.Windows.Forms.Timer(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.sidebordTransition = new System.Windows.Forms.Timer(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Reiniciar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Borde_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Reiniciar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Borde_Menu
            // 
            this.Borde_Menu.BackColor = System.Drawing.Color.White;
            this.Borde_Menu.Controls.Add(this.Btn_Cerrar);
            this.Borde_Menu.Controls.Add(this.titulo_barra);
            this.Borde_Menu.Controls.Add(this.btnHam);
            this.Borde_Menu.Controls.Add(this.Btn_Agrandar);
            this.Borde_Menu.Controls.Add(this.Btn_Minimizar);
            this.Borde_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Borde_Menu.Location = new System.Drawing.Point(0, 0);
            this.Borde_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Borde_Menu.Name = "Borde_Menu";
            this.Borde_Menu.Size = new System.Drawing.Size(1059, 45);
            this.Borde_Menu.TabIndex = 0;
            this.Borde_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borde_Menu_MouseDown);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.BackgroundImage = global::PROYECTO_EQUIPO.Properties.Resources.cerrar;
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Location = new System.Drawing.Point(1000, 12);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(46, 23);
            this.Btn_Cerrar.TabIndex = 3;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // titulo_barra
            // 
            this.titulo_barra.AutoSize = true;
            this.titulo_barra.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_barra.Location = new System.Drawing.Point(74, 9);
            this.titulo_barra.Name = "titulo_barra";
            this.titulo_barra.Size = new System.Drawing.Size(185, 27);
            this.titulo_barra.TabIndex = 1;
            this.titulo_barra.Text = "Control de la base";
            // 
            // btnHam
            // 
            this.btnHam.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_house_of_cards_60;
            this.btnHam.Location = new System.Drawing.Point(12, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(45, 45);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Btn_Agrandar
            // 
            this.Btn_Agrandar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Agrandar.BackgroundImage = global::PROYECTO_EQUIPO.Properties.Resources.maximize;
            this.Btn_Agrandar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Agrandar.FlatAppearance.BorderSize = 0;
            this.Btn_Agrandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agrandar.Location = new System.Drawing.Point(948, 12);
            this.Btn_Agrandar.Name = "Btn_Agrandar";
            this.Btn_Agrandar.Size = new System.Drawing.Size(46, 23);
            this.Btn_Agrandar.TabIndex = 1;
            this.Btn_Agrandar.UseVisualStyleBackColor = true;
            this.Btn_Agrandar.Click += new System.EventHandler(this.Btn_Agrandar_Click);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.BackgroundImage = global::PROYECTO_EQUIPO.Properties.Resources.minimizar_signo;
            this.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Location = new System.Drawing.Point(896, 12);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(46, 23);
            this.Btn_Minimizar.TabIndex = 2;
            this.Btn_Minimizar.UseVisualStyleBackColor = true;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.Reiniciar);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 45);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 572);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Tablas_Menu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 47);
            this.panel2.TabIndex = 3;
            // 
            // Tablas_Menu
            // 
            this.Tablas_Menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Tablas_Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tablas_Menu.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_table_241;
            this.Tablas_Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tablas_Menu.Location = new System.Drawing.Point(-16, -25);
            this.Tablas_Menu.Name = "Tablas_Menu";
            this.Tablas_Menu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Tablas_Menu.Size = new System.Drawing.Size(227, 91);
            this.Tablas_Menu.TabIndex = 3;
            this.Tablas_Menu.Text = "Tablas";
            this.Tablas_Menu.UseVisualStyleBackColor = false;
            this.Tablas_Menu.Click += new System.EventHandler(this.Tablas_Menu_Click);
            this.Tablas_Menu.MouseEnter += new System.EventHandler(this.Tablas_Menu_MouseEnter);
            this.Tablas_Menu.MouseLeave += new System.EventHandler(this.Tablas_Menu_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(3, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 47);
            this.panel3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_circle_24;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-16, -25);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(227, 91);
            this.button3.TabIndex = 3;
            this.button3.Text = "    Tabla de Promoción";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(3, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 47);
            this.panel4.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_circle_24;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-16, -25);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(227, 91);
            this.button4.TabIndex = 3;
            this.button4.Text = "    Tabla de Vivienda";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(3, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 47);
            this.panel5.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_circle_24;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-16, -25);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(227, 91);
            this.button5.TabIndex = 3;
            this.button5.Text = "    Tabla de Empresa";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel4);
            this.menuContainer.Controls.Add(this.panel5);
            this.menuContainer.Location = new System.Drawing.Point(3, 3);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(204, 47);
            this.menuContainer.TabIndex = 7;
            // 
            // menuTrantion
            // 
            this.menuTrantion.Interval = 10;
            this.menuTrantion.Tick += new System.EventHandler(this.menuTrantion_Tick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(3, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 47);
            this.panel6.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_exit_24;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-16, -25);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(227, 91);
            this.button6.TabIndex = 3;
            this.button6.Text = "Salida";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);
            // 
            // sidebordTransition
            // 
            this.sidebordTransition.Interval = 10;
            this.sidebordTransition.Tick += new System.EventHandler(this.sidebordTransition_Tick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.materialLabel1);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 45);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(859, 572);
            this.panelChildForm.TabIndex = 3;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            this.panelChildForm.MouseEnter += new System.EventHandler(this.panelChildForm_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_house_of_cards_90;
            this.pictureBox1.Location = new System.Drawing.Point(366, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Reiniciar
            // 
            this.Reiniciar.Controls.Add(this.button1);
            this.Reiniciar.Location = new System.Drawing.Point(3, 109);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(197, 47);
            this.Reiniciar.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_restart_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-16, -25);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(227, 91);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reiniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(311, 285);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(185, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Escoga la tabla que desee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1059, 617);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.Borde_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Borde_Menu.ResumeLayout(false);
            this.Borde_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Reiniciar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Borde_Menu;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label titulo_barra;
        private System.Windows.Forms.Button Btn_Agrandar;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Tablas_Menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Timer menuTrantion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer sidebordTransition;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel Reiniciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

