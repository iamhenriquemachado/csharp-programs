using System;

namespace ReverseString {
    class StringReverser {
        public static string ReverseString(string s){
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            
            return new string(arr)
        }
        static void Main(string[] args) {
            Console.WriteLine("Type a word to reverse: ");

            string word = Console.ReadLine();
            string invertedText = ReverseString(word);

            Console.WriteLine($"Reversed word: {invertedText}"); 
        }
    }
}   