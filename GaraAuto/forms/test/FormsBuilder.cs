using System.Collections.Generic;
using System.Windows.Forms;

namespace GaraAuto.forms.test
{
	public partial class FormsBuilder : Form
	{
		private List<LabelTextBox> contr;
		private Panel panel;
		private int currentIndex = 0;

		public FormsBuilder(List<LabelTextBox> controls, Panel panel)
		{
			InitializeComponent();
			this.contr = controls;
			this.panel = panel;

			MessageBox.Show(panel.Controls.Count.ToString());

			doSomethink();
		}
	

		public void doSomethink()
		{
			this.Width = panel.Width * contr.Count;
			
			this.SuspendLayout();

			for (int i = 0; i < contr.Count; i++)
			{
				contr[i].label.Left = panel.Width * i;
				contr[i].label.Top = 50;

				Button btn_next = new Button()
				{
					Left = panel.Width * i + 150,
					Top = 200,
					Name = "button_next_" + i,
					Text = "Next_" + i
				};
				Button btn_prev = new Button()
				{
					Left = panel.Width * i,
					Top = 200,
					Name = "button_prev_" + i,
					Text = "Prev_" + i
				};

				btn_next.Click += Btn_next_Click;
				btn_prev.Click += Btn_prev_Click;

				this.Controls.Add(contr[i].label);
				this.Controls.Add(btn_prev);
				this.Controls.Add(btn_next);

				MessageBox.Show(btn_next.Left.ToString());
			}
			MessageBox.Show("Panel: " + this.Width);

			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void Btn_next_Click(object sender, System.EventArgs e)
		{
//			MessageBox.Show(this.Left - 2 * panel.Width + "");
			if (this.Left - panel.Width + this.Width > 0)
			{
				this.Left -= panel.Width;
			}
		}

		private void Btn_prev_Click(object sender, System.EventArgs e)
		{
			int width = panel.Width * contr.Count;
			
			if (this.Left + panel.Width <= 0)
			{
				this.Left += panel.Width;
			}
		}


		private Button getButton()
		{
			Button button = new Button();
			button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			button.ForeColor = System.Drawing.SystemColors.ControlText;
			button.Location = new System.Drawing.Point(218, 319);
			button.Size = new System.Drawing.Size(129, 40);
			button.TabIndex = 4;
			button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			button.UseVisualStyleBackColor = true;


			return button;
		}
	}
}
