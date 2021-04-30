using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GaraAuto.forms.formGenerator
{
    public interface IFormGenerator
    {
        FormBuilder Create();
        FormBuilder SetControls(List<LabelInput> controlsList);
        FormBuilder AddControl(LabelInput control);
        FormBuilder RemoveControl(LabelInput control);
        FormBuilder SetBackgroundColor(Color color);
        FormBuilder SetButtonBackground(Color color);
        FormBuilder SetButtonForeground(Color color);
        FormBuilder SetPanel(Panel panel);
        public FormBuilder SetSendEvent(SendDataEventHandler sendDataEventHandler);
        public FormBuilder RemoveSendEvent(SendDataEventHandler sendDataEventHandler);
        Form Build();

    }
}
