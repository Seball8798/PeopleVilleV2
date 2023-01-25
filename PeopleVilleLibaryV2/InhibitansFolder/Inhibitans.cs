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
        public List<string> Item;
        Random rand = new Random();
        public int MoneyAmount;
        Taxi Taxi = new Taxi();



        public Inhibitans(string name, string food, List<string> item, int moneyAmount)
        {
            name = name;
            food = food;
            Item = item;
            MoneyAmount = moneyAmount;
        }

        public Inhibitans(string name, string food, int moneyAmount)
        {
            name = name;
            food = food;
            MoneyAmount = moneyAmount;
        }
        public Inhibitans(string name, int moneyAmount)
        {
            name = name;
            MoneyAmount = moneyAmount;
        }
        public Inhibitans(string name, string food)
        {
            name = name;
            food = food;
        }
        public Inhibitans(string name)
        {
            name = name;
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
        public void trade()
        {

        }

        public void InhibitansProfil(Inhibitans inhibitans)
        {
            //Food food = new Food();
            //Weapon weapon = new Weapon();
            //food.FoodList();
            //weapon.WeaponList();
            Food food = new Food();
            List<string> foodList = food.FoodList();
            Random rand = new Random();
            int randomIndex = rand.Next(0, foodList.Count);
            string randomFood = foodList[randomIndex];
            Inhibitans inhibitans = new Inhibitans("John", randomFood);

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
