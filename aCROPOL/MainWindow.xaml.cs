using aCROPOL.Model;
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

namespace aCROPOL
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Connect.database = new akropolkuryaeva21Entities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { if (LoginTB.Text == "" || PasswordTB.Password == "")
            {
                MessageBox.Show("Поле Логин или Пароль пустое", "Пусто", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else

            {
                try
                {
                    var user = Connect.database.Manager.FirstOrDefault(
                        data => data.Login == LoginTB.Text &&
                        data.Password == PasswordTB.Password);
                
                    if (user == null)
                    {
                        MessageBox.Show("Неправильный логин или пароль", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        switch (user.IDRole)
                        {
                            case 1://Аренда
                                Window1 window1 = new Window1();
                                window1.Show();
                                break;

                            case 2://Продажа
                                Window2 window2 = new Window2();
                                window2.Show();
                                break;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка Exception", MessageBoxButton.OK, MessageBoxImage.Error);
                }
        }
        }
    } 
}
