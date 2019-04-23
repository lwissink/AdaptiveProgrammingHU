using System;

namespace Exercise5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string inputNum;
            Console.Write("Enter a number - ");
            inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);
            int fn;
            
            if (num < 2)
            {
                if (num == 0)
                {
                    fn = 0;
                }
                else
                {
                    fn = 1;
                }
                    
            }
            else
            {
                fn = (num - 1) + (num - 2);
            }
            Console.WriteLine("Wanneer n {0} is is f(n) '{1}'",num,fn);
        }
    }
}