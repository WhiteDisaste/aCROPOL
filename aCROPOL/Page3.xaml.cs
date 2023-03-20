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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            Connect.database = new akropolkuryaeva21Entities();
            DR.ItemsSource = Connect.database.HousingStock.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Start.Text == "" || End.Text == "")
            {
                MessageBox.Show("Отсутсвуют данные");
            }
            else
            {
                DateTime datestart, dateend;
                datestart = Convert.ToDateTime(Start.DisplayDate);
                dateend = Convert.ToDateTime(End.DisplayDate);

                var cola = Connect.database.HousingStock.Where(q => q.YearConstruction >= datestart && q.YearConstruction <= dateend);
                var cola1 = Connect.database.HousingStock.Where(q => q.YearConstruction >= datestart && q.YearConstruction <= dateend).Sum(v=>v.SummaObjectCadastre);

                DR.ItemsSource = cola.ToList();
                tb1.Text = cola1.ToString();
                
            }

        }
    }
}
