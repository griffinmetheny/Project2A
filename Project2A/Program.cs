using System;
using System.Threading.Tasks.Sources;

namespace Project2A
{
  // Griffin Metheny
  // 9/14
  // Project 2A application
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // message prompting user to enter value between 1 and 25
                Console.WriteLine("Please enter an integer between 1 and 25");
                // receives input of users
                string input = Console.ReadLine();
                // converts string value (input) into integer (valueOfInput)
                int valueOfInput = int.Parse(input);

                // if else statement
                // the if portion ensures user input meets criteria (1-25)
                if ((valueOfInput < 1) || (valueOfInput > 25))
                {
                    // if the input is invalid, display this message
                    Console.WriteLine("Please input a valid integer and try again");
                }
                // the else portion executes if the input is valid
                else
                {
                    //for statement to display output
                    for (int i = 1; i <= valueOfInput; i++)
                    {
                        // display of the output
                        Console.WriteLine("You have entered " + input + "." + " The current integer in the loop is " + i);
                    }
                }
            }
            
            catch (Exception)
            {
                // display message if text is input 
                Console.WriteLine("Please input a valid integer and try again");
            }
        }
    }
}
