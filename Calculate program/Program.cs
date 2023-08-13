using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_program
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("---------------");
                Console.WriteLine("   Calculate   ");
                Console.WriteLine("---------------");

                double num1 = 0;
                double num2 = 0;

                double result = 0;

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n\t+: Add");
                Console.WriteLine("\t-: Subtract");
                Console.WriteLine("\t*: Multiply");
                Console.WriteLine("\t/: Divide");
                Console.Write("\nEnter an option: ");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"\nYour result: {num1} + {num2} = " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"\nYour result: {num1} - {num2} = " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"\nYour result: {num1} * {num2} = " + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"\nYour result: {num1} / {num2} = " + result);
                        break;

                    default:
                        Console.WriteLine("That was not a valid option!");
                        break;
                }
                Console.Write("Would you like to continue? (Y/N): ");
            } while (Console.ReadLine().ToUpper()=="Y");
            Console.WriteLine("Bye!");
        }
    }
}
