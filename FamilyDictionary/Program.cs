using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("Mother", new Dictionary<string, string>() { { "name", "Patricia" }, { "age", "71" } });

            myFamily.Add("Father", new Dictionary<string, string>() { { "name", "Laurence" }, { "age", "69" } });

            myFamily.Add("Sister", new Dictionary<string, string>() { { "name", "Josi" }, { "age", "36" } });

            myFamily.Add("Wife", new Dictionary<string, string>() { { "name", "Bridget" }, { "age", "30" } });

            foreach (var member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my { member.Key } and is {member.Value["age"]} years old.");
            }
            Console.ReadLine();
        }
    }
}
