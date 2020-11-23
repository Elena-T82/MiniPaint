using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace TP2
{
    public class uneLigne : Forme
    {

        public uneLigne(Point origine, Size taille, Color color) : base(origine, color, taille)
        {

        }

        public uneLigne()
        {

        }


        public override void Dessiner(Graphics p_g)
        {
            p_g.DrawLine(new Pen(color, 3), origine.X, origine.Y, origine.X + taille.Width, origine.Y + taille.Height);
        }
    }
}
