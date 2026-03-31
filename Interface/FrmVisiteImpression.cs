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
        }
    }
}