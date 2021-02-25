using System;
using System.Collections.Generic;

namespace JediMindTricksH1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Dictionary<string, int> family = new Dictionary<string, int>();

            // 2.
            // Adding a new value using the add-method
            family.Add("Maria", 40);

            // Adding a new value using the indexnotation method
            family["Emilie"] = 14;
            
            // Printing to check
            foreach (var pair in family)
            {
                Console.WriteLine($"Name: { pair.Key}, Age: {pair.Value}");
            }
            Console.WriteLine();
            
            // 3.
            // Remove the element with the key "Han from the dictionary

            // Initialising a new dictionary and adding values
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };

            // Printing the dictionary (4)

            foreach (var pair in characters)
            {
                Console.WriteLine($"{ pair.Key} is a jedi: {pair.Value}");
            }


            // Removing Han
            characters.Remove("Han");

            Console.WriteLine();

            // Checking if Han is removed
            if(characters.Remove("Han"))
            {
                Console.WriteLine("Removed Han");
            }
            else
            {
                Console.WriteLine("Couldn't find Han");
            }
            Console.ReadKey();

         }
    }
}
