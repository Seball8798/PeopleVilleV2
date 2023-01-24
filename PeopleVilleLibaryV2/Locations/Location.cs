using PeopleVilleLibraryV2.Date;
using PeopleVilleLibraryV2.iItems;
using PeopleVilleLibraryV2.Transport;
using PeopleVilleLibraryV2;
using PeopleVilleLibraryV2.InhibitansFolder;

namespace PeopleVilleLibraryV2.Location
{
    public class Location
    {

        public string streetName;
        public int streetNumber;

        public Location(string streetName, int streetNumber)
        {
            this.streetName = streetName;
            this.streetNumber = streetNumber;

        }
        public Location(string streetName)
        {
            this.streetName = streetName;

        }

        public Location()
        {

        }


        //public void AddInhabitant(Inhibitans inhabitant)
        //{
        //    Inhabitants.Add(inhabitant);
        //}

        public void Traffic()
        {

            Food food = new Food();
            Weapon weapon = new Weapon();
            Inhibitans inhibitans1 = new Inhibitans();
            Inhibitans inhibitans2 = new Inhibitans();

            Days days = new Days();
            Taxi taxi = new Taxi();
            Train train = new Train();
            Supermarket supermarket = new Supermarket();
            Restaurant restaurant = new Restaurant();
            Random rnd = new Random();

            weapon.WeaponList();
            food.FoodList();

            //inhibitans1.InhibitansProfil(inhibitans1);
            //inhibitans1.InhibitansProfil(inhibitans2);
        }
    }
}