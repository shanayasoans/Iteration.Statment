/*
 Author: Shanaya Soans 
 Date: 1/29/20
 Comments: This C# console application code demonstartes the use of iterative statments 
 after getting inputs from users.
*/
using System;

namespace Iteration.Statment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for the input
            Console.Write("Enter an Integer value between 1 and 100 to execute an iterative statment: ");
            
            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be use to perform the various iterative statments and is parsed as an integer
                int value_of_input = int.Parse(input);

                // If the value of user input is between 1 and 100, execute a For Loop
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times.");

                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + "." + "This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
        }
    }
}
