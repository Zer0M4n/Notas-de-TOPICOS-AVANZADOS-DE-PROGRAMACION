using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class BotonElipse : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graficos = new GraphicsPath();//generamos un objeto para controlar los grafico
            graficos.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);//usamos la funcion para hacer una elipce
            this.Region = new System.Drawing.Region(graficos);
            base.OnPaint(pevent);
        }
    }
}
