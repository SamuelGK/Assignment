using System;

namespace Assignemnt
{
    public class Program
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
                        // result = num0 + num1; 
                        Console.WriteLine($"Your answer: {num0} * {num1} = {Multi(num0, num1)}"); 
                        break;

                    case "+":
                        // result = num0 + num1;
                        Console.WriteLine($"Your answer: {num0} + {num1} = {Addition(num0, num1)}");
                        break;

                    case "-":
                        // result = num0 - num1;
                        Console.WriteLine($"Your answer: {num0} - {num1} = {Substract(num0, num1)}");
                        break;

                    case "/":
                        // result = num0 / num1;
                        Console.WriteLine($"Your answer: {num0} / {num1} = {Divide(num0, num1)}");
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

        public static double Divide(double num0, double num1)
        {
            return num0 / num1;
        }

        public static double Substract(double num0, double num1)
        {
            return num0 - num1;
        }

        public static double Addition(double num0, double num1)
        {
            return num0 + num1;
        }

        public static double Multi(double num0, double num1)
        {
            return num0 * num1;
        }
    }// end of program
}
