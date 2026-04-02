using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmVisiteConsultation : FrmBase
    {
        public FrmVisiteConsultation(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
            centrerFormulaire();
            this.Load += FrmVisiteConsultation_Load;
            this.Resize += FrmVisiteConsultation_Resize;
        }

        private void FrmVisiteConsultation_Load(object? sender, EventArgs e)
        {
            parametrerComposant();
            centrerFormulaire();
            remplirDgvVisites();
        }

        private void FrmVisiteConsultation_Resize(object? sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private void dgvVisites_SelectionChanged(object sender, EventArgs e)
        {
            afficher();
        }

        private void parametrerComposant()
        {

            // titre de la fenêtre
            this.lblTitre.Text = "Consultation des visites";
            centrerFormulaire();

            // paramétrage du datagridview
            parametrerDgvEchantillon();

            parametrerDgv(dgvVisites);
        }

        private void parametrerDgvEchantillon()
        {
            dgvEchantillon.Enabled = false;

            //style général 
            dgvEchantillon.Font = new Font("Segoe UI", 10);
            dgvEchantillon.RowTemplate.Height = 28;
            dgvEchantillon.BorderStyle = BorderStyle.FixedSingle;

            //bordures des cellules
            dgvEchantillon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEchantillon.GridColor = Color.LightGray;

            //suppression selection visuelle
            dgvEchantillon.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvEchantillon.DefaultCellStyle.SelectionForeColor = Color.Black;

            // entete visible et stylé

            dgvEchantillon.ColumnHeadersVisible = true;
            dgvEchantillon.EnableHeadersVisualStyles = false;
            dgvEchantillon.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvEchantillon.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvEchantillon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvEchantillon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //colonnes

            dgvEchantillon.Columns.Clear();

            //colonne nom 
            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.Name = "Nom";
            col.HeaderText = "Nom";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //colonne quantité
            DataGridViewColumn colQte = new DataGridViewTextBoxColumn();
            colQte.Name = "Quantite";
            colQte.HeaderText = "Quantité";
            colQte.Width = 100;
            colQte.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ajout des colonnes datagridview
            dgvEchantillon.Columns.Add(col);
            dgvEchantillon.Columns.Add(colQte);

            // ajustement automatique des colonnes
            dgvEchantillon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ajustement largeur totale
            dgvEchantillon.Width = getLargeur(dgvEchantillon);
        }
        private void parametrerDgv(DataGridView dgv)
        {
            // initialisation du datagridview : supprimerRendezVous des colonnes et des lignes ajoutées par défaut dans le composant
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            #region paramètrage concernant le datagridview dans son ensemble

            // Accessibilité (doit être sur true si on veut pouvoir utiliser les barres de défilement)
            dgv.Enabled = true;

            // style de bordure
            dgv.BorderStyle = BorderStyle.FixedSingle;

            // couleur de fond 
            dgv.BackgroundColor = Color.White;

            // couleur de texte  
            dgv.ForeColor = Color.Black;

            // police de caractères par défaut
            dgv.DefaultCellStyle.Font = new Font("Georgia", 11);

            // mode de sélection dans le composant : FullRowSelect, CellSelect ...
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // sélection multiple 
            dgv.MultiSelect = false;

            // l'utilisateur peut-il ajouter ou supprimer des lignes ?
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;

            // L'utilisateur peut-il modifier le contenu des cellules ou est-elle réservée à la programmation ?
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;

            // l'utilisateur peut-il redimensionner les colonnes et les lignes ?
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            // l'utilisateur peut-il modifier l'ordre des colonnes ?
            dgv.AllowUserToOrderColumns = false;

            // le composant accepte t'il le 'déposer' dans un Glisser - Déposer ?
            dgv.AllowDrop = false;

            // Largeur : à contrôler avec la largeur des colonnes si elle est définie
            // dgv.Width = 700;

            // faut-il ajuster automatiquement la taille des colonnes par un ajustement proportionnel à la largeur totale (commenter la ligne si non)
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            #endregion

            #region paramètrage concernant la ligne d'entête 

            // visibilité
            dgv.ColumnHeadersVisible = true;

            // bordure
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // style  [à adapter] (ici : noir sur fond transparent sans mise en évidence de la sélection)
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;    // même couleur que backColor pour ne pas mettre en évidence la colonne sélectionnée
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);


            // hauteur 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;

            #endregion

            #region paramètrage concernant l'entête de ligne (la colonne d'entête ou le sélecteur)

            // visible 
            dgv.RowHeadersVisible = false;

            // style de bordure  
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


            #endregion

            #region paramètrage au niveau des lignes

            // Hauteur 
            dgv.RowTemplate.Height = 30;

            #endregion

            #region paramètrage au niveau des cellules

            // style de bordure 
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // couleur de fond, ne pas utiliser transparent car la couleur de la ligne sélectionnée restera après sélection
            dgv.RowsDefaultCellStyle.BackColor = Color.White;

            // Couleur alternative appliquée une ligne sur deux
            // unDgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 238, 238, 238);

            #endregion

            #region paramètrage au niveau de la zone sélectionnée

            // couleur de fond mettre la même que les cellules si on ne veut pas mettre la zone en évidence 
            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;

            // couleur du texte
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            #endregion

            #region paramètrage des colonnes

            // faut-il ajuster automatiquement la taille des colonnes par un ajustement proportionnel à la largeur totale (commenter la ligne si non)
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


            // description de chaque colonne  [partie à personnaliser] 
            DataGridViewColumn col;

            // la première colonne contient l'objet visite : elle est masquée
            col = new DataGridViewTextBoxColumn();
            col.Name = "Visite";
            col.HeaderText = "";
            col.Visible = false;
            dgv.Columns.Add(col);


            // Colonne 0 : La date de la visite
            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 1 :  heure du rendez-vous
            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            col.Width = 50;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(col);

            // Colonne 2 ! ville du rendez-vous
            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 3 : praticien (nom et prénom)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Praticien";
            col.HeaderText = "Praticien";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);


            // faut-il désactiver le tri sur toutes les colonnes ? (commenter les lignes si non)
            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private int getLargeur(DataGridView dgv)
        {
            int largeur = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                    largeur += col.Width;
            }
            if (dgv.RowHeadersVisible)
                largeur += dgv.RowHeadersWidth;

            return largeur + 2; // 2 pixels de marge
        }
            private void remplirDgvVisites()
        {
            // vider le datagridview
            dgvVisites.Rows.Clear();

            // Parcourir les visites dans l'ordre chronologique
            foreach (Visite v in session.MesVisites)
            {
                // add the Visite object in the hidden first column followed by display values
                int rowIndex = dgvVisites.Rows.Add(
                         v,
                         v.DateEtHeure.ToLongDateString(),
                         v.DateEtHeure.ToShortTimeString(),
                         v.LePraticien.Ville,
                         v.LePraticien.NomPrenom);

                if (v.Bilan != null)
                {
                    // color the displayed cells in green when a bilan exists
                    var cells = dgvVisites.Rows[rowIndex].Cells;
                    // parcourir uniquement les cellules réellement présentes (sauter la colonne cachée index 0)
                    for (int i = 1; i < cells.Count; i++)
                    {
                        cells[i].Style.ForeColor = Color.Green;
                    }
                }
            }
            // afficher les détails de la première visite
            afficher();
        }
        // afficher la visite sélectionnée dans le datagridview
        private void afficher()
        {
            if (dgvVisites.Rows.Count == 0 || dgvVisites.SelectedRows.Count == 0)
            {
                ViderAffichage();
                return;
            }

            // afficher les détails de la visite dans les composants prévus à cet effet
            Visite uneVisite = (Visite)dgvVisites.SelectedRows[0].Cells[0].Value!;

            lblPraticien.Text = uneVisite.LePraticien.NomPrenom;
            lblEmail.Text = uneVisite.LePraticien.Email;
            lblRue.Text = uneVisite.LePraticien.Rue;
            lblTelephone.Text = uneVisite.LePraticien.Telephone;
            lblType.Text = uneVisite.LePraticien.Type!.Libelle;
            lblSpecialite.Text = uneVisite.LePraticien.Specialite!.Libelle;
            lblMotif.Text = uneVisite.LeMotif.Libelle;
            lblBilan.Text = uneVisite.Bilan == null ? string.Empty : uneVisite.Bilan;
            lstMedicament.Items.Clear();
            if (uneVisite.PremierMedicament != null)
                lstMedicament.Items.Add(uneVisite.PremierMedicament.Nom);
            if (uneVisite.SecondMedicament != null)
                lstMedicament.Items.Add(uneVisite.SecondMedicament.Nom);
            // remplir le datagridview des échantillons remis lors de la visite
            dgvEchantillon.Rows.Clear();
            foreach (KeyValuePair<Medicament, int> unCouple in uneVisite)
            {
                Medicament unMedicament = unCouple.Key;
                int qte = unCouple.Value;
                dgvEchantillon.Rows.Add(unMedicament.Nom, qte.ToString());
            }
        }
            private void ViderAffichage()
            {
                lblPraticien.Text = string.Empty;
                lblEmail.Text = string.Empty;
                lblRue.Text = string.Empty;
                lblTelephone.Text = string.Empty;
                lblType.Text = string.Empty;
                lblSpecialite.Text = string.Empty;
                lblMotif.Text = string.Empty;
                lblBilan.Text = string.Empty;
                lstMedicament.Items.Clear();
                dgvEchantillon.Rows.Clear();


        }

        }


}
    #endregion