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
            food.Add("Mango"); food.Add("Banan"); food.Add("Orange"); food.Add("Pizza"); food.Add("Burger");

            // Random events
            //Random rand = new Random();
            //int eventNum = rand.Next(0, 5);
            //switch (eventNum)
            //{
            //    case 1:
            //        Console.WriteLine(food[0].ToString());
            //        break;
            //    case 2:
            //        Console.WriteLine(food[1].ToString());
            //        break;
            //    case 3:
            //        Console.WriteLine(food[2].ToString());
            //        break;
            //    case 4:
            //        Console.WriteLine(food[3].ToString());
            //        break;
            //    default:
            //        Console.WriteLine(food[4].ToString());
            //        break;
            //}
        }
    }
}


