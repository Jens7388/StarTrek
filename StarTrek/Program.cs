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
                string[] allowedVulcanMaleNameCharacters = { "S,Sp,Sk,St,T", "a,e,i,o,u,y", "r,t,p,d,f,j,k,l,v,b,n,m", "a,e,i,o,u,y",  "q,p,k,ck,l" };
                Console.Write("Indtast et navn: ");
                string input = Console.ReadLine();
                if(input == String.Concat(allowedVulcanMaleNameCharacters[0].Split(","), allowedVulcanMaleNameCharacters[1].Split(","), allowedVulcanMaleNameCharacters[2].Split(","), allowedVulcanMaleNameCharacters[3].Split(","), allowedVulcanMaleNameCharacters[4].Split(",")))
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