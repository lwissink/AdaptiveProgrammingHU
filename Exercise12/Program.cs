using System;

namespace Exercise12
{
    public class Zwembad
    {
        public void z1(double breedte, double lengte, double diepte)
        {
            Console.WriteLine("BREEDTE: {0}", breedte);
            Console.WriteLine("LENGTE: {0}", lengte);
            Console.WriteLine("DIEPTE: {0}", diepte);

            double inhoud = breedte * lengte * diepte;

            Console.WriteLine("BEREKENDE INHOUD: {0}", inhoud);
            Console.WriteLine();
        }
        
        public void z2( )
        {
            double setBreedte = 2.5;
            double setLengte = 100.0;
            double setDiepte = 2.0;
             Console.WriteLine("GEGEVENS ZWEMBAD: Dit zwembad is {0} meter breed, {1} meter lang, en {2} meter diep ", setBreedte, setLengte, setDiepte);
             double inhoud = setBreedte * setLengte * setDiepte;
             Console.WriteLine("BEREKENDE INHOUD: {0}", inhoud);
        }
            
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Zwembad = new Zwembad();
            Zwembad.z1(2.0, 5.5, 1.5);

            Zwembad.z2();
            
        }
        
    }
}