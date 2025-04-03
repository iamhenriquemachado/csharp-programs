namespace Fibonnaci {
    class FibonnaciNumbers {
        public static int fibonnaci(int n) {
            if(n == 0) {
                return 0; 
            }
            if(n == 1) {
                return 1; 
            }
            return fibonnaci(n-1) + fibonnaci(n-2); 
        }
        static void Main() {
            int number = 10;
            Console.WriteLine($"Fibonnaci {number}") = {fibonnaci(number)}
        }
    }
}