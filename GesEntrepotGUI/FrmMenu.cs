using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesEntrepotGUI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void tsmAjtEntreprise_Click(object sender, EventArgs e)
        {
            // Créer un objet de la classe du formulaire à appeler
            FrmAjoutEntreprise leFrmAjoutEntreprise = new FrmAjoutEntreprise();

            // Affichage du formulaire
            leFrmAjoutEntreprise.Show();
        }

        private void tsmConsultEntreprises_Click(object sender, EventArgs e)
        {
            // Créer un objet de la classe du formulaire à appeler
            FrmConsultEntreprises leFrmConsultEntreprises = new FrmConsultEntreprises();

            // Affichage du formulaire
            leFrmConsultEntreprises.Show();
        }

        private void suppressionDesEntreprisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créer un objet de la classe du formulaire à appeler
            FrmSuppEntreprise leFrmSuppEntreprise = new FrmSuppEntreprise();

            // Affichage du formulaire
            leFrmSuppEntreprise.Show();

        }

        private void modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Créer un objet de la classe du formulaire à appeler
            FrmModifEntreprise leFrmModifEntreprise = new FrmModifEntreprise();

            // Affichage du formulaire
            leFrmModifEntreprise.Show();
        }
    }
}
