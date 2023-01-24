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
        public Supermarket(string streetName, int streetNumber, List<string> items) : base(streetName, streetNumber)
        {
            Items = items;
        }
        
        public Supermarket(string streetName, int streetNumber) : base(streetName, streetNumber)
        {
            
        }

        public Supermarket(string streetName) : base(streetName)
        {

        }

        public  Supermarket() 
        {

        }

        public void Medarbejder()
        {

        }
    }
}
