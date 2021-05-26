using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.showForms
{
    public partial class ShowPasagerXCursaY : Form
    {
        private List<Pasager> pasageri;
        private List<LocuriOcupate> locuriOcupates;
        private List<Traseu> trasee;
        public ShowPasagerXCursaY()
        {
            InitializeComponent();
            
            cmbCursa.SelectedIndexChanged += (sender, args) => fillDataGridView();

            trasee = new Traseu().getAll();
            locuriOcupates = new LocuriOcupate().getAll();
            pasageri = new Pasager().getAll();

            if (trasee.Count == 0) return;
            trasee.ForEach(traseu => cmbCursa.Items.Add(traseu.denumire));
            cmbCursa.SelectedIndex = 0;

            if (pasageri.Count == 0) return;
            pasageri.ForEach(pasager => cmbIdnpPasager.Items.Add(pasager.idnp));
            cmbCursa.SelectedIndex = 0;
            
            fillDataGridView();
        }

        private void fillDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("idnp", typeof(long));
            dt.Columns.Add("nume_prenume", typeof(string));
            dt.Columns.Add("birth_year", typeof(int));
            dt.Columns.Add("traseu", typeof(string));
            dt.Columns.Add("automobil", typeof(string));
            
            
            foreach (LocuriOcupate locOcup in locuriOcupates)
            {
                int i;
                if (locOcup.cursa.traseu.denumire.Equals(trasee[cmbCursa.SelectedIndex].denumire) &&
                    locOcup.pasager.idnp.ToString().Equals(cmbIdnpPasager.Text))

                    dt.Rows.Add(locOcup.pasager.idnp,
                        locOcup.pasager.nume_prenume,
                        locOcup.pasager.birth_year,
                        locOcup.cursa.traseu.denumire,
                        locOcup.cursa.Automobile.tipAutomobil.denumire);
            }

            dgvListaPasageri.DataSource = dt;
        }

        private void cmbIdnpPasager_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGridView();
        }
    }
}