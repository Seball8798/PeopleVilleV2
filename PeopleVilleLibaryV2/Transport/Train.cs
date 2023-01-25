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
                    Console.WriteLine("---> St Odense");
                    break;
                case 2:
                    Console.WriteLine("---> St Ondesvej");
                    break;
                case 3:
                    Console.WriteLine("---> St Ringsvej");
                    break;
                case 4:
                    Console.WriteLine("---> St Lunekovvej");
                    break;
                case 5:
                    Console.WriteLine("---> St Blommevej");
                    break;
                case 6:
                    Console.WriteLine("---> St Ballørup");
                    break;
                case 7:
                    Console.WriteLine("---> St Ryparken");
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
                    Console.WriteLine("Ø St Odense");
                    break;
                case 2:
                    Console.WriteLine("Ø St Ondesvej");
                    break;
                case 3:
                    Console.WriteLine("ØSt Ringsvej");
                    break;
                case 4:
                    Console.WriteLine("Ø St Lunekovvej");
                    break;
                case 5:
                    Console.WriteLine("Ø St Blommevej");
                    break;
                case 6:
                    Console.WriteLine("Ø St Ballørup");
                    break;
                case 7:
                    Console.WriteLine("Ø St Ryparken");
                    break;
            }
        }
    }
}

