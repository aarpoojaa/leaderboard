using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SQLite;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Leader.xaml
    /// </summary>
    public partial class Leader : Window
    {
        public Leader()
        {
            InitializeComponent();
        }
        public Leader(int x)
        {
            InitializeComponent();
            
            db();
        }
        private void Lead_Back(object sender, RoutedEventArgs e)
        {
            Leaderboard lead = new Leaderboard();
            lead.Show();
            this.Close();
            //P2.Content = null;
            
        }
        public void db()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            try
            {
                conn.Open();
                //SqlCommand command = new SqlCommand("CREATE TABLE Customer(First_Name char(50),Last_Name char(50));",myConnection );
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                //sqlite_cmd.CommandText = "CREATE TABLE kaushal (ind integer primary key autoincrement, gtag varchar(50),time integer , nom integer ,level integer, score integer );";
                //sqlite_cmd.ExecuteNonQuery();

                //P2.Content = null;

                /*sqlite_cmd.CommandText = "INSERT INTO kaushal (gtag, time,nom,level,score) VALUES (@a,@b,@c,@d,@e)";
                sqlite_cmd.Parameters.Add(new SQLiteParameter("@a", "kaushal10"));
                sqlite_cmd.Parameters.Add(new SQLiteParameter("@b", 12));
                sqlite_cmd.Parameters.Add(new SQLiteParameter("@c", 20));
                sqlite_cmd.Parameters.Add(new SQLiteParameter("@d", 1));
                sqlite_cmd.Parameters.Add(new SQLiteParameter("@e", 100));
                sqlite_cmd.ExecuteNonQuery();*/

               

                sqlite_cmd.CommandText = "SELECT gtag , score FROM kaushal where level = "+2+" order by score desc limit 10";
                SQLiteDataReader sqlRead = sqlite_cmd.ExecuteReader();
                //sqlRead.Read();
                //sqlRead.Read();
                //Console.WriteLine(sqlRead.GetValue(1));
                //Console.WriteLine(sqlRead[0]);

                List<string> gtags = new List<string>();
                List<string> scores = new List<string>();

                while (sqlRead.Read())
                {
                    string gtag = sqlRead.GetValue(0).ToString();
                    string score = sqlRead.GetValue(1).ToString();
                    gtags.Add(gtag);
                    scores.Add(score);
                    Console.WriteLine(gtag);
                    Console.WriteLine(score);
                    //Console.WriteLine(sqlRead.GetValue(2));
                }
                //now putting everything in the labels.
                
                N1.Content = gtags.ElementAt(1).ToString();
                N2.Content = gtags.ElementAt(1).ToString();
                N3.Content = gtags.ElementAt(2).ToString();
                N4.Content = gtags.ElementAt(3);
                N5.Content = gtags.ElementAt(4);
                N6.Content = gtags.ElementAt(5);
                N7.Content = gtags.ElementAt(6);
                N8.Content = gtags.ElementAt(7);
                N9.Content = gtags.ElementAt(8);
                N10.Content = gtags.ElementAt(9);
                //Now the gtags in n1,n2..
                p1.Content = scores.ElementAt(0);
                P2.Content = scores.ElementAt(1);
                P3.Content = scores.ElementAt(2);
                P4.Content = scores.ElementAt(3);
                P5.Content = scores.ElementAt(4);
                P6.Content = scores.ElementAt(5);
                P7.Content = scores.ElementAt(6);
                P8.Content = scores.ElementAt(7);
                P9.Content = scores.ElementAt(8);
                P10.Content = scores.ElementAt(9);

                Console.WriteLine("i have done the connection");
                
            }
            catch (Exception er)
            {
                Console.WriteLine(er.ToString());
                Console.WriteLine("error in opeining");
            }
            try
            {
                conn.Close();
                Console.WriteLine("i have done the connection CLOSEDDD");
            }
            catch (Exception er)
            {
                Console.WriteLine(er.ToString());
                Console.WriteLine(" error ");
            }
        }
    }
}
