using PeopleVilleLibraryV2;
using PeopleVilleLibraryV2.Date;
using PeopleVilleLibraryV2.iItems;
using PeopleVilleLibraryV2.InhibitansFolder;
using PeopleVilleLibraryV2.Location;
using PeopleVilleLibraryV2.Transport;

public class Program
{
    private static void Main(string[] args)
    {
        //weapon.WeaponList();
        //food.FoodList();

        //inhibitans1.InhibitansProfil(inhibitans1);
        //inhibitans1.InhibitansProfil(inhibitans2);
        Location location = new Location();
        Inhibitans inhibitans = new Inhibitans();
        location.Traffic();
        location.streetName = "Munkebjergvej";
        location.streetNumber = 130;
        inhibitans.InhibitansProfil(inhibitans);

        Console.WriteLine("\nlokation " + location.streetName);

        //Console.WriteLine(inhibitans);
        //Console.WriteLine("Inhibitans Name: " + inhibitans.name);
        //Console.WriteLine("Food: " + inhibitans.food);
        //Console.WriteLine("Weapon: " + inhibitans.weapon);



    }
}