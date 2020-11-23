using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class unRectangle : Forme
    {
        bool style;

        public unRectangle(Point origine, Size taille, Color color, bool style) : base(origine, color, taille)
        {
            this.style = style;
        }

        public unRectangle()
        {

        }

        public bool Style
        {
            get { return style; }
            set { style = value; }
        }

        public override void Dessiner(Graphics p_g)
        {
            if(style)
            {
                p_g.FillRectangle(new SolidBrush(color), origine.X, origine.Y, taille.Width, taille.Height);
            }
            else
            {
                p_g.DrawRectangle(new Pen(color, 2), origine.X, origine.Y, taille.Width, taille.Height);
            }
        }

    }
}
