using System;

namespace Exercise8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string inputNum;
            Console.Write("Enter a number - ");
            inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);
            Console.WriteLine("You entered '{0}'", num);
            
            const string format = "    {0,5}";
            
            
            for (int i = 0; i < num+1; i++)
            {
                string sterretje = new String('*', i);
                Console.WriteLine(String.Format(format, sterretje));
            }

            for (int i = num-1; i < num; i--)
            {
                string sterretje = new String('*', i);
                Console.WriteLine(string.Format(format, sterretje));
                if (i == 0)
                {
                    break;
                }
            }
        }
    }
}