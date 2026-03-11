using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmVisiteAjout : FrmBase
    {
        public FrmVisiteAjout(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        # region procédures événementielles


        private void FrmVisiteAjout_Load(object sender, EventArgs e)
        {
            parametrerComposant();
          
        }

        #endregion

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Ajouter une visite";

            // alimentation de la zone de liste des praticiens
            foreach (Praticien unPraticien in session.MesPraticiens)
            {
                cbxPraticien.Items.Add(unPraticien);
            }
            cbxPraticien.DisplayMember = "NomPrenom";
            cbxPraticien.ValueMember = "Id";
            cbxPraticien.SelectedIndex = 0;

            // alimentation de la zone de liste des motifs
            cbxMotif.DataSource = session.LesMotifs;
            cbxMotif.DisplayMember = "Libelle";
            cbxMotif.ValueMember = "Id";


        }

        //parametrage DataGridView
        parameterDgv(dgVisites);

        #region procédures

        private void parametrerComposant()
        

        private void parametreDgv(DataGridView dgv)

        private void remplirDgv()
        {
            //vider le datagridview
            dgvVisites.Rows.Clear();

            //parcourir les visites de la session par ordre chronologique
            foreach(Visite v in session.MesVisites.Where(v => v.Bilan is null))
            {
                dgvVisites.Rows.Add(v.DateEtHeure, v.DateEtHeure)
            }
        }

        #endregion

    }
}
