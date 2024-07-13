using System;

namespace word_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 01: Insert a phrase
            Console.WriteLine("Write a phrase: ");
            string phrase = Console.ReadLine();

            // Step 02: Count the words in a phrase
            string[] words = phrase.Split(' ');

            // Step 03: Count the number of words
            int words_counter = words.Length;

            // Step 04: Check longer & shorter words
            string longest_word = words[0]; 
            string shorter_word = words[0];

            foreach (string word in words)
            {
                if(word.Length > longest_word.Length)
                {
                    longest_word = word;
                }

                if (word.Length < longest_word.Length)
                {
                    shorter_word = word;
                }

            }

            // Step 05: Show results
            Console.WriteLine($"Word Counter: {longest_word}");
            Console.WriteLine($"Longest word is: {longest_word}");
            Console.WriteLine($"Shorter word is: {shorter_word}");

        }
    }
}
