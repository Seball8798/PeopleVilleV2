using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.iItems
{
    public class Food : Iitems
    {
        public string name { get; set; }

        public int price { get; set; }

        public string pickup()
        {

            return "";
        }
        public string transfer()
        {
            return "";

        }

        public void FoodList()
        {
            List<string> food = new List<string>();
            food.Add("Mango"); food.Add("Banan"); food.Add("Orange"); food.Add("Pizza"); food.Add("Burger"); food.Add("Apple"); food.Add("Pineapple");

            foreach (var item in food)
            {
                Console.WriteLine(item.ToString());

            }
        }
    }
}


