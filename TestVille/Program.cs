﻿using PeopleVilleLibraryV2;
using PeopleVilleLibraryV2.Date;
using PeopleVilleLibraryV2.iItems;
using PeopleVilleLibraryV2.InhibitansFolder;
using PeopleVilleLibraryV2.Location;
using PeopleVilleLibraryV2.Transport;

public class Program
{
    private static void Main(string[] args)
    {

        Inhibitans inhibitans = new Inhibitans();
        inhibitans.InhibitansProfil();
        Console.ReadLine();


        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("_______________Polymorphism________________");
        Console.WriteLine();
        Location location = new Location();
        Supermarket supermarket = new Supermarket();
        Restaurant restaurant = new Restaurant();

        location.Medarbejder();
        supermarket.Medarbejder();
        restaurant.Medarbejder();

    }
}