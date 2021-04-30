using GaraAuto.forms.addForms;
using GaraAuto.forms.main;
using GaraAuto.forms.test;
using System;
using System.Windows.Forms;

namespace GaraAuto
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new addLocalitate());
		}
	}
}
