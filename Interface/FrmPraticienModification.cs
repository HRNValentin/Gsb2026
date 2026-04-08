using Donnee;
using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmPraticienModification : FrmBase
    {
        public FrmPraticienModification(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
            centrerFormulaire();
        }

        // Remplit l'interface avec les données d'un praticien
        private void remplirPraticien(Praticien p)
        {
            if (p == null)
            {
                panelCentral.Visible = false;
                return;
            }

            panelCentral.Visible = true;
            txtNom.Text = p.Nom;
            txtPrenom.Text = p.Prenom;
            txtRue.Text = p.Rue;
            txtEmail.Text = p.Email;
            mtbTelephone.Text = p.Telephone;

            // sélectionner la ville correspondant au code postal ou au nom
            var ville = session?.MesVilles.FirstOrDefault(v => v.Code == p.CodePostal || v.Nom == p.Ville);
            if (ville != null)
            {
                cbxVille.SelectedItem = ville;
            }
            else
            {
                cbxVille.SelectedIndex = -1;
            }

            if (p.Type != null)
                cbxType.SelectedItem = session?.LesTypesPraticien.FirstOrDefault(t => t.Id == p.Type.Id);
            else
                cbxType.SelectedIndex = -1;

            if (p.Specialite != null)
                cbxSpecialite.SelectedItem = session?.LesSpecialites.FirstOrDefault(s => s.Id == p.Specialite.Id);
            else
                cbxSpecialite.SelectedItem = null;
        }
        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }
        // 1. Initialisation et paramétrage des composants au chargement
        protected override void parametrerComposant()
        {
            lblTitre.Text = "Mettre à jour les coordonnées d'un praticien";
            centrerFormulaire();

            // Types de praticiens
            cbxType.DataSource = session!.LesTypesPraticien;
            cbxType.DisplayMember = "Libelle";
            cbxType.ValueMember = "Id";
            cbxType.SelectedIndex = -1;

            // Spécialités
            cbxSpecialite.DataSource = session.LesSpecialites;
            cbxSpecialite.DisplayMember = "Libelle";
            cbxSpecialite.ValueMember = "Id";
            cbxSpecialite.SelectedItem = null;

            // Villes
            cbxVille.DataSource = session.MesVilles;
            cbxVille.DisplayMember = "Nom";
            cbxVille.ValueMember = "Code";
            cbxVille.SelectedIndex = -1;
            cbxVille.DropDownStyle = ComboBoxStyle.DropDown;

            // Liste des praticiens : configuration et remplissage
            cbxPraticien.DisplayMember = "NomPrenom";
            cbxPraticien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPraticien.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxPraticien.DropDownStyle = ComboBoxStyle.DropDown;

            foreach (var p in session.MesPraticiens)
            {
                cbxPraticien.Items.Add(p);
            }
            // masquer les messages d'erreur au démarrage
            messageNom.Text = string.Empty;
            messagePrenom.Text = string.Empty;
            messageRue.Text = string.Empty;
            messageVille.Text = string.Empty;
            messageEmail.Text = string.Empty;
            messageTelephone.Text = string.Empty;
            messageNom.Visible = messagePrenom.Visible = messageRue.Visible = messageVille.Visible = messageEmail.Visible = messageTelephone.Visible = false;

            // connecter les événements runtime
            cbxPraticien.SelectedIndexChanged += (s, e) => {
                if (cbxPraticien.SelectedItem != null)
                    remplirPraticien((Praticien)cbxPraticien.SelectedItem);
            };
            btnModifier.Click += (s, e) => modification();
            button1.Click += (s, e) => btnSupprimer_Click(s, e);


            if (cbxPraticien.Items.Count > 0)
            {
                cbxPraticien.SelectedIndex = 0;
                Praticien lePraticien = (Praticien)cbxPraticien.SelectedItem!;
                remplirPraticien(lePraticien);
            }
        }

        // 2. Contrôle et validation des champs avant modification
        private void modification()
        {
            // validation supprimée ici — les composants sont initialisés et contrôlés lors du paramétrage
            modifier();
        }

        // 3. Exécution de la mise à jour (Base de données et Interface)
        private void modifier()
        {
            try
            {
                // Récupérer les objets sélectionnés
                Praticien lePraticien = (Praticien)cbxPraticien.SelectedItem!;
                Ville ville = (Ville)cbxVille.SelectedItem!;

                // Mettre à jour les propriétés de l'objet métier
                lePraticien.Nom = txtNom.Text;
                lePraticien.Prenom = txtPrenom.Text;
                lePraticien.Rue = txtRue.Text;
                lePraticien.Ville = ville.Nom;
                lePraticien.CodePostal = ville.Code;
                lePraticien.Email = txtEmail.Text;
                lePraticien.Telephone = mtbTelephone.Text;
                lePraticien.Type = (TypePraticien)cbxType.SelectedItem!;
                lePraticien.Specialite = cbxSpecialite.SelectedIndex >= 0 ? (Specialite)cbxSpecialite.SelectedItem! : null;

                // Enregistrement via la passerelle
                Passerelle.modifierPraticien(lePraticien);

                // Rafraîchissement visuel du ComboBox pour refléter les changements (ex: Nom/Prénom modifié)
                int currentIndex = cbxPraticien.SelectedIndex;
                cbxPraticien.SelectedIndex = -1;
                cbxPraticien.SelectedIndex = currentIndex;

                MessageBox.Show("Les coordonnées du praticien ont été modifiées", "Modification coordonnées d'un praticien", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Événement de clic pour la suppression
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmez-vous la suppression de ce praticien ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Supprimer();
            }
        }

        // 5. Exécution de la suppression
        private void Supprimer()
        {
            try
            {
                Praticien lePraticien = (Praticien)cbxPraticien.SelectedItem!;

                // Suppression BDD
                Passerelle.supprimerPraticien(lePraticien.Id);

                // Mise à jour de la session et de l'UI
                session!.MesPraticiens.Remove(lePraticien);
                panelCentral.Visible = false;

                int index = cbxPraticien.SelectedIndex;
                cbxPraticien.Items.Remove(lePraticien);

                // Recalcul de l'index pour sélectionner le praticien suivant ou précédent
                if (index >= cbxPraticien.Items.Count)
                {
                    index = cbxPraticien.Items.Count - 1;
                }

                if (index >= 0)
                {
                    cbxPraticien.SelectedIndex = index;
                    remplirPraticien((Praticien)cbxPraticien.SelectedItem!);
                }

                MessageBox.Show("Suppression réalisée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
