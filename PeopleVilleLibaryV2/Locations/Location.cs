namespace PeopleVilleLibraryV2.Location
{
    public class Location
    {

        public string streetName;
        public int streetNumber;
        public int streetContact;

        private Location(string streetName, int streetNumber, int streetContact)
        {
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.streetContact = streetContact;
        }

        public void Buy()
        {

        }

    }
}