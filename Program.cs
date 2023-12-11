using System;
using System.Collections.Generic;
using System.Linq;


namespace Cities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+--------------+");
            Console.WriteLine("|    WELCOME   |");
            Console.WriteLine("+--------------+");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("==============================================================================================");
            Console.WriteLine("Our app will introduce you to captivating destinations and provide intriguing fun facts based on the cities' first and last letters.");
            Console.WriteLine("");
            Console.WriteLine("To begin, here are 10 cities waiting for you:");

            string[] citiesList = { "Butterworth", "Mthatha", "Jagersfontein", "Kroonstad", "Boksburg", "Soweto", "Empangeni", "Polokwane", "Secunda", "Kuruman" };

            // foreach will display each item in the array under each other.
            foreach (string list in citiesList)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine("");
            Console.WriteLine("==============================================================================================");

            Console.WriteLine("");
            Console.WriteLine("Please enter the first letter: ");
            string firstLetter = Console.ReadLine().ToUpper(); //First letter input, no matter what the user input the string will be converted to a capital letter

            Console.WriteLine("");
            Console.WriteLine("Please enter the last letter: ");
            string lastLetter = Console.ReadLine().ToLower(); //Last letter input, no matter what the user input the string will be converted to a lower letter

            //The dictionary contains the fun fact information that will be displayed
            Dictionary<string, string> funFacts = new Dictionary<string, string>
            {
                { "Butterworth", " is one of the oldest towns in the Amatole in Eastern Cape Province. Developed around the Wesleyan Mission Station and was built on the banks of the Gcuwa River in 1827. "},
                { "Mthatha", " formerly known as Umtata, is the birthplace of Nelson Mandela." },
                { "Jagersfontein", " is home to the oldest and largest diamond mine hole in the world. Mining began in 1870 and the pit was hand-dug for 39 years until 1909."},
                { "Kroonstad", " is an afrikaans word directly translated to Crown City and is the third largest city in the Free State (after Bloemfontein and Welkom)"},
                { "Boksburg", " was initially established as a gold mining town in 1887 during the South African gold rush. It quickly grew into a thriving community and played a significant role in the mining industry of the region."},
                { "Soweto", " name is an English syllabic abbreviation for SOuth WEstern TOwnships."},
                { "Empangeni", " is surrounded by sugarcane plantations and is an important agricultural hub in the region. It’s home to several industries, including a paper mill, a sugar mill, and a distillery."},
                { "Polokwane", " formerly known as Pietersburg, is well known for Hunting Safari’s, Arts and Crafts and a Game Breeding Centre"},
                { "Secunda", " name comes from the Latin word 'secundi' meaning second. It was the second Sasol extraction refinery producing oil from coal, after Sasolburg."},
                { "Kuruman", " The Eye of Kuruman is said to be the largest natural spring in the Southern Hemisphere."}
            };

            //LINQ Queries
            var checkList = from city in citiesList
                            where city.StartsWith(firstLetter) && city.EndsWith(lastLetter)
                            select city;

            bool cityFound = false;  //this boolean will check if the city is found

            foreach (var city in checkList)
            {
                if (city.StartsWith(firstLetter) && city.EndsWith(lastLetter))
                {
                    cityFound = true; // Set the flag to true

                    Console.WriteLine(city);
                    Console.WriteLine("");
                    Console.WriteLine($"Fun Fact : {city}" + funFacts[city]);
                    Console.WriteLine("");
                    
                }
            }
            
            if (!cityFound)
            {
                Console.WriteLine("No City found with those characters");
                Console.WriteLine("");

            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Wait for a key press before exiting
        }
    }
}



/*
foreach (var city in checkList)
{
    if (city == citiesList[0])
    {
        Console.WriteLine(city + " is one of the oldest towns in the Amatole in Eastern Cape Province. Developed around the Wesleyan Mission Station and was built on the banks of the Gcuwa River in 1827.");
    }
    else if (city == citiesList[1])
    {
        Console.WriteLine(city + " formerly known as Umtata, is the birthplace of Nelson Mandela.");
    }

    else if (city == citiesList[2])
    {
        Console.WriteLine(city + " is home to the oldest and largest diamond mine hole in the world. Mining began in 1870 and the pit was hand-dug for 39 years until 1909.");
    }
    else if (city == citiesList[3])
    {
        Console.WriteLine(city + " is an afrikaans word directly translated to Crown City and is the third largest city in the Free State (after Bloemfontein and Welkom)");
    }
    else if (city == citiesList[4])
    {
        Console.WriteLine(city + " was initially established as a gold mining town in 1887 during the South African gold rush. It quickly grew into a thriving community and played a significant role in the mining industry of the region.");
    }
    else if (city == citiesList[5])
    {
        Console.WriteLine(city + " name is an English syllabic abbreviation for SOuth WEstern TOwnships.");
    }
    else if (city == citiesList[6])
    {
        Console.WriteLine(city + " is surrounded by sugarcane plantations and is an important agricultural hub in the region. It’s home to several industries, including a paper mill, a sugar mill, and a distillery.");
    }
    else if (city == citiesList[7])
    {
        Console.WriteLine(city + " formerly known as Pietersburg, is well known for Hunting Safari’s, Arts and Crafts and a Game Breeding Centre");
    }
    else if (city == citiesList[8])
    {
        Console.WriteLine(city + " name comes from the Latin word 'secundi' meaning second. It was the second Sasol extraction refinery producing oil from coal, after Sasolburg.");
    }
    else if (city == citiesList[9])
    {
        Console.WriteLine(city + " The Eye of Kuruman is said to be the largest natural spring in the Southern Hemisphere.");
    }
    else
    {
        Console.WriteLine("No City found with those characters");
    }
}
*/

