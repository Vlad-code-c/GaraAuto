using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GaraAuto.forms.formGenerator
{
    public class FormBuilder : IFormGenerator
    {
        private FormGenerator _formGenerator;
        
        public FormBuilder()
        {
            Create();
        }

        public FormBuilder Create()
        {
            this._formGenerator = new FormGenerator();
            return this;
        }

        public FormBuilder SetControls(List<LabelInput> controlsList)
        {
            this._formGenerator.ControlsList = controlsList;
            return this;
        }

        public FormBuilder AddControl(LabelInput control)
        {
            this._formGenerator.ControlsList.Add(control);
            return this;
        }

        public FormBuilder RemoveControl(LabelInput control)
        {
            this._formGenerator.ControlsList.Remove(control);
            return this;
        }

        public FormBuilder SetBackgroundColor(Color color)
        {
            this._formGenerator.BackColorProperty = color;
            return this;
        }

        public FormBuilder SetButtonBackground(Color color)
        {
            this._formGenerator.ButtonBackgroundProperty = color;
            return this;
        }

        public FormBuilder SetButtonForeground(Color color)
        {
            this._formGenerator.ButtonForegroundProperty = color;
            return this;
        }

        public FormBuilder SetPanel(Panel panel)
        {
            this._formGenerator.Panel = panel;
            return this;
        }

        public FormBuilder SetSendEvent(SendDataEventHandler sendDataEventHandler)
        {
            this._formGenerator.SendData += sendDataEventHandler;
            return this;
        }

        public FormBuilder RemoveSendEvent(SendDataEventHandler sendDataEventHandler)
        {
            this._formGenerator.SendData -= sendDataEventHandler;
            return this;
        }
        
        public Form Build()
        {
            return this._formGenerator.GenerateHorizontalLayout();
        }

    }
}