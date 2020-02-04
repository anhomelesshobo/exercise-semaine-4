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

namespace num5wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        int nombre = 1;
        int var = 200;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void update_change(object sender, SizeChangedEventArgs e)
        {


            fenetre.Width = var;
            fenetre.Height = var;


            sonic2.Source = sonic1.Source;
                sonic1.Source = sonic2.Source;
                sonic4.Source = sonic3.Source;
                sonic3.Source = sonic4.Source;

            var = var + 100;
           

            

            



        }
    }
}
