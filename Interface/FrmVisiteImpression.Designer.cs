namespace Interface
{
    partial class FrmVisiteImpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteImpression));
            printRendezVous = new System.Drawing.Printing.PrintDocument();
            choixImprimante = new PrintDialog();
            aperçuRendezVous = new PrintPreviewDialog();
            panelCentral = new Panel();
            imgGsb = new PictureBox();
            panelSaisie = new Panel();
            dtpFin = new DateTimePicker();
            dtpDebut = new DateTimePicker();
            messageInterval = new Label();
            message = new Label();
            imgImprimer = new PictureBox();
            imgApercu = new PictureBox();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgGsb).BeginInit();
            panelSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgImprimer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgApercu).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1166, 74);
            // 
            // choixImprimante
            // 
            choixImprimante.UseEXDialog = true;
            // 
            // aperçuRendezVous
            // 
            aperçuRendezVous.AutoScrollMargin = new Size(0, 0);
            aperçuRendezVous.AutoScrollMinSize = new Size(0, 0);
            aperçuRendezVous.ClientSize = new Size(400, 300);
            aperçuRendezVous.Enabled = true;
            aperçuRendezVous.Icon = (Icon)resources.GetObject("aperçuRendezVous.Icon");
            aperçuRendezVous.Name = "aperçuRendezVous";
            aperçuRendezVous.Visible = false;
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.None;
            panelCentral.Controls.Add(imgGsb);
            panelCentral.Controls.Add(panelSaisie);
            panelCentral.Location = new Point(0, 98);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1166, 504);
            panelCentral.TabIndex = 13;
            // 
            // imgGsb
            // 
            imgGsb.Image = Properties.Resources.logoGSB;
            imgGsb.Location = new Point(232, 9);
            imgGsb.Name = "imgGsb";
            imgGsb.Size = new Size(345, 223);
            imgGsb.SizeMode = PictureBoxSizeMode.StretchImage;
            imgGsb.TabIndex = 1;
            imgGsb.TabStop = false;
            // 
            // panelSaisie
            // 
            panelSaisie.Controls.Add(dtpFin);
            panelSaisie.Controls.Add(dtpDebut);
            panelSaisie.Controls.Add(messageInterval);
            panelSaisie.Controls.Add(message);
            panelSaisie.Controls.Add(imgImprimer);
            panelSaisie.Controls.Add(imgApercu);
            panelSaisie.Location = new Point(583, 0);
            panelSaisie.Name = "panelSaisie";
            panelSaisie.Size = new Size(507, 471);
            panelSaisie.TabIndex = 0;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(47, 66);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(250, 23);
            dtpFin.TabIndex = 5;
            // 
            // dtpDebut
            // 
            dtpDebut.Location = new Point(47, 9);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(250, 23);
            dtpDebut.TabIndex = 4;
            // 
            // messageInterval
            // 
            messageInterval.AutoSize = true;
            messageInterval.Location = new Point(19, 66);
            messageInterval.Name = "messageInterval";
            messageInterval.Size = new Size(22, 15);
            messageInterval.TabIndex = 3;
            messageInterval.Text = "Au";
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(19, 9);
            message.Name = "message";
            message.Size = new Size(22, 15);
            message.TabIndex = 2;
            message.Text = "Du";
            // 
            // imgImprimer
            // 
            imgImprimer.BackgroundImage = Properties.Resources.imprimer;
            imgImprimer.Enabled = false;
            imgImprimer.Image = Properties.Resources.imprimer;
            imgImprimer.Location = new Point(207, 169);
            imgImprimer.Name = "imgImprimer";
            imgImprimer.Size = new Size(144, 140);
            imgImprimer.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImprimer.TabIndex = 1;
            imgImprimer.TabStop = false;
            // 
            // imgApercu
            // 
            imgApercu.BackgroundImage = Properties.Resources.apercu;
            imgApercu.Enabled = false;
            imgApercu.Image = Properties.Resources.apercu;
            imgApercu.Location = new Point(19, 169);
            imgApercu.Name = "imgApercu";
            imgApercu.Size = new Size(159, 140);
            imgApercu.SizeMode = PictureBoxSizeMode.StretchImage;
            imgApercu.TabIndex = 0;
            imgApercu.TabStop = false;
            // 
            // FrmVisiteImpression
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 647);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteImpression";
            Text = "FrmVisiteImpression";
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgGsb).EndInit();
            panelSaisie.ResumeLayout(false);
            panelSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgImprimer).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgApercu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printRendezVous;
        private PrintDialog choixImprimante;
        private PrintPreviewDialog aperçuRendezVous;
        private Panel panelCentral;
        private Panel panelSaisie;
        private PictureBox imgImprimer;
        private PictureBox imgApercu;
        private Label message;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpDebut;
        private Label messageInterval;
        private PictureBox imgGsb;
    }
}