using System;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number:");
            int input_number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 11; i++) {
                int result = input_number * i;
                Console.WriteLine(result);
            }
        }
    }
}
