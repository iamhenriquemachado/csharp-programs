using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace calculator_in_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int result;
                Console.WriteLine("First number:");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Second number:");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Operation:");
                string symbol = Console.ReadLine();

                switch (symbol) {
                    case "+": 
                       result = number1 + number2;
                        Console.WriteLine("Result: " + result);
                        break;

                    case "-":
                        result = number1 - number2;
                        Console.WriteLine("Result: " + result);
                        break;

                    case "*":
                        result = number1 * number2;
                        Console.WriteLine("Result: " + result);
                        break;

                    case "/":
                        result = number1 / number2;
                        Console.WriteLine("Result: " + result);
                        break;

                        default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.ReadLine();
                Console.WriteLine("Do you want to continue (Y/N): ");
                value = Console.ReadLine();


            } while (value == "y" || value == "Y");
        }
    }
}
