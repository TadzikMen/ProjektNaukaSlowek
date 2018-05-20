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
using System.Windows.Shapes;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for TlumaczenieZdanWindow.xaml
    /// </summary>
    public partial class TlumaczenieZdanWindow : Window
    {
        public TlumaczenieZdanWindow()
        {
            InitializeComponent();
        }

		private void btnSprawdz_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnPokazTlumaczenie_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnKolejneZdanie_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			RozpocznijNaukeWindow rnw = new RozpocznijNaukeWindow();
			rnw.Show();
			this.Close();
		}
	}
}
