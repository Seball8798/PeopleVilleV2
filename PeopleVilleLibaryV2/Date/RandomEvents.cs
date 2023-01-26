using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Date
{
    public class RandomEvents
    {
        // Random events
        public RandomEvents()
        {
            Random rand= new Random();
            int eventNum = rand.Next(1, 4);
            switch (eventNum)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }

        }
        public enum WeekDays
        {
            Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Monday
        }
        public void Days()
        {

            WeekDays startingDay = (WeekDays)(new Random()).Next(0, 7);
            switch (startingDay)
            {
                case WeekDays.Monday:
                    Console.WriteLine("The bank has been robbed!");
                    break;
                case WeekDays.Tuesday:
                    Console.WriteLine("A new supermarket has opened in the city");
                    break;
                case WeekDays.Wednesday:
                    Console.WriteLine("There is a free concert happening in the park tonight");
                    break;
                case WeekDays.Thursday:
                    Console.WriteLine("");
                    break;
                case WeekDays.Friday:
                    Console.WriteLine("Friday");
                    break;
                case WeekDays.Saturday:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Nothing interesting happening today");
                    break; 
            }


        }
    }
}
