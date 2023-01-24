using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Location
{
    class Restaurant : Location
    {
        List<string> food;


        public Restaurant(string streetName, int streetNumber, int streetContact, List<string> food) : base(streetName, streetNumber, streetContact)
        {
            this.food = food;
        }
    }
}
