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
		private bool existsPasager;
		public OcupaLoc()
		{
			InitializeComponent();
			txt_cursa.Click += txt_cursa_Click;
			txt_pasager.TextChanged += txt_pasagerOnTextChanged;

			txt_pasagerName.Enabled = false;
			txt_pasagerName.Visible = false;
			label3.Visible = false;

		}

		private void txt_pasagerOnTextChanged(object sender, EventArgs e)
		{
			Pasager pasager = pasageri.FirstOrDefault(pasager => pasager.idnp.ToString() == txt_pasager.Text);
			if (pasager != null)
			{
				pb_pasager.Image = DefaultProperties.iconTrueImage;
				existsPasager = true;
				txt_pasagerName.Text = pasager.nume_prenume;

				txt_pasagerName.Visible = true;
				label3.Visible = true;
			}
			else
			{
				pb_pasager.Image = DefaultProperties.iconFalseImage;
				existsPasager = false;
				txt_pasagerName.Text = "";
				txt_pasagerName.Visible = false;
				label3.Visible = false;
			}
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
			pb_cursa.Image = DefaultProperties.iconTrueImage;
		}

		private void btn_primary_add_Click(object sender, EventArgs e)
		{
			if (SelectedCursa != null && existsPasager)
			{
				Pasager pasager = new Pasager()
				{
					idnp = Convert.ToInt64(txt_pasager.Text)
				};
				pasager.read();

				LocuriOcupate loc = new LocuriOcupate()
				{
					cursa = SelectedCursa,
					pasager = pasager
				};
				
				loc.create();
			}
		}
	}
}
