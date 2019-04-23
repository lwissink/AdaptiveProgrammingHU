using System;

namespace Exercise6
{
    internal class Program
    {
        public static int ears(int n_rabbits){
            if(n_rabbits <= 1){
                return n_rabbits * 2;
            }else{
                return 2 + ears(n_rabbits-1); //hier word het opnieuw aangeroepen
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(ears(4)); 
        }
    }
}