namespace Interface
{
    partial class FrmVisiteConsultation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteConsultation));
            panelCentral = new Panel();
            label1 = new Label();
            lstMedicament = new ListBox();
            dgvEchantillon = new DataGridView();
            lblBilan = new Label();
            lblMotif = new Label();
            Praticien = new Label();
            dgvVisites = new DataGridView();
            panelPraticien = new Panel();
            lblSpecialite = new Label();
            lblType = new Label();
            lblEmail = new Label();
            lblTelephone = new Label();
            lblRue = new Label();
            lblPraticien = new Label();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            panelPraticien.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1025, 74);
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.None;
            panelCentral.Controls.Add(label1);
            panelCentral.Controls.Add(lstMedicament);
            panelCentral.Controls.Add(dgvEchantillon);
            panelCentral.Controls.Add(lblBilan);
            panelCentral.Controls.Add(lblMotif);
            panelCentral.Controls.Add(Praticien);
            panelCentral.Controls.Add(dgvVisites);
            panelCentral.Controls.Add(panelPraticien);
            panelCentral.Location = new Point(0, 82);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1025, 382);
            panelCentral.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 280);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 11;
            label1.Text = "Médicaments présentés";
            // 
            // lstMedicament
            // 
            lstMedicament.FormattingEnabled = true;
            lstMedicament.Location = new Point(337, 298);
            lstMedicament.Name = "lstMedicament";
            lstMedicament.Size = new Size(324, 64);
            lstMedicament.TabIndex = 10;
            // 
            // dgvEchantillon
            // 
            dgvEchantillon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEchantillon.Location = new Point(803, 212);
            dgvEchantillon.Name = "dgvEchantillon";
            dgvEchantillon.Size = new Size(200, 157);
            dgvEchantillon.TabIndex = 9;
            // 
            // lblBilan
            // 
            lblBilan.AutoSize = true;
            lblBilan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBilan.Location = new Point(330, 193);
            lblBilan.Name = "lblBilan";
            lblBilan.Size = new Size(96, 15);
            lblBilan.TabIndex = 8;
            lblBilan.Text = "Bilan de la visite";
            // 
            // lblMotif
            // 
            lblMotif.AutoSize = true;
            lblMotif.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMotif.Location = new Point(334, 169);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(38, 15);
            lblMotif.TabIndex = 7;
            lblMotif.Text = "Motif";
            // 
            // Praticien
            // 
            Praticien.AutoSize = true;
            Praticien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Praticien.Location = new Point(330, 19);
            Praticien.Name = "Praticien";
            Praticien.Size = new Size(56, 15);
            Praticien.TabIndex = 6;
            Praticien.Text = "Praticien";
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Location = new Point(12, 19);
            dgvVisites.MinimumSize = new Size(0, 50);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(316, 350);
            dgvVisites.TabIndex = 2;
            // 
            // panelPraticien
            // 
            panelPraticien.BorderStyle = BorderStyle.FixedSingle;
            panelPraticien.Controls.Add(lblSpecialite);
            panelPraticien.Controls.Add(lblType);
            panelPraticien.Controls.Add(lblEmail);
            panelPraticien.Controls.Add(lblTelephone);
            panelPraticien.Controls.Add(lblRue);
            panelPraticien.Controls.Add(lblPraticien);
            panelPraticien.Location = new Point(334, 48);
            panelPraticien.Name = "panelPraticien";
            panelPraticien.Size = new Size(683, 118);
            panelPraticien.TabIndex = 1;
            // 
            // lblSpecialite
            // 
            lblSpecialite.Location = new Point(303, 41);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(38, 15);
            lblSpecialite.TabIndex = 5;
            lblSpecialite.Text = "label1";
            // 
            // lblType
            // 
            lblType.Location = new Point(303, 9);
            lblType.Name = "lblType";
            lblType.Size = new Size(38, 15);
            lblType.TabIndex = 4;
            lblType.Text = "label1";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(22, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(38, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "label1";
            // 
            // lblTelephone
            // 
            lblTelephone.Location = new Point(22, 68);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(38, 15);
            lblTelephone.TabIndex = 2;
            lblTelephone.Text = "label1";
            // 
            // lblRue
            // 
            lblRue.Location = new Point(22, 41);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(38, 15);
            lblRue.TabIndex = 1;
            lblRue.Text = "label1";
            // 
            // lblPraticien
            // 
            lblPraticien.Location = new Point(22, 9);
            lblPraticien.Name = "lblPraticien";
            lblPraticien.Size = new Size(38, 15);
            lblPraticien.TabIndex = 0;
            lblPraticien.Text = "label1";
            // 
            // FrmVisiteConsultation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 512);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteConsultation";
            Text = "FrmVisiteConsultation";
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            panelPraticien.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private Panel panelPraticien;
        private Label lblPraticien;
        private DataGridView dgvVisites;
        private Label lblSpecialite;
        private Label lblType;
        private Label lblEmail;
        private Label lblTelephone;
        private Label lblRue;
        private Label Praticien;
        private Label lblMotif;
        private ListBox lstMedicament;
        private DataGridView dgvEchantillon;
        private Label lblBilan;
        private Label label1;
    }
}