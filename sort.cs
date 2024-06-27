using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Initialize a list of names
        List<string> names = new List<string> { "Shravani", "Aditi", "Sakshi", "pooja", "Sharvi" };

        // Sort the list in alphabetical order
        names.Sort();

        // Print the sorted list
        Console.WriteLine("Names in alphabetical order:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
