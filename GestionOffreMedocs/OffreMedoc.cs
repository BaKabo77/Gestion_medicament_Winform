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
    public partial class OffreMedoc : Form
    {

        private gsbMedicamentEntities DBMedicament;
        private string NomMedoc;

        public OffreMedoc(gsbMedicamentEntities dBMedicament, string nomMedoc)
        {
            InitializeComponent();
            DBMedicament = dBMedicament;
            NomMedoc = nomMedoc;

            string idNom = DBMedicament.medicament.Where(ele=>ele.nomCommercial.Equals(nomMedoc)).Select(ele=>ele.id).FirstOrDefault();

            GridMedoc.DataSource = DBMedicament.offrir.Where(ele=>ele.idMedicament.Equals(idNom)).Select(ele=>ele).ToList();

          
        }

        private void OffreMedoc_Load(object sender, EventArgs e)
        {

        }
    }
}
