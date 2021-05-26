using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.showForms
{
    public partial class ShowTipTransportCursaX : Form
    {
        private List<Traseu> trasee;
        private List<TipAutomobil> tipuriAuto;
        private List<Cursa> curse;
        
        
        public ShowTipTransportCursaX()
        {
            InitializeComponent();
            
            cmbCursa.SelectedIndexChanged += (sender, args) => fillDataGridView();
            
            curse = new Cursa().getAll();
            

            tipuriAuto = new TipAutomobil().getAll();
            
            if (tipuriAuto.Count == 0) return;
            
            
            curse.ForEach(cursa => cmbCursa.Items.Add(cursa.traseu.denumire));
            cmbCursa.SelectedIndex = 0;
            
            fillDataGridView();
        }

        private void fillDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("denumire", typeof(string));
            dt.Columns.Add("nr_locuri", typeof(int));

            foreach (Cursa cursa in curse)
            {
                if (cursa.traseu.denumire.Equals(curse[cmbCursa.SelectedIndex].traseu.denumire) &&
                    cursa.Automobile.tipAutomobil.denumire.Equals(curse[cmbCursa.SelectedIndex].Automobile.tipAutomobil.denumire))
                {
                    dt.Rows.Add(cursa.Automobile.id,
                        cursa.Automobile.tipAutomobil.denumire,
                        cursa.Automobile.tipAutomobil.nrLocuri);
                }   
            }

            dgvListaPasageri.DataSource = dt;
        }

        private void cmbIdnpPasager_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataGridView();
        }
    }
}