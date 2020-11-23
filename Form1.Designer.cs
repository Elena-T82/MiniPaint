namespace TP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dessinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleCarréToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cercleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pleinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.gbPolygone = new System.Windows.Forms.GroupBox();
            this.numSegments = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGomme = new System.Windows.Forms.Button();
            this.btSelection = new System.Windows.Forms.Button();
            this.gbSelection = new System.Windows.Forms.GroupBox();
            this.cbSelection = new System.Windows.Forms.CheckBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MenuContextuel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.déplacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redimensionnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.gbPolygone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSegments)).BeginInit();
            this.gbSelection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MenuContextuel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem,
            this.dessinerToolStripMenuItem,
            this.styleToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem1,
            this.chargerToolStripMenuItem});
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sauvegarderToolStripMenuItem.Text = "Fichier";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // dessinerToolStripMenuItem
            // 
            this.dessinerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleCarréToolStripMenuItem,
            this.cercleToolStripMenuItem,
            this.triangleToolStripMenuItem,
            this.polygoneToolStripMenuItem,
            this.ligneToolStripMenuItem});
            this.dessinerToolStripMenuItem.Name = "dessinerToolStripMenuItem";
            this.dessinerToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.dessinerToolStripMenuItem.Text = "Dessiner";
            this.dessinerToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // rectangleCarréToolStripMenuItem
            // 
            this.rectangleCarréToolStripMenuItem.Name = "rectangleCarréToolStripMenuItem";
            this.rectangleCarréToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.rectangleCarréToolStripMenuItem.Text = "Rectangle - carré";
            this.rectangleCarréToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // cercleToolStripMenuItem
            // 
            this.cercleToolStripMenuItem.Name = "cercleToolStripMenuItem";
            this.cercleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cercleToolStripMenuItem.Text = "Cercle";
            this.cercleToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // triangleToolStripMenuItem
            // 
            this.triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            this.triangleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.triangleToolStripMenuItem.Text = "Triangle";
            this.triangleToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // polygoneToolStripMenuItem
            // 
            this.polygoneToolStripMenuItem.Name = "polygoneToolStripMenuItem";
            this.polygoneToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.polygoneToolStripMenuItem.Text = "Polygone";
            this.polygoneToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // ligneToolStripMenuItem
            // 
            this.ligneToolStripMenuItem.Name = "ligneToolStripMenuItem";
            this.ligneToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ligneToolStripMenuItem.Text = "Ligne";
            this.ligneToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pleinToolStripMenuItem,
            this.contourToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.styleToolStripMenuItem.Text = "Style";
            this.styleToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // pleinToolStripMenuItem
            // 
            this.pleinToolStripMenuItem.Name = "pleinToolStripMenuItem";
            this.pleinToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pleinToolStripMenuItem.Text = "Plein";
            this.pleinToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // contourToolStripMenuItem
            // 
            this.contourToolStripMenuItem.Name = "contourToolStripMenuItem";
            this.contourToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.contourToolStripMenuItem.Text = "Contour";
            this.contourToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // btnColor
            // 
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(12, 19);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(66, 59);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Couleur";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // gbPolygone
            // 
            this.gbPolygone.Controls.Add(this.numSegments);
            this.gbPolygone.Controls.Add(this.label1);
            this.gbPolygone.Enabled = false;
            this.gbPolygone.Location = new System.Drawing.Point(162, 19);
            this.gbPolygone.Name = "gbPolygone";
            this.gbPolygone.Size = new System.Drawing.Size(168, 59);
            this.gbPolygone.TabIndex = 3;
            this.gbPolygone.TabStop = false;
            this.gbPolygone.Text = "Polygone";
            // 
            // numSegments
            // 
            this.numSegments.Location = new System.Drawing.Point(124, 21);
            this.numSegments.Name = "numSegments";
            this.numSegments.Size = new System.Drawing.Size(38, 20);
            this.numSegments.TabIndex = 4;
            this.numSegments.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de segments :";
            // 
            // btnGomme
            // 
            this.btnGomme.Image = global::TP2.Properties.Resources.gomme;
            this.btnGomme.Location = new System.Drawing.Point(84, 19);
            this.btnGomme.Name = "btnGomme";
            this.btnGomme.Size = new System.Drawing.Size(72, 59);
            this.btnGomme.TabIndex = 2;
            this.btnGomme.UseVisualStyleBackColor = true;
            this.btnGomme.Click += new System.EventHandler(this.btnGomme_Click);
            // 
            // btSelection
            // 
            this.btSelection.Location = new System.Drawing.Point(16, 19);
            this.btSelection.Name = "btSelection";
            this.btSelection.Size = new System.Drawing.Size(99, 30);
            this.btSelection.TabIndex = 4;
            this.btSelection.Text = "Activer / Annuler";
            this.btSelection.UseVisualStyleBackColor = true;
            this.btSelection.Click += new System.EventHandler(this.btSelection_Click);
            // 
            // gbSelection
            // 
            this.gbSelection.Controls.Add(this.cbSelection);
            this.gbSelection.Controls.Add(this.btSelection);
            this.gbSelection.Location = new System.Drawing.Point(336, 20);
            this.gbSelection.Name = "gbSelection";
            this.gbSelection.Size = new System.Drawing.Size(168, 59);
            this.gbSelection.TabIndex = 5;
            this.gbSelection.TabStop = false;
            this.gbSelection.Text = "Selection";
            // 
            // cbSelection
            // 
            this.cbSelection.AutoSize = true;
            this.cbSelection.Enabled = false;
            this.cbSelection.Location = new System.Drawing.Point(132, 28);
            this.cbSelection.Name = "cbSelection";
            this.cbSelection.Size = new System.Drawing.Size(15, 14);
            this.cbSelection.TabIndex = 6;
            this.cbSelection.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(743, 45);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(51, 40);
            this.btnRetour.TabIndex = 6;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnRetour);
            this.groupBox1.Controls.Add(this.btnColor);
            this.groupBox1.Controls.Add(this.gbSelection);
            this.groupBox1.Controls.Add(this.btnGomme);
            this.groupBox1.Controls.Add(this.gbPolygone);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // MenuContextuel
            // 
            this.MenuContextuel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déplacerToolStripMenuItem,
            this.redimensionnerToolStripMenuItem});
            this.MenuContextuel.Name = "MenuContextuel";
            this.MenuContextuel.Size = new System.Drawing.Size(161, 48);
            this.MenuContextuel.Click += new System.EventHandler(this.MenuContextuel_Click);
            // 
            // déplacerToolStripMenuItem
            // 
            this.déplacerToolStripMenuItem.Name = "déplacerToolStripMenuItem";
            this.déplacerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.déplacerToolStripMenuItem.Text = "Déplacer";
            this.déplacerToolStripMenuItem.Click += new System.EventHandler(this.MenuContextuel_Click);
            // 
            // redimensionnerToolStripMenuItem
            // 
            this.redimensionnerToolStripMenuItem.Name = "redimensionnerToolStripMenuItem";
            this.redimensionnerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.redimensionnerToolStripMenuItem.Text = "Redimensionner";
            this.redimensionnerToolStripMenuItem.Click += new System.EventHandler(this.MenuContextuel_Click);
            // 
            // sauvegarderToolStripMenuItem1
            // 
            this.sauvegarderToolStripMenuItem1.Name = "sauvegarderToolStripMenuItem1";
            this.sauvegarderToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sauvegarderToolStripMenuItem1.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem1.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.menuElement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.gbPolygone.ResumeLayout(false);
            this.gbPolygone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSegments)).EndInit();
            this.gbSelection.ResumeLayout(false);
            this.gbSelection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.MenuContextuel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem dessinerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleCarréToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cercleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pleinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contourToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnGomme;
        private System.Windows.Forms.GroupBox gbPolygone;
        private System.Windows.Forms.NumericUpDown numSegments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSelection;
        private System.Windows.Forms.GroupBox gbSelection;
        private System.Windows.Forms.CheckBox cbSelection;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip MenuContextuel;
        private System.Windows.Forms.ToolStripMenuItem déplacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redimensionnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
    }
}

