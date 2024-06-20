using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesEntrepotBLL;

namespace GesEntrepotGUI
{
    public partial class FrmAjoutEntreprise : Form
    {
        public FrmAjoutEntreprise()
        {
            InitializeComponent();
            cbxVille.DataSource = VilleManager.GetInstance().GetVilles();
            cbxVille.DisplayMember = "nomVille";
            cbxVille.ValueMember = "numInsee";
        }

        private void btnEnregistrerEntreprise_Click(object sender, EventArgs e)
        {
            // L'enregistrement du client : apl du Manager
            string msg = EntrepriseManager.GetInstance().CreerEntreprise(txtNomEntreprise.Text, this.txtRue.Text, this.txtMail.Text, (int)cbxVille.SelectedValue);
            MessageBox.Show(msg);
            
        }
    }
}
