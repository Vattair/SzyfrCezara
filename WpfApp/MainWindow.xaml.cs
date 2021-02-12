using ClassLibrary;
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

namespace WpfApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_S(object sender, RoutedEventArgs e)
        {
            TextBox wejscieBox = this.FindName("wej") as TextBox;
            TextBox przesBox = this.FindName("shift") as TextBox;
            TextBox wyjscieBox = this.FindName("wyj") as TextBox;

            int przesuniecie;
            try
            {
                przesuniecie = int.Parse(przesBox.Text);
            }
            catch
            {
                return;
            }
            wyjscieBox.Text = Szyfr.Szyfruj(wejscieBox.Text, przesuniecie);
        }

        private void Button_R(object sender, RoutedEventArgs e)
        {
            TextBox wejscieBox = this.FindName("wej") as TextBox;
            TextBox przesBox = this.FindName("shift") as TextBox;
            TextBox wyjscieBox = this.FindName("wyj") as TextBox;

            int przesuniecie;
            try
            {
                przesuniecie = int.Parse(przesBox.Text);
            }
            catch
            {
                return;
            }
            wyjscieBox.Text = Szyfr.Deszyfruj(wejscieBox.Text, przesuniecie);
        }
    }
}
