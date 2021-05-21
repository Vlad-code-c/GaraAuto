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
    public partial class AddPasager : Form
    {
        private List<Pasager> pasageri = new List<Pasager>();
        private bool exists = false;
        private bool isNameValid = false;
        private bool isSurnameValid = false;

        public AddPasager()
        {
            InitializeComponent();

            new Thread(() => pasageri = new Pasager().getAll()).Start();

            btn_delete.Visible = false;

            txt_idnp.KeyPress += txt_idnpOnKeyPress;
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


        private void txt_idnpOnTextChanged(object sender, EventArgs e)
        {
            if (txt_idnp.Text.Length == 13)
                pb_idnp.Image = DefaultProperties.iconTrueImage;
            else
                pb_idnp.Image = DefaultProperties.iconFalseImage;

            checkIfExists();
            writeFromDb();
        }


        private void checkIfExists()
        {
            Pasager pasager = pasageri.FirstOrDefault(pasager => pasager.idnp.ToString() == txt_idnp.Text);
            if (pasager != null)
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
            Pasager pasager = pasageri.FirstOrDefault(pasager => pasager.idnp.ToString() == txt_idnp.Text);
            if (pasager != null)
            {
                txt_idnp.Text = pasager.idnp.ToString();
                txt_name.Text = pasager.nume_prenume.Split(' ')[0];
                txt_surname.Text = pasager.nume_prenume.Split(' ')[1];
                numericUpDown1.Value = pasager.birth_year;
            }
            else
            {
                txt_name.Text = "";
                txt_surname.Text = "";
                numericUpDown1.Value = 2000;
            }
        }

        private void txt_nameOnTextChanged(object sender, EventArgs e)
        {
            if (Validator.isValidPersonName(txt_name.Text))
            {
                pb_nume.Image = DefaultProperties.iconTrueImage;
                isNameValid = true;
            }
            else
            {
                pb_nume.Image = DefaultProperties.iconFalseImage;
                isNameValid = false;
            }
        }

        private void txt_surnameOnTextChanged(object sender, EventArgs e)
        {
            if (Validator.isValidPersonName(txt_surname.Text))
            {
                pb_prenume.Image = DefaultProperties.iconTrueImage;
                isSurnameValid = true;
            }
            else
            {
                pb_prenume.Image = DefaultProperties.iconFalseImage;
                isSurnameValid = false;
            }
        }


        private void btn_primary_add_Click(object sender, EventArgs e)
        {
            if (isNameValid && isSurnameValid)
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
            if (!exists) return;
            
            Pasager pasager = new Pasager()
            {
                idnp = Convert.ToInt64(txt_idnp.Text)
            };
            
            txt_idnp.Text = "";
            
            pasager.delete();
            pasageri.RemoveAll(pas => pas.idnp == pasager.idnp);
            
            checkIfExists();
            writeFromDb();
        }

        private void create()
        {
            Pasager pasager = new Pasager()
            {
                idnp = Convert.ToInt64(txt_idnp.Text),
                nume_prenume = txt_name.Text + " " + txt_surname.Text,
                birth_year = (int) numericUpDown1.Value
            };
            pasager.create();
            pasageri.Add(pasager);
            
            checkIfExists();
        }

        private void update()
        {
            Pasager pasager = new Pasager()
            {
                idnp = Convert.ToInt64(txt_idnp.Text),
                nume_prenume = txt_name.Text + " " + txt_surname.Text,
                birth_year = (int) numericUpDown1.Value
            };
            pasager.update();
            pasageri.RemoveAll(pas => pas.idnp == pasager.idnp);
            pasageri.Add(pasager);
            
            checkIfExists();
        }
    }
}