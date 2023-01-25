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
            weapon.Add("AK47"); weapon.Add("Grenade"); weapon.Add("Knife"); weapon.Add("Baseball Bat"); weapon.Add("Tank");

            //foreach (var item in weapon)
            //{
            //    Console.WriteLine(item.ToString());

            //}

            //Random rand = new Random();
            //int eventNum = rand.Next(0, 5);
            //switch (eventNum)
            //{
            //    case 1:
            //        Console.WriteLine(weapon[0].ToString());
            //        break;
            //    case 2:
            //        Console.WriteLine(weapon[1].ToString());
            //        break;
            //    case 3:
            //        Console.WriteLine(weapon[2].ToString());
            //        break;
            //    case 4:
            //        Console.WriteLine(weapon[3].ToString());
            //        break;
            //    default:
            //        Console.WriteLine(weapon[4].ToString());
            //        break;
            //}
        }

    }
}
