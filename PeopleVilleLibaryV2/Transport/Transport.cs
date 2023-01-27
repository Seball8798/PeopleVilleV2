using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Transport
{
    public abstract class Transport
    {
        public string Location { get; set; }

        public abstract string Drive();
        public abstract string Stop();
    }
}
