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
    public partial class AjoutMedoc : Form
    {
        gsbMedicamentEntities DBMedicament;

        public AjoutMedoc(gsbMedicamentEntities DB)
        {
            this.DBMedicament = DB;
            InitializeComponent();

            foreach (famille item in DBMedicament.famille)
            {
                
                this.comboFamille.Items.Add(item.id);
            }
     
        }

        private void AjoutMedoc_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private medicament newMedoc()
        {
            medicament medicament = new medicament();
            medicament.nomCommercial = NomMed.Text;
            medicament.id = IDMed.Text;
            medicament.composition = CompoMed.Text;
            medicament.idFamille= this.comboFamille.SelectedItem.ToString();
            medicament.effets = EffetMed.Text;
            medicament.contreIndications = CIMed.Text;
            return medicament;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.DBMedicament.medicament.Add(newMedoc());
                this.DBMedicament.SaveChanges();
                MessageBox.Show("Ajout du medicament enregistré");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
