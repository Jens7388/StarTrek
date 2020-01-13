using System;
using System.Collections.Generic;

namespace StarTrek
{
    // COPYRIGHT JENS PEDERSEN!!! Ulovlig kopiering er ulovligt!!
    class Program
    {
        static List<string> vulcanMaleNames = new List<string>();
        static List<string> vulcanFemaleNames = new List<string>();
        static Random generator = new Random();

        private static void GenerateVulcanMaleNames()
        {
            string[] allowedVulcanMaleNameChars = { "S", "Sp", "Sk", "St", "T" };
            string[] allowedVulcanMaleNameChars2 = { "a", "e", "i", "o", "u", "y" };
            string[] allowedVulcanMaleNameChars3 = { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
            string[] allowedVulcanMaleNameChars4 = { "a", "e", "i", "o", "u", "y" };
            string[] allowedVulcanMaleNameChars5 = { "q", "p", "k", "ck", "l" };
            while(vulcanMaleNames.Count != 10800)
            {              
                int firstChars = generator.Next(0, allowedVulcanMaleNameChars.Length);
                int secondChars = generator.Next(0, allowedVulcanMaleNameChars2.Length);
                int thirdChars = generator.Next(0, allowedVulcanMaleNameChars3.Length);
                int fourthChars = generator.Next(0, allowedVulcanMaleNameChars4.Length);
                int fifthChars = generator.Next(0, allowedVulcanMaleNameChars5.Length);

                string vulcanMaleName = allowedVulcanMaleNameChars[firstChars] + 
                    allowedVulcanMaleNameChars2[secondChars] +
                    allowedVulcanMaleNameChars3[thirdChars] + 
                    allowedVulcanMaleNameChars4[fourthChars] + 
                    allowedVulcanMaleNameChars5[fifthChars];
                string moreVulcanMaleNames = allowedVulcanMaleNameChars[firstChars] + 
                    allowedVulcanMaleNameChars2[secondChars] + 
                    allowedVulcanMaleNameChars5[fifthChars];

                if(!vulcanMaleNames.Contains(vulcanMaleName))
                {
                    vulcanMaleNames.Add(vulcanMaleName); 
                }
                if(!vulcanMaleNames.Contains(moreVulcanMaleNames))
                {
                    vulcanMaleNames.Add(moreVulcanMaleNames);
                }
            }
        }
        private static void GenerateVulcanFemaleNames()
        {
            string[] allowedVulcanFemaleNameChars = { "T'" };  
            string[] allowedVulcanFemaleNameChars2 = { "P", "K", "Q" };
            string[] allowedVulcanFemaleNameChars3 = { "a", "e", "i", "o", "u", "y" };
            string[] allowedVulcanFemaleNameChars4 = { "r", "j", "'p", "k", "l" };
            for(int i = 0; i < 42069; i++)
            {
                int firstChars = generator.Next(0, allowedVulcanFemaleNameChars.Length);
                int secondChars = generator.Next(0, allowedVulcanFemaleNameChars2.Length);
                int thirdChars = generator.Next(0, allowedVulcanFemaleNameChars3.Length);
                int fourthChars = generator.Next(0, allowedVulcanFemaleNameChars4.Length);

                string vulcanFemaleName = allowedVulcanFemaleNameChars[firstChars] + 
                    allowedVulcanFemaleNameChars2[secondChars] +
                    allowedVulcanFemaleNameChars3[thirdChars] + 
                    allowedVulcanFemaleNameChars4[fourthChars];    
                
                vulcanFemaleNames.Add(vulcanFemaleName);
            }
        }
        static void Main()
        {
            GenerateVulcanMaleNames();
            GenerateVulcanFemaleNames();
            while(true)
            {
                List<string> inputVulcanMaleNames = new List<string>();
                List<string> inputVulcanFemaleNames = new List<string>(); 

                Console.Write("Hvor mange vulcan navne ønsker du at indtaste?: ");
                string input = Console.ReadLine();
                int.TryParse(input, out int names);
                for(int i = 0; i < names; i++)
                {
                    input = Console.ReadLine();
                    if(vulcanMaleNames.Contains(input))
                    {
                        Console.WriteLine($"'{input}' er et lovligt vulcan male navn");
                        inputVulcanMaleNames.Add(input);
                    }
                    else if(vulcanFemaleNames.Contains(input))
                    {
                        Console.WriteLine($"'{input}' er et lovligt vulcan female navn");
                    }
                    else
                    {
                        Console.WriteLine($"'{input}' er ikke et lovligt vulcan male eller female navn");
                    }
                }
                
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}