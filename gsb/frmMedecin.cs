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
    public partial class frmMedecin : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        public frmMedecin(gsbrapportsEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
        }

        private void frmMedecin_Load(object sender, EventArgs e)
        {

        }
    }
}
