namespace GesEntrepotGUI
{
    partial class FrmConsultEntreprises
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.dtgConsultEntreprises = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultEntreprises)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(311, 54);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(156, 13);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Caractéristiques des entreprises";
            // 
            // dtgConsultEntreprises
            // 
            this.dtgConsultEntreprises.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgConsultEntreprises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultEntreprises.Location = new System.Drawing.Point(101, 99);
            this.dtgConsultEntreprises.Name = "dtgConsultEntreprises";
            this.dtgConsultEntreprises.Size = new System.Drawing.Size(597, 249);
            this.dtgConsultEntreprises.TabIndex = 2;
            // 
            // FrmConsultEntreprises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgConsultEntreprises);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmConsultEntreprises";
            this.Text = "Consultation des entreprises";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultEntreprises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.DataGridView dtgConsultEntreprises;
    }
}