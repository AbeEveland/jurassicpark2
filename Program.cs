using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark2
{
    class Program
    {

        //problem: create an application to manage dinosaurs in a zoo
        //create a class to represent dinos
        //class dinos should have these properties:
        //    Diet type - this will be carnivore or herbivore
        //    when acquired - this will default to the current time when the dinosaur is created
        //    weight - how heavy the dino is in pounds
        //    enclosure number  - then number of the pen the dino is currently in.
        //add a method called "description" to your class to print out a description of the
        //dinos to include all of its properties. create an output format of your choosing
        //store dinos in a list<dinosaur>
        //this is what should happen when the console runs.
        // # view # this command ill show all the dinos in the list, ordered by "whenacquired"
        // # add # this command will let the user type in the info for a dino and add it to the list
        // # remove # this command will prompt the user for a dino name then find and delete the dino witht hat name
        // # transfer # this command will prompt the user for a dino name and a new "enclosurenumber" and update that dinos info
        // # summary # this command will display the number of carnivors and the number of herbavors.
        // # quit # this will stoop the program
        //=================================================================================================
        // # p -Problem:  create an app that allows us to manage info of DINOS.
        // 1. Create a class that has: diet type,when acquired, weight, enclosure number.

        class Dino
        {

            public string Name { get; set; }
            public string DietType { get; set; }
            public string WhenAcquired { get; set; }
            public int Weight { get; set; }
            public int EnclosureNumber { get; set; }

            static void Description(Dino thisDino)
            {
                Console.WriteLine($"This is the dino's name      {thisDino.name}");
                Console.WriteLine($"This is the dino's diet type {thisDino.diettype}");
                Console.WriteLine($"This is the dino's birthday  {thisDino.whenacquired}");
                Console.WriteLine($"This is the dino's weight    {thisDino.weight}");
                Console.WriteLine($"This is the dino's address   {thisDino.enclosurenumber}");
            }
        }


        static void Main(string[] args)
        {

            var dinosaurs = new List<Dino>();

            var fluffy = new Dino
            {
                name = "fluffy",
                diettype = "herbivore",
                whenacquired = "",
                weight = $"3000 lbs ",
                enclosurenumber = 1,
            };

            Dino precious = new Dino
            {
                name = "precious",
                diettype = "herbivore",
                whenacquired = "",
                weight = $"1500 lbs",
                enclosurenumber = 2,
            };

            Dino sweety = new Dino
            {
                name = "sweety",
                diettype = "carnivore",
                whenacquired = "",
                weight = $"800 lbs",
                enclosurenumber = 3,
            };

            Dino max = new Dino
            {
                name = "max",
                diettype = "carnivore",
                whenacquired = "",
                weight = $"10000 lbs",
                enclosurenumber = 4,
            };

            Dino brutus = new Dino
            {
                name = "brutus",
                diettype = "carnivore",
                whenacquired = "",
                weight = $"9000 lbs",
                enclosurenumber = 5,
            };

            dinosaurs.Add(fluffy);
            dinosaurs.Add(precious);
            dinosaurs.Add(sweety);
            dinosaurs.Add(max);
            dinosaurs.Add(brutus);

            while (1 == 1)
            {

                for (int i = 0; i < dinosaurs.Count; i++)
                {

                    //Console.WriteLine(i);
                    //Console.WriteLine($"Name:             {dinosaurs.name}");
                    //Console.WriteLine($"Diet:             {dinosaurs.diettype}");
                    //Console.WriteLine($"When Acquired:    {dinosaurs.whenacquired}");
                    //Console.WriteLine($"Weight:           {dinosaurs.weight}");
                    //Console.WriteLine($"Enclosure Number: {dinosaurs.enclosurenumber}");
                }

                Console.WriteLine("(A)dd, (V)iew, (R)emove, (T)ransfer, (S)ummary, (Q)uit: ");
                string choice = Console.ReadLine();

                /*view*/
                if (choice == "V" || choice == "v")
                {
                    var view = dinosaurs.OrderBy(Dino => Dino.whenacquired);
                    Console.WriteLine(view);
                }

                /*add*/
                if (choice == "A" || choice == "a")
                {
                    Console.WriteLine("name: ");
                    var newname = Console.ReadLine();

                    Console.WriteLine("diet type: ");
                    var newdiettype = Console.ReadLine();

                    Console.WriteLine("birthdate: ");
                    var newwhenacquired = Console.ReadLine();

                    Console.WriteLine("weight: ");
                    var newweight = Console.ReadLine();

                    Console.WriteLine("pen number: ");
                    var newenclosurenumber = Int32.Parse(Console.ReadLine());

                    Dino newDinosaur = new Dino
                    {
                        name = newname,
                        diettype = newdiettype,

                        whenacquired = newwhenacquired,
                        weight = newweight,
                        enclosurenumber = newenclosurenumber,
                    };
                    dinosaurs.Add(newDinosaur);
                }

                /*remove*/
                if (choice == "R" || choice == "r")
                {

                    Console.WriteLine("Name of dino to remove");
                    var dinonametoremove = Console.ReadLine();

                    var removedino = dinosaurs.FirstOrDefault(Dino => Dino.name == dinonametoremove);

                    if (removedino == null) Console.WriteLine($"There is no dino named {dinonametoremove}");
                    else
                    {
                        Console.WriteLine("Are you sure you want to remove this dino? (y/n): ");
                        var shouldweremove = Console.ReadLine();
                        if (shouldweremove == "y") dinosaurs.Remove(removedino);
                    }
                }


                /*summary*/
                if (choice == "S" || choice == "s")
                {
                    // # summary # this command will display the number of carnivors and the number of herbavors.
                }

                /*quit*/
                if (choice == "Q" || choice == "q")
                {
                    // # transfer # this command will prompt the user for a dino name and a new "enclosurenumber" and update that dinos info
                }

                /*quit*/
                if (choice == "Q" || choice == "q") break;

            }
        }
    }
}


