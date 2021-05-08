using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.addForms
{
	public partial class AddCursa : Form
	{
		private List<Automobile> automobile = new List<Automobile>(); 
		public AddCursa()
		{
			InitializeComponent();
			
			cb_tip_auto.SelectedValueChanged += cb_automobilOnSelectedValueChanged;

			addAutoCompleteStrings();
			textBox1.Click += textBox1OnClick;
			btn_primary_add.Click += btn_primary_addOnClick;
		}

		private void btn_primary_addOnClick(object sender, EventArgs e)
		{
			TipAutomobil tip = new TipAutomobil()
			{
				denumire = cb_tip_auto.Text
			};
			tip.read();

			Localitate localitate_inceput = new Localitate()
			{
				name = textBox1.Text.Trim().Split("-")[0].Trim()
			};
			localitate_inceput.read();
			
			// MessageBox.Show("_" + textBox1.Text.Trim().Split("-")[0].Trim() + "_");
			
			
			Localitate localitate_sfarsit = new Localitate()
			{
				name = textBox1.Text.Trim().Split("-")[1].Trim()
			};
			localitate_sfarsit.read();
			
			Traseu traseu = new Traseu()
			{
				localitate_inceput = localitate_inceput,
				localitate_sfarsit = localitate_sfarsit
			};
			traseu.read();
			
			MessageBox.Show(localitate_inceput.id.ToString());
			MessageBox.Show(localitate_sfarsit.id.ToString());
			MessageBox.Show(traseu.ToString());

			Automobile automobil = new Automobile()
			{
				nrInmatriculare = cb_automobil.Text,
				tipAutomobil = tip
			};
			automobil.read();
			
			
			Cursa cursa = new Cursa()
			{
				Automobile = automobil,
				traseu = traseu,
				ora = cb_ora.Text
			};
			cursa.create();
		}

		private void textBox1OnClick(object sender, EventArgs e)
		{
			SelectTraseu st;
			if (cb_ora.SelectedText != "")
			{
				st = new SelectTraseu(Convert.ToInt32(cb_ora.SelectedText));
			}
			else
			{
				st = new SelectTraseu();
			}

			st.Closed += (o, args) =>
			{
				textBox1.Text = st.SelectedTraseu;
			};
			st.ShowDialog();

		}

		private void cb_automobilOnSelectedValueChanged(object sender, EventArgs e)
		{
			cb_automobil.Items.Clear();
			cb_automobil.Text = "";
			automobile.ForEach(auto =>
			{
				if (auto.tipAutomobil.denumire.Equals(cb_tip_auto.Text))
				{
					cb_automobil.Items.Add(auto.nrInmatriculare);
				}
			});
		}

		private void addAutoCompleteStrings()
		{
			AutoCompleteStringCollection acsc_tip_auto = new AutoCompleteStringCollection();
			AutoCompleteStringCollection acsc_auto = new AutoCompleteStringCollection();

			automobile = new Automobile().getAll();
			automobile.ForEach(automobil =>
			{
				cb_automobil.Items.Add(automobil.nrInmatriculare);
				acsc_auto.Add(automobil.nrInmatriculare);
			});
			
			new TipAutomobil().getAll().ForEach(tip_auto =>
			{
				cb_tip_auto.Items.Add(tip_auto.denumire);
				acsc_tip_auto.Add(tip_auto.denumire);
			});

			cb_automobil.AutoCompleteMode = AutoCompleteMode.Suggest;
			cb_automobil.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cb_automobil.AutoCompleteCustomSource = acsc_auto;
			
			cb_tip_auto.AutoCompleteMode = AutoCompleteMode.Suggest;
			cb_tip_auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cb_tip_auto.AutoCompleteCustomSource = acsc_tip_auto;

			addClockItems();
		}
		
		
		private void addClockItems()
		{
			//TODO: Replace cmBox with textbox 
			cb_ora.MaxDropDownItems = 10;
			
			DateTime item = DateTime.Today.AddHours(5); // 14:00:00
			while(item <= DateTime.Today.AddHours(22)) // 16:00:00
			{
				cb_ora.Items.Add(item.TimeOfDay.ToString(@"hh\:mm"));
				item = item.AddMinutes(10);
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void cb_traseu_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cb_automobil_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void cb_ora_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void cb_loc_inceput_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void AddCursa_Load(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void txt_id_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_primary_add_Click(object sender, EventArgs e)
		{

		}

		private void btn_delete_Click(object sender, EventArgs e)
		{

		}
	}
}
