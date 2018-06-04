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
    /// Interaction logic for Leaderboard.xaml
    /// </summary>
    public partial class Leaderboard : Window
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        public void hidePanels()
        {
            Child.Visibility = Visibility.Collapsed;
                    }
        private void Leaderboard_Click(object sender, EventArgs e)
        {
            hidePanels();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            if (but == button)
            {
                Child.Visibility = Visibility.Visible;
                //Leader lead = new Leader();
                UserControl1 user = new UserControl1(1);
                Child.Children.Add(user);
                
                 
            }
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == button1)
            {
                Child.Visibility = Visibility.Visible;
                //Leader lead = new Leader();
                UserControl1 user = new UserControl1(2);
                Child.Children.Add(user);

            }
                 
    }

        private void hide_Grid(object sender, RoutedEventArgs e)
        {
            Child.Visibility = Visibility.Hidden;

        }



        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == button2)
            {

                Child.Visibility = Visibility.Visible;
                //Leader lead = new Leader(7);
                UserControl1 user = new UserControl1(3);
                Child.Children.Add(user);
            }
        }


        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

    }
}
