using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using GaraAuto.db.objects;

namespace GaraAuto.forms.addForms
{
    public partial class AddCursa : Form
    {
        private List<Automobile> automobile = new List<Automobile>();
        private List<TipAutomobil> tipuri = new List<TipAutomobil>();
        private List<Cursa> curse = new List<Cursa>();
        private bool exists = false;
        private bool isTraseuValid = false;
        private bool isCarValid = false;
        private Traseu SelectedTraseu;

        public AddCursa()
        {
            InitializeComponent();

            new Thread(() => curse = new Cursa().getAll()).Start();

            cb_tip_auto.SelectedValueChanged += cb_tip_automobilOnSelectedValueChanged;
            cb_automobil.SelectedValueChanged += cb_automobilOnSelectedValueChanged;
            textBox1.Click += textBox1OnClick;

            btn_delete.Visible = false;

            addAutoCompleteStrings();
        }

        private void cb_automobilOnSelectedValueChanged(object sender, EventArgs e)
        {
            isCarValid = true;
        }

        private void textBox1OnClick(object sender, EventArgs e)
        {
            SelectTraseu st = new SelectTraseu();

            st.Closed += (o, args) =>
            {
                SelectedTraseu = st.SelectedTraseu;
                textBox1.Text = SelectedTraseu.denumire;
                isTraseuValid = true;

                pb_traseu.Image = DefaultProperties.iconTrueImage;
            };
            st.ShowDialog();
        }

        private void cb_tip_automobilOnSelectedValueChanged(object sender, EventArgs e)
        {
            cb_automobil.Items.Clear();
            cb_automobil.Text = "";
            automobile.ForEach(auto =>
            {
                if (auto.tipAutomobil.denumire.Equals(cb_tip_auto.Text))
                {
                    cb_automobil.Items.Add(auto.nrInmatriculare);
                }
            });
        }

        private void addAutoCompleteStrings()
        {
            AutoCompleteStringCollection acsc_tip_auto = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acsc_auto = new AutoCompleteStringCollection();

            automobile = new Automobile().getAll();
            automobile.ForEach(automobil =>
            {
                cb_automobil.Items.Add(automobil.nrInmatriculare);
                acsc_auto.Add(automobil.nrInmatriculare);
            });

            tipuri = new TipAutomobil().getAll();
            tipuri.ForEach(tip_auto =>
            {
                cb_tip_auto.Items.Add(tip_auto.denumire);
                acsc_tip_auto.Add(tip_auto.denumire);
            });

            cb_automobil.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_automobil.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cb_automobil.AutoCompleteCustomSource = acsc_auto;

            cb_tip_auto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_tip_auto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cb_tip_auto.AutoCompleteCustomSource = acsc_tip_auto;
        }


        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            checkIfExists();
        }

        private void checkIfExists()
        {
            Cursa cursa = curse.FirstOrDefault(curs => curs.id_cursa.ToString() == txt_id.Text);
            if (cursa != null)
            {
                exists = true;
                btn_delete.Visible = true;
                btn_primary_add.Text = DefaultProperties.btn_update_text;
                btn_primary_add.BackColor = DefaultProperties.defaultInfoButtonColor;
                btn_primary_add.Image = DefaultProperties.buttonInfoWhiteImage;
                writeFromDb();
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
            Cursa cursa = curse.FirstOrDefault(curs => curs.id_cursa.ToString() == txt_id.Text);
            if (cursa != null)
            {
                isTraseuValid = true;
                textBox1.Text = cursa.traseu.denumire;

                nud_ora.Value = Convert.ToDecimal(cursa.ora.Split(':')[0]);
                nud_minute.Value = Convert.ToDecimal(cursa.ora.Split(':')[1]);

                for (var i = 0; i < cb_tip_auto.Items.Count; i++)
                    if (cb_tip_auto.Items[i].ToString() == cursa.Automobile.tipAutomobil.denumire)
                        cb_tip_auto.SelectedIndex = i;

                for (var i = 0; i < cb_automobil.Items.Count; i++)
                    if (cb_automobil.Items[i].ToString() == cursa.Automobile.nrInmatriculare)
                        cb_automobil.SelectedIndex = i;
                
                SelectedTraseu = cursa.traseu;
            }
            else
            {
                isTraseuValid = false;
                nud_ora.Value = 8;
                nud_minute.Value = 0;
                cb_tip_auto.SelectedIndex = 0;
                textBox1.Text = "Selecteaza";
                cb_automobil.SelectedIndex = 0;
            }
        }


        private void btn_primary_add_Click(object sender, EventArgs e)
        {
            if (isCarValid && isTraseuValid)
            {
                TipAutomobil tip = tipuri.Find(tip => tip.denumire == cb_tip_auto.Text);


                Automobile automobil = automobile.Find(auto => auto.nrInmatriculare == cb_automobil.Text);


                Cursa cursa = new Cursa()
                {
                    Automobile = automobil,
                    traseu = SelectedTraseu,
                    ora = nud_ora.Value + ":" + nud_minute.Value
                };
                
                if (!exists) cursa.create();
                else
                {
                    cursa.id_cursa = Convert.ToInt32(txt_id.Text);
                    cursa.update();
                }

                txt_id.Text = cursa.id_cursa.ToString();

                curse.RemoveAll(curs => curs.id_cursa == cursa.id_cursa);
                curse.Add(cursa);
                checkIfExists();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Cursa cursa = new Cursa()
            {
                id_cursa = Convert.ToInt32(txt_id.Text)
            };
            
            cursa.delete();

            curse.RemoveAll(curs => curs.id_cursa == cursa.id_cursa);
            checkIfExists();
        }
    }
}