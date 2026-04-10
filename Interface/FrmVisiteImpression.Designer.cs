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
            label2 = new Label();
            label = new Label();
            imgImprimer = new PictureBox();
            imgApercu = new PictureBox();
            messageIntervale = new Label();
            message = new Label();
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
            panelSaisie.Controls.Add(messageIntervale);
            panelSaisie.Controls.Add(dtpFin);
            panelSaisie.Controls.Add(dtpDebut);
            panelSaisie.Controls.Add(label2);
            panelSaisie.Controls.Add(label);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 66);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 3;
            label2.Text = "Au";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(19, 9);
            label.Name = "label";
            label.Size = new Size(22, 15);
            label.TabIndex = 2;
            label.Text = "Du";
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
            // messageIntervale
            // 
            messageIntervale.AutoSize = true;
            messageIntervale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageIntervale.ForeColor = Color.Red;
            messageIntervale.Location = new Point(34, 101);
            messageIntervale.Name = "messageIntervale";
            messageIntervale.Size = new Size(30, 15);
            messageIntervale.TabIndex = 6;
            messageIntervale.Text = "msg";
            // 
            // message
            // 
            message.AutoSize = true;
            message.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            message.ForeColor = Color.Red;
            message.Location = new Point(12, 80);
            message.Name = "message";
            message.Size = new Size(30, 15);
            message.TabIndex = 7;
            message.Text = "msg";
            // 
            // FrmVisiteImpression
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 647);
            Controls.Add(message);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteImpression";
            Text = "FrmVisiteImpression";
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            Controls.SetChildIndex(message, 0);
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
        private Label label;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpDebut;
        private Label label2;
        private PictureBox imgGsb;
        private Label messageIntervale;
        private Label message;
    }
}