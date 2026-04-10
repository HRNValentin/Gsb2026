using Interface;
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
    public partial class FrmVisiteImpression : FrmBase
    {
        private List<Visite> lesVisites = new List<Visite>();

        public FrmVisiteImpression(Session uneSession) : base(uneSession)
        {
            InitializeComponent();

            this.Load += FrmVisiteImpression_Load;
            this.Resize += FrmVisiteImpression_Resize;

            // lier les événements des contrôles initialisés par InitializeComponent
            dtpDebut.ValueChanged += dtpDebut_ValueChanged;
            dtpFin.ValueChanged += dtpFin_ValueChanged;
            imgImprimer.Click += imgImprimer_Click;
            imgApercu.Click += imgApercu_Click;
            printRendezVous.PrintPage += printRendezVous_PrintPage;
        }

        private void FrmVisiteImpression_Load(object? sender, EventArgs e)
        {
            // recentrer le formulaire
            centrerFormulaire();

            // initialisation de la collection des visites : on ne garde que les visites dont
            // la date et l'heure sont supérieures ou égales à la date et l'heure du jour
            if (session?.MesVisites != null)
            {
                lesVisites = session.MesVisites
                                   .Where(v => v.DateEtHeure >= DateTime.Now)
                                   .ToList();
            }

            // si aucune visite ne correspond, afficher un message et masquer la zone de saisie
            if (lesVisites == null || lesVisites.Count == 0)
            {
                label.Text = "Aucun rendez-vous planifié pour le moment.";
                panelSaisie.Visible = false;
            }
            else
            {
                // restaurer les libellés par défaut et afficher la zone de saisie
                label.Text = "Du";
                label2.Text = "Au";
                panelSaisie.Visible = true;
            }

            // paramétrage des composants spécifiques à ce formulaire
            parametrerComposant();
        }
        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private void parametrerComposant()
        {
            // titre de la fenêtre
            this.lblTitre.Text = "Impression des rendez-vous sur une période";

            // définition des plages pour les sélecteurs de date
            DateTime today = DateTime.Today;

            // dtpDebut : aujourd'hui .. aujourd'hui + 53
            dtpDebut.MinDate = today;
            dtpDebut.MaxDate = today.AddDays(53);
            dtpDebut.Value = dtpDebut.MinDate;

            // dtpFin : aujourd'hui + 7 .. aujourd'hui + 60
            dtpFin.MinDate = today.AddDays(7);
            dtpFin.MaxDate = today.AddDays(60);
            // s'assurer que dtpFin a une valeur valide
            if (dtpFin.Value < dtpFin.MinDate || dtpFin.Value > dtpFin.MaxDate)
            {
                dtpFin.Value = dtpFin.MinDate;
            }

            // vider les messages
            messageIntervale.Text = string.Empty;
            message.Text = string.Empty;

            // état des boutons d'impression / aperçu selon la présence de visites
            MettreAJourEtatBoutons();
        }

        private void MettreAJourEtatBoutons()
        {
            var start = dtpDebut.Value.Date;
            var end = dtpFin.Value.Date;
            bool any = lesVisites != null && lesVisites.Any(v => v.DateEtHeure.Date >= start && v.DateEtHeure.Date <= end);
            imgImprimer.Enabled = any;
            imgApercu.Enabled = any;
        }

        private List<Visite> RecupVisitesSurIntervalle()
        {
            var start = dtpDebut.Value.Date;
            var end = dtpFin.Value.Date;
            return lesVisites
                .Where(v => v.DateEtHeure.Date >= start && v.DateEtHeure.Date <= end)
                .OrderBy(v => v.DateEtHeure)
                .ToList();
        }

        private void FrmVisiteImpression_Resize(object? sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void dtpFin_ValueChanged(object? sender, EventArgs e)
        {
            // effacer le message éventuel
            messageIntervale.Text = string.Empty;
            MettreAJourEtatBoutons();
        }

        private void dtpDebut_ValueChanged(object? sender, EventArgs e)
        {
            // effacer le message éventuel
            messageIntervale.Text = string.Empty;

            // fixer la valeur minimale de dtpFin à dtpDebut + 7 jours
            DateTime minFin = dtpDebut.Value.Date.AddDays(7);
            if (minFin > dtpFin.MaxDate)
            {
                // si la nouvelle min dépasse le max configuré, on ajuste le max également
                dtpFin.MaxDate = minFin;
            }
            dtpFin.MinDate = minFin;

            // si la valeur courante de dtpFin est inférieure à la nouvelle min, on la corrige
            if (dtpFin.Value.Date < dtpFin.MinDate)
            {
                dtpFin.Value = dtpFin.MinDate;
            }

            MettreAJourEtatBoutons();
        }

        private void imgImprimer_Click(object? sender, EventArgs e)
        {
            var visites = RecupVisitesSurIntervalle();
            if (visites == null || visites.Count == 0)
            {
                messageIntervale.Text = "Aucun rendez-vous planifié sur cette période.";
                return;
            }

            // initialisation des composants d'impression
            printRendezVous.DocumentName = "Rendez-vous";
            choixImprimante.Document = printRendezVous;
            DialogResult result = choixImprimante.ShowDialog();
            if (result == DialogResult.OK)
            {
                printRendezVous.Print();
            }
        }

        private void imgApercu_Click(object? sender, EventArgs e)
        {
            var visites = RecupVisitesSurIntervalle();
            if (visites == null || visites.Count == 0)
            {
                messageIntervale.Text = "Aucun rendez-vous planifié sur cette période.";
                return;
            }

            // préparation de l'aperçu
            aperçuRendezVous.Document = printRendezVous;
            aperçuRendezVous.ShowDialog();
        }

        private void printRendezVous_PrintPage(object? sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // on considère que l'impression tient sur une seule page
            var visites = RecupVisitesSurIntervalle();

            // mise en forme
            int margeGauche = 50;
            int margeHaut = 50;
            int hauteurLigne = 25;
            var policeTitre = new Font("Segoe UI", 12, FontStyle.Bold);
            var police = new Font("Segoe UI", 9);
            var brush = Brushes.Black;

            // titre
            e.Graphics.DrawString("Rendez-vous", policeTitre, brush, new PointF(margeGauche, margeHaut));

            // colonnes
            var lesColonnes = new[] {
                new { Titre = "Date", Largeur = 170, Alignement = StringAlignment.Near },
                new { Titre = "Heure", Largeur = 80, Alignement = StringAlignment.Center },
                new { Titre = "Praticien", Largeur = 200, Alignement = StringAlignment.Near },
                new { Titre = "Téléphone", Largeur = 120, Alignement = StringAlignment.Near },
                new { Titre = "Lieu", Largeur = 200, Alignement = StringAlignment.Near },
                new { Titre = "Motif", Largeur = 200, Alignement = StringAlignment.Near }
            };

            int y = margeHaut + hauteurLigne + 10;
            int x = margeGauche;

            // en-tête
            foreach (var col in lesColonnes)
            {
                Rectangle rect = new Rectangle(x, y, col.Largeur, hauteurLigne);
                e.Graphics.DrawString(col.Titre, police, brush, rect, new StringFormat { Alignment = col.Alignement, LineAlignment = StringAlignment.Center });
                x += col.Largeur;
            }

            // corps
            y += hauteurLigne + 5;
            foreach (var v in visites)
            {
                x = margeGauche;
                var valeurs = new[] {
                    v.DateEtHeure.ToShortDateString(),
                    v.DateEtHeure.ToShortTimeString(),
                    v.LePraticien?.NomPrenom ?? string.Empty,
                    v.LePraticien?.Telephone ?? string.Empty,
                    v.LePraticien?.Ville ?? string.Empty,
                    v.LeMotif?.Libelle ?? string.Empty
                };

                for (int i = 0; i < lesColonnes.Length; i++)
                {
                    var col = lesColonnes[i];
                    Rectangle rect = new Rectangle(x, y, col.Largeur, hauteurLigne);
                    e.Graphics.DrawString(valeurs[i], police, brush, rect, new StringFormat { Alignment = col.Alignement, LineAlignment = StringAlignment.Center });
                    x += col.Largeur;
                }

                y += hauteurLigne + 5;
            }

            e.HasMorePages = false;
        }
    }
}