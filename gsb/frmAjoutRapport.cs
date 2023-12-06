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
            for (int i = 0; i > 30; i++)
                this.cmbVisiteur.Items.Add(i);
           this.mesDonneesEF = mesDonneesEF;
           this.bindingSourceVisiteur.DataSource = mesDonneesEF.visiteurs.ToList();  
           this.bindingSourceMedecin.DataSource = mesDonneesEF.medecins.ToList();
           this.bindingSourceFamille.DataSource = mesDonneesEF.familles.ToList();
        }

        

        

        private void frmAjoutRapport_Load(object sender, EventArgs e)
        {

        }

        private void cmbVisiteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
