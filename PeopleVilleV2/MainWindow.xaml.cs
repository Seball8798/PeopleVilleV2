
using PeopleVilleLibraryV2.Date;
using PeopleVilleLibraryV2.iItems;
using PeopleVilleLibraryV2.InhibitansFolder;
using PeopleVilleLibraryV2.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Label = System.Windows.Controls.Label;

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

        public MainWindow()
        { 
            InitializeComponent();
            InitializeInhibitans();
        }

        public List<InhibitansDataModel> inhibitansList = new List<InhibitansDataModel>();
        public Random rand = new Random();
        public RandomEvents randomEvents = new RandomEvents();
        public Inhibitans inhibitans = new Inhibitans();


        private void InitializeInhibitans()
        {
            Food food = new Food();
            Weapon weapon = new Weapon();
            Supermarket supermarket = new Supermarket();
            Restaurant restaurant = new Restaurant();
            List<string> WeaponList = weapon.WeaponList();
            List<string> foodList = food.FoodList();
            Random rand = new Random();
            List<string> LocationList = restaurant.Locations.Concat(supermarket.Locations).ToList();
            //List<string> LocationList = supermarket.SupermarketsList().Concat(restaurant.Locations).ToList();

            var foodNu1 = foodList[rand.Next(0, foodList.Count)];
            var foodNu2 = foodList[rand.Next(0, foodList.Count)];
            var foodNu3 = foodList[rand.Next(0, foodList.Count)];

            var weapon1 = WeaponList[rand.Next(0, WeaponList.Count)];
            var weapon2 = WeaponList[rand.Next(0, WeaponList.Count)];
            var weapon3 = WeaponList[rand.Next(0, WeaponList.Count)];

            var rndMoney1 = rand.Next(0, 10000);
            var rndMoney2 = rand.Next(0, 10000);
            var rndMoney3 = rand.Next(0, 10000);


            var loc1 = LocationList[rand.Next(0, LocationList.Count)];
            var loc2 = LocationList[rand.Next(0, LocationList.Count)];
            var loc3 = LocationList[rand.Next(0, LocationList.Count)];




            Inhibitans inhibitant_Bob = new Inhibitans("Bob", foodNu1, weapon1, rndMoney1, loc1);
            Inhibitans inhibitant_Mikkel = new Inhibitans("Mikkel", foodNu2, weapon2, rndMoney2, loc2);
            Inhibitans inhibitant_Sebastian = new Inhibitans("Sebastian", foodNu3, weapon3, rndMoney3, loc3);
            inhibitansList.Add(new InhibitansDataModel(inhibitant_Bob));
            inhibitansList.Add(new InhibitansDataModel(inhibitant_Mikkel));
            inhibitansList.Add(new InhibitansDataModel(inhibitant_Sebastian));

            PeopleGrid.ItemsSource = inhibitansList;
        }
        private void SwitchDay_Click(object sender, RoutedEventArgs e)
        {            
            inhibitans.InhibitansProfil();


            if (dayIndex >= weekDays.Length)
                dayIndex = 0;

            DisplayDay.Content = weekDays[dayIndex++].ToString();
            DisplayDay.Content += randomEvents.GetRandomEvent();
            //MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Are you sure?", "Next day", System.Windows.MessageBoxButton.YesNo);

            //if (messageBoxResult == MessageBoxResult.Yes)
            //{

            //    DisplayDay.Content = weekDays[dayIndex++].ToString();
            //}
            //else
            //{
            //    DisplayDay.Content = weekDays[dayIndex].ToString();
            //}


            InitializeInhibitans();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Label newLabel = new Label();
            // Get the selected row from the DataGrid
            var selectedRow = PeopleGrid.SelectedItem as InhibitansDataModel;
            // Check if the selected item is null
            if (selectedRow == null)
            {
                // Show an error message to the user
                MessageBox.Show("Please select a row from the DataGrid before clicking the button", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            // Check if there are any existing labels in the TradeStackpanel
            if (TradeStackpanel.Children.OfType<Label>().Count() == 2)
            {
                // Remove the existing label
                TradeStackpanel.Children.Clear();
            }
                // Create a new label
                newLabel.Foreground = new SolidColorBrush(Colors.White);

                // Set the label's content to the selected row's name
                newLabel.Content = $"Name: {selectedRow.FirstName}, Food: {selectedRow.Food}, Weapon: {selectedRow.Weapons}, Money: {selectedRow.Money}";


                // Add the label to the UI (for example, you could add it to a StackPanel)
                TradeStackpanel.Children.Add(newLabel);
        }

        private void TradeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
