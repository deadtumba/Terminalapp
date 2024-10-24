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
    public partial class Form : Page
    {
        public Form(bool vibrn)
        {
            InitializeComponent();
        }
        private void FrameForm_ContentRendered(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbFamiliya.Text = "";
            txbImya.Text = "";
            txbOtchestvo.Text = "";
            txbNomeravto.Text = "";
            txbOrganizaciya.Text = "";
            txbNomerTelefona.Text = "";
       
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
