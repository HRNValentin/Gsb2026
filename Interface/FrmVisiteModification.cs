using Metier;
using Donnee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Interface
{
    public partial class FrmVisiteModification : FrmBase
    {
            public FrmVisiteModification(Session uneSession) : base(uneSession)
            {
                InitializeComponent();
            }
        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // utiliser le bouton pour appliquer la modification sélectionnée
            // si une ligne est sélectionnée, récupérer la visite et appliquer la date/heure choisis
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            var valeur = row.Cells["Visite"].Value;
            if (valeur is Visite visite)
            {
                try
                {
                    // récupérer les valeurs depuis les dateTimePicker sur le panneau de droite
                    DateTime nouvelleDate = dateTimePicker1.Value.Date + dateTimePicker2.Value.TimeOfDay;
                    // appeler la passerelle pour modifier (implémentation vide pour l'instant)
                    Passerelle.modifierRendezVous(visite.Id, nouvelleDate);
                    // modifier en mémoire
                    visite.deplacer(nouvelleDate);
                    // rafraichir
                    remplirDgv();
                    MessageBox.Show("La visite a été modifiée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            // quand la sélection change, afficher la date/heure du rendez-vous dans les dateTimePicker
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            var valeur = row.Cells["Visite"].Value;
            if (valeur is Visite visite)
            {
                dateTimePicker1.Value = visite.DateEtHeure.Date;
                dateTimePicker2.Value = visite.DateEtHeure;
            }
        }
        private void FrmVisiteModification_Load(object sender, EventArgs e)
        {
            // parametrage et remplissage du datagridView en s'inspirant de FrmVisiteAjout
            parametrerComposant();
            parametrerDgv(dataGridView1);
            remplirDgv();

            // gestion du clic sur les cellules (pour suppression via image)
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // ------------------------- nouvelles méthodes -------------------------

        private void parametrerComposant()
        {
            // titre de la fenêtre
            this.lblTitre.Text = "Modification rendez-vous";
            // adapter le label explicatif
            label6.Text = "Sélectionner la visite afin de modifier le rendez -vous";
        }

        private void parametrerDgv(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            // quelques réglages généraux (simplifiés)
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12, FontStyle.Bold);
            dgv.RowTemplate.Height = 30;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewColumn col;

            // Colonne 0 : objet Visite (cachée)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Visite";
            col.HeaderText = "VisiteObj";
            col.Visible = false;
            dgv.Columns.Add(col);

            // Colonne 1 : image de suppression
            var imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Supprimer";
            imgCol.HeaderText = "";
            // utiliser la ressource 'supprimer' présente dans Properties.Resources
            imgCol.Image = Properties.Resources.supprimer;
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.Width = 30;
            dgv.Columns.Add(imgCol);

            // Colonne 2 : date
            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 3 : heure
            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            col.Width = 50;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(col);

            // Colonne 4 : lieu (ville)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 5 : praticien
            col = new DataGridViewTextBoxColumn();
            col.Name = "Praticien";
            col.HeaderText = "chez";
            col.Width = 250;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // désactiver le tri
            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void remplirDgv()
        {
            dataGridView1.Rows.Clear();
            // afficher uniquement les visites sans bilan
            foreach (Visite v in session.MesVisites.Where(v => v.Bilan is null))
            {
                dataGridView1.Rows.Add(
                    v, // colonne cachée contenant l'objet visite
                    Properties.Resources.supprimer,
                    v.DateEtHeure.ToLongDateString(),
                    v.DateEtHeure.ToShortTimeString(),
                    v.LePraticien.Ville,
                    v.LePraticien.NomPrenom);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dgv = (DataGridView)sender;
            // si clic sur la colonne 'Supprimer'
            if (dgv.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                var valeur = dgv.Rows[e.RowIndex].Cells["Visite"].Value;
                if (valeur is Visite visite)
                {
                    var res = MessageBox.Show($"Voulez-vous supprimer le rendez-vous du {visite.DateEtHeure}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            // appeler la passerelle (même si l'implémentation est vide pour l'instant)
                            Passerelle.supprimerRendezVous(visite.Id);
                        }
                        catch { }

                        // supprimer localement et mettre à jour l'affichage
                        session.MesVisites.Remove(visite);
                        remplirDgv();
                    }
                }
            }
        }
       
    }
}
