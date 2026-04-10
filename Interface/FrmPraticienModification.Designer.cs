namespace Interface
{
    partial class FrmPraticienModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPraticienModification));
            panelCentral = new Panel();
            lblPraticienRecherche = new Label();
            lblSpecialite = new Label();
            lblType = new Label();
            lblPrenom = new Label();
            panel2 = new Panel();
            cbxPraticien = new ComboBox();
            lblEmail = new Label();
            lblTelephone = new Label();
            lblVille = new Label();
            lblRue = new Label();
            cbxSpecialite = new ComboBox();
            lblNom = new Label();
            button1 = new Button();
            btnModifier = new Button();
            cbxVille = new ComboBox();
            cbxType = new ComboBox();
            mtbTelephone = new MaskedTextBox();
            txtEmail = new TextBox();
            txtRue = new TextBox();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            messageEmail = new Label();
            messageTelephone = new Label();
            messageVille = new Label();
            messageRue = new Label();
            messagePrenom = new Label();
            messageNom = new Label();
            panelCentral.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1002, 74);
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.None;
            panelCentral.Controls.Add(lblPraticienRecherche);
            panelCentral.Controls.Add(lblSpecialite);
            panelCentral.Controls.Add(lblType);
            panelCentral.Controls.Add(lblPrenom);
            panelCentral.Controls.Add(panel2);
            panelCentral.Controls.Add(lblEmail);
            panelCentral.Controls.Add(lblTelephone);
            panelCentral.Controls.Add(lblVille);
            panelCentral.Controls.Add(lblRue);
            panelCentral.Controls.Add(cbxSpecialite);
            panelCentral.Controls.Add(lblNom);
            panelCentral.Controls.Add(button1);
            panelCentral.Controls.Add(btnModifier);
            panelCentral.Controls.Add(cbxVille);
            panelCentral.Controls.Add(cbxType);
            panelCentral.Controls.Add(mtbTelephone);
            panelCentral.Controls.Add(txtEmail);
            panelCentral.Controls.Add(txtRue);
            panelCentral.Controls.Add(txtPrenom);
            panelCentral.Controls.Add(txtNom);
            panelCentral.Controls.Add(messageEmail);
            panelCentral.Controls.Add(messageTelephone);
            panelCentral.Controls.Add(messageVille);
            panelCentral.Controls.Add(messageRue);
            panelCentral.Controls.Add(messagePrenom);
            panelCentral.Controls.Add(messageNom);
            panelCentral.Location = new Point(12, 81);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(978, 460);
            panelCentral.TabIndex = 13;
            // 
            // lblPraticienRecherche
            // 
            lblPraticienRecherche.AutoSize = true;
            lblPraticienRecherche.Location = new Point(347, 27);
            lblPraticienRecherche.Name = "lblPraticienRecherche";
            lblPraticienRecherche.Size = new Size(108, 15);
            lblPraticienRecherche.TabIndex = 29;
            lblPraticienRecherche.Text = "Praticien recherché";
            // 
            // lblSpecialite
            // 
            lblSpecialite.AutoSize = true;
            lblSpecialite.Location = new Point(480, 356);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(57, 15);
            lblSpecialite.TabIndex = 27;
            lblSpecialite.Text = "Specialite";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(53, 356);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 26;
            lblType.Text = "Type";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(677, 17);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(49, 15);
            lblPrenom.TabIndex = 25;
            lblPrenom.Text = "Prénom";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cbxPraticien);
            panel2.Location = new Point(347, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 48);
            panel2.TabIndex = 28;
            // 
            // cbxPraticien
            // 
            cbxPraticien.FormattingEnabled = true;
            cbxPraticien.Location = new Point(17, 6);
            cbxPraticien.Name = "cbxPraticien";
            cbxPraticien.Size = new Size(256, 23);
            cbxPraticien.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(480, 288);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Email";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(54, 288);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(61, 15);
            lblTelephone.TabIndex = 23;
            lblTelephone.Text = "Telephone";
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Location = new Point(54, 196);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(29, 15);
            lblVille.TabIndex = 22;
            lblVille.Text = "Ville";
            // 
            // lblRue
            // 
            lblRue.AutoSize = true;
            lblRue.Location = new Point(53, 109);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(27, 15);
            lblRue.TabIndex = 21;
            lblRue.Text = "Rue";
            // 
            // cbxSpecialite
            // 
            cbxSpecialite.FormattingEnabled = true;
            cbxSpecialite.Location = new Point(480, 382);
            cbxSpecialite.Name = "cbxSpecialite";
            cbxSpecialite.Size = new Size(393, 23);
            cbxSpecialite.TabIndex = 20;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(53, 17);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 19;
            lblNom.Text = "Nom";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(480, 423);
            button1.Name = "button1";
            button1.Size = new Size(393, 23);
            button1.TabIndex = 18;
            button1.Text = "Supprimer la fiche du praticien";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.ForeColor = Color.Blue;
            btnModifier.Location = new Point(53, 423);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(393, 23);
            btnModifier.TabIndex = 17;
            btnModifier.Text = "Modifier la fiche du praticien";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // cbxVille
            // 
            cbxVille.FormattingEnabled = true;
            cbxVille.Location = new Point(53, 223);
            cbxVille.Name = "cbxVille";
            cbxVille.Size = new Size(654, 23);
            cbxVille.TabIndex = 16;
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(53, 382);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(393, 23);
            cbxType.TabIndex = 13;
            // 
            // mtbTelephone
            // 
            mtbTelephone.Location = new Point(54, 306);
            mtbTelephone.Mask = "00 00 00 00 00";
            mtbTelephone.Name = "mtbTelephone";
            mtbTelephone.Size = new Size(162, 23);
            mtbTelephone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(480, 315);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtRue
            // 
            txtRue.Location = new Point(53, 136);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(652, 23);
            txtRue.TabIndex = 8;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(677, 45);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(225, 23);
            txtPrenom.TabIndex = 7;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(53, 45);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(225, 23);
            txtNom.TabIndex = 6;
            // 
            // messageEmail
            // 
            messageEmail.AutoSize = true;
            messageEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageEmail.ForeColor = Color.Red;
            messageEmail.Location = new Point(480, 341);
            messageEmail.Name = "messageEmail";
            messageEmail.Size = new Size(30, 15);
            messageEmail.TabIndex = 5;
            messageEmail.Text = "msg";
            // 
            // messageTelephone
            // 
            messageTelephone.AutoSize = true;
            messageTelephone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageTelephone.ForeColor = Color.Red;
            messageTelephone.Location = new Point(53, 341);
            messageTelephone.Name = "messageTelephone";
            messageTelephone.Size = new Size(30, 15);
            messageTelephone.TabIndex = 4;
            messageTelephone.Text = "msg";
            // 
            // messageVille
            // 
            messageVille.AutoSize = true;
            messageVille.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageVille.ForeColor = Color.Red;
            messageVille.Location = new Point(53, 249);
            messageVille.Name = "messageVille";
            messageVille.Size = new Size(30, 15);
            messageVille.TabIndex = 3;
            messageVille.Text = "msg";
            // 
            // messageRue
            // 
            messageRue.AutoSize = true;
            messageRue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageRue.ForeColor = Color.Red;
            messageRue.Location = new Point(53, 162);
            messageRue.Name = "messageRue";
            messageRue.Size = new Size(30, 15);
            messageRue.TabIndex = 2;
            messageRue.Text = "msg";
            // 
            // messagePrenom
            // 
            messagePrenom.AutoSize = true;
            messagePrenom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messagePrenom.ForeColor = Color.Red;
            messagePrenom.Location = new Point(677, 71);
            messagePrenom.Name = "messagePrenom";
            messagePrenom.Size = new Size(30, 15);
            messagePrenom.TabIndex = 1;
            messagePrenom.Text = "msg";
            // 
            // messageNom
            // 
            messageNom.AutoSize = true;
            messageNom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageNom.ForeColor = Color.Red;
            messageNom.Location = new Point(53, 71);
            messageNom.Name = "messageNom";
            messageNom.Size = new Size(30, 15);
            messageNom.TabIndex = 0;
            messageNom.Text = "msg";
            // 
            // FrmPraticienModification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 593);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmPraticienModification";
            Text = "FrmPraticienModification";
            Controls.SetChildIndex(panelCentral, 0);
            Controls.SetChildIndex(lblTitre, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private Label messageNom;
        private TextBox textVille;
        private TextBox txtRue;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private Label messageEmail;
        private Label messageTelephone;
        private Label messageVille;
        private Label messageRue;
        private Label messagePrenom;
        private TextBox txtEmail;
        private ComboBox comboBox2;
        private ComboBox cbxType;
        private MaskedTextBox mtbTelephone;
        private ComboBox cbxVille;
        private ComboBox cbxPraticien;
        private Label lblNom;
        private Button button1;
        private Button btnModifier;
        private ComboBox cbxSpecialite;
        private Label lblSpecialite;
        private Label lblType;
        private Label lblPrenom;
        private Label lblEmail;
        private Label lblTelephone;
        private Label lblVille;
        private Label lblRue;
        private Panel panel2;
        private Label lblPraticienRecherche;
    }
}