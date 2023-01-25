using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Date
{
    public class Days
    {
        public List<string> dayNames;
        private bool newDay;
        private int Salary;

        public Days(List<string> dayNames, bool newDay, int Salary)
        {
            this.dayNames = dayNames;
            this.newDay = newDay;
            this.Salary = Salary;
        }
        public enum WeekDays
        {
            Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday, Monday
        }
        public Days()
        {

            WeekDays startingDay = (WeekDays)(new Random()).Next(0, 7);
            switch (startingDay)
            {
                case WeekDays.Monday:
                    Console.WriteLine("Monday");
                    break;
                case WeekDays.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case WeekDays.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;
                case WeekDays.Thursday:
                    Console.WriteLine("Thursday");
                    break;
                case WeekDays.Friday:
                    Console.WriteLine("Friday");
                    break;
                case WeekDays.Saturday:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Sunday");
                    break;
            }





        }
    }
}
