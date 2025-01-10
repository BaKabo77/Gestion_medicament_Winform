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
    public partial class AjoutFamille : Form
    {

        gsbMedicamentEntities DBMedicament;

        public AjoutFamille(gsbMedicamentEntities GSB)
        {
            this.DBMedicament = GSB;
            InitializeComponent();
        }

        private void AjoutFamille_Load(object sender, EventArgs e)
        {

        }

        private famille newFamille()
        {
            famille newFamille = new famille();
            newFamille.id = IDFamille.Text;
            newFamille.libelle = LibFamille.Text;
            return newFamille;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dbdFamille.EndEdit();
            try
            {
                this.DBMedicament.famille.Add(newFamille());
                this.DBMedicament.SaveChanges();
                MessageBox.Show("Ajout de la famille enregistré");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
