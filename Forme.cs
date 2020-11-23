using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP2
{
    [DataContract]
    [XmlInclude(typeof(unCercle))]
    [XmlInclude(typeof(unRectangle))]
    [XmlInclude(typeof(uneLigne))]
    [XmlInclude(typeof(unTriangle))]
    [XmlInclude(typeof(unPolygone))]

    public abstract class Forme
    {
        //les champs commun à toute les autres classes
        protected Point origine;
        protected Size taille;
        protected Color color;

        public int intCouleur;

        [XmlIgnore]
        public Color Couleur
        {
            get { return Color.FromArgb(intCouleur); }
            set { color = value;
                    intCouleur = color.ToArgb();
                }
        }

        public Point Origine
        {
            get { return origine; }
            set { origine = value; }
        }

        public Size Taille
        {
            get { return taille; }
            set { taille = value; }
        }


        protected Forme(Point origine, Color color, Size taille)
        {
            this.origine = origine;
            this.taille = taille;
            Couleur = color;

        }

        public Forme()
        {

        }


        public abstract void Dessiner(Graphics g);
        
        //permet de savoir si lors d'une selection, le clic de la souris se trouve dans la forme
        public bool Selectionner(Point po)
        {
            if ((po.X >= origine.X && po.X <= origine.X + taille.Width) && (po.Y >= origine.Y && po.Y <= origine.Y + taille.Height))
            {
                return true;
            }
            else
                return false;
        }

        //Dessne les carrés de selection autour de la forme.
        public void AppliquerSelection(Graphics p_g)
        {
            p_g.DrawRectangle(new Pen(Color.Red, 2), origine.X - 5, origine.Y - 5, 10, 10);
            p_g.DrawRectangle(new Pen(Color.Red, 2), origine.X + taille.Width - 5, origine.Y - 5, 10, 10);
            p_g.DrawRectangle(new Pen(Color.Red, 2), origine.X + taille.Width - 5, origine.Y + taille.Height - 5, 10, 10);
            p_g.DrawRectangle(new Pen(Color.Red, 2), origine.X - 5, origine.Y + taille.Height - 5, 10, 10);


        }

        public void Deplacer(Point fin, Point deplacement)
        {
            origine.X = fin.X - deplacement.X;
            origine.Y = fin.Y - deplacement.Y;

        }

        public void Redimensionner(Size espacement, Size redimension)
        {
            taille.Width = taille.Width - espacement.Width + redimension.Width;
            taille.Height = taille.Height - espacement.Height + redimension.Height;
        }


        //permet de calculer la difference entre le point d'origine de 2 formes
        public static Point operator +(Forme forme1, Forme forme2)
        {
            Point NouveauPoint;

            int x = forme1.Origine.X + forme2.Origine.X;
            int y = forme1.Origine.Y + forme2.Origine.Y;

            NouveauPoint = new Point(x, y);

            return NouveauPoint;
        }

    }
}
