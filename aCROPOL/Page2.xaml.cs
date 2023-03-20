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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            Connect.database = new akropolkuryaeva21Entities();
            DR.ItemsSource = Connect.database.HousingStock.ToList();
            Com.ItemsSource = Connect.database.HousingStock.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Com.Text == "")
            {
                MessageBox.Show("Отсутсвуют данные ");
                

            }
            else
            {
                DR.ItemsSource = Connect.database.HousingStock.Where(a => a.NumberRooms == ((HousingStock)Com.SelectedItem).NumberRooms).ToList();

            }
        }
    }
}
