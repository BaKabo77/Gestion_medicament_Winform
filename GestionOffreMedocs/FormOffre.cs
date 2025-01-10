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
    public partial class FormOffre : Form
    {

        private gsbMedicamentEntities DBMedicament;


        public FormOffre(gsbMedicamentEntities dBMedicament)
        {
            InitializeComponent();
            DBMedicament = dBMedicament;
            List<string> list = new List<string>();

            DBMedicament.famille.ToList().ForEach(ele=> list.Add(ele.id));

            cmbFamille.DataSource =list;
        }

        private void FormOffre_Load(object sender, EventArgs e)
        {
            cmbMedoc.Visible = false;
            labelMedoc.Visible = false;
            AfficherBtn.Enabled = false;
        }

        private void cmbFamille_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbFamille.SelectedValue != null)
            {
                string selectedFamille = cmbFamille.SelectedValue.ToString();

                // Filtrer les médicaments par famille sélectionnée
                var medicaments = DBMedicament.medicament
                                    .Where(m => m.idFamille == selectedFamille)
                                    .Select(m => m.nomCommercial)
                                    .ToList();

                // Mise à jour de la ComboBox cmbMedoc
                if (medicaments.Any())
                {
                    cmbMedoc.DataSource = medicaments;
                    cmbMedoc.Visible = true;
                    labelMedoc.Visible = true;
                }
                else
                {
                    // Cacher si aucun médicament n'est trouvé
                    cmbMedoc.Visible = false;
                    labelMedoc.Visible = false;
                }
            }
        }

        private void cmbMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherBtn.Enabled = true;
        }

        private void ValiderBtn_Click(object sender, EventArgs e)
        {
            OffreMedoc om = new OffreMedoc(DBMedicament, cmbMedoc.SelectedValue.ToString());
            om.Show();
        }
    }
}
