namespace GesEntrepotGUI
{
    partial class FrmModifEntreprise
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
            this.cbxEntreprises = new System.Windows.Forms.ComboBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblEntreprise = new System.Windows.Forms.Label();
            this.lblNomEntreprise = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblMel = new System.Windows.Forms.Label();
            this.pnlModifEntreprise = new System.Windows.Forms.Panel();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtMel = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cbxVilles = new System.Windows.Forms.ComboBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.pnlModifEntreprise.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxEntreprises
            // 
            this.cbxEntreprises.FormattingEnabled = true;
            this.cbxEntreprises.Location = new System.Drawing.Point(389, 112);
            this.cbxEntreprises.Name = "cbxEntreprises";
            this.cbxEntreprises.Size = new System.Drawing.Size(121, 21);
            this.cbxEntreprises.TabIndex = 0;
            this.cbxEntreprises.SelectionChangeCommitted += new System.EventHandler(this.cbxEntreprises_SelectionChangeCommitted);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(271, 55);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(239, 13);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Modification des caractéristiques d\'une entreprise";
            // 
            // lblEntreprise
            // 
            this.lblEntreprise.AutoSize = true;
            this.lblEntreprise.Location = new System.Drawing.Point(180, 115);
            this.lblEntreprise.Name = "lblEntreprise";
            this.lblEntreprise.Size = new System.Drawing.Size(200, 13);
            this.lblEntreprise.TabIndex = 2;
            this.lblEntreprise.Text = "Veuillez choisir une entreprise à modifier :";
            // 
            // lblNomEntreprise
            // 
            this.lblNomEntreprise.AutoSize = true;
            this.lblNomEntreprise.Location = new System.Drawing.Point(28, 9);
            this.lblNomEntreprise.Name = "lblNomEntreprise";
            this.lblNomEntreprise.Size = new System.Drawing.Size(103, 13);
            this.lblNomEntreprise.TabIndex = 3;
            this.lblNomEntreprise.Text = "Nom de l\'entreprise :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(28, 86);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(122, 13);
            this.lblRue.TabIndex = 4;
            this.lblRue.Text = "Adresse de l\'entreprise : ";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(320, 86);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(35, 13);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville : ";
            // 
            // lblMel
            // 
            this.lblMel.AutoSize = true;
            this.lblMel.Location = new System.Drawing.Point(28, 48);
            this.lblMel.Name = "lblMel";
            this.lblMel.Size = new System.Drawing.Size(96, 13);
            this.lblMel.TabIndex = 6;
            this.lblMel.Text = "Mail électronique : ";
            // 
            // pnlModifEntreprise
            // 
            this.pnlModifEntreprise.Controls.Add(this.txtRue);
            this.pnlModifEntreprise.Controls.Add(this.txtMel);
            this.pnlModifEntreprise.Controls.Add(this.txtNom);
            this.pnlModifEntreprise.Controls.Add(this.cbxVilles);
            this.pnlModifEntreprise.Controls.Add(this.btnModif);
            this.pnlModifEntreprise.Controls.Add(this.btnAnnuler);
            this.pnlModifEntreprise.Controls.Add(this.lblMel);
            this.pnlModifEntreprise.Controls.Add(this.lblVille);
            this.pnlModifEntreprise.Controls.Add(this.lblRue);
            this.pnlModifEntreprise.Controls.Add(this.lblNomEntreprise);
            this.pnlModifEntreprise.Location = new System.Drawing.Point(155, 173);
            this.pnlModifEntreprise.Name = "pnlModifEntreprise";
            this.pnlModifEntreprise.Size = new System.Drawing.Size(505, 199);
            this.pnlModifEntreprise.TabIndex = 7;
            this.pnlModifEntreprise.Visible = false;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(155, 83);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(120, 20);
            this.txtRue.TabIndex = 12;
            // 
            // txtMel
            // 
            this.txtMel.Location = new System.Drawing.Point(137, 48);
            this.txtMel.Name = "txtMel";
            this.txtMel.Size = new System.Drawing.Size(138, 20);
            this.txtMel.TabIndex = 11;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(137, 9);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(138, 20);
            this.txtNom.TabIndex = 10;
            // 
            // cbxVilles
            // 
            this.cbxVilles.FormattingEnabled = true;
            this.cbxVilles.Location = new System.Drawing.Point(361, 83);
            this.cbxVilles.Name = "cbxVilles";
            this.cbxVilles.Size = new System.Drawing.Size(86, 21);
            this.cbxVilles.TabIndex = 9;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(370, 149);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(77, 23);
            this.btnModif.TabIndex = 8;
            this.btnModif.Text = "Enregistrer";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(31, 149);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // FrmModifEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlModifEntreprise);
            this.Controls.Add(this.lblEntreprise);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.cbxEntreprises);
            this.Name = "FrmModifEntreprise";
            this.Text = "Modification des caractéristiques d\'une entreprise";
            this.pnlModifEntreprise.ResumeLayout(false);
            this.pnlModifEntreprise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEntreprises;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblEntreprise;
        private System.Windows.Forms.Label lblNomEntreprise;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblMel;
        private System.Windows.Forms.Panel pnlModifEntreprise;
        private System.Windows.Forms.ComboBox cbxVilles;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtMel;
        private System.Windows.Forms.TextBox txtNom;
    }
}