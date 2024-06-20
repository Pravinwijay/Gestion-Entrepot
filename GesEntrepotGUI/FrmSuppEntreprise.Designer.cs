namespace GesEntrepotGUI
{
    partial class FrmSuppEntreprise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblListeEntreprise = new System.Windows.Forms.Label();
            this.cbxSuppEntreprise = new System.Windows.Forms.ComboBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnlSuppEntreprise = new System.Windows.Forms.Panel();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNomSelectione = new System.Windows.Forms.Label();
            this.lblVilleSelectionnee = new System.Windows.Forms.Label();
            this.lblRueSelectionee = new System.Windows.Forms.Label();
            this.lblMailSelectionnee = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlSuppEntreprise.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListeEntreprise
            // 
            this.lblListeEntreprise.AutoSize = true;
            this.lblListeEntreprise.Location = new System.Drawing.Point(281, 94);
            this.lblListeEntreprise.Name = "lblListeEntreprise";
            this.lblListeEntreprise.Size = new System.Drawing.Size(213, 13);
            this.lblListeEntreprise.TabIndex = 0;
            this.lblListeEntreprise.Text = "Veuillez sélectionner l\'entreprise à supprimer";
            // 
            // cbxSuppEntreprise
            // 
            this.cbxSuppEntreprise.FormattingEnabled = true;
            this.cbxSuppEntreprise.Location = new System.Drawing.Point(296, 123);
            this.cbxSuppEntreprise.Name = "cbxSuppEntreprise";
            this.cbxSuppEntreprise.Size = new System.Drawing.Size(170, 21);
            this.cbxSuppEntreprise.TabIndex = 1;
            this.cbxSuppEntreprise.SelectionChangeCommitted += new System.EventHandler(this.cbxSuppEntreprise_SelectionChangeCommitted);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(323, 52);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(143, 13);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Suppression d\'une entreprise";
            // 
            // pnlSuppEntreprise
            // 
            this.pnlSuppEntreprise.Controls.Add(this.btnSuppr);
            this.pnlSuppEntreprise.Controls.Add(this.btnAnnuler);
            this.pnlSuppEntreprise.Controls.Add(this.lblNomSelectione);
            this.pnlSuppEntreprise.Controls.Add(this.lblVilleSelectionnee);
            this.pnlSuppEntreprise.Controls.Add(this.lblRueSelectionee);
            this.pnlSuppEntreprise.Controls.Add(this.lblMailSelectionnee);
            this.pnlSuppEntreprise.Controls.Add(this.lblMail);
            this.pnlSuppEntreprise.Controls.Add(this.lblVille);
            this.pnlSuppEntreprise.Controls.Add(this.lblRue);
            this.pnlSuppEntreprise.Controls.Add(this.lblNom);
            this.pnlSuppEntreprise.Location = new System.Drawing.Point(227, 163);
            this.pnlSuppEntreprise.Name = "pnlSuppEntreprise";
            this.pnlSuppEntreprise.Size = new System.Drawing.Size(377, 216);
            this.pnlSuppEntreprise.TabIndex = 3;
            this.pnlSuppEntreprise.Visible = false;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(203, 153);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 23);
            this.btnSuppr.TabIndex = 4;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(55, 153);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblNomSelectione
            // 
            this.lblNomSelectione.AutoSize = true;
            this.lblNomSelectione.Location = new System.Drawing.Point(186, 18);
            this.lblNomSelectione.Name = "lblNomSelectione";
            this.lblNomSelectione.Size = new System.Drawing.Size(88, 13);
            this.lblNomSelectione.TabIndex = 11;
            this.lblNomSelectione.Text = "Nom Sélectionné";
            // 
            // lblVilleSelectionnee
            // 
            this.lblVilleSelectionnee.AutoSize = true;
            this.lblVilleSelectionnee.Location = new System.Drawing.Point(186, 114);
            this.lblVilleSelectionnee.Name = "lblVilleSelectionnee";
            this.lblVilleSelectionnee.Size = new System.Drawing.Size(91, 13);
            this.lblVilleSelectionnee.TabIndex = 10;
            this.lblVilleSelectionnee.Text = "Ville Selectionnée";
            // 
            // lblRueSelectionee
            // 
            this.lblRueSelectionee.AutoSize = true;
            this.lblRueSelectionee.Location = new System.Drawing.Point(186, 84);
            this.lblRueSelectionee.Name = "lblRueSelectionee";
            this.lblRueSelectionee.Size = new System.Drawing.Size(92, 13);
            this.lblRueSelectionee.TabIndex = 9;
            this.lblRueSelectionee.Text = "Rue Selectionnée";
            // 
            // lblMailSelectionnee
            // 
            this.lblMailSelectionnee.AutoSize = true;
            this.lblMailSelectionnee.Location = new System.Drawing.Point(186, 47);
            this.lblMailSelectionnee.Name = "lblMailSelectionnee";
            this.lblMailSelectionnee.Size = new System.Drawing.Size(85, 13);
            this.lblMailSelectionnee.TabIndex = 8;
            this.lblMailSelectionnee.Text = "Mail Selectionné";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(52, 47);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(93, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail électronique :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(53, 114);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(35, 13);
            this.lblVille.TabIndex = 2;
            this.lblVille.Text = "Ville : ";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(52, 84);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(36, 13);
            this.lblRue.TabIndex = 1;
            this.lblRue.Text = "Rue : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(52, 18);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(103, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom de l\'entreprise :";
            // 
            // FrmSuppEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSuppEntreprise);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.cbxSuppEntreprise);
            this.Controls.Add(this.lblListeEntreprise);
            this.Name = "FrmSuppEntreprise";
            this.Text = "Suppression d\'une entreprise";
            this.pnlSuppEntreprise.ResumeLayout(false);
            this.pnlSuppEntreprise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListeEntreprise;
        private System.Windows.Forms.ComboBox cbxSuppEntreprise;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnlSuppEntreprise;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMailSelectionnee;
        private System.Windows.Forms.Label lblVilleSelectionnee;
        private System.Windows.Forms.Label lblRueSelectionee;
        private System.Windows.Forms.Label lblNomSelectione;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnAnnuler;
    }
}