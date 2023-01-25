using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Transport
{
    public class Taxi : Transport
    {
        public override void Drive()
        {
            Random rnd = new Random();
            int retning = rnd.Next(1, 7);

            switch (retning)
            {
                case 1:
                    Console.WriteLine("---> Restaurant");
                    break;
                case 2:
                    Console.WriteLine("---> Supermarket");
                    break;
                case 3:
                    Console.WriteLine("---> Bank");
                    break;
                case 4:
                    Console.WriteLine("---> Station");
                    break;
                case 5:
                    Console.WriteLine("---> Apotek");
                    break;
                case 6:
                    Console.WriteLine("---> Bibliotek");
                    break;
                case 7:
                    Console.WriteLine("---> Centrum");
                    break;
            }
        }

        public override void Stop()
        {

            Random rnd = new Random();
            int stop = rnd.Next(1, 7);

            switch (stop)
            {
                case 1:
                    Console.WriteLine("Ø Restaurant");
                    break;
                case 2:
                    Console.WriteLine("Ø Supermarket");
                    break;
                case 3:
                    Console.WriteLine("Ø Bank");
                    break;
                case 4:
                    Console.WriteLine("Ø Station");
                    break;
                case 5:
                    Console.WriteLine("Ø Apotek");
                    break;
                case 6:
                    Console.WriteLine("Ø Bibliotek");
                    break;
                case 7:
                    Console.WriteLine("Ø Centrum");
                    break;
            }
        }
    }
}
