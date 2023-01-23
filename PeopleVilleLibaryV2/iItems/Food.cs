using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.iItems
{
    class Food : Iitems
    {
        public string name { get; set; }
        public int price { get; set; }

        public void pickup() { }
        public void transfer() { }
    }
}
