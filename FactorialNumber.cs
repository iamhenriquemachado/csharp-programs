using System;

namespace Factorial {
    class FactorialNumber {
        public static void Main(string[] args) {
            int i, f = 1, num;

            Console.WriteLine("Input the number: "); 
            num = int.Parse(Console.ReadLine()); 

            for(i = 1; i <= num; i++) {
                f = f * i // or f *= i

            }
            Console.WriteLine($"The factorial number of {num} is: {f}")
        }
    }
}