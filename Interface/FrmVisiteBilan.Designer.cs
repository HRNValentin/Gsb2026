namespace Interface
{
    partial class FrmVisiteBilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteBilan));
            panelCentral = new Panel();
            panelGauche = new Panel();
            label6 = new Label();
            msgBilan = new Label();
            messageSecondMedicament = new Label();
            msgPremierMedicament = new Label();
            label2 = new Label();
            textBilan = new TextBox();
            panelDroite = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Colonne0 = new DataGridViewTextBoxColumn();
            Colonne1 = new DataGridViewTextBoxColumn();
            Colonne2 = new DataGridViewTextBoxColumn();
            Colonne3 = new DataGridViewImageColumn();
            Colonne4 = new DataGridViewImageColumn();
            Colonne5 = new DataGridViewImageColumn();
            btnAjouter = new Button();
            cptQuantite = new NumericUpDown();
            cbxEchantillon = new ComboBox();
            panelHaut = new Panel();
            lblPosition = new Label();
            lblNom = new Label();
            lblDate = new Label();
            label7 = new Label();
            label1 = new Label();
            button1 = new Button();
            btnPrecedent = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panelCentral.SuspendLayout();
            panelGauche.SuspendLayout();
            panelDroite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cptQuantite).BeginInit();
            panelHaut.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1364, 74);
            // 
            // panelCentral
            // 
            panelCentral.Anchor = AnchorStyles.None;
            panelCentral.BorderStyle = BorderStyle.FixedSingle;
            panelCentral.Controls.Add(panelGauche);
            panelCentral.Controls.Add(panelHaut);
            panelCentral.Location = new Point(20, 80);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1332, 503);
            panelCentral.TabIndex = 13;
            // 
            // panelGauche
            // 
            panelGauche.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGauche.BorderStyle = BorderStyle.FixedSingle;
            panelGauche.Controls.Add(comboBox2);
            panelGauche.Controls.Add(comboBox1);
            panelGauche.Controls.Add(button2);
            panelGauche.Controls.Add(label6);
            panelGauche.Controls.Add(msgBilan);
            panelGauche.Controls.Add(messageSecondMedicament);
            panelGauche.Controls.Add(msgPremierMedicament);
            panelGauche.Controls.Add(label2);
            panelGauche.Controls.Add(textBilan);
            panelGauche.Controls.Add(panelDroite);
            panelGauche.Location = new Point(30, 147);
            panelGauche.Name = "panelGauche";
            panelGauche.Size = new Size(1274, 341);
            panelGauche.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 11);
            label6.Name = "label6";
            label6.Size = new Size(162, 15);
            label6.TabIndex = 11;
            label6.Text = "Second medicament proposé";
            // 
            // msgBilan
            // 
            msgBilan.AutoSize = true;
            msgBilan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msgBilan.ForeColor = Color.Red;
            msgBilan.Location = new Point(73, 237);
            msgBilan.Name = "msgBilan";
            msgBilan.Size = new Size(30, 15);
            msgBilan.TabIndex = 5;
            msgBilan.Text = "msg";
            // 
            // messageSecondMedicament
            // 
            messageSecondMedicament.AutoSize = true;
            messageSecondMedicament.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageSecondMedicament.ForeColor = Color.Red;
            messageSecondMedicament.Location = new Point(298, 58);
            messageSecondMedicament.Name = "messageSecondMedicament";
            messageSecondMedicament.Size = new Size(30, 15);
            messageSecondMedicament.TabIndex = 4;
            messageSecondMedicament.Text = "msg";
            // 
            // msgPremierMedicament
            // 
            msgPremierMedicament.AutoSize = true;
            msgPremierMedicament.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msgPremierMedicament.ForeColor = Color.Red;
            msgPremierMedicament.Location = new Point(23, 61);
            msgPremierMedicament.Name = "msgPremierMedicament";
            msgPremierMedicament.Size = new Size(30, 15);
            msgPremierMedicament.TabIndex = 3;
            msgPremierMedicament.Text = "msg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 11);
            label2.Name = "label2";
            label2.Size = new Size(166, 15);
            label2.TabIndex = 2;
            label2.Text = "Premier medicament présenté";
            // 
            // textBilan
            // 
            textBilan.Location = new Point(73, 88);
            textBilan.Multiline = true;
            textBilan.Name = "textBilan";
            textBilan.Size = new Size(286, 146);
            textBilan.TabIndex = 0;
            // 
            // panelDroite
            // 
            panelDroite.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDroite.BorderStyle = BorderStyle.FixedSingle;
            panelDroite.Controls.Add(label5);
            panelDroite.Controls.Add(label4);
            panelDroite.Controls.Add(label3);
            panelDroite.Controls.Add(dataGridView1);
            panelDroite.Controls.Add(btnAjouter);
            panelDroite.Controls.Add(cptQuantite);
            panelDroite.Controls.Add(cbxEchantillon);
            panelDroite.Location = new Point(653, 10);
            panelDroite.Name = "panelDroite";
            panelDroite.Size = new Size(465, 317);
            panelDroite.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 24);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 11;
            label5.Text = "Quantite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 24);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 11;
            label4.Text = "Medicament";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 10;
            label3.Text = "Echantillons distribués";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Colonne0, Colonne1, Colonne2, Colonne3, Colonne4, Colonne5 });
            dataGridView1.Location = new Point(27, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(344, 226);
            dataGridView1.TabIndex = 9;
            // 
            // Colonne0
            // 
            Colonne0.HeaderText = "Medicament";
            Colonne0.Name = "Colonne0";
            Colonne0.Visible = false;
            // 
            // Colonne1
            // 
            Colonne1.HeaderText = "Nom";
            Colonne1.Name = "Colonne1";
            // 
            // Colonne2
            // 
            Colonne2.HeaderText = "Quantite";
            Colonne2.Name = "Colonne2";
            // 
            // Colonne3
            // 
            Colonne3.HeaderText = "";
            Colonne3.Name = "Colonne3";
            // 
            // Colonne4
            // 
            Colonne4.HeaderText = "";
            Colonne4.Name = "Colonne4";
            // 
            // Colonne5
            // 
            Colonne5.HeaderText = "";
            Colonne5.Name = "Colonne5";
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(320, 56);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            // 
            // cptQuantite
            // 
            cptQuantite.Location = new Point(260, 57);
            cptQuantite.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            cptQuantite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cptQuantite.Name = "cptQuantite";
            cptQuantite.Size = new Size(54, 23);
            cptQuantite.TabIndex = 7;
            cptQuantite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxEchantillon
            // 
            cbxEchantillon.FormattingEnabled = true;
            cbxEchantillon.Location = new Point(27, 57);
            cbxEchantillon.Name = "cbxEchantillon";
            cbxEchantillon.Size = new Size(227, 23);
            cbxEchantillon.TabIndex = 6;
            // 
            // panelHaut
            // 
            panelHaut.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHaut.BorderStyle = BorderStyle.FixedSingle;
            panelHaut.Controls.Add(lblPosition);
            panelHaut.Controls.Add(lblNom);
            panelHaut.Controls.Add(lblDate);
            panelHaut.Controls.Add(label7);
            panelHaut.Controls.Add(label1);
            panelHaut.Controls.Add(button1);
            panelHaut.Controls.Add(btnPrecedent);
            panelHaut.Location = new Point(30, 36);
            panelHaut.Name = "panelHaut";
            panelHaut.Size = new Size(1274, 80);
            panelHaut.TabIndex = 0;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(59, 53);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(24, 15);
            lblPosition.TabIndex = 16;
            lblPosition.Text = "0/0";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(404, 16);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(32, 15);
            lblNom.TabIndex = 15;
            lblNom.Text = "nom";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(193, 16);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(30, 15);
            lblDate.TabIndex = 14;
            lblDate.Text = "date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 16);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 13;
            label7.Text = "Chez";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 16);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 12;
            label1.Text = "Le";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Location = new Point(105, 16);
            button1.Name = "button1";
            button1.Size = new Size(40, 23);
            button1.TabIndex = 1;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnPrecedent
            // 
            btnPrecedent.BackColor = Color.PaleGreen;
            btnPrecedent.Location = new Point(59, 16);
            btnPrecedent.Name = "btnPrecedent";
            btnPrecedent.Size = new Size(40, 23);
            btnPrecedent.TabIndex = 0;
            btnPrecedent.Text = "<";
            btnPrecedent.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(370, 299);
            button2.Name = "button2";
            button2.Size = new Size(213, 37);
            button2.TabIndex = 12;
            button2.Text = "Enregistrer la fiche visite";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 23);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(298, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(227, 23);
            comboBox2.TabIndex = 14;
            // 
            // FrmVisiteBilan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 635);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteBilan";
            Text = "FrmVisiteBilan";
            Load += FrmVisiteBilan_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            panelGauche.ResumeLayout(false);
            panelGauche.PerformLayout();
            panelDroite.ResumeLayout(false);
            panelDroite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cptQuantite).EndInit();
            panelHaut.ResumeLayout(false);
            panelHaut.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private Panel panelGauche;
        private Panel panelDroite;
        private Panel panelHaut;
        private TextBox textBilan;
        private Label label2;
        private Label msgBilan;
        private Label messageSecondMedicament;
        private Label msgPremierMedicament;
        private NumericUpDown cptQuantite;
        private ComboBox cbxEchantillon;
        private Button btnAjouter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Colonne0;
        private DataGridViewTextBoxColumn Colonne1;
        private DataGridViewTextBoxColumn Colonne2;
        private DataGridViewImageColumn Colonne3;
        private DataGridViewImageColumn Colonne4;
        private DataGridViewImageColumn Colonne5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button btnPrecedent;
        private Label label7;
        private Label label1;
        private Label lblNom;
        private Label lblDate;
        private Label lblPosition;
        private Button button2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}