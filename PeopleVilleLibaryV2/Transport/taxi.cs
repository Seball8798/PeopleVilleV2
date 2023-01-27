using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Transport
{
    public class Taxi : Transport
    {
        public override string Drive()
        {
            Random rnd = new Random();
            int retning = rnd.Next(1, 7);

            switch (retning)
            {
                case 1:
                    return "Restaurant";
                case 2:
                    return "From Supermarket";
                case 3:
                    return "From Bank";
                case 4:
                    return "From Station";             
                case 5:
                    return "From Apotek";             
                case 6:
                    return "From Bibliotek";             
                case 7:                
                    return"From Centrum";              
            }
            return "";
        }

        public override string Stop()
        {

            Random rnd = new Random();
            int stop = rnd.Next(1, 7);

            switch (stop)
            {
                case 1:
                    return "Stop Restaurant";
                case 2:
                    return "Stop Supermarket";
                case 3:
                    return "Stop Bank";
                case 4:
                    return "Stop Station";
                case 5:
                    return "Stop Apotek";
                case 6:
                    return "Stop Bibliotek";
                case 7:
                    return "Stop Centrum";
            }
            return "";
        }
    }
}
