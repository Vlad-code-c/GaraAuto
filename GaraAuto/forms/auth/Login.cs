using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GaraAuto.db.objects;
using GaraAuto.forms.main;

namespace GaraAuto.forms.auth
{
    public partial class Login : Form
    {
        public Login()
        {
	        new User();
	        if (User.currenLoggedUser != null)
	        {
		        showMainPage();
	        }
	        
            InitializeComponent();

			this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
			panelControlBar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelControlBar.Width, panelControlBar.Height, 5, 5));
		
			
			btn_login.Click += btn_loginOnClick;
			pb_show.MouseEnter += pb_showOnMouseEnter;
			pb_show.MouseLeave += pb_showOnMouseLeave;
        }

        private void pb_showOnMouseLeave(object sender, EventArgs e)
        {
	        pb_show.Image = DefaultProperties.symb_hide_pass;
	        txt_password.PasswordChar = '*';
        }

        private void pb_showOnMouseEnter(object sender, EventArgs e)
        {
	        pb_show.Image = DefaultProperties.symb_show_pass;
	        txt_password.PasswordChar = char.Parse("\0");
        }

        private void btn_loginOnClick(object sender, EventArgs e)
        {
	        if (!validateLoginForm())
	        {
		        MessageBox.Show("Datele introduse nu sunt corecte");
		        return;
	        }
	        
	        User user = new User()
	        {
		        email = txt_email.Text,
		        Password = txt_password.Text,
		        keepIn = ck_keepIn.Checked
	        };
	        user.read();

	        if (User.currenLoggedUser != null)
	        {
		        showMainPage();
	        }
	        else
	        {
		        MessageBox.Show("Email-ul sau parola sunt incorecte!");
	        }
        }

        private void showMainPage()
        {
	        MainActionPage mainForm = new MainActionPage();
	        mainForm.Shown += (o, args) =>
	        {
		        Hide();
	        };
	        mainForm.Show();
        }

        private bool validateLoginForm()
        {
	        if (!Validator.isValidEmail(txt_email.Text))
	        {
		        return false;
	        }

	        if (!Validator.isValidPassword(txt_password.Text))
	        {
		        return false;
	        }

	        return true;
        }

        private void label_register_Click(object sender, EventArgs e)
        {
	        Register register = new Register();
	        register.Shown += (o, args) =>
	        {
				this.Hide();
	        };
	        register.Show();
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

	}
}