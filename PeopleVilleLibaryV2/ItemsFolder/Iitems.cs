using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.iItems
{
    public interface Iitems
    {
        public List<string> Items { get; set; }
        public int price { get; set; }
    }
}
