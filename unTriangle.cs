using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class unTriangle : Forme
    {

        bool style;

        public unTriangle(Point origine, Size taille, Color color, bool style) : base(origine, color, taille)
        {
            this.style = style;
        }

        public unTriangle()
        {

        }

        public bool Style
        {
            get { return style; }
            set { style = value; }
        }

        public override void Dessiner(Graphics p_g)
        {
            var tableauPoints = new Point[3];

            for (int i = 0; i < 3; i++)
            {
                double x = origine.X + taille.Width * Math.Cos(2 * Math.PI * i / 3);
                double y = origine.Y + taille.Width * Math.Sin(2 * Math.PI * i / 3);

                tableauPoints[i] = new Point((int)(x), (int)(y));

            }
        
            if (style)
                p_g.FillPolygon(new SolidBrush(color), tableauPoints);

            else
                p_g.DrawPolygon(new Pen(color, 3), tableauPoints);
        }
    }
}
