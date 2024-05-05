namespace Calculadora
{
    partial class Form1
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
            System.Windows.Forms.Button btn_Limpieza_Historial;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.pnl_Historial = new System.Windows.Forms.Panel();
            this.Pantalla_Historial_RichBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pantalla_Secundaria_TxtBox = new System.Windows.Forms.TextBox();
            this.Pantalla_Principal_TxtBox = new System.Windows.Forms.TextBox();
            this.btn_Porcent = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_Ce = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.Btn_Igual = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.btn_Historial = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minimizar_Btn = new System.Windows.Forms.Button();
            this.Ocultar_Ventana_Btn = new System.Windows.Forms.Button();
            this.cerrar_Btn = new System.Windows.Forms.Button();
            btn_Limpieza_Historial = new System.Windows.Forms.Button();
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Historial.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Limpieza_Historial
            // 
            btn_Limpieza_Historial.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn_Limpieza_Historial.FlatAppearance.BorderSize = 0;
            btn_Limpieza_Historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Limpieza_Historial.Location = new System.Drawing.Point(0, -24);
            btn_Limpieza_Historial.Name = "btn_Limpieza_Historial";
            btn_Limpieza_Historial.Size = new System.Drawing.Size(354, 35);
            btn_Limpieza_Historial.TabIndex = 6;
            btn_Limpieza_Historial.Text = "X";
            btn_Limpieza_Historial.UseVisualStyleBackColor = true;
            btn_Limpieza_Historial.Click += new System.EventHandler(this.btn_Limpieza_Historial_Click);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.Controls.Add(this.pictureBox1);
            this.pnl_Titulo.Controls.Add(this.Minimizar_Btn);
            this.pnl_Titulo.Controls.Add(this.Ocultar_Ventana_Btn);
            this.pnl_Titulo.Controls.Add(this.cerrar_Btn);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(354, 40);
            this.pnl_Titulo.TabIndex = 0;
            this.pnl_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Titulo_MouseDown);
            // 
            // pnl_Historial
            // 
            this.pnl_Historial.Controls.Add(this.Pantalla_Historial_RichBox);
            this.pnl_Historial.Controls.Add(btn_Limpieza_Historial);
            this.pnl_Historial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Historial.Location = new System.Drawing.Point(0, 566);
            this.pnl_Historial.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Historial.Name = "pnl_Historial";
            this.pnl_Historial.Size = new System.Drawing.Size(354, 11);
            this.pnl_Historial.TabIndex = 1;
            // 
            // Pantalla_Historial_RichBox
            // 
            this.Pantalla_Historial_RichBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Pantalla_Historial_RichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pantalla_Historial_RichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pantalla_Historial_RichBox.ForeColor = System.Drawing.Color.DarkGray;
            this.Pantalla_Historial_RichBox.Location = new System.Drawing.Point(0, 0);
            this.Pantalla_Historial_RichBox.Name = "Pantalla_Historial_RichBox";
            this.Pantalla_Historial_RichBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.Pantalla_Historial_RichBox.Size = new System.Drawing.Size(354, 0);
            this.Pantalla_Historial_RichBox.TabIndex = 7;
            this.Pantalla_Historial_RichBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Historial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 30);
            this.panel1.TabIndex = 2;
            // 
            // Pantalla_Secundaria_TxtBox
            // 
            this.Pantalla_Secundaria_TxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Pantalla_Secundaria_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pantalla_Secundaria_TxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pantalla_Secundaria_TxtBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla_Secundaria_TxtBox.ForeColor = System.Drawing.Color.DarkGray;
            this.Pantalla_Secundaria_TxtBox.Location = new System.Drawing.Point(0, 70);
            this.Pantalla_Secundaria_TxtBox.Margin = new System.Windows.Forms.Padding(0);
            this.Pantalla_Secundaria_TxtBox.Multiline = true;
            this.Pantalla_Secundaria_TxtBox.Name = "Pantalla_Secundaria_TxtBox";
            this.Pantalla_Secundaria_TxtBox.Size = new System.Drawing.Size(354, 30);
            this.Pantalla_Secundaria_TxtBox.TabIndex = 3;
            this.Pantalla_Secundaria_TxtBox.Text = "0";
            this.Pantalla_Secundaria_TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Pantalla_Principal_TxtBox
            // 
            this.Pantalla_Principal_TxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Pantalla_Principal_TxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pantalla_Principal_TxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pantalla_Principal_TxtBox.Font = new System.Drawing.Font("Gadugi", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla_Principal_TxtBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.Pantalla_Principal_TxtBox.Location = new System.Drawing.Point(0, 100);
            this.Pantalla_Principal_TxtBox.Margin = new System.Windows.Forms.Padding(0);
            this.Pantalla_Principal_TxtBox.Multiline = true;
            this.Pantalla_Principal_TxtBox.Name = "Pantalla_Principal_TxtBox";
            this.Pantalla_Principal_TxtBox.Size = new System.Drawing.Size(354, 75);
            this.Pantalla_Principal_TxtBox.TabIndex = 4;
            this.Pantalla_Principal_TxtBox.Text = "0";
            this.Pantalla_Principal_TxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Porcent
            // 
            this.btn_Porcent.BackColor = System.Drawing.Color.Silver;
            this.btn_Porcent.FlatAppearance.BorderSize = 0;
            this.btn_Porcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Porcent.Location = new System.Drawing.Point(2, 177);
            this.btn_Porcent.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Porcent.Name = "btn_Porcent";
            this.btn_Porcent.Size = new System.Drawing.Size(89, 40);
            this.btn_Porcent.TabIndex = 8;
            this.btn_Porcent.Text = "%";
            this.btn_Porcent.UseVisualStyleBackColor = false;
            this.btn_Porcent.Click += new System.EventHandler(this.Operaciones_Especiales_click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.Silver;
            this.btn_C.FlatAppearance.BorderSize = 0;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C.Location = new System.Drawing.Point(187, 177);
            this.btn_C.Margin = new System.Windows.Forms.Padding(0);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(75, 40);
            this.btn_C.TabIndex = 10;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_Ce
            // 
            this.btn_Ce.BackColor = System.Drawing.Color.Silver;
            this.btn_Ce.FlatAppearance.BorderSize = 0;
            this.btn_Ce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ce.Location = new System.Drawing.Point(91, 177);
            this.btn_Ce.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Ce.Name = "btn_Ce";
            this.btn_Ce.Size = new System.Drawing.Size(96, 40);
            this.btn_Ce.TabIndex = 11;
            this.btn_Ce.Text = "CE";
            this.btn_Ce.UseVisualStyleBackColor = false;
            this.btn_Ce.Click += new System.EventHandler(this.btn_Ce_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(91, 257);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 69);
            this.button2.TabIndex = 15;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(187, 257);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 69);
            this.button4.TabIndex = 14;
            this.button4.Text = "9";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(262, 257);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 68);
            this.button5.TabIndex = 13;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Math_Operaciones);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(2, 257);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 69);
            this.button6.TabIndex = 12;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(91, 217);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 40);
            this.button7.TabIndex = 19;
            this.button7.Text = "³√";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Operaciones_Especiales_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(187, 217);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 40);
            this.button8.TabIndex = 18;
            this.button8.Text = "x²";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Operaciones_Especiales_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(262, 217);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 40);
            this.button9.TabIndex = 17;
            this.button9.Text = "x³";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Operaciones_Especiales_click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Silver;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(2, 217);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(89, 40);
            this.button10.TabIndex = 16;
            this.button10.Text = "²√";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Operaciones_Especiales_click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(91, 319);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 69);
            this.button11.TabIndex = 23;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(187, 319);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 69);
            this.button12.TabIndex = 22;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(262, 319);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 68);
            this.button13.TabIndex = 21;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Math_Operaciones);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(2, 319);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(89, 69);
            this.button14.TabIndex = 20;
            this.button14.Text = "4";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(91, 381);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(96, 69);
            this.button15.TabIndex = 27;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(187, 381);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 69);
            this.button16.TabIndex = 26;
            this.button16.Text = "3";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(262, 381);
            this.button17.Margin = new System.Windows.Forms.Padding(0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(90, 68);
            this.button17.TabIndex = 25;
            this.button17.Text = "*";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Math_Operaciones);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(2, 381);
            this.button18.Margin = new System.Windows.Forms.Padding(0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(89, 69);
            this.button18.TabIndex = 24;
            this.button18.Text = "1";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(91, 443);
            this.button19.Margin = new System.Windows.Forms.Padding(0);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(96, 69);
            this.button19.TabIndex = 31;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(187, 443);
            this.button20.Margin = new System.Windows.Forms.Padding(0);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 69);
            this.button20.TabIndex = 30;
            this.button20.Text = ".";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(262, 443);
            this.button21.Margin = new System.Windows.Forms.Padding(0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(90, 68);
            this.button21.TabIndex = 29;
            this.button21.Text = "/";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.Math_Operaciones);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(2, 443);
            this.button22.Margin = new System.Windows.Forms.Padding(0);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(89, 69);
            this.button22.TabIndex = 28;
            this.button22.Text = "+/-";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.Operaciones_Especiales_click);
            // 
            // Btn_Igual
            // 
            this.Btn_Igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Btn_Igual.FlatAppearance.BorderSize = 0;
            this.Btn_Igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Igual.Location = new System.Drawing.Point(2, 505);
            this.Btn_Igual.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Igual.Name = "Btn_Igual";
            this.Btn_Igual.Size = new System.Drawing.Size(350, 55);
            this.Btn_Igual.TabIndex = 32;
            this.Btn_Igual.Text = "=";
            this.Btn_Igual.UseVisualStyleBackColor = false;
            this.Btn_Igual.Click += new System.EventHandler(this.Btn_Igual_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Silver;
            this.Back_btn.FlatAppearance.BorderSize = 0;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_btn.Image = global::Calculadora.Properties.Resources.icons8_flecha_izquierda_larga_25;
            this.Back_btn.Location = new System.Drawing.Point(262, 177);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(90, 40);
            this.Back_btn.TabIndex = 9;
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // btn_Historial
            // 
            this.btn_Historial.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Historial.FlatAppearance.BorderSize = 0;
            this.btn_Historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Historial.Image = global::Calculadora.Properties.Resources.icons8_pasado_24;
            this.btn_Historial.Location = new System.Drawing.Point(304, 0);
            this.btn_Historial.Name = "btn_Historial";
            this.btn_Historial.Size = new System.Drawing.Size(50, 30);
            this.btn_Historial.TabIndex = 2;
            this.btn_Historial.UseVisualStyleBackColor = true;
            this.btn_Historial.Click += new System.EventHandler(this.btn_Historial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.icons8_calculadora_32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 37);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Minimizar_Btn
            // 
            this.Minimizar_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimizar_Btn.FlatAppearance.BorderSize = 0;
            this.Minimizar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar_Btn.Font = new System.Drawing.Font("Garamond", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.Minimizar_Btn.ForeColor = System.Drawing.Color.Black;
            this.Minimizar_Btn.Image = global::Calculadora.Properties.Resources.icons8_minimizar_la_ventana_24;
            this.Minimizar_Btn.Location = new System.Drawing.Point(204, 0);
            this.Minimizar_Btn.Name = "Minimizar_Btn";
            this.Minimizar_Btn.Size = new System.Drawing.Size(50, 40);
            this.Minimizar_Btn.TabIndex = 5;
            this.Minimizar_Btn.Text = "minimize";
            this.Minimizar_Btn.UseVisualStyleBackColor = true;
            this.Minimizar_Btn.Click += new System.EventHandler(this.Control_Ventana_Click);
            // 
            // Ocultar_Ventana_Btn
            // 
            this.Ocultar_Ventana_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ocultar_Ventana_Btn.FlatAppearance.BorderSize = 0;
            this.Ocultar_Ventana_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ocultar_Ventana_Btn.Font = new System.Drawing.Font("Gadugi", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ocultar_Ventana_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(2)))), ((int)(((byte)(32)))));
            this.Ocultar_Ventana_Btn.Image = global::Calculadora.Properties.Resources.icons8_restaurar_abajo_25;
            this.Ocultar_Ventana_Btn.Location = new System.Drawing.Point(254, 0);
            this.Ocultar_Ventana_Btn.Name = "Ocultar_Ventana_Btn";
            this.Ocultar_Ventana_Btn.Size = new System.Drawing.Size(50, 40);
            this.Ocultar_Ventana_Btn.TabIndex = 4;
            this.Ocultar_Ventana_Btn.Text = "Maxin";
            this.Ocultar_Ventana_Btn.UseVisualStyleBackColor = true;
            this.Ocultar_Ventana_Btn.Click += new System.EventHandler(this.Control_Ventana_Click);
            // 
            // cerrar_Btn
            // 
            this.cerrar_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cerrar_Btn.FlatAppearance.BorderSize = 0;
            this.cerrar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar_Btn.Font = new System.Drawing.Font("Gadugi", 0.001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cerrar_Btn.Image = global::Calculadora.Properties.Resources.icons8_x_25__1_;
            this.cerrar_Btn.Location = new System.Drawing.Point(304, 0);
            this.cerrar_Btn.Name = "cerrar_Btn";
            this.cerrar_Btn.Size = new System.Drawing.Size(50, 40);
            this.cerrar_Btn.TabIndex = 2;
            this.cerrar_Btn.Text = "Cerrar";
            this.cerrar_Btn.UseVisualStyleBackColor = true;
            this.cerrar_Btn.Click += new System.EventHandler(this.Control_Ventana_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(354, 577);
            this.Controls.Add(this.pnl_Historial);
            this.Controls.Add(this.Btn_Igual);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_Ce);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.btn_Porcent);
            this.Controls.Add(this.Pantalla_Principal_TxtBox);
            this.Controls.Add(this.Pantalla_Secundaria_TxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Titulo);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Historial.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Panel pnl_Historial;
        private System.Windows.Forms.Button cerrar_Btn;
        private System.Windows.Forms.Button Ocultar_Ventana_Btn;
        private System.Windows.Forms.Button Minimizar_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Historial;
        private System.Windows.Forms.TextBox Pantalla_Secundaria_TxtBox;
        private System.Windows.Forms.TextBox Pantalla_Principal_TxtBox;
        private System.Windows.Forms.RichTextBox Pantalla_Historial_RichBox;
        private System.Windows.Forms.Button btn_Porcent;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_Ce;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button Btn_Igual;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}