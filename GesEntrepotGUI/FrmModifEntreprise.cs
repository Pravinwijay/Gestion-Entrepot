using GesEntrepotBLL;
using GesEntrepotBO;
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
    public partial class FrmModifEntreprise : Form
    {
        public FrmModifEntreprise()
        {
            InitializeComponent();

            // On alimente la liste déroulante
            cbxEntreprises.DataSource = EntrepriseManager.GetInstance().GetLesEntreprises();
            cbxEntreprises.DisplayMember = "nom";
            cbxEntreprises.ValueMember = "id";   
        }

        
        private void cbxEntreprises_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // On récupère l'id de l'entreprise séléctionnée
            int idEntreprise = (int)cbxEntreprises.SelectedValue;

            // Création de l'instance qui contient les caractérisitques de l'entreprise selectionnée 
            Entreprise uneEntreprise = EntrepriseManager.GetInstance().GetUneEntreprise(idEntreprise);

            // Affichage du panel qui contient les carac de l'entreprise : 
            this.pnlModifEntreprise.Show();

            // Pour afficher la liste des villes
            cbxVilles.DataSource = VilleManager.GetInstance().GetVilles();
            cbxVilles.DisplayMember = "nomVille";
            cbxVilles.ValueMember = "NumInsee";


            // On renseigne les champs pour afficher les caract de l'entreprise :
            txtNom.Text = uneEntreprise.Nom;
            txtMel.Text = uneEntreprise.Mel;
            txtRue.Text = uneEntreprise.Rue;
            cbxVilles.Text = uneEntreprise.Ville.NomVille;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            // On récupère l'id et le reste modifié de l'entreprise séléctionnée
            int idEntreprise = (int)cbxEntreprises.SelectedValue;
            string nouvNom = txtNom.Text;
            string nouvMel = txtMel.Text;
            string nouvRue = txtRue.Text;
            int nouvVille = (int)cbxVilles.SelectedValue;
            
            // L'enregistrement du client : apl du Manager
            string msg = EntrepriseManager.GetInstance().ModifEntreprise(idEntreprise, nouvNom, nouvMel,nouvRue, (int)cbxVilles.SelectedValue);
            MessageBox.Show(msg);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            pnlModifEntreprise.Visible = false;
        }
    }
}
