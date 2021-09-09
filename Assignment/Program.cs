using System;

namespace Assignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                double num0 = 0;

                double num1 = 0;
                double result = 0;

                Console.Clear();
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("Calculator Program");

                Console.WriteLine("Enter a number 0: ");
                num0 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter a number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter a command:");
                Console.WriteLine("* : Multiply ");
                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Substract");
                Console.WriteLine("/ : Divide");


                switch (Console.ReadLine())
                   
                {

                    case "*":
                        result = num0 + num1;
                        Console.WriteLine($"Your answer: {num0} * {num1} = {(num0, num1 + result)}"); 
                        break;

                    case "+":
                        result = num0 + num1;
                        Console.WriteLine($"Your answer: {num0} + {num1} = {(num0, num1 + result)}");
                        break;

                    case "-":
                        result = num0 - num1;
                        Console.WriteLine($"Your answer: {num0} - {num1} = {(num0, num1 + result)}");
                        break;

                    case "/":
                        result = num0 / num1;
                        Console.WriteLine($"Your answer: {num0} / {num1} = {(num0, num1 + result)}");
                        break;

                    default:
                        Console.WriteLine("Unvalid command");
                        break;
                        
                }
                Console.WriteLine("Keep going? (O = ok, N = no)");



            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Goodbye");
            Console.ReadKey();


        }//end of main


        


    }// end of program
}
