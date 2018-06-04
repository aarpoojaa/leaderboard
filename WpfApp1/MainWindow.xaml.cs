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


namespace WpfApp1
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

        private void Label_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Prac_Mode_Click(object sender, RoutedEventArgs e)
        {
            Practice Prac = new Practice();
            Prac.Show();
            this.Close();
        }

        private void Pro_Mode_Click (object sender, RoutedEventArgs e)
        {
            Window1 Win1 = new Window1();
            Win1.Show();
            this.Close();
        }

        private void Leader_Click(object sender, RoutedEventArgs e)
        {
            Leaderboard leader = new Leaderboard();
            leader.Show();
            this.Close();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void Prac_Hover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
        }

    }
}
