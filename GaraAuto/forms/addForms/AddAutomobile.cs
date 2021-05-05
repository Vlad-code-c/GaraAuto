using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.addForms
{
	public partial class AddAutomobile : Form
	{
		public AddAutomobile()
		{
			InitializeComponent();
			
			
			addAutoCompleteStrings();
		}

		private void txt_nrInmatriculare_TextChanged(object sender, EventArgs e)
		{

		}

		private void cb_tipAutomobil_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btn_primary_add_Click(object sender, EventArgs e)
		{
			TipAutomobil tip = new TipAutomobil()
			{
				denumire = cb_tipAutomobil.Text
			};
			tip.read();
			
			if (tip.id == -1)
			{
				DialogResult dialogResult = MessageBox.Show("Tipul introdus nu exista. Doriti sa il creati?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
				
				if (dialogResult == DialogResult.Yes)
				{
					AddTipAutomobil addTipAutomobil = new AddTipAutomobil(true, cb_tipAutomobil.Text);
					addTipAutomobil.Show();
				}
				else
				{
					return;
				}
			}


			Automobile automobile = new Automobile()
			{
				nrInmatriculare = txt_nrInmatriculare.Text,
				tipAutomobil = tip
			};
			automobile.create();
		}

		private void addAutoCompleteStrings()
		{
			AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();

			TipAutomobil tipAuto = new TipAutomobil();
			List<TipAutomobil> tipuri = tipAuto.getAll();
			
			tipuri.ForEach(tip =>
			{
				acsc.Add(tip.denumire);
				cb_tipAutomobil.Items.Add(tip.denumire);
			});

			cb_tipAutomobil.AutoCompleteMode = AutoCompleteMode.Suggest;
			cb_tipAutomobil.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cb_tipAutomobil.AutoCompleteCustomSource = acsc;
		}
	}
}
