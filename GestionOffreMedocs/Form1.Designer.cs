namespace GestionOffreMedocs
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicamentsOffertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicamentsToolStripMenuItem,
            this.famillesToolStripMenuItem,
            this.offresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicamentsToolStripMenuItem
            // 
            this.medicamentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            this.medicamentsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.medicamentsToolStripMenuItem.Text = "Medicaments";
            // 
            // gererToolStripMenuItem
            // 
            this.gererToolStripMenuItem.Name = "gererToolStripMenuItem";
            this.gererToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.gererToolStripMenuItem.Text = "Gerer";
            this.gererToolStripMenuItem.Click += new System.EventHandler(this.gererToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // famillesToolStripMenuItem
            // 
            this.famillesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem1,
            this.ajouterToolStripMenuItem1});
            this.famillesToolStripMenuItem.Name = "famillesToolStripMenuItem";
            this.famillesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.famillesToolStripMenuItem.Text = "Familles";
            // 
            // gererToolStripMenuItem1
            // 
            this.gererToolStripMenuItem1.Name = "gererToolStripMenuItem1";
            this.gererToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.gererToolStripMenuItem1.Text = "Gerer";
            this.gererToolStripMenuItem1.Click += new System.EventHandler(this.gererToolStripMenuItem1_Click);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // offresToolStripMenuItem
            // 
            this.offresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicamentsOffertsToolStripMenuItem});
            this.offresToolStripMenuItem.Name = "offresToolStripMenuItem";
            this.offresToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.offresToolStripMenuItem.Text = "Offres";
            this.offresToolStripMenuItem.Click += new System.EventHandler(this.offresToolStripMenuItem_Click);
            // 
            // médicamentsOffertsToolStripMenuItem
            // 
            this.médicamentsOffertsToolStripMenuItem.Name = "médicamentsOffertsToolStripMenuItem";
            this.médicamentsOffertsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.médicamentsOffertsToolStripMenuItem.Text = "Médicaments offerts";
            this.médicamentsOffertsToolStripMenuItem.Click += new System.EventHandler(this.médicamentsOffertsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 526);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion médicament et famille";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famillesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem offresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicamentsOffertsToolStripMenuItem;
    }
}

