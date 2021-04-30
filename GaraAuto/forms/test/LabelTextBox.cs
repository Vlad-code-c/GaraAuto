using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraAuto.forms.test
{
	public class LabelTextBox
	{
		public Label label { get; set; } 
		public TextBox txt { get; set; } 

		public LabelTextBox(Label label, TextBox textBox)
		{
			this.label = label;
			this.txt = textBox;
		}

	}
}
