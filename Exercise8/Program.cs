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
            for (int i = 0; i < num; i++)
            {
                string sterretje = new String('*', num);
                Console.WriteLine(sterretje);
        }
    }
}