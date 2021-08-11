using System;
using System.Collections.Generic;

namespace ConsoleApp_Iteration_Assignment
{
    class Program
    {
        static void Main(string[] args)

            

            //Part 1 adding a string to each item in the array Start
        {
            Console.WriteLine("I have the infinite loop code commented out\nUncomment it if you want to run it\n\n\n");
            
            
            string[] arrayOfPlanets = { "Mars", "Jupiter", "Neptune", "Venus", "Saturn", "Mercury", "Uranus", "Earth" };

            Console.WriteLine("Type your message here:\n");
            string userInput = Console.ReadLine();
            
            for (int i = 0; i < arrayOfPlanets.Length; i++)
            {
                arrayOfPlanets[i] = arrayOfPlanets[i] + " " + userInput;
                Console.WriteLine(arrayOfPlanets[i]);
            }

            Console.WriteLine("\n\n\n\n");
            
            //Part 1 adding a string to each item in the array End






            //Part 2 stuck in an infinate loop Start

            //Stuck in an infinate loop
            //while(number <= 10)
            //{
            //    Console.WriteLine(number);
            //}

            //Since variable number is always less than 10 the while loop has no escape clause

            int number = 1;

            while (number <= 10)
            {
                Console.WriteLine(number);
                number++; // By having number increase by one each loop the while loop can end once number reaches 10
            }

            Console.WriteLine("\n\n\n\n");

            //Part 2 stuck in an infinate loop End





            //Part 3 Comparission operators <  and <= Start

            number = 0;

            while(number < 5)
            {
                Console.WriteLine($"The < operator won\'t print 5 now it\'s at {number}");
                number++;
            }


            Console.WriteLine("\n\n\n\n");


            number = 0;

            while (number <= 5)
            {
                Console.WriteLine($"The <= operator will print now it\'s at {number}");
                number++;
            }

            Console.WriteLine("\n\n\n\n");

            //Part 3 Comparission operators <  and <= End

            
            
            //Part 4 Search List of strings Start

            List<string> driverNames = new List<string>();

            driverNames.Add("Hamilton");
            driverNames.Add("Verstappen");
            driverNames.Add("Perez");
            driverNames.Add("Bottas");
            driverNames.Add("Sainz");
            driverNames.Add("Leclerc");
            driverNames.Add("Alonso");


            int stop = driverNames.Count - 1;
            
            Console.WriteLine("Search for a driver here:\n");
            string userSearch = Console.ReadLine();
            
            for (int i = 0; i < driverNames.Count; i++)
            {
                if (driverNames[i] == userSearch)
                {
                    Console.WriteLine($"We found {driverNames[i]} at index {i}");
                    break;
                }

                else if (i == stop && driverNames[i] != userSearch )
                {
                     Console.WriteLine("No results found");
                }

            }
            

            Console.WriteLine("\n\n\n");


            //Part 4 Search List of strings End


            //Part 5 Same result Start

            List<string> names = new List<string>() { "William", "John", "Tony", "John", "Patrick", "Luckaz","Joan", "Nicole"};

            int stop2 = names.Count - 1;

            bool isFound = false;

            Console.WriteLine("Search for a worker here:\n");
            string userSearch2 = Console.ReadLine();
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == userSearch2)
                {
                    Console.WriteLine($"We found a {names[i]} at index {i}");
                    isFound = true;
                }

                else if (i == stop2 && userSearch2 != names[i] && isFound == false)
                {
                    Console.WriteLine("No Results found");
                }
            }

            //Part 5 Same result End
        }
    }
}
