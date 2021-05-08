using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.addForms
{
	public partial class OcupaLoc : Form
	{
		private List<Pasager> pasageri = new List<Pasager>();
		private Cursa SelectedCursa;
		public OcupaLoc()
		{
			InitializeComponent();
			txt_cursa.Click += txt_cursa_Click;
		}

		private void txt_cursa_Click(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				Thread.CurrentThread.IsBackground = true;
				pasageri = new Pasager().getAll();
			}).Start();
			
			SelectCursa sc = new SelectCursa();
			sc.Closed += (o, args) =>
			{
				SelectedCursa = sc.selectedCursa;
				txt_cursa.Text = sc.selectedCursa.traseu.denumire;
			};
			sc.ShowDialog();
		}


		private void txt_cursa_TextChanged(object sender, EventArgs e)
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
