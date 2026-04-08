namespace Interface
{
    partial class FrmPraticienAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPraticienAjout));
            panelCentral = new Panel();
            btnAjouter = new Button();
            cbxSpecialite = new ComboBox();
            cbxType = new ComboBox();
            mtbTelephone = new MaskedTextBox();
            txtEmail = new TextBox();
            txtVille = new TextBox();
            txtRue = new TextBox();
            txtPrenom = new TextBox();
            txtNom = new TextBox();
            messageEmail = new Label();
            messagePrenom = new Label();
            messageVille = new Label();
            messageType = new Label();
            messageTelephone = new Label();
            messageRue = new Label();
            messageNom = new Label();
            lblNom = new Label();
            lblPrenom = new Label();
            lblRue = new Label();
            lblVille = new Label();
            lblTelephone = new Label();
            lblEmail = new Label();
            lblType = new Label();
            lblSpecialite = new Label();
            panelCentral.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1041, 74);
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.None;
            panelCentral.BorderStyle = BorderStyle.FixedSingle;
            panelCentral.Controls.Add(lblSpecialite);
            panelCentral.Controls.Add(lblType);
            panelCentral.Controls.Add(lblEmail);
            panelCentral.Controls.Add(lblTelephone);
            panelCentral.Controls.Add(lblVille);
            panelCentral.Controls.Add(lblRue);
            panelCentral.Controls.Add(lblPrenom);
            panelCentral.Controls.Add(lblNom);
            panelCentral.Controls.Add(btnAjouter);
            panelCentral.Controls.Add(cbxSpecialite);
            panelCentral.Controls.Add(cbxType);
            panelCentral.Controls.Add(mtbTelephone);
            panelCentral.Controls.Add(txtEmail);
            panelCentral.Controls.Add(txtVille);
            panelCentral.Controls.Add(txtRue);
            panelCentral.Controls.Add(txtPrenom);
            panelCentral.Controls.Add(txtNom);
            panelCentral.Controls.Add(messageEmail);
            panelCentral.Controls.Add(messagePrenom);
            panelCentral.Controls.Add(messageVille);
            panelCentral.Controls.Add(messageType);
            panelCentral.Controls.Add(messageTelephone);
            panelCentral.Controls.Add(messageRue);
            panelCentral.Controls.Add(messageNom);
            panelCentral.Location = new Point(12, 106);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1017, 453);
            panelCentral.TabIndex = 13;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Red;
            btnAjouter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(433, 384);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(178, 40);
            btnAjouter.TabIndex = 15;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // cbxSpecialite
            // 
            cbxSpecialite.FormattingEnabled = true;
            cbxSpecialite.Location = new Point(705, 361);
            cbxSpecialite.Name = "cbxSpecialite";
            cbxSpecialite.Size = new Size(196, 23);
            cbxSpecialite.TabIndex = 14;
            // 
            // cbxType
            // 
            cbxType.FormattingEnabled = true;
            cbxType.Location = new Point(73, 361);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(196, 23);
            cbxType.TabIndex = 13;
            // 
            // mtbTelephone
            // 
            mtbTelephone.Location = new Point(73, 251);
            mtbTelephone.Mask = "00 00 00 00 00 00";
            mtbTelephone.Name = "mtbTelephone";
            mtbTelephone.Size = new Size(196, 23);
            mtbTelephone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(617, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtVille
            // 
            txtVille.Location = new Point(73, 181);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(828, 23);
            txtVille.TabIndex = 10;
            // 
            // txtRue
            // 
            txtRue.Location = new Point(73, 110);
            txtRue.Name = "txtRue";
            txtRue.Size = new Size(873, 23);
            txtRue.TabIndex = 9;
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(617, 33);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(302, 23);
            txtPrenom.TabIndex = 8;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(73, 33);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(302, 23);
            txtNom.TabIndex = 7;
            // 
            // messageEmail
            // 
            messageEmail.AutoSize = true;
            messageEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageEmail.ForeColor = Color.Red;
            messageEmail.Location = new Point(617, 277);
            messageEmail.Name = "messageEmail";
            messageEmail.Size = new Size(30, 15);
            messageEmail.TabIndex = 6;
            messageEmail.Text = "msg";
            // 
            // messagePrenom
            // 
            messagePrenom.AutoSize = true;
            messagePrenom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messagePrenom.ForeColor = Color.Red;
            messagePrenom.Location = new Point(617, 59);
            messagePrenom.Name = "messagePrenom";
            messagePrenom.Size = new Size(30, 15);
            messagePrenom.TabIndex = 5;
            messagePrenom.Text = "msg";
            // 
            // messageVille
            // 
            messageVille.AutoSize = true;
            messageVille.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageVille.ForeColor = Color.Red;
            messageVille.Location = new Point(73, 207);
            messageVille.Name = "messageVille";
            messageVille.Size = new Size(30, 15);
            messageVille.TabIndex = 4;
            messageVille.Text = "msg";
            // 
            // messageType
            // 
            messageType.AutoSize = true;
            messageType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageType.ForeColor = Color.Red;
            messageType.Location = new Point(73, 397);
            messageType.Name = "messageType";
            messageType.Size = new Size(30, 15);
            messageType.TabIndex = 3;
            messageType.Text = "msg";
            // 
            // messageTelephone
            // 
            messageTelephone.AutoSize = true;
            messageTelephone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageTelephone.ForeColor = Color.Red;
            messageTelephone.Location = new Point(73, 277);
            messageTelephone.Name = "messageTelephone";
            messageTelephone.Size = new Size(30, 15);
            messageTelephone.TabIndex = 2;
            messageTelephone.Text = "msg";
            // 
            // messageRue
            // 
            messageRue.AutoSize = true;
            messageRue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageRue.ForeColor = Color.Red;
            messageRue.Location = new Point(73, 136);
            messageRue.Name = "messageRue";
            messageRue.Size = new Size(30, 15);
            messageRue.TabIndex = 1;
            messageRue.Text = "msg";
            // 
            // messageNom
            // 
            messageNom.AutoSize = true;
            messageNom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageNom.ForeColor = Color.Red;
            messageNom.Location = new Point(73, 59);
            messageNom.Name = "messageNom";
            messageNom.Size = new Size(30, 15);
            messageNom.TabIndex = 0;
            messageNom.Text = "msg";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(73, 15);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(34, 15);
            lblNom.TabIndex = 16;
            lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(617, 15);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(62, 15);
            lblPrenom.TabIndex = 17;
            lblPrenom.Text = "lblPrenom";
            // 
            // lblRue
            // 
            lblRue.AutoSize = true;
            lblRue.Location = new Point(73, 92);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(27, 15);
            lblRue.TabIndex = 18;
            lblRue.Text = "Rue";
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Location = new Point(73, 163);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(29, 15);
            lblVille.TabIndex = 19;
            lblVille.Text = "Ville";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(73, 233);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(61, 15);
            lblTelephone.TabIndex = 20;
            lblTelephone.Text = "Telephone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(617, 233);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(73, 343);
            lblType.Name = "lblType";
            lblType.Size = new Size(31, 15);
            lblType.TabIndex = 22;
            lblType.Text = "Type";
            // 
            // lblSpecialite
            // 
            lblSpecialite.AutoSize = true;
            lblSpecialite.Location = new Point(705, 343);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(57, 15);
            lblSpecialite.TabIndex = 23;
            lblSpecialite.Text = "Specialite";
            // 
            // FrmPraticienAjout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 611);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmPraticienAjout";
            Text = "FrmPraticienAjout";
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private Label messageEmail;
        private Label messagePrenom;
        private Label messageVille;
        private Label messageType;
        private Label messageTelephone;
        private Label messageRue;
        private Label messageNom;
        private MaskedTextBox mtbTelephone;
        private TextBox txtEmail;
        private TextBox txtVille;
        private TextBox txtRue;
        private TextBox txtPrenom;
        private TextBox txtNom;
        private Button btnAjouter;
        private ComboBox cbxSpecialite;
        private ComboBox cbxType;
        private Label lblSpecialite;
        private Label lblType;
        private Label lblEmail;
        private Label lblTelephone;
        private Label lblVille;
        private Label lblRue;
        private Label lblPrenom;
        private Label lblNom;
    }
}