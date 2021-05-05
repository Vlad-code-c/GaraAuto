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
	public partial class AddTipAutomobil : Form
	{
		private bool closeAfter;
		
		public AddTipAutomobil(bool closeAfter = false, string name = "")
		{
			InitializeComponent();
			this.closeAfter = closeAfter;
			txt_denumire.Text = name;
		}



		private void btn_primary_add_Click(object sender, EventArgs e)
		{
			TipAutomobil tipAutomobil = new TipAutomobil()
			{
				denumire = txt_denumire.Text,
				nrLocuri = (int) numericUpDown1.Value
			};
			tipAutomobil.create();

			if (closeAfter)
			{
				this.Close();
			}
		}
	}
}
