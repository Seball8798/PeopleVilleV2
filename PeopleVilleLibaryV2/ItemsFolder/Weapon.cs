﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.iItems
{
    public class Weapon : Iitems
    {
        public string name { get; set; }

        public int price { get; set; }

        public List<string> WeaponList()
        {
            List<string> weapon = new List<string>();
            weapon.Add("AK47"); weapon.Add("Grenade"); weapon.Add("Knife"); weapon.Add("Axe"); weapon.Add("Tank");
            return weapon;

        }
    }
}
