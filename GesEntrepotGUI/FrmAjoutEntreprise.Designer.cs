namespace GesEntrepotGUI
{
    partial class FrmAjoutEntreprise
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
            this.lblNomEntreprise = new System.Windows.Forms.Label();
            this.txtNomEntreprise = new System.Windows.Forms.TextBox();
            this.lblRueEntreprise = new System.Windows.Forms.Label();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.cbxVille = new System.Windows.Forms.ComboBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnEnregistrerEntreprise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomEntreprise
            // 
            this.lblNomEntreprise.AutoSize = true;
            this.lblNomEntreprise.Location = new System.Drawing.Point(235, 117);
            this.lblNomEntreprise.Name = "lblNomEntreprise";
            this.lblNomEntreprise.Size = new System.Drawing.Size(97, 13);
            this.lblNomEntreprise.TabIndex = 0;
            this.lblNomEntreprise.Text = "Nom de l\'entreprise";
            // 
            // txtNomEntreprise
            // 
            this.txtNomEntreprise.Location = new System.Drawing.Point(370, 117);
            this.txtNomEntreprise.Name = "txtNomEntreprise";
            this.txtNomEntreprise.Size = new System.Drawing.Size(190, 20);
            this.txtNomEntreprise.TabIndex = 1;
            // 
            // lblRueEntreprise
            // 
            this.lblRueEntreprise.AutoSize = true;
            this.lblRueEntreprise.Location = new System.Drawing.Point(238, 202);
            this.lblRueEntreprise.Name = "lblRueEntreprise";
            this.lblRueEntreprise.Size = new System.Drawing.Size(27, 13);
            this.lblRueEntreprise.TabIndex = 2;
            this.lblRueEntreprise.Text = "Rue";
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(370, 199);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(190, 20);
            this.txtRue.TabIndex = 3;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(238, 243);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville";
            // 
            // cbxVille
            // 
            this.cbxVille.FormattingEnabled = true;
            this.cbxVille.Location = new System.Drawing.Point(370, 240);
            this.cbxVille.Name = "cbxVille";
            this.cbxVille.Size = new System.Drawing.Size(190, 21);
            this.cbxVille.TabIndex = 5;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(238, 160);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(87, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail électronique";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(370, 160);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(190, 20);
            this.txtMail.TabIndex = 7;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(239, 57);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(221, 13);
            this.lblTitre.TabIndex = 8;
            this.lblTitre.Text = "Création des caractéristiques d\'une entreprise";
            // 
            // btnEnregistrerEntreprise
            // 
            this.btnEnregistrerEntreprise.Location = new System.Drawing.Point(238, 317);
            this.btnEnregistrerEntreprise.Name = "btnEnregistrerEntreprise";
            this.btnEnregistrerEntreprise.Size = new System.Drawing.Size(322, 27);
            this.btnEnregistrerEntreprise.TabIndex = 9;
            this.btnEnregistrerEntreprise.Text = "Enregistrer";
            this.btnEnregistrerEntreprise.UseVisualStyleBackColor = true;
            this.btnEnregistrerEntreprise.Click += new System.EventHandler(this.btnEnregistrerEntreprise_Click);
            // 
            // FrmAjoutEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrerEntreprise);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.cbxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.lblRueEntreprise);
            this.Controls.Add(this.txtNomEntreprise);
            this.Controls.Add(this.lblNomEntreprise);
            this.Name = "FrmAjoutEntreprise";
            this.Text = "Ajout d\'une entreprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomEntreprise;
        private System.Windows.Forms.TextBox txtNomEntreprise;
        private System.Windows.Forms.Label lblRueEntreprise;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.ComboBox cbxVille;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnEnregistrerEntreprise;
    }
}