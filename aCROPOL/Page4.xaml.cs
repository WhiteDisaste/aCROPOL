using aCROPOL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
            Connect.database = new akropolkuryaeva21Entities();
            DR.ItemsSource = Connect.database.HousingStock.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TB2.Text != "")
            {
                HousingStock elka = (HousingStock)DR.SelectedItem;
                if ( elka != null)
                {
                    var edit = new HousingStock()
                    {
                        ID = elka.ID,
                        FloorsBuilding = elka.FloorsBuilding,
                        Occupied = elka.Occupied,
                        YearConstruction = elka.YearConstruction,
                        IDLocation = elka.IDLocation,
                        NumberRooms = elka.NumberRooms,
                        IDNumberBathrooms = elka.IDNumberBathrooms,
                        Conditioners = elka.Conditioners,
                        SummaObjectCadastre = elka.SummaObjectCadastre,
                        MarketValueObject = elka.MarketValueObject,
                        RentalCost = Convert.ToDecimal(TB2.Text),
                        IDReantalBuildings = elka.IDReantalBuildings
                    };
                    try
                    {
                        Connect.database.HousingStock.AddOrUpdate(edit);
                        Connect.database.SaveChanges();
                        MessageBox.Show("Готово");
                            
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message.ToString());
                    }


                }
            }

        }
    }
}
