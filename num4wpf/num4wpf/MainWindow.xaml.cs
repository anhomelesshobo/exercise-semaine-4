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

namespace num4wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Lacouleur = "Red";
        string Lacouleur1 = "Blue";
        string Lacouleur2= "Yellow";
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void RadioButton0_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(RadioButton0.IsChecked==true)
            {
                Lemessage.Text = "You've selected the color red";
                Ell.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(Lacouleur);
            }

            if (RadioButton1.IsChecked == true)
            {
                Lemessage.Text = "You've selected the color Blue";
                Ell.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(Lacouleur1);
            }

            if (RadioButton2.IsChecked == true)
            {
                Lemessage.Text = "You've selected the color Yellow";
                Ell.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString(Lacouleur2);
            }
        }
    }
}
