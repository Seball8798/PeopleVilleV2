
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
using System.ComponentModel;
using PeopleVilleLibraryV2.Transport;

namespace PeopleVilleV2
{
    public class InhibitansDataModel : INotifyPropertyChanged
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string _food;
        public string Food
        {
            get { return _food; }
            set
            {
                _food = value;
                OnPropertyChanged("Food");
            }
        }

        private string _weapons;
        public string Weapons
        {
            get { return _weapons; }
            set
            {
                _weapons = value;
                OnPropertyChanged("Weapons");
            }
        }

        private int _money;
        public int Money
        {
            get { return _money; }
            set
            {
                _money = value;
                OnPropertyChanged("Money");
            }
        }
        private string _location;
        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged("Money");
            }
        }

        public InhibitansDataModel(string firstName, string food, string weapons, int money, string location)
        {
            FirstName = firstName;
            Food = food;
            Weapons = weapons;
            Money = money;
            Location = location;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
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
            MyEvent += HandleMyEvent;

        }

        public List<InhibitansDataModel> inhibitansList = new List<InhibitansDataModel>();
        public Random rand = new Random();
        public Inhibitans inhibitans = new Inhibitans();
        public Inhibitans inhibitant_Bob;
        public Inhibitans inhibitant_Mikkel;
        public Inhibitans inhibitant_Sebastian;

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

            inhibitansList.Add(new InhibitansDataModel("Bob", foodNu1, weapon1, rndMoney1, loc1));
            inhibitansList.Add(new InhibitansDataModel("Mikkel", foodNu2, weapon2, rndMoney2, loc2));
            inhibitansList.Add(new InhibitansDataModel("Sebastian", foodNu3, weapon3, rndMoney3, loc3));

            PeopleGrid.ItemsSource = inhibitansList;

        }
        private void SwitchDay_Click(object sender, RoutedEventArgs e)
        {
            var randMoney = rand.Next(0, 100);

            if (dayIndex >= weekDays.Length)
                dayIndex = 0;

            DisplayDay.Content = weekDays[dayIndex++].ToString();
            // Update data source
            inhibitansList[0].Money += randMoney;
            inhibitansList[1].Money += randMoney;
            inhibitansList[2].Money += randMoney;

            TradeStackpanel.Children.Clear();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InitializeInhibitans();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Label newLabel1 = new Label();
            Label newLabel2 = new Label();
            // Get the selected rows from the DataGrid
            if (PeopleGrid.ItemsSource != null)
            {
                if (PeopleGrid.SelectedItems.Count < 2 || PeopleGrid.SelectedItems.Count == 3)
                {
                    // Show an error message to the user
                    MessageBox.Show("Please select two rows from the DataGrid before clicking the button", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                var selectedRow1 = PeopleGrid.SelectedItems[0] as InhibitansDataModel;
                var selectedRow2 = PeopleGrid.SelectedItems[1] as InhibitansDataModel;
                // Check if the selected items are null
                if (selectedRow1 == null || selectedRow2 == null)
                {
                    // Show an error message to the user
                    MessageBox.Show("Please select two rows from the DataGrid before clicking the button", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Check if there are any existing labels in the TradeStackpanel
                if (TradeStackpanel.Children.OfType<Label>().Count() == 2)
                {
                    // Remove the existing labels
                    TradeStackpanel.Children.Clear();
                }
                // Create new labels
                newLabel1.Foreground = new SolidColorBrush(Colors.White);
                newLabel2.Foreground = new SolidColorBrush(Colors.White);

                // Set the labels' content to the selected rows' information
                newLabel1.Content = $"Name: {selectedRow1.FirstName}, Food: {selectedRow1.Food}, Weapon: {selectedRow1.Weapons}, Money: {selectedRow1.Money}";
                newLabel2.Content = $"Name: {selectedRow2.FirstName}, Food: {selectedRow2.Food}, Weapon: {selectedRow2.Weapons}, Money: {selectedRow2.Money}";

                // Add the labels to the UI (for example, you could add them to a StackPanel)
                TradeStackpanel.Children.Add(newLabel1);
                TradeStackpanel.Children.Add(newLabel2);
            }
        }
        //------------------------------------Trade goes here-----------------------------------------------------//
        public string foodTrade1;
        private void TradeButton_Click(object sender, RoutedEventArgs e)
        {
            if (TradeStackpanel.Children.Count == 2)
            {
                var selectedCell1 = PeopleGrid.SelectedCells[0];
                var selectedCell2 = PeopleGrid.SelectedCells[1];
                var selectedCell3 = PeopleGrid.SelectedCells[2];


                // Get the data item of the selected cells
                var dataItem1 = selectedCell1.Item as InhibitansDataModel;
                var dataItem2 = selectedCell2.Item as InhibitansDataModel;
                var dataItem3 = selectedCell3.Item as InhibitansDataModel;


                // Randomly decide which properties to trade
                var random = new Random();
                //var tradeFood = random.Next(2) == 0;
                //var tradeWeapon = random.Next(2) == 0;
                //var tradeMoney = random.Next(2) == 0;

                // Make the trade
                if (selectedCell1 != null && selectedCell2 != null && selectedCell1.Item != null && selectedCell2.Item != null)
                {
                    var tempFood = inhibitansList[0].Food;
                    inhibitansList[0].Food = inhibitansList[1].Food;
                    inhibitansList[1].Food = tempFood;
                    foodTrade1 = $"Name: {inhibitansList[0].FirstName}, traded Food with {inhibitansList[1].FirstName}";
                }
                //if (tradeWeapon)
                //{
                //    var tempWeapon = dataItem1.Weapons;
                //    dataItem1.Weapons = dataItem2.Weapons;
                //    dataItem2.Weapons = tempWeapon;
                //}
                //if (tradeMoney)
                //{
                //    var tempMoney = dataItem1.Money;
                //    dataItem1.Money = dataItem2.Money;
                //    dataItem2.Money = tempMoney;
                //}

                // Refresh the grid

                // Show a message box to indicate that the trade was successful
                MessageBox.Show(foodTrade1, "Trade successful!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Show an error message if not enough cells are selected
                MessageBox.Show("Please select two cells to make a trade", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }



        }
        //-------------------------------EVENT Delgate------------------------------------------------------------------

        // Declare the delegate (what type of method will be handling the event)
        public delegate void MyEventHandler(object sender, EventArgs e);

        // Declare the event using the delegate
        public event MyEventHandler MyEvent;



        // Method that will be called when the event is raised
        private void HandleMyEvent(object sender, EventArgs e)
        {
            Random rand = new Random();
            int eventNum = rand.Next(1, 4);
            string eventText = "";
            switch (eventNum)
            {
                case 1:
                    eventText = "The bank has been robbed!";
                    break;
                case 2:
                    eventText = "A new supermarket has opened in the city";
                    break;
                case 3:
                    eventText = "There is a free concert happening in the park tonight";
                    break;
                default:
                    eventText = "Nothing interesting happening today";
                    break;
            }
            eventlabel.Content = eventText;
        }


        private void RaiseEventButton_Click(object sender, RoutedEventArgs e)
        {
            // Raise the event
            MyEvent?.Invoke(this, EventArgs.Empty);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.Drive();
            string newLocation = train.Drive();
            InhibitansDataModel selectedRow1 = PeopleGrid.SelectedItems[0] as InhibitansDataModel;
            selectedRow1.Location = newLocation;
            train.Stop();
            newLocation = train.Stop();
            InhibitansDataModel selectedRow2 = PeopleGrid.SelectedItems[1] as InhibitansDataModel;
            selectedRow2.Location = newLocation;
        }

    }
}

