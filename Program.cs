﻿namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;


            string answer;

            Console.WriteLine("Hello, welcome to the calculator program!");
            Console.WriteLine("Please enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");

            Console.WriteLine("Please enter a for addition, s for substraction, m for multiplication or d for division");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                result = num1 / num2;
            }
            else
            {
                result = 0;
                Console.WriteLine("Please select other operation");
                
                return;
 
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thank you for using calculator program");



            Console.ReadKey();


        }

    }
}
    