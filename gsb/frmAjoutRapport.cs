using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsb
{
    public partial class frmAjoutRapport : Form
    {

        private gsbrapportsEntities mesDonneesEF;
        public frmAjoutRapport(gsbrapportsEntities mesDonneesEF)
        {
            InitializeComponent();
         
           this.mesDonneesEF = mesDonneesEF;
           this.bindingSourceVisiteur.DataSource = mesDonneesEF.visiteurs.ToList();  
           this.bindingSourceMedecin.DataSource = mesDonneesEF.medecins.ToList();
           this.bindingSourceFamille.DataSource = mesDonneesEF.familles.ToList();
        }

        private int getNumRapport()
        {
            var reqDernier = (from rp in this.mesDonneesEF.rapports
                              orderby rp.id descending
                              select rp);
            rapport dernierRapport = reqDernier.First();
            int res = dernierRapport.id + 1;
            return res;
        }

        private rapport newRapport()
        {
            rapport newRapport = new rapport();
            newRapport.id = Convert.ToInt32(txtNum.Text);
            newRapport.date = date.Value;
            newRapport.motif = txtMotif.Text;
            newRapport.bilan = txtBilan.Text;
            newRapport.idVisiteur = Convert.ToString(cmbVisiteur.SelectedValue);
            newRapport.idMedecin = Convert.ToInt32(cmbMedecin.SelectedValue);
            return newRapport;

        }

        private offrir newOffre()
        {
            offrir offre = new offrir();
            offre.idRapport = Convert.ToInt32(txtNum.Text);
            return offre;
        }



        private void frmAjoutRapport_Load(object sender, EventArgs e)
        {

        }

        private void cmbVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtNum.Text = this.getNumRapport().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingSourceRapport.EndEdit();
            this.bindingSourceOffrir.EndEdit();
            try
            {
                this.mesDonneesEF.rapports.Add(newRapport());
                this.mesDonneesEF.SaveChanges();
                this.mesDonneesEF.offrirs.Add(newOffre());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : { ex.Message}");
            }
        }
    }
}
