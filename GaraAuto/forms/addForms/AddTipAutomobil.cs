using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.addForms
{
    public partial class AddTipAutomobil : Form
    {
        private List<TipAutomobil> tipuri = new List<TipAutomobil>();
        private bool isValid = false;
        private bool isIdValid = false;
        private bool exists = false;
        
        private bool closeAfter;

        public AddTipAutomobil(bool closeAfter = false, string name = "")
        {
            InitializeComponent();

            // tooltip_help.SetToolTip(pictureBox3, "Id-ul va fi folosit pentru a actualiza sau sterge datele");

            new Thread(() => { tipuri = new TipAutomobil().getAll(); }).Start();

            this.closeAfter = closeAfter;
            txt_denumire.Text = name;
            btn_delete.Visible = false;

            txt_id.TextChanged += txt_idOnTextChanged;
            txt_id.KeyPress += Txt_idOnKeyPress;

            txt_denumire.TextChanged += txt_denumireOnTextChanged;
        }

        private void txt_denumireOnTextChanged(object sender, EventArgs e)
        {
            validateTextBox();
        }


        private void txt_idOnTextChanged(object sender, EventArgs e)
        {
            checkIfExists();
        }

        private void checkIfExists()
        {
            TipAutomobil tipAutomobil = tipuri.FirstOrDefault(tip => tip.id.ToString() == txt_id.Text);

            if (tipAutomobil != null)
            {
                btn_delete.Visible = true;
                btn_primary_add.BackColor = DefaultProperties.defaultInfoButtonColor;
                btn_primary_add.Image = DefaultProperties.buttonInfoWhiteImage;
                btn_primary_add.Text = "Update";
                exists = true;
                
                txt_denumire.Text = tipAutomobil.denumire;
                numericUpDown1.Value = tipAutomobil.nrLocuri;
            }
            else
            {
                btn_delete.Visible = false;
                btn_primary_add.BackColor = DefaultProperties.defaultPrimaryButtonColor;
                btn_primary_add.Image = DefaultProperties.buttonPrimaryWhiteImage;
                btn_primary_add.Text = "Adauga";
                exists = false;
            }

            validateTextBox();
        }

        private void validateTextBox()
        {
            if (Validator.isValidDenumireTipAuto(txt_denumire.Text))
            {
                pb_denumire.Image = DefaultProperties.iconTrueImage;
                isValid = true;
            }
            else
            {
                pb_denumire.Image = DefaultProperties.iconFalseImage;
                isValid = false;
            }
        }

        private void Txt_idOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = true;
            }
        }


        private void btn_primary_add_Click_1(object sender, EventArgs e)
        {
            if (exists)
            {
                if (!isValid) return;
                
                TipAutomobil tipAutomobil_upd = new TipAutomobil()
                {
                    id = Convert.ToInt32(txt_id.Text),
                    denumire = txt_denumire.Text,
                    nrLocuri = (int) numericUpDown1.Value
                };
                tipAutomobil_upd.update();
                return;
            }

            TipAutomobil tipAutomobil = new TipAutomobil()
            {
                denumire = txt_denumire.Text,
                nrLocuri = (int) numericUpDown1.Value
            };
            tipAutomobil.create();
            txt_id.Text = tipAutomobil.id.ToString();
            tipuri.Add(tipAutomobil);

            checkIfExists();

            if (closeAfter)
            {
                this.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            TipAutomobil tipAutomobil_upd = new TipAutomobil()
            {
                id = Convert.ToInt32(txt_id.Text)
            };
            tipAutomobil_upd.delete();

            tipuri.RemoveAll(tip => tip.id == tipAutomobil_upd.id);
            checkIfExists();
        }

		private void AddTipAutomobil_Load(object sender, EventArgs e)
		{

		}
	}
}