namespace Interface
{
    partial class FrmVisiteAjout
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteAjout));
            panelDroite = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnAjouter = new Button();
            dtpDate = new DateTimePicker();
            cbxMotif = new ComboBox();
            cbxPraticien = new ComboBox();
            label2 = new Label();
            panelGauche = new Panel();
            dgvVisites = new DataGridView();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelDroite.SuspendLayout();
            panel2.SuspendLayout();
            panelGauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // panelDroite
            // 
            panelDroite.Controls.Add(panel2);
            panelDroite.Dock = DockStyle.Right;
            panelDroite.Location = new Point(469, 98);
            panelDroite.Name = "panelDroite";
            panelDroite.Padding = new Padding(10);
            panelDroite.Size = new Size(331, 307);
            panelDroite.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnAjouter);
            panel2.Controls.Add(dtpDate);
            panel2.Controls.Add(cbxMotif);
            panel2.Controls.Add(cbxPraticien);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(6, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 289);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 155);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 7;
            label5.Text = "Date et heure";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 108);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Motif";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 58);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Praticien";
            // 
            // btnAjouter
            // 
            btnAjouter.AccessibleRole = AccessibleRole.TitleBar;
            btnAjouter.BackColor = Color.Red;
            btnAjouter.Location = new Point(58, 209);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(109, 149);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 3;
            // 
            // cbxMotif
            // 
            cbxMotif.FormattingEnabled = true;
            cbxMotif.Location = new Point(109, 100);
            cbxMotif.Name = "cbxMotif";
            cbxMotif.Size = new Size(173, 23);
            cbxMotif.TabIndex = 2;
            // 
            // cbxPraticien
            // 
            cbxPraticien.FormattingEnabled = true;
            cbxPraticien.Location = new Point(109, 56);
            cbxPraticien.Name = "cbxPraticien";
            cbxPraticien.Size = new Size(173, 23);
            cbxPraticien.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 19);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 0;
            label2.Text = "Nouveau rendez-vous";
            // 
            // panelGauche
            // 
            panelGauche.Controls.Add(dgvVisites);
            panelGauche.Controls.Add(label1);
            panelGauche.Dock = DockStyle.Fill;
            panelGauche.Location = new Point(0, 98);
            panelGauche.Name = "panelGauche";
            panelGauche.Padding = new Padding(10);
            panelGauche.Size = new Size(469, 307);
            panelGauche.TabIndex = 14;
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Dock = DockStyle.Fill;
            dgvVisites.Location = new Point(10, 25);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(449, 272);
            dgvVisites.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(449, 15);
            label1.TabIndex = 0;
            label1.Text = "Liste des rendez-vous déjà progrmmés";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FrmVisiteAjout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGauche);
            Controls.Add(panelDroite);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Location = new Point(0, 0);
            Name = "FrmVisiteAjout";
            Text = "FrmVisiteAjout";
            Load += FrmVisiteAjout_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelDroite, 0);
            Controls.SetChildIndex(panelGauche, 0);
            panelDroite.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelGauche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDroite;
        private Panel panelGauche;
        private Label label1;
        private Panel panel2;
        private ComboBox cbxMotif;
        private ComboBox cbxPraticien;
        private Label label2;
        private DataGridView dgvVisites;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private Label label3;
        private Button btnAjouter;
        private DateTimePicker dtpDate;
        private Label label5;
    }
}