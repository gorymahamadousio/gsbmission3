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

    public partial class frmRechercheRapport : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        public frmRechercheRapport(gsbrapportsEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bindingSourceRapport.DataSource = mesDonneesEF.rapports.ToList();
            this.bindingSourceVisiteur.DataSource=mesDonneesEF.visiteurs.ToList();  
        }

        private void frmRechercheRapport_Load(object sender, EventArgs e)
        {

        }

        private List<rapport> getRapport()
        {
            
           
            var res = (from rp in mesDonneesEF.rapports
                       where rp.idVisiteur == cmbVisiteur.SelectedValue && rp.date == dateRapport.Value.Date
                       select rp).ToList();
            
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbVisiteur.SelectedValue != null && dateRapport.Value !=null)
            {
                List<rapport> mesrapports= getRapport();
                if(mesrapports != null)
                {
                    dgvRapport.DataSource = mesrapports;
                }
                         
            
            }
        }
    }
}
