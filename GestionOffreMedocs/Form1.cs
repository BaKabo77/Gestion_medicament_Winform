using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionOffreMedocs
{
    public partial class Form1 : Form
    {
        gsbMedicamentEntities DBMedicament;

        public Form1()
        {
            InitializeComponent();
            this.DBMedicament = new gsbMedicamentEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjoutMedoc AM = new AjoutMedoc(DBMedicament);
            AM.MdiParent = this;
            AM.Show();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjoutFamille AF = new AjoutFamille(DBMedicament);
            AF.MdiParent = this;
            AF.Show();
        }

        private void gererToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GestionFamille gf = new GestionFamille(DBMedicament);
            gf.MdiParent = this;
            gf.Show();
        }

        private void gererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMedoc gm = new GestionMedoc(DBMedicament);
            gm.MdiParent = this;
            gm.Show();
        }

        private void offresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void médicamentsOffertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOffre frmoffre = new FormOffre(DBMedicament);
            frmoffre.MdiParent = this;
            frmoffre.Show();
        }
    }
}
