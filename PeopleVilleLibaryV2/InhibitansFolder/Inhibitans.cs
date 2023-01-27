using PeopleVilleLibraryV2.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleVilleLibraryV2.iItems;
using PeopleVilleLibraryV2;
using System.Reflection;
using System.Diagnostics;
using System.Xml.Linq;
using PeopleVilleLibraryV2.Location;

namespace PeopleVilleLibraryV2.InhibitansFolder
{
    public class Inhibitans
    {
        public string name { get; set; }
        public string food;
        public string weapon;
        public string location;
        Random rand = new Random();
        public int moneyAmount;
        Taxi Taxi = new Taxi();



        public Inhibitans(string Name, string Food, string Weapon, int MoneyAmount, string Location)
        {
            name = Name;
            food = Food;
            weapon = Weapon;
            moneyAmount = MoneyAmount;
            location= Location;
        }

        public Inhibitans(string Name, string Food, int MoneyAmount, string Location)
        {
            name = Name;
            food = Food;
            moneyAmount = MoneyAmount;
            location = Location;
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
        public int TaxiAction()
        {
            int trekke1 = moneyAmount - 100;
            return trekke1;
        }
        public int TrainAction()
        {
            int trekke2 = moneyAmount - 35;
            return trekke2;
        }


        public void InhibitansProfil()
        {
            //Food food = new Food();
            //Weapon weapon = new Weapon();
            //food.FoodList();
            //weapon.WeaponList();
            Food food = new Food();
            Weapon weapon = new Weapon();
            Supermarket supermarket = new Supermarket();
            Restaurant restaurant = new Restaurant();
            List<string> WeaponList = weapon.WeaponList();
            List<string> foodList = food.FoodList();
            List<string> LocationList = new List<string>();
            LocationList.AddRange(supermarket.SupermarketsList());
            LocationList.AddRange(restaurant.RestaurantsList());
            Random rand = new Random();

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

            //Før Trade
            Console.WriteLine("-------------------- -------- -------------------------");
            Console.WriteLine("-------------------- Før Trade -------------------------");
            Console.WriteLine("-------------------- -------- -------------------------");
            //test in console
            foreach (var item in inhibitant_Sebastian.ToString())
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");
            foreach (var item1 in inhibitant_Mikkel.ToString())
            {
                Console.Write(item1);

            }
            Console.WriteLine("\n");
            foreach (var item2 in inhibitant_Bob.ToString())
            {
                Console.Write(item2);

            }


            Food food1 = new Food();
            //Forhandle
            if (inhibitant_Bob.moneyAmount != null)

                food1.price = 100;

            inhibitant_Bob.moneyAmount += food1.price;
            inhibitant_Bob.food = inhibitant_Bob.food.Remove(0);


            if (inhibitant_Mikkel.moneyAmount != null)

                food1.price = 150;

            inhibitant_Mikkel.moneyAmount += food1.price;
            inhibitant_Mikkel.weapon = inhibitant_Mikkel.weapon.Remove(0);


            if (inhibitant_Sebastian.moneyAmount != null)

                food1.price = 200;

            inhibitant_Sebastian.moneyAmount += food1.price;
            inhibitant_Sebastian.weapon = inhibitant_Sebastian.weapon.Remove(0);

            Console.WriteLine();


            //Éfter Trade
            Console.WriteLine("-------------------- -------- -------------------------");
            Console.WriteLine("-------------------- Efter Trade -----------------------");
            Console.WriteLine("-------------------- -------- -------------------------");
            //test in console
            foreach (var item in inhibitant_Sebastian.ToString())
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");
            foreach (var item1 in inhibitant_Mikkel.ToString())
            {
                Console.Write(item1);

            }
            Console.WriteLine("\n");
            foreach (var item2 in inhibitant_Bob.ToString())
            {
                Console.Write(item2);

            }


        }


        public override string ToString()
        {
            return $"Inhibitans name: {name}\n*Currently has 1 whole {food}\n*Owns an {weapon}\n*Has ${moneyAmount} in the bank.";
        }
        public void Trade(Inhibitans sender, Inhibitans receiver)
        {
            
        }
    }
}
