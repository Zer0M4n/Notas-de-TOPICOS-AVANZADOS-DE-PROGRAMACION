namespace WindowsFormsApp1
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
            this.botonElipse1 = new WindowsFormsApp1.BotonElipse();
            this.SuspendLayout();
            // 
            // botonElipse1
            // 
            this.botonElipse1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonElipse1.Location = new System.Drawing.Point(312, 165);
            this.botonElipse1.Name = "botonElipse1";
            this.botonElipse1.Size = new System.Drawing.Size(188, 98);
            this.botonElipse1.TabIndex = 0;
            this.botonElipse1.Text = "juan";
            this.botonElipse1.UseVisualStyleBackColor = false;
            this.botonElipse1.Click += new System.EventHandler(this.botonElipse1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonElipse1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private BotonElipse botonElipse1;
    }
}

