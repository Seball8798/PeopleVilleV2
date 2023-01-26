using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Date
{
    public class RandomEvents
    {
        public string GetRandomEvent()
        {
            Random rand = new Random();
            int eventNum = rand.Next(1, 4);
            switch (eventNum)
            {
                case 1:
                    return ",  The bank has been robbed!";
                case 2:
                    return ",  A new supermarket has opened in the city";
                case 3:
                    return ",  There is a free concert happening in the park tonight";
                default:
                    return ",  Nothing interesting happening today";
            }
        }
    }
}
