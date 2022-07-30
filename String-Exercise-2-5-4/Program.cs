using System;

namespace String_Exercise_2_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 4
            string alice = "\"Alice was beginning to get very tired of sitting by her sister on the bank,\n" +
                           "and of having nothing to do: once or twice she had peeped into the book her\n" +
                           "sister was reading, but it had no pictures or conversations in it, 'and what is\n" +
                           "the use of a book,' thought Alice 'without pictures or conversation?'\"";
            Console.WriteLine($"{alice}\n\nEnter a term to search for in the quote:");
            string searchTerm = Console.ReadLine().ToLower();
            int searchIndex = alice.ToLower().IndexOf(searchTerm, 0);
            if (searchIndex != -1)
            {
                Console.WriteLine($"Match found for search term '{searchTerm}' of length {searchTerm.Length} at index {searchIndex}.");
                string newQuote = alice.Substring(0, searchIndex).Trim() + alice.Substring(searchIndex + searchTerm.Length);
                Console.WriteLine($"Quote with first instance of search term removed:\n{newQuote}");
            }
            else
            {
                Console.WriteLine("No match found!");
            }
            Console.ReadLine();
        }
    }
}
