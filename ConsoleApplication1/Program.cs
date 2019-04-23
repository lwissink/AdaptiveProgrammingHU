using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string word = "sterk";
            string part = "ste";

            int waar = 0;
            
            Console.WriteLine(word.Contains(part));

            int x = part.Length;
            Console.WriteLine(x);
            
            
            for (int i = 0; i < x; i++)
            {
                var wordletter = word[i];
                var wordpart = part[i];
                
                Console.WriteLine(wordletter+" "+wordpart);
                
                if (wordletter == wordpart)
                {
                    waar = 1;
                }
                else
                {
                    waar = 0;
                }
            }

            if(waar == 1)
            {
                Console.WriteLine("het is een prefix");
            }
            else
            {
                Console.WriteLine("het is niet een prefix");
            }  
        }
    }
}
