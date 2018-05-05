using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ClientApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		SplashWindow sw = new SplashWindow();
		DispatcherTimer timer = null;

		public MainWindow()
		{
			if (!Models.ObslugaSplashScreen.CzySplashOdpalony)
			{
				this.Hide();
				OdpalSplasha();
			}
			InitializeComponent();
		}

		private void OdpalSplasha()
		{
			sw.Show();
			timer = new DispatcherTimer
			{
				Interval = TimeSpan.FromMilliseconds(5000)
			};
			timer.Tick += new EventHandler(WylaczSplasha);
			timer.Start();
			timer.Interval = TimeSpan.FromMilliseconds(5000);
			timer.Tick += Timer_Tick;
			Models.ObslugaSplashScreen.CzySplashOdpalony = true;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			timer.Stop();
			this.Show();
		}

		private void WylaczSplasha(object sender, EventArgs e)
		{
			timer.Stop();
			sw.Close();
		}

		private void btnRejestracja_Click(object sender, RoutedEventArgs e)
		{
			RejestracjaWindow rw = new RejestracjaWindow();
			rw.ShowDialog();
		}

		private void btnWyjscie_Click(object sender, RoutedEventArgs e) => System.Windows.Application.Current.Shutdown();

		private void btnZaloguj_Click(object sender, RoutedEventArgs e)
		{
			LogowanieWindow lw = new LogowanieWindow();
			lw.Show();
			this.Close();
		}
	}
}
