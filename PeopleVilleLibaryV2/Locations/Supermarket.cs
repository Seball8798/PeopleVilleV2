using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Location
{
    public class Supermarket : Location
    {
        public List<string> Locations { get; set; }

        public Supermarket(string streetName, int streetNumber, List<string> items) : base(streetName, streetNumber)
        {
            Locations = SupermarketsList();
        }

        public Supermarket(string streetName, int streetNumber) : base(streetName, streetNumber)
        {
            Locations = SupermarketsList();

        }

        public Supermarket(string streetName) : base(streetName)
        {
            Locations = SupermarketsList();

        }

        public Supermarket()
        {
            Locations = SupermarketsList();
        }

        public List<string> SupermarketsList()
        {
            List<string> supermarketsList = new List<string>();
            supermarketsList.Add("Lidl");
            supermarketsList.Add("Aldi");
            supermarketsList.Add("Walmart");
            supermarketsList.Add("Rema 1000");
            supermarketsList.Add("Bilka");
            return supermarketsList;
        }


        public override void Medarbejder()
        {
            Console.WriteLine("Vi er medarbejder fra Supermarket.");
        }
    }
}
