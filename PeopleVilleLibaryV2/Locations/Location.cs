using PeopleVilleLibraryV2.Date;
using PeopleVilleLibraryV2.iItems;
using PeopleVilleLibraryV2.Transport;
using PeopleVilleLibraryV2;
using PeopleVilleLibraryV2.InhibitansFolder;

namespace PeopleVilleLibraryV2.Location
{
    public class Location
    {
        public List<string> Locations { get; set; }
        public string streetName;
        public int streetNumber;

        public Location(string streetname, int streetnumber)
        {
            Locations = new List<string>();
        }

        public Location(string streetname)
        {
            Locations = new List<string>();
        }

        public Location()
        {
            Locations = new List<string>();
        }

        public virtual void Medarbejder()
        {
            Console.WriteLine("Vi er medarbejder fra hele location.");
        }
    }
}