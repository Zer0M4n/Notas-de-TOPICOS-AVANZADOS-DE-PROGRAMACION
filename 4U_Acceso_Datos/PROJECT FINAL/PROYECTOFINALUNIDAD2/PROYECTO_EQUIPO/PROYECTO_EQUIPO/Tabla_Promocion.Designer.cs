namespace PROYECTO_EQUIPO.FORMS
{
    partial class Tabla_Promocion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.View_DataBase = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Modificar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Consultar = new System.Windows.Forms.Button();
            this.Reiniciar = new System.Windows.Forms.Panel();
            this.Guardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.View_DataBase)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Reiniciar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // View_DataBase
            // 
            this.View_DataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_DataBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.View_DataBase.Location = new System.Drawing.Point(0, 304);
            this.View_DataBase.Margin = new System.Windows.Forms.Padding(2);
            this.View_DataBase.Name = "View_DataBase";
            this.View_DataBase.RowHeadersWidth = 51;
            this.View_DataBase.RowTemplate.Height = 24;
            this.View_DataBase.Size = new System.Drawing.Size(631, 123);
            this.View_DataBase.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Reiniciar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 38);
            this.panel1.TabIndex = 82;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Modificar);
            this.panel3.Location = new System.Drawing.Point(483, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 38);
            this.panel3.TabIndex = 85;
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Modificar.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_change_24;
            this.Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modificar.Location = new System.Drawing.Point(-12, -20);
            this.Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Modificar.Name = "Modificar";
            this.Modificar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Modificar.Size = new System.Drawing.Size(170, 74);
            this.Modificar.TabIndex = 3;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            this.Modificar.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.Modificar.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Consultar);
            this.panel4.Location = new System.Drawing.Point(316, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 38);
            this.panel4.TabIndex = 86;
            // 
            // Consultar
            // 
            this.Consultar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Consultar.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_consultation_24;
            this.Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultar.Location = new System.Drawing.Point(-12, -20);
            this.Consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Consultar.Name = "Consultar";
            this.Consultar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Consultar.Size = new System.Drawing.Size(170, 74);
            this.Consultar.TabIndex = 3;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = false;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            this.Consultar.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.Consultar.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // Reiniciar
            // 
            this.Reiniciar.Controls.Add(this.Guardar);
            this.Reiniciar.Location = new System.Drawing.Point(2, 2);
            this.Reiniciar.Margin = new System.Windows.Forms.Padding(2);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(148, 38);
            this.Reiniciar.TabIndex = 83;
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardar.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_save_24;
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardar.Location = new System.Drawing.Point(-12, -20);
            this.Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Guardar.Name = "Guardar";
            this.Guardar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Guardar.Size = new System.Drawing.Size(170, 74);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            this.Guardar.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.Guardar.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Eliminar);
            this.panel2.Location = new System.Drawing.Point(154, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 38);
            this.panel2.TabIndex = 84;
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eliminar.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_x_24;
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminar.Location = new System.Drawing.Point(-12, -20);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Eliminar.Size = new System.Drawing.Size(170, 74);
            this.Eliminar.TabIndex = 3;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            this.Eliminar.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.Eliminar.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "ID promocion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 84;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Nombre Promocion";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Planos situacion";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Poblacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_EQUIPO.Properties.Resources.icons8_promo_100;
            this.pictureBox1.Location = new System.Drawing.Point(390, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // Tabla_Promocion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(631, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.View_DataBase);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tabla_Promocion";
            this.Text = "Tabla_Promocion";
            this.Load += new System.EventHandler(this.Tabla_Promocion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_DataBase)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.Reiniciar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView View_DataBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Reiniciar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}