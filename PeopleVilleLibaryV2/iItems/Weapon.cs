using System;
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

        public string pickup()
        {

            return "" ;
        }
        public string transfer()
        {
            return "";

        }
        public void WeaponList()
        {
            List<string> weapon = new List<string>();   
            weapon.Add("Ak47"); weapon.Add("Grenade"); weapon.Add("Knife"); weapon.Add("Baseball Bat"); weapon.Add("En fucking vikinge tanks!");

            foreach (var item in weapon)
            {
                Console.WriteLine(item.ToString());

            }
        }

    }
}
