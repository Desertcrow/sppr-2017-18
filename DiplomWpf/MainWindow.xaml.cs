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

namespace DiplomWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void main_Loaded(object sender, RoutedEventArgs e)
        {
            //Проверка на тип поьзователя
        }
        private void prof_test_start(object sender, RoutedEventArgs e)
        {
            //Переход на окно выбора теста
        }

        private void org_test_start(object sender, RoutedEventArgs e)
        {
            OrgCommTest org = new OrgCommTest();
            App.Current.MainWindow = org;
            this.Close();
            org.Show();
        }

        private void soc_test_start(object sender, RoutedEventArgs e)
        {
            //Переход на окно теста
        }

        private void pers_data(object sender, RoutedEventArgs e)
        {
            //Переход на окно 
        }

        private void reports(object sender, RoutedEventArgs e)
        {
            //Переход на окно отчетов
        }

        private void mail_to_rec(object sender, RoutedEventArgs e)
        {
            //Вывод окна написания письма
        }

        
    }
}
