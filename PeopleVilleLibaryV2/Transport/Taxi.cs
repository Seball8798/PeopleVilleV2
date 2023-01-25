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
                    Console.WriteLine("Restaurant");
                    break;
                case 2:
                    Console.WriteLine("From Supermarket");
                    break;             
                case 3:                
                    Console.WriteLine("From Bank");
                    break;             
                case 4:                
                    Console.WriteLine("From Station");
                    break;             
                case 5:                
                    Console.WriteLine("From Apotek");
                    break;             
                case 6:                
                    Console.WriteLine("From Bibliotek");
                    break;             
                case 7:                
                    Console.WriteLine("From Centrum");
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
                    Console.WriteLine("Stop Restaurant");
                    break;
                case 2:
                    Console.WriteLine("Stop Supermarket");
                    break;
                case 3:
                    Console.WriteLine("Stop Bank");
                    break;
                case 4:
                    Console.WriteLine("Stop Station");
                    break;
                case 5:
                    Console.WriteLine("Stop Apotek");
                    break;
                case 6:
                    Console.WriteLine("Stop Bibliotek");
                    break;
                case 7:
                    Console.WriteLine("Stop Centrum");
                    break;
            }
        }
    }
}
