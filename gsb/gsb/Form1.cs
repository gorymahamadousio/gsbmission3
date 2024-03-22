using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsb
{
    public partial class Form1 : Form
    {

        private gsbrapportsEntities mesDonneesEF;
        public Form1()
        {
            InitializeComponent();
            this.mesDonneesEF = new gsbrapportsEntities();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            frmAjoutRapport frm = new frmAjoutRapport(this.mesDonneesEF);
            frm.MdiParent = this;
            frm.Show();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMedecin f=new frmMedecin(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRechercheRapport f = new frmRechercheRapport(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }
    }
}
