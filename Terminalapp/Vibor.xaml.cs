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

namespace Terminalapp
{
    /// <summary>
    /// Логика взаимодействия для Form.xaml
    /// </summary>
    public partial class Vibor : Page
    {
        bool vibrn;
        public Vibor()
        {
            InitializeComponent();
          
        }

        private void FrameVibor_ContentRendered(object sender, EventArgs e)
        {

        }

        private void btnRazgruzka_Click(object sender, RoutedEventArgs e)
        {
            vibrn = true;
            MessageBox.Show("true");
            FrameVibor.Navigate(new Form(vibrn));
            btnPogruzka.Visibility = Visibility.Collapsed;
            btnRazgruzka.Visibility = Visibility.Collapsed;
        }

        private void btnPogruzka_Click(object sender, RoutedEventArgs e)
        {
            vibrn = false;
            MessageBox.Show("false");
            FrameVibor.Navigate(new Form(vibrn));
            btnPogruzka.Visibility = Visibility.Collapsed;
            btnRazgruzka.Visibility = Visibility.Collapsed;
        }
    }
}
