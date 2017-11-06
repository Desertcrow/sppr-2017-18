using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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
using System.Windows.Threading;

namespace DiplomWpf
{
    /// <summary>
    /// Логика взаимодействия для OrgCommTest.xaml
    /// </summary>
    public partial class OrgCommTest : Window
    {
        public OrgCommTest()
        {
            InitializeComponent();
        }

        private int min = 10;
        private int sec = 0;
        private int index=1;
        private string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\USER\\Desktop\\Диплом(2017-2018)\\DiplomWpf\\DiplomWpf\recruting.mdf\";Integrated Security=True";
        
        private void Window_Loaded(object sender, RoutedEventArgs e)      
        {
            tes.Content = min + ":" + sec;
            ind.Content = "#"+index;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0,0,1);
            timer.Start();
            SqlConnection con = new SqlConnection(connStr);
            con.Open();
            string sql = "select Question from OrgCommTest where id="+index+" ";
            SqlCommand command = new SqlCommand(sql, con);
            text.Text = command.ExecuteScalar().ToString();
            con.Close();
        }
        
        
        private void timer_Tick(object sender, EventArgs e)
        {
            sec--;
            if (sec < 0) { sec = 59; min--; }
            tes.Content = min + ":" + sec;
            //if (sec == 0 && min == 0) ;
        }

        private void Finish(object sender, RoutedEventArgs e)
        {
            //Вывод окна результата
        }

        private void Answer(object sender, RoutedEventArgs e)
        {
            if (index != 40)
            {
                //обновить бд
                index++;
                ind.Content = "#" + index;
                
            }
            if (index == 40)
            {
                //обновить бд
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            index--;
            if (index < 1) index = 40;
            ind.Content = "#" + index;
        }

        private void Forth(object sender, RoutedEventArgs e)
        {
            index++;
            if (index > 40) index = 1;
            ind.Content = "#" + index;
        }
    }
}
