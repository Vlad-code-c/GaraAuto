using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraAuto.forms.commonUserControls
{
	public partial class ControlBarButtons : UserControl
	{
		private Form form;
		private Cursor initialCursor;
		public ControlBarButtons()
		{
			InitializeComponent();
			close.Click += Close_Click;
			minimalize.Click += Minimalize_Click;
		}

		private void Minimalize_Click(object sender, EventArgs e)
		{
			Form form = this.ParentForm;
			form.WindowState = FormWindowState.Minimized;
		}

		private void Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
