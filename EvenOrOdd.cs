using System;

namespace EvenOrOdd {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Type a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number is: " + CheckEvenOrOdd(number));    

        }
        static string CheckEvenOrOdd(int number) { 
            if(number % 2 == 0) {
                return "Even";
            } else {
                return "Odd";
            }
        }

    }

}
