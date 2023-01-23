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
        public Supermarket(List<string> items)
        {
            Items = items;
        }
        public void Medarbejder()
        {

        }
    }
}
