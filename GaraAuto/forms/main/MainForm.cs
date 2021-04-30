using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GaraAuto.forms.main
{
	public partial class MainForm : DraggableForm
	{
		private int formLeft_x = -450;
		private int formRight_x = 900;
		
		public MainForm()
		{
			InitializeComponent();

			this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
			panelControlBar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelControlBar.Width, panelControlBar.Height, 5, 5));

			base.init(this, panelControlBar);
			
			this.Cursor = new Cursor("../../../images/cursors/circle_75_25x25.cur");
		}


		private void MainForm_Load(object sender, System.EventArgs e)
		{

		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (formLeft_x >= -5) timer1.Stop();

			formLeft_x += 5;
			formRight_x -= 5;

			mainFormLeftSide1.Location = new System.Drawing.Point(formLeft_x, mainFormLeftSide1.Location.Y);
			mainFormRightSide1.Location = new System.Drawing.Point(formRight_x, mainFormRightSide1.Location.Y);
		}


		//https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms#18822204
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // width of ellipse
			int nHeightEllipse // height of ellipse
		);

		private void controlBarButtons1_Load(object sender, EventArgs e)
		{

		}
	}
}