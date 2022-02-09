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

namespace FormularzDoLogowania
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BT_Zaloguj_Click(object sender, RoutedEventArgs e)
        {
            var login = TB_Login.Text;
            var haslo = TB_Haslo.Text;
            if(login=="admin" && haslo == "1234")
            {
                MessageBox.Show("zalogowano");
            }
            else
            {
                MessageBox.Show("blad logowania");
            }

        }
    }
}
