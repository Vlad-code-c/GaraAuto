using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.addForms
{
	public partial class addLocalitate : Form
	{
		private List<Localitate> localitati = new List<Localitate>();
		private List<Raion> raioane = new List<Raion>();
		private bool exists = false;
		private bool isLocalitNameValid = false;

		public addLocalitate()
		{
			InitializeComponent();

			new Thread(() =>
			{
				localitati = new Localitate().getAll();
			}).Start();

			btn_delete.Visible = false;
			
			addAutoCompleteStrings();
		}
		

		private void addAutoCompleteStrings()
		{
			AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();

			raioane = new Raion().getAll();
			raioane.ForEach(r =>
			{
				cb_raion.Items.Add(r.Nume);
				acsc.Add(r.Nume);
			});

			cb_raion.AutoCompleteMode = AutoCompleteMode.Suggest;
			cb_raion.AutoCompleteSource = AutoCompleteSource.CustomSource;
			cb_raion.AutoCompleteCustomSource = acsc;

			cb_raion.SelectedIndex = 0;
		}

		private void checkIfExists()
		{
			Localitate localitate = localitati.FirstOrDefault(localit => localit.id.ToString() == txt_id.Text);

			if (localitate != null)
			{
				exists = true;
				btn_delete.Visible = true;
				btn_primary_add.Text = DefaultProperties.btn_update_text;
				btn_primary_add.BackColor = DefaultProperties.defaultInfoButtonColor;
				btn_primary_add.Image = DefaultProperties.buttonInfoWhiteImage;
			}
			else
			{
				exists = false;
				btn_delete.Visible = false;
				btn_primary_add.Text = DefaultProperties.btn_add_text;
				btn_primary_add.BackColor = DefaultProperties.defaultPrimaryButtonColor;
				btn_primary_add.Image = DefaultProperties.buttonPrimaryWhiteImage;				
			}
		}

		private void writeFromDb()
		{
			Localitate localitate = localitati.FirstOrDefault(localit => localit.id.ToString() == txt_id.Text);
			if (localitate != null)
			{
				txt_localitate.Text = localitate.name;
				foreach (object item in cb_raion.Items)
				{
					if (((string) item).Equals(localitate.raion.Nume))
					{
						cb_raion.SelectedIndex = cb_raion.Items.IndexOf(item);
						break;
					}
				}
			}
			else
			{
				cb_raion.SelectedIndex = 0;
				txt_localitate.Text = "";
			}
		}
		
		private void txt_idOnTextChanged(object sender, EventArgs e)
		{
			checkIfExists();
			writeFromDb();
		}
		
		
		private void txt_localitate_TextChanged(object sender, EventArgs e)
		{
			if (Validator.isValidDenumireLocalitate(txt_localitate.Text))
			{
				pb_localitate.Image = DefaultProperties.iconTrueImage;
				isLocalitNameValid = true;
			}
			else
			{
				pb_localitate.Image = DefaultProperties.iconFalseImage;
				isLocalitNameValid = false;
			}
		}

		

		private void btn_primary_add_Click(object sender, EventArgs e)
		{
			if (isLocalitNameValid)
			{
				if (exists)
				{
					update();
				}
				else
				{
					create();
				}
			}
		}
		
		private void btn_delete_Click(object sender, EventArgs e)
		{
			Localitate localitate = new Localitate()
			{
				id = Convert.ToInt32(txt_id.Text)
			};
			localitate.delete();

			localitati.RemoveAll(localit => localit.id.ToString() == txt_id.Text);
			checkIfExists();
		}


		private void create()
		{
			Raion raion = raioane.Find(raion => raion.Nume.Equals(cb_raion.Text));

			Localitate localitate = new Localitate();
			localitate.name = txt_localitate.Text;
			localitate.raion = raion;
			localitate.create();
			
			localitati.Add(localitate);
			txt_id.Text = localitate.id.ToString();
			checkIfExists();
		}

		private void update()
		{
			Raion raion = raioane.Find(raion => raion.Nume.Equals(cb_raion.Text));

			Localitate localitate = new Localitate()
			{
				id = Convert.ToInt32(txt_id.Text),
				name = txt_localitate.Text,
				raion = raion
			};
			localitate.update();
			localitati.RemoveAll(localit => localit.id == localitate.id);
			localitati.Add(localitate);
			checkIfExists();
			writeFromDb();
		}

		
	}
}
