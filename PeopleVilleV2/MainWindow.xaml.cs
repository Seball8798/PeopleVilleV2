
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
using PeopleVilleLibraryV2;
using PeopleVilleLibraryV2.Date;
using PeopleVilleLibraryV2.iItems;
using PeopleVilleLibraryV2.InhibitansFolder;
using PeopleVilleLibraryV2.Location;
using PeopleVilleLibraryV2.Transport;
using static PeopleVilleLibraryV2.Date.Days;

namespace PeopleVilleV2
{
    public class InhibitansDataModel
    {
        public string FirstName { get; set; }
        public int Money { get; set; }
        public string Food { get; set; }
        public string Weapons { get; set; }
        public string Location { get; set; }


        public InhibitansDataModel(Inhibitans inhibitans)
        {
            FirstName = inhibitans.name;
            Money = inhibitans.moneyAmount;
            Food = inhibitans.food;
            Weapons = inhibitans.weapon;
            Location = inhibitans.location;
        }
    }
    public partial class MainWindow : Window
    {
        int dayIndex;
        private readonly Days.WeekDays[] weekDays = (Days.WeekDays[])Enum.GetValues(typeof(Days.WeekDays));
        public Inhibitans inhibitant_Bob;
        public Inhibitans inhibitant_Mikkel;
        public Inhibitans inhibitant_Sebastian;
        public MainWindow()
        {
            InitializeComponent();
            InitializeInhibitans();

        }

        private void InitializeInhibitans()
        {
            List<InhibitansDataModel> inhibitansList = new List<InhibitansDataModel>();
            Food food = new Food();
            Weapon weapon = new Weapon();
            Supermarket supermarket = new Supermarket();
            Restaurant restaurant = new Restaurant();
            List<string> WeaponList = weapon.WeaponList();
            List<string> foodList = food.FoodList();
            List<string> LocationList = supermarket.SupermarketsList().Concat(restaurant.RestaurantsList()).ToList();
            Random rand = new Random();

            inhibitant_Bob = new Inhibitans("Bob", foodList[rand.Next(0, foodList.Count)], WeaponList[rand.Next(0, WeaponList.Count)], rand.Next(0, 10000));
            inhibitant_Bob.location = LocationList[rand.Next(0, LocationList.Count)];
            inhibitant_Mikkel = new Inhibitans("Mikkel", foodList[rand.Next(0, foodList.Count)], WeaponList[rand.Next(0, WeaponList.Count)], rand.Next(0, 10000), LocationList[rand.Next(0, LocationList.Count)]);
            inhibitant_Sebastian = new Inhibitans("Sebastian", foodList[rand.Next(0, foodList.Count)], WeaponList[rand.Next(0, WeaponList.Count)], rand.Next(0, 10000), LocationList[rand.Next(0, LocationList.Count)]);
            inhibitansList.Add(new InhibitansDataModel(inhibitant_Bob));
            inhibitansList.Add(new InhibitansDataModel(inhibitant_Mikkel));
            inhibitansList.Add(new InhibitansDataModel(inhibitant_Sebastian));
            PeopleGrid.ItemsSource = inhibitansList;
        }
        private void SwitchDay_Click(object sender, RoutedEventArgs e)
        {
            if (dayIndex >= weekDays.Length)
                dayIndex = 0;

            DisplayDay.Content = weekDays[dayIndex++].ToString();

            InitializeInhibitans();
        }

        private void OutputFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }

}
