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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Arcade_Prac.xaml
    /// </summary>
    public partial class Arcade_Prac : Window
    {
        public Arcade_Prac()
        {
            InitializeComponent();
        }

        private void Click_Back(object sender, RoutedEventArgs e)
        {
            Practice prac = new Practice();
            prac.Show();
            this.Close();
        }
    }
}
