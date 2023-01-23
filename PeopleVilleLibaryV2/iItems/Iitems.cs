using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.iItems
{
    public interface Iitems
    {
        string name { get; set; }
        int price { get; set; }

        public void pickup() { }
        public void transfer() { }
    }
}
