﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Date
{
    internal class Days
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
    }
}
