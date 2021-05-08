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
    public partial class AddTipAutomobil : Form
    {
        private List<TipAutomobil> tipuri = new List<TipAutomobil>();
        private bool isIdValid = false;
        private bool isDenumValid = false;

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
            checkIfExists();
        }


        private void txt_idOnTextChanged(object sender, EventArgs e)
        {
            checkIfExists();
        }

        private void checkIfExists()
        {
            if (Validator.isValidDenumireTipAuto(txt_denumire.Text))
            {
                isDenumValid = true;
                pb_denumire.Image = DefaultProperties.iconTrueImage;
            }
            else
            {
                pb_denumire.Image = DefaultProperties.iconFalseImage;
                isDenumValid = false;
            }


            if (tipuri.FirstOrDefault(tip => tip.id.ToString() == txt_id.Text) != null)
            {
                btn_delete.Visible = true;
                btn_primary_add.BackColor = DefaultProperties.defaultInfoButtonColor;
                btn_primary_add.Image = DefaultProperties.buttonInfoWhiteImage;
                btn_primary_add.Text = "Update";
                isIdValid = false;
            }
            else
            {
                btn_delete.Visible = false;
                btn_primary_add.BackColor = DefaultProperties.defaultPrimaryButtonColor;
                btn_primary_add.Image = DefaultProperties.buttonPrimaryWhiteImage;
                btn_primary_add.Text = "Adauga";
                isIdValid = true;
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
            if (tipuri.FirstOrDefault(tip => tip.id.ToString() == txt_id.Text) != null)
            {
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
            tipuri.Add(tipAutomobil);

            checkIfExists();

            if (closeAfter)
            {
                this.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (isIdValid) return;

            TipAutomobil tipAutomobil_upd = new TipAutomobil()
            {
                id = Convert.ToInt32(txt_id.Text)
            };
            tipAutomobil_upd.delete();
        }
    }
}