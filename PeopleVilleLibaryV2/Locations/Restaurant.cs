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
        
        public List<string> Locations { get; set; }

            public Restaurant(string streetname, int streetnumber) : base(streetname, streetnumber)
            {
                Locations = RestaurantsList();
            }

            public Restaurant(string streetname) : base(streetname)
            {
                Locations = RestaurantsList();
            }

            public Restaurant()
            {
                Locations = RestaurantsList();
            }

            public List<string> RestaurantsList()
            {
                List<string> restaurants = new List<string>();
                restaurants.Add("McDonald's");
                restaurants.Add("Sunset");
                restaurants.Add("KFC");
                restaurants.Add("Ali's Kebab");
                restaurants.Add("Max Burger's");
                return restaurants;
            }

            public override void Medarbejder()
            {
                Console.WriteLine("Vi er medarbejder fra Restaurant.");
            }
    }
}

