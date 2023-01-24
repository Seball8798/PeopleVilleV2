using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Location
{
    public class Supermarket : Location
    {
        List<string> Items;
        public Supermarket(string streetName, int streetNumber, int streetContact, List<string> items) : base(streetName, streetNumber, streetContact)
        {
            Items = items;
        }
        public void Medarbejder()
        {

        }
    }
}
