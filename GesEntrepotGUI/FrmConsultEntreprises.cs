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

namespace GesEntrepotGUI
{
    public partial class FrmConsultEntreprises : Form
    {
        public FrmConsultEntreprises()
        {
            InitializeComponent();
            this.dtgConsultEntreprises.DataSource = EntrepriseManager.GetInstance().GetLesEntreprises();

            // Pour masquer l'id et ville
            this.dtgConsultEntreprises.Columns["id"].Visible = false;
            this.dtgConsultEntreprises.Columns["ville"].Visible = false;

            // Pour changer les titres des colonnes
            dtgConsultEntreprises.Columns["Nom"].HeaderText = "Nom de l'entreprise";
            dtgConsultEntreprises.Columns["Rue"].HeaderText = "Adresse";
            dtgConsultEntreprises.Columns["Mel"].HeaderText = "Mail électronique";
            dtgConsultEntreprises.Columns["NomVille"].HeaderText = "Ville";

        }
    }
}
