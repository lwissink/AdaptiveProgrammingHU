using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String word = "sterk";
            String part = "ste";
            String notpart = "str";
            
            Console.WriteLine(word.Contains(part));
            Console.WriteLine(word.Contains(notpart));
            
            
        }
    }
}
