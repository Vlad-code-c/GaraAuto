using System.Windows.Forms;

namespace GaraAuto.forms.formGenerator
{
    public class LabelInput
    {
        public Label label { get; } 
        public Control input { get; } 
        public int gap { get; }

        public LabelInput(Label label, Control input, int gap)
        {
            this.label = label;
            this.input = input;
            this.gap = gap;
        }
    }
}