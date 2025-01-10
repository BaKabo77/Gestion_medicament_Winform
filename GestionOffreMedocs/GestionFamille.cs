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
    public partial class GestionFamille : Form
    {
        gsbMedicamentEntities DBMedicament;

        private Dictionary<string,string> modifs;

        public GestionFamille(gsbMedicamentEntities m)
        {
            InitializeComponent();
            this.DBMedicament = m;
            this.DBFamille.DataSource = DBMedicament.famille.ToList();
            this.tabFamille.CellValueChanged += TabFamille_CellValueChanged;
            this.modifs = new Dictionary<string,string>();

        }

        private void GestionFamille_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private famille getFamille(string lib)
        {
            return DBMedicament.famille.FirstOrDefault(famille => famille.id == lib);
        }

        private void FamilleNavBar_RefreshItems(object sender, EventArgs e)
        {

        }

        private void DBFamille_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
            this.btnValider.Enabled = true;
            this.colLib.ReadOnly = false;
            MessageBox.Show("Vous ne pouvez modifier que le libellé d'une famille de médicament");
        }

        private void tabFamille_DataMemberChanged(object sender, EventArgs e)
        {
            

        }

        private void TabFamille_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow modif = tabFamille.Rows[e.RowIndex];
            string libele = modif.Cells[0].Value.ToString();
            string id = modif.Cells[1].Value.ToString();
            this.modifs.Add(id, libele);
            

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try{ 
                foreach (KeyValuePair<string,string> item in modifs)
                {
                    using(gsbMedicamentEntities context = new gsbMedicamentEntities())
                    {
                        famille fam = context.famille.FirstOrDefault(f=>item.Key == f.id);
                        if (fam != null)
                        {
                            fam.libelle = item.Value;
                            context.SaveChanges();
                        }
                    }
                }

                MessageBox.Show("les modifications ont étés validées");

            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);

            }
            finally
            {
                this.Close();
            }

        }
    }
}
