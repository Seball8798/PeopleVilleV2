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
        List<string> Food;


        public Restaurant(string streetName, int streetNumber, List<string> food) : base(streetName, streetNumber)
        {
            Food = food;
        }

        public Restaurant(string streetName, int streetNumber) : base(streetName, streetNumber)
        {

        }

        public Restaurant(string streetName) : base(streetName)
        {

        }

        public Restaurant()
        {

        }
    }
}
