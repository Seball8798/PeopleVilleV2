using PeopleVilleLibraryV2.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleVilleLibraryV2.iItems;
using PeopleVilleLibraryV2.Location;
using System.Reflection;

namespace PeopleVilleLibraryV2.InhibitansFolder
{
    public class Inhibitans
    {
        public string name { get; set; }
        public string food;
        public string weapon;
        Random rand = new Random();
        public int moneyAmount;
        Taxi Taxi = new Taxi();



        public Inhibitans(string Name, string Food, string Weapon, int MoneyAmount)
        {
            name = Name;
            food = Food;
            weapon = Weapon;
            moneyAmount = MoneyAmount;
        }

        public Inhibitans(string Name, string Food, int MoneyAmount)
        {
            name = Name;
            food = Food;
            moneyAmount = MoneyAmount;
        }
        public Inhibitans(string Name, string Food, string Weapon)
        {
            name = Name;
            food = Food;
            weapon = Weapon;
        }
        public Inhibitans(string Name, int MoneyAmount)
        {
            name = Name;
            moneyAmount = MoneyAmount;
        }
        public Inhibitans(string Name, string Food)
        {
            name = Name;
            food = Food;
        }
        public Inhibitans(string Name)
        {
            name = Name;
        }
        public Inhibitans()
        {
        }
        public void TaxiAction(Taxi taxi)
        {

        }
        public void TrainAction(Train train)
        {

        }
        // other properties and methods
        public void Trade(Inhibitans sender, Inhibitans receiver, string item, int money)
        {
            if ((sender.food == item || sender.weapon == item) && sender.moneyAmount >= money)
            {
                //Remove item from sender's inventory
                if (sender.food == item)
                    sender.food = "";
                else
                    sender.weapon = "";
                // Add money to sender's account
                sender.moneyAmount -= money;
                // Add item to receiver's inventory
                if (string.IsNullOrEmpty(receiver.food))
                    receiver.food = item;
                else
                    receiver.weapon = item;
                // Remove money from receiver's account
                receiver.moneyAmount += money;
            }
        }



        public void InhibitansProfil(Inhibitans inhibitans)
        {
            //Food food = new Food();
            //Weapon weapon = new Weapon();
            //food.FoodList();
            //weapon.WeaponList();
            Food food = new Food();
            Weapon weapon = new Weapon();
            List<string> WeaponList = weapon.WeaponList();
            List<string> foodList = food.FoodList();
            Random rand = new Random();
            int randomIndex = rand.Next(0, foodList.Count);
            moneyAmount = rand.Next(100, 10000);
            string randomFood = foodList[randomIndex];
            string randomWeapon = weapon.WeaponList()[randomIndex];

            Inhibitans inhibitant_Bob = new Inhibitans("Bob", randomFood, randomWeapon);
            Inhibitans inhibitant_Mikkel = new Inhibitans("Mikkel", randomFood, randomWeapon);
            Inhibitans inhibitant_Sebastian = new Inhibitans("Sebastian", randomFood, moneyAmount);

            //test in console
            foreach (var item in inhibitant_Sebastian.ToString())
            {
                Console.Write(item);
            }
            
        }

        public override string ToString()
        {
            return $"Inhibitans name: {name}, Food: {food}, Weapon: {weapon}, Money: {moneyAmount}";
        }

    }
}
