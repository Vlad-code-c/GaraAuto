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
    public partial class AddTraseu : Form
    {
        private List<Traseu> trasee = new List<Traseu>();
        private bool exists = false;

        public AddTraseu()
        {
            InitializeComponent();

            new Thread(() => trasee = new Traseu().getAll()).Start();

            addAutoCompleteStrings();

            btn_delete.Visible = false;
            
            cb_start.TextChanged += cb_OnTextChanged;
            cb_finish.TextChanged += cb_OnTextChanged;
            txt_id.TextChanged += txt_idOnTextChanged;
            btn_delete.Click += btn_delete_Click;
        }

        private void txt_idOnTextChanged(object sender, EventArgs e)
        {
            checkIfExists();
            writeFromDb();
        }

        private void checkIfExists()
        {
            Traseu traseu = trasee.FirstOrDefault(traseu => traseu.id_traseu.ToString() == txt_id.Text);
            if (traseu != null)
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
            Traseu traseu = trasee.FirstOrDefault(traseu => traseu.id_traseu.ToString() == txt_id.Text);
            if (traseu != null)
            {
                for (var i = 0; i < cb_start.Items.Count; i++)
                {
                    if (cb_start.Items[i].ToString() == traseu.localitate_inceput.name)
                    {
                        cb_start.SelectedIndex = i;
                    }

                    if (cb_finish.Items[i].ToString() == traseu.localitate_sfarsit.name)
                    {
                        cb_finish.SelectedIndex = i;
                    }
                }

                customNumericUpDown1.Value = traseu.distanta;
            }
            else
            {
                cb_start.SelectedIndex = 0;
                cb_finish.SelectedIndex = 0;
                customNumericUpDown1.Value = 1;
            }
        }


        private void cb_OnTextChanged(object sender, EventArgs e)
        {
            txt_denumire.Text = cb_start.Text + " - " + cb_finish.Text;
        }

        private void addAutoCompleteStrings()
        {
            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();

            Localitate localitate = new Localitate();
            List<Localitate> localits = localitate.getAll();

            localits.ForEach(localit =>
            {
                acsc.Add(localit.name);
                cb_start.Items.Add(localit.name);
                cb_finish.Items.Add(localit.name);
            });


            cb_start.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_start.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cb_start.AutoCompleteCustomSource = acsc;

            cb_finish.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_finish.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cb_finish.AutoCompleteCustomSource = acsc;

            writeFromDb();
        }


        private void btn_primary_add_Click(object sender, EventArgs e)
        {
            if (!exists)
            {
                create();
            }
            else
            {
                update();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Traseu traseu = new Traseu()
            {
                id_traseu = Convert.ToInt32(txt_id.Text)
            };
            traseu.delete();
            trasee.RemoveAll(tras => tras.id_traseu == traseu.id_traseu);

            txt_id.Text = "";
            writeFromDb();
            checkIfExists();
        }

        private void create()
        {
            Traseu traseu = new Traseu();
            Localitate localitate = new Localitate()
            {
                name = cb_start.Text
            };
            localitate.read();

            Localitate localitate_end = new Localitate()
            {
                name = cb_finish.Text
            };
            localitate_end.read();

            traseu.localitate_inceput = localitate;
            traseu.localitate_sfarsit = localitate_end;

            traseu.distanta = Convert.ToInt32(customNumericUpDown1.Value.ToString().Replace(" km", ""));

            traseu.create();

            trasee.Add(traseu);
            txt_id.Text = traseu.id_traseu.ToString();
            
            writeFromDb();
            checkIfExists();
        }

        private void update()
        {
            Localitate localitate = new Localitate()
            {
                name = cb_start.Text
            };
            localitate.read();

            Localitate localitate_end = new Localitate()
            {
                name = cb_finish.Text
            };
            localitate_end.read();

            Traseu traseu = new Traseu()
            {
                id_traseu = Convert.ToInt32(txt_id.Text),
                localitate_inceput = localitate,
                localitate_sfarsit = localitate_end,
                distanta = Convert.ToInt32(customNumericUpDown1.Value.ToString().Replace(" km", ""))
            };

            traseu.update();
        }
    }
}