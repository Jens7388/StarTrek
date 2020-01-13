using System;
using System.Collections.Generic;

namespace StarTrek
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                List<string> vulcanMaleNames = new List<string>();
                List<string> vulcanFemaleNames = new List<string>();
                string[] allowedVulcanMaleNameCharacters = { "S", "Sp ", "Sk", "St", "T" };
                string[] allowedVulcanMaleNameCharacters2 = { "a", "e", "i", "o", "u", "y" };
                string[] allowedVulcanMaleNameCharacters3 = { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
                string[] allowedVulcanMaleNameCharacters4 = { "a", "e", "i", "o", "u", "y" };
                string[] allowedVulcanMaleNameCharacters5 = { "q", "p", "k", "ck", "l" };
                Console.Write("Indtast et navn: ");
                string input = Console.ReadLine();
                if(input == allowedVulcanMaleNameCharacters[0] + allowedVulcanMaleNameCharacters2[0] + allowedVulcanMaleNameCharacters3[0] + allowedVulcanMaleNameCharacters4[0] + allowedVulcanMaleNameCharacters5[0])
                {
                    Console.WriteLine("Dette er et lovligt vulcan male navn");
                }
                else
                {
                    Console.WriteLine("Dette er ikke et lovligt vulcan male navn");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}