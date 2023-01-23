using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Location
{
    public class Restaurant : Location
    {
        List<string> food;


        public Restaurant(List<string> food) : base(r, h)
        {
            this.food = food;
        }
    }
}
