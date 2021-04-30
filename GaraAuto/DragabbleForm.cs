using System.Drawing;
using System.Windows.Forms;

namespace GaraAuto
{
    public class DraggableForm : Form
    {
        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving

        private Form form;



        public void init(Form form, Control control)
        {
            this.form = form;
            
            // form.FormBorderStyle = FormBorderStyle.None; // get rid of the standard title bar


            control.MouseDown += new MouseEventHandler(Title_MouseDown);
            control.MouseUp += new MouseEventHandler(Title_MouseUp);
            control.MouseMove += new MouseEventHandler(Title_MouseMove);
		
        }

	

		void Title_MouseUp(object sender, MouseEventArgs e)
        {
			this.drag = false;

            form.Cursor = new Cursor("../../../images/cursors/circle_75_25x25.cur");
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;

            form.Cursor = new Cursor("../../../images/cursors/circle_dark_50_25x25.cur");
        }

        void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = form.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                    p2.Y - this.startPoint.Y);
                form.Location = p3;
            }
        }

    }
}