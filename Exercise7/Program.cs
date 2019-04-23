using System;

namespace Exercise7
{
    internal class Program
    {
        public static int findGCD(int a, int b)
        {
            if( a == b){
                return a;
            }
            else if( a>b ){
                return findGCD(a-b, b);
            }else{
                return findGCD(a, b-a);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(findGCD(900,280));
            //900 - 280
            //620 - 280
            //340 - 280
            //280 - 60
            //220 - 60
            //160 - 60
            //100 - 60
            //60 - 40
            //20
            //dus 9 keer
        }
    }
}