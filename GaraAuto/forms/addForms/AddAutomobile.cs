using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.addForms
{
    public partial class AddAutomobile : Form
    {
        private List<Automobile> automobile = new List<Automobile>();
        private bool exists = false;
        private bool tipAutoIsSelected = false;
        private bool isValid = false;

        public AddAutomobile()
        {
            InitializeComponent();

            new Thread(() => { automobile = new Automobile().getAll(); }).Start();


            addAutoCompleteStrings();

            btn_delete.Visible = false;
            
            txt_nrInmatriculare.TextChanged += (o, s) =>
            {
                checkIfExists();
                validateTextbox();
                readFromDb();
            };
            cb_tipAutomobil.SelectedValueChanged += cb_tipAutomobilOnSelectedValueChanged;

        }

        private void cb_tipAutomobilOnSelectedValueChanged(object sender, EventArgs e)
        {
            tipAutoIsSelected = true;
            pb_tip_auto.Image = DefaultProperties.iconTrueImage;
            cb_tipAutomobil.SelectedValueChanged -= cb_tipAutomobilOnSelectedValueChanged;
        }

        private void readFromDb()
        {
            Automobile automobil = automobile.FirstOrDefault(auto => auto.nrInmatriculare == txt_nrInmatriculare.Text);

            if (automobil == null)
            {
                
                return;
            }

            for (int i = 0; i < cb_tipAutomobil.Items.Count; i++)
            {
                if ((string) cb_tipAutomobil.Items[i] == automobil.tipAutomobil.denumire)
                {
                    cb_tipAutomobil.SelectedIndex = i;
                    return;
                }
            }
        }
        
        private void checkIfExists()
        {
            Automobile firstOrDefault =
                automobile.FirstOrDefault(auto => auto.nrInmatriculare == txt_nrInmatriculare.Text);
            
            if (firstOrDefault != null)
            {
                btn_delete.Visible = true;
                btn_primary_add.BackColor = DefaultProperties.defaultInfoButtonColor;
                btn_primary_add.Image = DefaultProperties.buttonInfoWhiteImage;
                btn_primary_add.Text = "Update";
                exists = true;
            }
            else
            {
                btn_delete.Visible = false;
                btn_primary_add.BackColor = DefaultProperties.defaultPrimaryButtonColor;
                btn_primary_add.Image = DefaultProperties.buttonPrimaryWhiteImage;
                btn_primary_add.Text = "Adauga";
                exists = false;
            }
            
        }

        private void validateTextbox()
        {
            if (Validator.isValidNrInmatriculare(txt_nrInmatriculare.Text))
            {
                pb_nr_inmatric.Image = DefaultProperties.iconTrueImage;
                isValid = true;
            }
            else
            {
                pb_nr_inmatric.Image = DefaultProperties.iconFalseImage;
                isValid = false;
            }
        }

        private void btn_primary_add_Click(object sender, EventArgs e)
        {
            if (!(isValid && tipAutoIsSelected))
            {
                MessageBox.Show("Datele setate nu sunt valide");
                return;
            }
            
            if (exists)
            {
                TipAutomobil tip_upd = new TipAutomobil()
                {
                    denumire = cb_tipAutomobil.Text
                };
                tip_upd.read();

                Automobile automobil_upd = new Automobile()
                {
                    nrInmatriculare = txt_nrInmatriculare.Text,
                    tipAutomobil = tip_upd
                };
                automobil_upd.update();
                
                return;
            }

            TipAutomobil tip = new TipAutomobil()
            {
                denumire = cb_tipAutomobil.Text
            };
            tip.read();

            if (tip.id == -1)
            {
                DialogResult dialogResult = MessageBox.Show("Tipul introdus nu exista. Doriti sa il creati?", "Error",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.Yes)
                {
                    AddTipAutomobil addTipAutomobil = new AddTipAutomobil(true, cb_tipAutomobil.Text);
                    addTipAutomobil.Show();
                }
                else
                {
                    return;
                }
            }


            Automobile automobil = new Automobile()
            {
                nrInmatriculare = txt_nrInmatriculare.Text,
                tipAutomobil = tip
            };
            automobil.create();

            automobile.Add(automobil);
            checkIfExists();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Automobile automobil_upd = new Automobile()
            {
                nrInmatriculare = txt_nrInmatriculare.Text
            };

            automobil_upd.delete();
            
            automobile.Remove(
                automobile.Find(auto => auto.nrInmatriculare.Equals(automobil_upd.nrInmatriculare)));

            checkIfExists();
        }

        private void addAutoCompleteStrings()
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();

            TipAutomobil tipAuto = new TipAutomobil();
            List<TipAutomobil> tipuri = tipAuto.getAll();

            tipuri.ForEach(tip =>
            {
                acsc.Add(tip.denumire);
                cb_tipAutomobil.Items.Add(tip.denumire);
            });

            cb_tipAutomobil.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_tipAutomobil.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cb_tipAutomobil.AutoCompleteCustomSource = acsc;
        }
    }
    
}