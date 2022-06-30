using System;

namespace Q12_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentence ");
            string line = Console.ReadLine();

            Console.WriteLine("Original Sentence = " + line);

            string updsen= line.Replace("ies", "s");
            Console.WriteLine("Updated Sentence = " + updsen);
        }
    }
}
