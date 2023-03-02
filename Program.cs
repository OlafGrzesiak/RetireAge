using System;
using System.Reflection;

namespace retireAge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type your age:");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Whats your gender? Type m or f");
            string userGender = Console.ReadLine();

            int maleRetireAge = 65; // in poland retire age for male is 65
            int femaleRetireAge = 60; // in poland retire age for female is 60

            int maleRetireDiff = maleRetireAge - userAge;
            int femaleRetireDiff = femaleRetireAge - userAge;



            if (userAge < 0)
            {
                Console.WriteLine("Age cannot be negative!");
            }

            if (userGender != "m" && userGender != "f")
            {
                Console.WriteLine("Invalid gender");
            }

            else if (userGender == "m")
            {
                if (userAge >= maleRetireAge)
                {
                    Console.WriteLine("You are retired!");
                }
                else
                {
                    Console.WriteLine($"You are {maleRetireDiff} years away from retirement!");
                }
            }

            else if (userGender == "f")
            {
                if (userAge >= femaleRetireAge)
                {
                    Console.WriteLine("You are retired!");
                }
                else
                {
                    Console.WriteLine($"You are {femaleRetireDiff} years away from retirement!");
                }
            }

            Console.ReadKey();

        }
    }
}
