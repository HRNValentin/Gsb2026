using Metier;
using Donnee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmPraticienAjout : FrmBase
    {
        public FrmPraticienAjout(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
            centrerFormulaire();
            parametrerComposant();
        }
        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        // 1. Initialisation et paramétrage des composants au chargement
        private void parametrerComposant()
        {
            lblTitre.Text = "Ajouter un praticien";
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

            // Ville : autocomplétion à partir de la collection MesVilles
            txtVille.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtVille.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var source = new AutoCompleteStringCollection();
            foreach (Ville ville in session!.MesVilles)
            {
                source.Add(ville.Nom);
            }
            txtVille.AutoCompleteCustomSource = source;

            // masquer les messages d'erreur au démarrage
            messageNom.Text = string.Empty;
            messagePrenom.Text = string.Empty;
            messageRue.Text = string.Empty;
            messageVille.Text = string.Empty;
            messageEmail.Text = string.Empty;
            messageTelephone.Text = string.Empty;
            messageType.Text = string.Empty;

            messageNom.Visible = messagePrenom.Visible = messageRue.Visible = messageVille.Visible = messageEmail.Visible = messageTelephone.Visible = messageType.Visible = false;

            // connecter les événements runtime
            btnAjouter.Click += (s, e) => ajout();
        }

        // Contrôles génériques
        private bool controlerChamp(TextBox txt, Label lblMessage, string message)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                lblMessage.Text = message;
                lblMessage.Visible = true;
                return false;
            }
            lblMessage.Text = "";
            lblMessage.Visible = false;
            return true;
        }

        private bool controlerTelephone()
        {
            if (!mtbTelephone.MaskFull)
            {
                messageTelephone.Text = "Le téléphone du praticien doit être précisé";
                messageTelephone.Visible = true;
                return false;
            }
            messageTelephone.Visible = false; // cacher le message si tout est bon
            return true;
        }

        private bool controlerType()
        {
            if (cbxType.SelectedIndex == -1)
            {
                messageType.Text = "Veuillez sélectionner le type de praticien.";
                messageType.Visible = true;
                return false;
            }
            messageType.Text = "";
            messageType.Visible = false;
            return true;
        }

        private bool controlerEmail()
        {
            if (txtEmail.Text == string.Empty)
            {
                messageEmail.Text = "L'adresse mail du praticien doit être précisée";
                messageEmail.Visible = true;
                return false;
            }
            Regex uneExpression = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            if (!uneExpression.IsMatch(txtEmail.Text))
            {
                messageEmail.Text = "L'adresse mail n'est pas valide";
                messageEmail.Visible = true;
                return false;
            }
            messageEmail.Text = "";
            messageEmail.Visible = false;
            return true;
        }

        private bool controlerVille()
        {
            if (string.IsNullOrWhiteSpace(txtVille.Text))
            {
                messageVille.Text = "La ville du praticien doit être précisée";
                messageVille.Visible = true;
                return false;
            }
            var trouve = session!.MesVilles.Find(x => x.Nom == txtVille.Text);
            if (trouve == null)
            {
                messageVille.Text = "La ville saisie n'existe pas dans la liste";
                messageVille.Visible = true;
                return false;
            }
            messageVille.Text = "";
            messageVille.Visible = false;
            return true;
        }

        // Gestionnaire centralisé des validations avant ajout
        private void ajout()
        {
            bool nomOk = controlerChamp(txtNom, messageNom, "Le nom du praticien doit être précisé");
            bool prenomOk = controlerChamp(txtPrenom, messagePrenom, "Le prénom du praticien doit être précisé");
            bool rueOk = controlerChamp(txtRue, messageRue, "La rue du praticien doit être précisée");
            bool villeOk = controlerVille();
            bool emailOk = controlerEmail();
            bool telephoneOk = controlerTelephone();
            bool typeOk = controlerType();
            if (nomOk && prenomOk && rueOk && villeOk && emailOk && telephoneOk && typeOk)
            {
                ajouter();
            }
        }

        // Exécution de l'ajout en base et mise à jour de la session/UI
        private void ajouter()
        {
            try
            {
                string nom = txtNom.Text.Trim();
                string prenom = txtPrenom.Text.Trim();
                string rue = txtRue.Text.Trim();
                string villeNom = txtVille.Text.Trim();
                Ville laVille = session!.MesVilles.Find(x => x.Nom == villeNom)!;
                string codePostal = laVille.Code;
                string telephone = mtbTelephone.Text;
                string email = txtEmail.Text.Trim();
                string idType = ((TypePraticien)cbxType.SelectedItem!).Id;
                string? idSpecialite = cbxSpecialite.SelectedIndex >= 0 ? ((Specialite)cbxSpecialite.SelectedItem!).Id : null;

                int id = Passerelle.ajouterPraticien(nom, prenom, rue, codePostal, villeNom, telephone, email, idType, idSpecialite!);

                // création de l'objet métier et mise à jour de la session
                TypePraticien type = session.LesTypesPraticien.Find(t => t.Id == idType)!;
                Specialite? specialite = idSpecialite != null ? session.LesSpecialites.Find(s => s.Id == idSpecialite) : null;

                Praticien p = new Praticien(id, nom, prenom, rue, codePostal, villeNom, email, telephone, type, specialite);
                session.MesPraticiens.Add(p);
                session.MesPraticiens.Sort();

                // Vider les champs et afficher message
                txtNom.Text = string.Empty;
                txtPrenom.Text = string.Empty;
                txtRue.Text = string.Empty;
                txtVille.Text = string.Empty;
                txtEmail.Text = string.Empty;
                mtbTelephone.Text = string.Empty;
                cbxType.SelectedIndex = -1;
                cbxSpecialite.SelectedItem = null;

                MessageBox.Show("Le praticien a été ajouté", "Ajout praticien", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
