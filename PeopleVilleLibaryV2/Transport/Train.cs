using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Transport
{
    public class Train : Transport
    {

        public override void Drive() 
        {

            Random rnd = new Random();
            int retningA = rnd.Next(1, 7);

            switch (retningA)
            {
                case 1:
                    Console.WriteLine("From St Odense");
                    break;
                case 2:
                    Console.WriteLine("From St Ondesvej");
                    break;
                case 3:
                    Console.WriteLine("From St Ringsvej");
                    break;
                case 4:
                    Console.WriteLine("From St Lunekovvej");
                    break;
                case 5:
                    Console.WriteLine("From St Blommevej");
                    break;
                case 6:
                    Console.WriteLine("From St Ballørup");
                    break;
                case 7:
                    Console.WriteLine("From St Ryparken");
                    break;
            }
        }

        public  override void Stop() 
        {
            Random rnd = new Random();
            int retningStop = rnd.Next(1, 7);

            switch (retningStop)
            {
                case 1:
                    Console.WriteLine("Stop St Odense");
                    break;
                case 2:
                    Console.WriteLine("Stop St Ondesvej");
                    break;
                case 3:
                    Console.WriteLine("Stop Ringsvej");
                    break;
                case 4:
                    Console.WriteLine("Stop St Lunekovvej");
                    break;
                case 5:
                    Console.WriteLine("Stop St Blommevej");
                    break;
                case 6:
                    Console.WriteLine("Stop St Ballørup");
                    break;
                case 7:
                    Console.WriteLine("Stop St Ryparken");
                    break;
            }
        }
    }
}

