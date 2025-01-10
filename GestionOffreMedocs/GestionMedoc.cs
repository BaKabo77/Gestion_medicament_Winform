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
    public partial class GestionMedoc : Form
    {

        private gsbMedicamentEntities DBMedicament;

        private List<medicament> modifs;

        public GestionMedoc(gsbMedicamentEntities DB)
        {
            InitializeComponent();
            DBMedicament = DB;
            tabMed.DataSource = DBMedicament.medicament.ToList();
            modifs = new List<medicament>();
            this.tabMed.CellValueChanged += tabMed_CellValueChanged;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabMed.ReadOnly = false;
            this.colFam.ReadOnly = true;
            this.colID.ReadOnly = true;
            this.btnValider.Enabled = true;
            MessageBox.Show("Modification de tout les champs sauf les ID de médicaments et familles");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(medicament m in modifs)
                {
                    using(gsbMedicamentEntities context = new gsbMedicamentEntities())
                    {
                        medicament med = context.medicament.FirstOrDefault(ele => ele.id == m.id);
                        med.nomCommercial = m.nomCommercial;
                        med.composition = m.composition;
                        med.effets = m.effets;
                        med.contreIndications = m.contreIndications;
                        context.SaveChanges();

                    }
                }

                MessageBox.Show("les modifications ont étés validées");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void tabMed_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si l'index est valide
            if (e.RowIndex < 0 || e.RowIndex >= tabMed.Rows.Count)
                return;

            DataGridViewRow modif = tabMed.Rows[e.RowIndex];

            // Créer et remplir l'objet médicament
            medicament medoc = new medicament
            {
                id = modif.Cells[0].Value?.ToString(),
                nomCommercial = modif.Cells[1].Value?.ToString(),
                idFamille = modif.Cells[2].Value?.ToString(),
                composition = modif.Cells[3].Value?.ToString(),
                effets = modif.Cells[4].Value?.ToString(),
                contreIndications = modif.Cells[5].Value?.ToString(),
            };

            // Ajouter l'objet à la liste des modifications
            if (modifs == null)
                modifs = new List<medicament>();
            modifs.Add(medoc);

            
        }


        private void tabMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GestionMedoc_Load(object sender, EventArgs e)
        {

        }
    }
}
