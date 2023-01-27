using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.iItems
{
    public class Food : Iitems
    {

        public int price { get; set; }

        public List<string> Items { get; set; }

        public Food()
        {
            Items = FoodList();
        }



        public List<string> FoodList()
        {
            List<string> food = new List<string>();
            food.Add("Mango"); food.Add("Banana"); food.Add("Orange"); food.Add("Pizza"); food.Add("Burger"); food.Add("Peanut"); food.Add("Mango");
            return food;
        }
    }
}


