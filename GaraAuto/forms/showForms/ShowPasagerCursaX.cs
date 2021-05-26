using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.showForms
{
    public partial class ShowPasagerCursaX : Form
    {
        private List<LocuriOcupate> locuriOcupates;
        private List<Traseu> trasee;
        public ShowPasagerCursaX()
        {
            InitializeComponent();
            
            cmbCursa.SelectedIndexChanged += (sender, args) => fillDataGridView();

            trasee = new Traseu().getAll();
            locuriOcupates = new LocuriOcupate().getAll();

            if (trasee.Count == 0) return;
            trasee.ForEach(traseu => cmbCursa.Items.Add(traseu.denumire));
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
                if (locOcup.cursa.traseu.denumire.Equals(trasee[cmbCursa.SelectedIndex].denumire))
                    // i = 0;
                
                    dt.Rows.Add(locOcup.pasager.idnp,
                        locOcup.pasager.nume_prenume,
                        locOcup.pasager.birth_year,
                        locOcup.cursa.traseu.denumire,
                        locOcup.cursa.Automobile.tipAutomobil.denumire);
            }

            dgvListaPasageri.DataSource = dt;
        } 
    }
}