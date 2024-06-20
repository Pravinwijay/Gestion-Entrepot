using GesEntrepotBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesEntrepotBO;

namespace GesEntrepotGUI
{
    public partial class FrmSuppEntreprise : Form
    {
        public FrmSuppEntreprise()
        {
            InitializeComponent();

            // Alimentation de la liste déroulante
            this.cbxSuppEntreprise.DataSource = EntrepriseManager.GetInstance().GetLesEntreprises();
            this.cbxSuppEntreprise.DisplayMember = "nom";
            this.cbxSuppEntreprise.ValueMember = "id";
        }

        private void cbxSuppEntreprise_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // On récupère l'id de l'entreprise séléctionnée
            int idEntreprise = (int)cbxSuppEntreprise.SelectedValue;

            // Création de l'instance qui contient les caractérisitques de l'entreprise selectionnée 
            Entreprise uneEntreprise = EntrepriseManager.GetInstance().GetUneEntreprise(idEntreprise);

            // Affichage du panel qui contient les carac de l'entreprise : 
            this.pnlSuppEntreprise.Show();

            // On renseigne les champs pour afficher les caract de l'entreprise :
            lblNomSelectione.Text = uneEntreprise.Nom;
            lblMailSelectionnee.Text = uneEntreprise.Mel;
            lblRueSelectionee.Text = uneEntreprise.Rue;
            lblVilleSelectionnee.Text = uneEntreprise.Ville.NomVille;
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            // On récupère l'id de l'entreprise séléctionnée
            int idEntreprise = (int)cbxSuppEntreprise.SelectedValue;

            string msg  = EntrepriseManager.GetInstance().SupprEntreprise(idEntreprise);
            MessageBox.Show(msg);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // On cache le pnl
            pnlSuppEntreprise.Visible = false;
        }


    }
}
