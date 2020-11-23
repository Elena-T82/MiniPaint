using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class unPolygone : Forme
    {
        bool style;
        int cotes;

        public unPolygone(Point origine, Size taille, int cotes, Color color, bool style) : base(origine, color, taille)
        {
            this.style = style;
            this.cotes = cotes;
            
        }

        public unPolygone()
        {

        }

        public bool Style
        {
            get { return style; }
            set { style = value; }
        }

        public int Cotes
        {
            get { return cotes; }
            set { cotes = value; }
        }

        //permet de dessiner un polygone régulier.

        //le polygone se dessine depuis son centre. Donc lors de la selection d'un polygon, la zone de selection est décalée vers le mouvement de la souris. Le problème est le même pour le triangle.
        public override void Dessiner(Graphics p_g)
        {
            var tableauPoints = new Point[cotes];
          
            for (int i = 0; i < cotes; i++)
            {
                //on utilise .Width sur X et Y pour que la longueur des cotés soit identiques.
                double x = origine.X + (taille.Width * Math.Cos(2 * Math.PI * i / cotes));
                double y = origine.Y + (taille.Width * Math.Sin(2 * Math.PI * i / cotes));

                tableauPoints[i] = new Point((int)(x),(int)(y));

            }

            if (style)
                p_g.FillPolygon(new SolidBrush(color), tableauPoints);

            else
                p_g.DrawPolygon(new Pen(color, 3), tableauPoints);
        }
    }
}
