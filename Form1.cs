using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TP2
{

    public enum typeForme
    {
        Rectangle,
        Triangle,
        Cercle, 
        Polygone,
        Ligne
    }

    public partial class Form1 : Form
    {
        typeForme formeType = typeForme.Rectangle;
        bool style = false;

        Point debut;
        bool dessine = false;
        Point difference;

        Size espacement;

        Stack<Forme> formes = new Stack<Forme>();

        List<Forme> formesSelectionner = new List<Forme>();

        Color color = Color.Black;

        bool selection = false;

        //permet de deplacement ou le redimensionnement.
        bool clicEnfonce = false;

        //variable mis à jour au clic du menu contextuel
        bool deplacement = false;
        bool redimensionner = false;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach(Forme forme in formes)
            {
                forme.Dessiner(g);

                //permet d'afficher le visuel de la selection
                if (selection)
                    if (formesSelectionner.Count != 0)
                        formesSelectionner[0].AppliquerSelection(g);
                        
            }

            g.Dispose();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
            btnColor.BackColor = color;

            //permet de changer la couleur d'une forme si elle a été sélectionné.
            if (selection)
                if (formesSelectionner.Count != 0)
                    formesSelectionner[0].Couleur = color;

            Invalidate();
        }

        private void menuElement_Click(object sender, EventArgs e)
        {
            switch(sender.ToString())
            {
                case "Rectangle - carré":

                    formeType = typeForme.Rectangle;
                    gbPolygone.Enabled = false;
                    break;

                case "Cercle":

                    formeType = typeForme.Cercle;
                    gbPolygone.Enabled = false;
                    break;

                case "Triangle":

                    formeType = typeForme.Triangle;
                    gbPolygone.Enabled = false;
                    break;

                case "Polygone":

                    formeType = typeForme.Polygone;
                    gbPolygone.Enabled = true;
                    break;

                case "Ligne":

                    formeType = typeForme.Ligne;
                    gbPolygone.Enabled = false;
                    break;

                case "Plein":

                    style = true;
                    break;

                case "Contour":

                    style = false;
                    break;

                case "Sauvegarder":

                    Serialiser();
                    break;

                case "Charger":

                    Deserialiser();
                    break;
            }
        }

        private void Serialiser()
        {
            List<Forme> maListe = formes.ToList<Forme>();

            XmlSerializer serialiser = new XmlSerializer(typeof(List<Forme>));
            FileStream fichier = new FileStream("formeSerialiser.xml", FileMode.Create);
            serialiser.Serialize(fichier, maListe);
            fichier.Close();

            MessageBox.Show("Votre dessin est sauvegardé.");
        }

        private void Deserialiser()
        {
            List<Forme> maListe = formes.ToList<Forme>();

            FileStream fichier = new FileStream("formeSerialiser.xml", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Forme>));
            List<Forme> the = (List<Forme>)serializer.Deserialize(fichier);

            fichier.Close();

            Graphics g = CreateGraphics();

            foreach (Forme t in the)
            {
                //on retransforme le int en couleur.
                t.Couleur = Color.FromArgb(t.intCouleur);
                formes.Push(t);
                t.Dessiner(g);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            debut = e.Location;

            clicEnfonce = true;

            if (!selection)
            {
                dessine = true;
            }
            //permet de garder la différence entre le clic souris et le point d'origine de la forme selectionné afin que, quand on déplace la forme, la souris puisse rester constamment au même endroit dans la forme.
            else if(selection && formesSelectionner.Count > 0)
            {
                int differenceX = debut.X - formesSelectionner[0].Origine.X;
                int differenceY = debut.Y - formesSelectionner[0].Origine.Y;

                difference = new Point(differenceX, differenceY);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point fin = e.Location;
            Graphics g = CreateGraphics();

            if(dessine)
            {
                g.Clear(Color.White);

                switch (formeType)
                {
                    case typeForme.Rectangle:

                        unRectangle rectangle = new unRectangle(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), color, style);
                        rectangle.Dessiner(g);

                        break;

                    case typeForme.Cercle:

                        unCercle cercle = new unCercle(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), color, style);
                        cercle.Dessiner(g);

                        break;

                    case typeForme.Triangle:

                        unTriangle triangle = new unTriangle(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), color, style);
                        triangle.Dessiner(g);
                        break;

                    case typeForme.Polygone:

                        int cotes = (int)numSegments.Value;

                        if (cotes < 3)
                        {
                            MessageBox.Show("Un polygone ne peut pas avoir moins de 3 côtés.");
                            dessine = false;
                        }
                        else
                        {
                            unPolygone polygone = new unPolygone(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), cotes, color, style);
                            polygone.Dessiner(g);
                        }

                        break;

                    case typeForme.Ligne:

                        uneLigne ligne = new uneLigne(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), color);
                        ligne.Dessiner(g);

                        break;
                }
               
                Form1_Paint(null, new PaintEventArgs(g, new Rectangle(0, 0, Width, Height)));

                g.Dispose();

            }
            //si on a sélectionné le mode deplacer via le clic droit
            else if(selection && clicEnfonce && deplacement && formesSelectionner.Count != 0)
            {
                formesSelectionner[0].Deplacer(fin, difference); 

                Invalidate();
            }
            //si on a sélectionné le mode redimensionner via le clic droit
            else if (selection && clicEnfonce && redimensionner && formesSelectionner.Count != 0)
            {
                int x = formesSelectionner[0].Taille.Width - difference.X;
                int y = formesSelectionner[0].Taille.Height - difference.Y;

                espacement = new Size(x, y);

                formesSelectionner[0].Redimensionner(espacement, new Size(fin.X - debut.X, fin.Y - debut.Y));

                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Point fin = e.Location;
            dessine = false;

            clicEnfonce = false;

            if (!selection)
            {
                //on ajoute les formes dans la pile au lacher de souris
                switch (formeType)
                {
                    case typeForme.Rectangle:

                        formes.Push(new unRectangle(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), color, style));

                        break;

                    case typeForme.Cercle:

                        formes.Push(new unCercle(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), color, style));

                        break;

                    case typeForme.Triangle:

                        formes.Push(new unTriangle(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), color, style));

                        break;

                    case typeForme.Polygone:

                        int cotes = (int)numSegments.Value;

                        formes.Push(new unPolygone(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), cotes, color, style));

                        break;

                    case typeForme.Ligne:

                        formes.Push(new uneLigne(debut, new Size(fin.X - debut.X, fin.Y - debut.Y), color));

                        break;
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            
            int numRetenu = 0;

            formesSelectionner.Clear();
            
            //fait apparaître le menu contextuel au clic droit.
             if (e.Button == MouseButtons.Right)
             {
                MenuContextuel.Show(MousePosition);
             }

            else if (selection && e.Button == MouseButtons.Left)
            {
                foreach(Forme forme in formes)
                {
                    //on ajoute les formes selectionnées dans une liste
                    if (forme.Selectionner(e.Location))
                    {
                        formesSelectionner.Add(forme);
                    }
                }

                //on compare les formes jusqu'à ce qu'il n'en reste qu'une : la plus petite.
                if (formesSelectionner.Count > 1)
                {
                    for (int j = 1; j < formesSelectionner.Count; j++)
                    {
                        //On compare les diagonales de toutes les formes qui ont été selectionné.

                        float a = formesSelectionner[j - 1].Taille.Width * 2;
                        float b = formesSelectionner[j - 1].Taille.Height * 2;
                        float perimetre1 = (float)(a + b);

                        float c = formesSelectionner[j].Taille.Width * 2;
                        float d = formesSelectionner[j].Taille.Height * 2;
                        float perimetre2 = (float)(c + d);

                        //on retient l'emplacement de la plus petite diagonale.
                        if (perimetre1 < perimetre2)
                        {
                            numRetenu = j - 1;
                        }
                        else
                        {
                            numRetenu = j;
                        }
                    }

                    formesSelectionner[0] = formesSelectionner[numRetenu];

                    //on supprime les formes les plus grandes.
                    for (int i = 1; i < formesSelectionner.Count; i++)
                    {
                        formesSelectionner.RemoveAt(i);
                    }
                }
                //il ne reste qu'une forme dans la liste : la plus petite
            }

            Invalidate();
        }


        private void btnGomme_Click(object sender, EventArgs e)
        {
            //on vide tout

            Graphics g = CreateGraphics();
            formes.Clear();
            formesSelectionner.Clear();

            selection = false;
            cbSelection.Checked = false;

            g.Clear(Color.White);
        }

        private void btSelection_Click(object sender, EventArgs e)
        {
            if (cbSelection.Checked)
            {
                selection = false;
                cbSelection.Checked = false;
                deplacement = false;
                redimensionner = false;

                formesSelectionner.Clear();
            }
            else
            {
                selection = true;
                cbSelection.Checked = true;
            }

            Invalidate();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (formes.Count != 0)
                if (!selection)
                    formes.Pop();
                else
                    MessageBox.Show("Retirer la sélection.");

            Invalidate();
        }

        private void MenuContextuel_Click(object sender, EventArgs e)
        {
            //retiens le choix de l'utilisateur pour la prochaine selection
            switch (sender.ToString())
            {
                case "Déplacer":

                    deplacement = true;
                    redimensionner = false;
                    break;

                case "Redimensionner":

                    deplacement = false;
                    redimensionner = true;
                    break;
            }
        }

    }
}
