using PeopleVilleLibraryV2;
using PeopleVilleLibraryV2.Date;
using PeopleVilleLibraryV2.iItems;
using PeopleVilleLibraryV2.Inhibitans;

public class Program
{
    private static void Main(string[] args)
    {
        Food food = new Food();
        Weapon weapon = new Weapon();
        Inhibitans inhibitans1 = new Inhibitans();
        Days days = new Days();

        weapon.WeaponList();
        food.FoodList();
        
    }
    //public static void FoodArray()
    //{
    //    List<string> food = new List<string>();
    //    food.Add("Mango"); food.Add("Banan"); food.Add("Orange"); food.Add("Pizza"); food.Add("Burger"); food.Add("Apple"); food.Add("Pineapple");
    //    //Food[] food = {new Food ("salat"),
    //    //                   new Food ("pizza"),
    //    //                   new Food ("Bønner")};

    //    foreach (var item in food)
    //    {
    //        Console.WriteLine(item.ToString());

    //    }
    //    //return food.Length;
    //

}