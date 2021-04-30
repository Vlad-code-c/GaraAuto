using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GaraAuto.forms.formGenerator;

namespace GaraAuto.forms.test
{
    public partial class TestMainForm : Form
    {
        public TestMainForm()
        {
            InitializeComponent();

            
            
            Form fgb = new FormBuilder().Create()
                .SetControls(forRaion())
                .SetBackgroundColor(Color.FromArgb(108, 128, 153))
                .SetButtonForeground(Color.White)
                .SetButtonBackground(Color.FromArgb(247, 151, 32))
                .SetPanel(panel1)
                .SetSendEvent(() => { MessageBox.Show("Something"); })
                .Build();

            fgb.TopLevel = false;
            panel1.Controls.Add(fgb);
            fgb.BringToFront();
            fgb.Show();
        }

        private List<LabelInput> forRaion()
        {
            return null;
        }
        private List<LabelInput> getControls(List<KeyValuePair<InputType, string>> columns, List<List<string>> comboboxItems)
        {
            List<LabelInput> controls = new List<LabelInput>();
            int combobox_index = 0;
            
            for (var i = 0; i < columns.Count; i++)
            {
                string name = columns[i].Value;

                Label label = new Label()
                {
                    Name = name,
                    Text = name,
                    Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
                };

                Control control = null;

                switch (columns[i].Key)
                {
                    case InputType.LABEL:
                        control = new Label()
                        {
                            Name = "label_" + name.Replace(" ", "_"),
                            Text = name,
                            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
                        };
                        break;
                    
                    case InputType.TEXTBOX:
                        control = new TextBox
                        {
                            Name = "input_" + name,
                            Text = "",
                            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
                        };
                        break;
                    
                    case InputType.CHECKBOX:
                        control = new CheckBox()
                        {
                            Name = "checkbox_" + name,
                            Text = "",
                            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point),
                            Checked = false
                        };
                        break;
                    
                    case InputType.COMBOBOX:
                        control = new ComboBox()
                        {
                            Name = "combobox_" + name,
                            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
                        };

                        if (comboboxItems.Count > 0 && combobox_index < comboboxItems.Count)
                        {
                            ((ComboBox) control).Items.AddRange(comboboxItems[combobox_index].ToArray());
                            combobox_index++;
                        }
                        break;
                }

                controls.Add(new LabelInput(label, control, 100));
            }

            return controls;


        }
    }
}