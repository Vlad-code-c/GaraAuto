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
	public partial class addLocalitate : Form
	{
		public addLocalitate()
		{
			InitializeComponent();
			btn_primary_add.MouseHover += (o, s) => {
				Color color = btn_primary_add.BackColor;
				btn_primary_add.BackColor = btn_primary_add.ForeColor;
				btn_primary_add.ForeColor = color;
				
				btn_primary_add.Image = GaraAuto.Properties.Resources.next_white1;
			};
			btn_primary_add.MouseLeave += (o, s) => {
				Color color = btn_primary_add.BackColor;
				btn_primary_add.BackColor = btn_primary_add.ForeColor;
				btn_primary_add.ForeColor = color;

				btn_primary_add.Image = GaraAuto.Properties.Resources.next_black;
			};

			btn_primary_add.Click += new EventHandler(btn_clicked);

			addAutoCompleteStrings();
		}

		private void btn_clicked(object sender, EventArgs e)
		{
			Raion raion = new Raion();
			raion.Nume = txt_raion.Text;
			raion.create();

			Localitate localitate = new Localitate();
			localitate.name = txt_localitate.Text;
			localitate.raion = raion;
			localitate.create();
		}

		public void addAutoCompleteStrings()
		{
			AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
			
			new Raion().getAll().ForEach(r => acsc.Add(r.Nume));

			txt_raion.AutoCompleteMode = AutoCompleteMode.Suggest;
			txt_raion.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txt_raion.AutoCompleteCustomSource = acsc;
		}
		
		private void txt_localitate_TextChanged(object sender, EventArgs e)
		{

		}

		private void txt_raion_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_primary_add_Click(object sender, EventArgs e)
		{

		}

		private void addLocalitate_Load(object sender, EventArgs e)
		{

		}

		private void btn_delete_Click(object sender, EventArgs e)
		{

		}
	}
}
