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
	public partial class AddTraseu : Form
	{
		public AddTraseu()
		{
			InitializeComponent();

			addAutoCompleteStrings();
			cb_start.TextChanged += cb_OnTextChanged;
			cb_finish.TextChanged += cb_OnTextChanged;
			btn_primary_add.Click += btn_primary_addOnClick;

		}

		private void btn_primary_addOnClick(object sender, EventArgs e)
		{
			Traseu traseu = new Traseu();
			Localitate localitate = new Localitate()
			{
				name = cb_start.Text
			};
			localitate.read();

			Localitate localitate_end = new Localitate()
			{
				name = cb_finish.Text
			};
			localitate_end.read();

			traseu.localitate_inceput = localitate;
			traseu.localitate_sfarsit = localitate_end;

			traseu.distanta = Convert.ToInt32(customNumericUpDown1.Value.ToString().Replace(" km", ""));
			
			traseu.create();
		}

		private void cb_OnTextChanged(object sender, EventArgs e)
		{
			txt_denumire.Text = cb_start.Text + " - " + cb_finish.Text;
		}

		private void addAutoCompleteStrings()
		{
			AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();

			Localitate localitate = new Localitate();
			List<Localitate> localits = localitate.getAll();
			
			localits.ForEach(localit =>
			{
				acsc.Add(localit.name);
				cb_start.Items.Add(localit.name);
				cb_finish.Items.Add(localit.name);
			});

			cb_start.AutoCompleteMode = AutoCompleteMode.Suggest;
			cb_start.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cb_start.AutoCompleteCustomSource = acsc;
			
			cb_finish.AutoCompleteMode = AutoCompleteMode.Suggest;
			cb_finish.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cb_finish.AutoCompleteCustomSource = acsc;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txt_denumire_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
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
