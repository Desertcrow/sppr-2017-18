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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Cancel_Button(object sender, RoutedEventArgs e)
        {
            AuthWindow auth = new AuthWindow();
            App.Current.MainWindow = auth;
            this.Close();
            auth.Show();
        }

        private void Ok_button(object sender, RoutedEventArgs e)
        {
            //Проверка ввода
            //Добавление записи в БД
        }
    }
}
