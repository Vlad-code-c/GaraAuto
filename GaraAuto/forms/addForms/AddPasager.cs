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
	public partial class AddPasager : Form
	{
		public AddPasager()
		{
			InitializeComponent();
			
			txt_idnp.KeyPress += txt_idnpOnKeyPress;
			btn_primary_add.Click += btn_primary_addOnClick;
		}

		private void btn_primary_addOnClick(object sender, EventArgs e)
		{
			Pasager pasager = new Pasager()
			{
				idnp = Convert.ToInt64(txt_idnp.Text),
				nume_prenume = txt_name.Text + " " + txt_surname.Text,
				birth_year = (int) numericUpDown1.Value
			};
			pasager.create();
		}

		private void txt_idnpOnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
			{
				
			}
			else
			{
				e.Handled = true;
			}

		}

		private void btn_primary_add_Click(object sender, EventArgs e)
		{

		}

		private void btn_delete_Click(object sender, EventArgs e)
		{

		}
	}
}
