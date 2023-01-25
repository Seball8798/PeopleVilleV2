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

        public List<string> FoodList()
        {
            List<string> food = new List<string>();
            food.Add("Mango"); food.Add("Banana"); food.Add("Orange"); food.Add("Pizza"); food.Add("Burger");
            return food;
        }
    }
}


