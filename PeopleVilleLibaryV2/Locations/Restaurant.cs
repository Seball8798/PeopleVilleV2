using PeopleVilleLibraryV2.iItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Location
{
    public class Restaurant : Location
    {
        //List<string> Food;


        //public Restaurant(string streetName, int streetNumber, List<string> food) : base(streetName, streetNumber)
        //{
        //    Food = food;
        //}

        //public Restaurant(string streetName, int streetNumber) : base(streetName, streetNumber)
        //{

        //}

        //public Restaurant(string streetName) : base(streetName)
        //{

        //}

        //public Restaurant()
        //{

        //}

        public List<string> RestaurantsList()
        {
            List<string> restaurants = new List<string>();
            restaurants.Add("McDonald's"); restaurants.Add("Sunset"); restaurants.Add("KFC"); restaurants.Add("Ali's Kebab"); restaurants.Add("Max Burger's");
            return restaurants;
        }
    }
}
