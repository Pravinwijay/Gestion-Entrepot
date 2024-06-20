namespace GesEntrepotGUI
{
    partial class FrmMenu
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
            this.MnuMenu = new System.Windows.Forms.MenuStrip();
            this.tsmAjtEntreprise = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultEntreprises = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionDesEntreprisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuMenu
            // 
            this.MnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAjtEntreprise,
            this.tsmConsultEntreprises,
            this.suppressionDesEntreprisesToolStripMenuItem,
            this.modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem});
            this.MnuMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMenu.Name = "MnuMenu";
            this.MnuMenu.Size = new System.Drawing.Size(800, 24);
            this.MnuMenu.TabIndex = 0;
            this.MnuMenu.Text = "menuStrip1";
            // 
            // tsmAjtEntreprise
            // 
            this.tsmAjtEntreprise.Name = "tsmAjtEntreprise";
            this.tsmAjtEntreprise.Size = new System.Drawing.Size(136, 20);
            this.tsmAjtEntreprise.Text = "Ajouter une entreprise";
            this.tsmAjtEntreprise.Click += new System.EventHandler(this.tsmAjtEntreprise_Click);
            // 
            // tsmConsultEntreprises
            // 
            this.tsmConsultEntreprises.Name = "tsmConsultEntreprises";
            this.tsmConsultEntreprises.Size = new System.Drawing.Size(168, 20);
            this.tsmConsultEntreprises.Text = "Consultation des entreprises";
            this.tsmConsultEntreprises.Click += new System.EventHandler(this.tsmConsultEntreprises_Click);
            // 
            // suppressionDesEntreprisesToolStripMenuItem
            // 
            this.suppressionDesEntreprisesToolStripMenuItem.Name = "suppressionDesEntreprisesToolStripMenuItem";
            this.suppressionDesEntreprisesToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.suppressionDesEntreprisesToolStripMenuItem.Text = "Suppression des entreprises";
            this.suppressionDesEntreprisesToolStripMenuItem.Click += new System.EventHandler(this.suppressionDesEntreprisesToolStripMenuItem_Click);
            // 
            // modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem
            // 
            this.modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem.Name = "modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem";
            this.modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem.Size = new System.Drawing.Size(281, 20);
            this.modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem.Text = "Modification des caractéristiques d\'une entreprise";
            this.modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem.Click += new System.EventHandler(this.modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MnuMenu);
            this.MainMenuStrip = this.MnuMenu;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmAjtEntreprise;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultEntreprises;
        private System.Windows.Forms.ToolStripMenuItem suppressionDesEntreprisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierLesCaractéristiquesDuneEntrepriseToolStripMenuItem;
    }
}