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
    /// Interaction logic for Practice.xaml
    /// </summary>
    public partial class Practice : Window
    {
        public Practice()
        {
            InitializeComponent();
        }
        private void Prac_Back(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Arcade_Click(object sender, RoutedEventArgs e)
        {
            Arcade_Prac arc = new Arcade_Prac();
            arc.Show();
            this.Close();
        }

        private void Classic_Click(object sender, RoutedEventArgs e)
        {
            Classic_Prac clas = new Classic_Prac();
            clas.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
