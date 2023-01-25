﻿using PeopleVilleLibraryV2.Transport;
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
            Weapon weapon = new Weapon();
            List<string> WeaponList = weapon.WeaponList();
            List<string> foodList = food.FoodList();
            Random rand = new Random();
            int randomIndex = rand.Next(0, foodList.Count);
            string randomFood = foodList[randomIndex];
            string randomWeapon = weapon.WeaponList()[randomIndex];
            Inhibitans inhibitant_Bob = new Inhibitans("Bob", randomFood, randomWeapon);
            foreach (var item in inhibitant_Bob.ToString())
            {
                Console.Write(item);
            }
            
        }

        public override string ToString()
        {
            return $"Inhibitans name: {name}, Food: {food}, Weapon: {weapon}";
        }

    }
}
