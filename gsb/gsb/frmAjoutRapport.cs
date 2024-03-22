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
           this.bindingSourceMedicament.DataSource = mesDonneesEF.medicaments.ToList();
           this.bindingSourceRapport.DataSource = mesDonneesEF.rapports.ToList();
           
            

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
            newRapport.id = Convert.ToInt32(this.txtNum.Text = this.getNumRapport().ToString());
            newRapport.date = date.Value;
            newRapport.motif = txtMotif.Text;
            newRapport.bilan = txtBilan.Text;
            visiteur user = (visiteur)cmbVisiteur.SelectedValue;
            newRapport.idVisiteur = user.id;
            medecin doc = (medecin)cmbMedecin.SelectedValue;
            newRapport.idMedecin = doc.id;
            return newRapport;

        }

      private offrir newOffre()
        {

            int monId= getNumRapport() ;

            offrir offre = new offrir();
            offre.idRapport =monId ;
            medicament m = (medicament)cmbMedicament.SelectedValue;
            offre.idMedicament= m.id;
            offre.quantite = 1;
            return offre;
        }
      


        private void frmAjoutRapport_Load(object sender, EventArgs e)
        {

        }

        private void cmbVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            this.bindingSourceRapport.EndEdit();
            this.bindingSourceOffrir.EndEdit();
            try
            {
                this.mesDonneesEF.rapports.Add(newRapport());
                this.mesDonneesEF.offrirs.Add(newOffre());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement Validé");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}");
            }
        }

        private void cmbMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(cmbFamille.SelectedValue != null)
            {
                /*medicament medoc = (medicament)cmbFamille.SelectedValue;
                cmbFamille.SelectedValue = Convert.ToString(medoc.idFamille);*/

               // string idfamille=Convert.ToString(cmbFamille.SelectedValue);
                
                var req = (from medicament in this.mesDonneesEF.medicaments
                          // where medicament.idFamille == idfamille
                           select medicament.id);

                cmbMedicament.DisplayMember = "id";
                cmbMedicament.ValueMember = "id";
                cmbMedicament.DataSource = req.ToList();
            }
    }
}
