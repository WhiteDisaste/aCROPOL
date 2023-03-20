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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            Connect.database = new akropolkuryaeva21Entities();
            TB4.ItemsSource = Connect.database.Location.ToList();
            TB7.ItemsSource = Connect.database.Location.ToList();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int q, v;
            decimal z, x, c;
            DateTime datetime = Convert.ToDateTime(TB3.Text);
            z = Convert.ToDecimal(TB5.Text);
            x = Convert.ToDecimal(TB9.Text);
            c = Convert.ToDecimal(TB10.Text);



        }
    }
}
