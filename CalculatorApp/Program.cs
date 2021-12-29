using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double firstnum;
            double secondnum;
            double result;
            string operand;

            Console.WriteLine("Enter a number");
            firstnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operator: +, -, *, /");
            operand = Console.ReadLine();

            Console.WriteLine("Enter second number");
            secondnum = Double.Parse(Console.ReadLine());

            if (operand == "+")
            {
                result = firstnum + secondnum;
                Console.WriteLine($"Your result: {firstnum} + {secondnum} = " + (firstnum + secondnum));
            }

            if (operand == "-")
            {
                result = firstnum - secondnum;
                Console.WriteLine($"Your result: {firstnum} - {secondnum} = " + (firstnum - secondnum));
            }

            if (operand == "*")
            {
                result = firstnum * secondnum;
                Console.WriteLine($"Your result: {firstnum} * {secondnum} = " + (firstnum * secondnum));
            }

            if (operand == "/")
            {
                result = firstnum / secondnum;
                Console.WriteLine($"Your result: {firstnum} / {secondnum} = " + (firstnum / secondnum));
            }


            //wait for keypress
            Console.ReadKey();

        }
    }
}
