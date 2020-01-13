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
                string[] allowedVulcanMaleNameChars = { "S", "Sp", "Sk", "St", "T" };
                string[] allowedVulcanMaleNameChars2 = { "a", "e", "i", "o", "u", "y" };
                string[] allowedVulcanMaleNameChars3 = { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
                string[] allowedVulcanMaleNameChars4 = { "a", "e", "i", "o", "u", "y" };
                string[] allowedVulcanMaleNameChars5 = { "q", "p", "k", "ck", "l" };
                for(int i = 0; i < 42069; i++)
                {
                    Random generator = new Random();
                    int firstChars = generator.Next(0, allowedVulcanMaleNameChars.Length);
                    int secondChars = generator.Next(0, allowedVulcanMaleNameChars.Length);
                    int thirdChars = generator.Next(0, allowedVulcanMaleNameChars.Length);
                    int fourthChars = generator.Next(0, allowedVulcanMaleNameChars.Length);
                    int fifthChars = generator.Next(0, allowedVulcanMaleNameChars.Length);

                    string vulcanMaleName = allowedVulcanMaleNameChars[firstChars] + allowedVulcanMaleNameChars2[secondChars] +
                        allowedVulcanMaleNameChars3[thirdChars] + allowedVulcanMaleNameChars4[fourthChars] + allowedVulcanMaleNameChars5[fifthChars];
                    vulcanMaleNames.Add(vulcanMaleName);
                }
                /*Console.Write("Indtast et navn: ");
                if(input)
                {
                    Console.WriteLine("Dette er et lovligt vulcan male navn");
                }
                else
                {
                    Console.WriteLine("Dette er ikke et lovligt vulcan male navn");
                }*/
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}