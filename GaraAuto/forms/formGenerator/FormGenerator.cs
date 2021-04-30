using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GaraAuto.forms.controlGenerator;

namespace GaraAuto.forms.formGenerator
{
    public delegate void SendDataEventHandler();
    public class FormGenerator : Form
    {
        public event SendDataEventHandler SendData;
        public List<LabelInput> ControlsList { get; internal set; }
        public Color BackColorProperty { get; internal set; } = DefaultBackColor;
        public Color ButtonBackgroundProperty { get; internal set; } = DefaultBackColor;
        public Color ButtonForegroundProperty { get; internal set; } = DefaultForeColor;
        public Panel Panel { get; internal set; }

        private int _currentIndex;
        private Label _currentLabel;
        private Control _currentTxt;
        private Button _btnNext;
        private Button _btnPrev;
        private Button _btnSend;

        public Form GenerateHorizontalLayout()
        {
            InitForm();
            
            if (ControlsList.Count <= 0) return null;
            
            
            this.Width = Panel.Width;
            this.Height = Panel.Height;
            int top = 0;
            int left = 0;
            
            //Determina pozitia optima pentru fiecare controller
            foreach (var controls in ControlsList)
            {
                int maxHeight = controls.input.Height > controls.label.Height
                    ? controls.input.Height
                    : controls.label.Height;
                int maxWidth = controls.input.Width + controls.label.Width + controls.gap;

                top = (Panel.Height - maxHeight) / 2;
                left = (Panel.Width - maxWidth) / 2;


                controls.label.Top = top;
                controls.input.Top = top;

                controls.label.Left = left;
                controls.input.Left = left + controls.gap + controls.label.Width;
            }

            int leftPercentage = (left / 100) * 25;
            Button btnPrev = (Button) new ControlBuilder(new Button())
                .SetLeft(left + leftPercentage)
                .SetTop(top + 50)
                .SetName("btn_prev")
                .SetText("Inapoi")
                .SetVisible(false)
                .AddClickEvent(Prev)
                .SetBackColor(ButtonBackgroundProperty)
                .SetForeColor(ButtonForegroundProperty)
                .SetFont(new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point))
                .Build();
            
            
            Button btnNext = (Button) new ControlBuilder(new Button())
                .SetLeft(Width - left - btnPrev.Width - leftPercentage)
                .SetTop(top + 50)
                .SetName("btn_next")
                .SetText("Inainte")
                .SetVisible(true)
                .AddClickEvent(Next)
                .SetBackColor(ButtonBackgroundProperty)
                .SetForeColor(ButtonForegroundProperty)
                .SetFont(new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point))
                .Build();
            
            
            Button btnSend = (Button) new ControlBuilder(new Button())
                .SetLeft(btnNext.Left)
                .SetTop(btnNext.Top)
                .SetName("btn_send")
                .SetText("Trimite")
                .SetVisible(false)
                .AddClickEvent(Send)
                .SetBackColor(Color.FromArgb(179, 136, 235))
                .SetForeColor(ButtonForegroundProperty)
                .SetFont(new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point))
                .Build();

            this.Controls.Add(btnPrev);
            this.Controls.Add(btnNext);
            this.Controls.Add(btnSend);
            
            _btnNext = btnNext;
            _btnPrev = btnPrev;
            _btnSend = btnSend;

            _currentLabel = ControlsList[0].label;
            _currentTxt = ControlsList[0].input;
            
            
            this.Controls.Add(_currentLabel);
            this.Controls.Add(_currentTxt);
            
            return this;
        }

        private void Send(object sender, EventArgs e)
        {
            SendData?.Invoke();
        }

        private void InitForm()
        {
            this.BackColor = BackColorProperty;

            this.FormBorderStyle = FormBorderStyle.None;
        }
        
        private void Next(object sender, EventArgs e)
        {
            if (_currentIndex < ControlsList.Count - 1)
            {
                this.Controls.Remove(ControlsList[_currentIndex].label);
                this.Controls.Remove(ControlsList[_currentIndex].input);
                
                _currentIndex++;
                
                this.Controls.Add(ControlsList[_currentIndex].label);
                this.Controls.Add(ControlsList[_currentIndex].input);
                
                _btnNext.Visible = true;
                _btnPrev.Visible = true;
              
                if (_currentIndex == ControlsList.Count - 1)
                {
                    _btnNext.Visible = false;
                    _btnSend.Visible = true;
                }
            } 
        }

        private void Prev(object sender, EventArgs e)
        {
            if (_currentIndex > 0)
            {
                this.Controls.Remove(ControlsList[_currentIndex].label);
                this.Controls.Remove(ControlsList[_currentIndex].input);
                
                _currentIndex--;

                this.Controls.Add(ControlsList[_currentIndex].label);
                this.Controls.Add(ControlsList[_currentIndex].input);
                
                _btnPrev.Visible = true;
                _btnNext.Visible = true;

            } else if (_currentIndex == 0)
            {
                _btnPrev.Visible = false;
            }
        }


    }
}