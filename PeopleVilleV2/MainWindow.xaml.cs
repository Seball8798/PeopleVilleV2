
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
using PeopleVilleLibraryV2.InhibitansFolder;
using PeopleVilleLibraryV2.Transport;

namespace PeopleVilleV2
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] name = { "Bob", "Mikkel", "Sebastian" };


            //string[] item = { "Telefon", "Bærbar", "Headset", "Sofa", "Mouse" };

            List<string> food = new List<string>();
            food.Add("Mango"); food.Add("Banan"); food.Add("Orange"); food.Add("Pizza"); food.Add("Burger"); food.Add("Apple"); food.Add("Pineapple");
           
            Random randMoney = new Random();
            int money;
            money = randMoney.Next(0, 100000);
            Inhibitans inhibitans1 = new Inhibitans(name[0], food[2]);
            Inhibitans inhibitans2 = new Inhibitans(name[1], money);
            Inhibitans inhibitans3 = new Inhibitans(name[2], money);

            Taxi taxi = new Taxi();
            Train train = new Train();
            inhibitans1.TaxiAction(taxi);
            inhibitans2.TrainAction(train);

        }

        //Random rand = new Random();
        //Inhabitant Mikkel = new Inhabitant("Mikkel", randMoney);
        //Inhabitant Sebastian = new Inhabitant("Sebastian", randMoney);
        //Inhabitant Mads = new Inhabitant("Mads", randMoney);
        //Inhabitant Charlie = new Inhabitant("Charlie", randMoney);
        //Inhabitant Dave = new Inhabitant("Dave", randMoney);
        //Inhabitant Lars = new Inhabitant("Lars", randMoney);
        //Inhabitant John = new Inhabitant("John", randMoney);
    }
}
