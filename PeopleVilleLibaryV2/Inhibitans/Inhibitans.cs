using PeopleVilleLibraryV2.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleVilleLibraryV2.iItems;


namespace PeopleVilleLibraryV2.Inhibitans
{
    public class Inhibitans
    {
        private string Name { get; set; }
        public string Food;
        public List<string> Item;
        Random rand = new Random();
        public int MoneyAmount;
        Taxi Taxi = new Taxi();



        public Inhibitans(string name, string food, List<string> item, int moneyAmount)
        {
            Name = name;
            Food = food;
            Item = item;
            MoneyAmount = moneyAmount;
        }

        public Inhibitans(string name, string food, int moneyAmount)
        {
            Name = name;
            Food = food;
            MoneyAmount = moneyAmount;
        }
        public Inhibitans(string name, int moneyAmount)
        {
            Name = name;
            MoneyAmount = moneyAmount;
        }
        public Inhibitans(string name, string food)
        {
            Name = name;
            Food = food;
        }
        public Inhibitans(string name)
        {
            Name = name;
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
    }
}
