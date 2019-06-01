using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Exercise10
{
    class MatrixMultiplicatie
    {
        private int[,] z; private int[,] b; private int[,] c;       

        public void ReadMatrix()
        {
            Console.Write("\n*Aantal rijen in de eerste Matrix : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\n*Aantal colommen in de eerste Matrix : ");
            int m = int.Parse(Console.ReadLine());
            z = new int[n, m];
            Console.WriteLine("\n*Vul de waardes in van de eerste Matrix : ");
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    try
                    {
                        Console.WriteLine("Enter waarde " + (1 + i).ToString() + " " + (1 + j).ToString());
                        z[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        try
                        {
                            Console.WriteLine("Enter waarde " + (1 + i).ToString() + " " + (1 + j).ToString());
                            Console.WriteLine("\nEnter een goede waarde");
                            z[i, j] = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("\nEnter waarde(laatste kans)");
                            Console.WriteLine("Enter waarde " + (1 + i).ToString() + " " + (1 + j).ToString());
                            z[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }
            Console.Write("\n**Aantal rijen in de tweede Matrix :" + m);
            Console.Write("\n**Aantal colommen in de tweede Matrix :");
            int k = int.Parse(Console.ReadLine());
            b = new int[m, k];
            Console.WriteLine("\n**Vul de waardes in van de tweede Matrix:");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    try
                    {
                        Console.WriteLine("Enter waarde " + (1 + i).ToString() + " " + (1 + j).ToString());
                        b[i, j] = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        try
                        {
                            Console.WriteLine("\nEnter waarde");
                            b[i, j] = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("\nEnter waarde(laatste kans)");
                            b[i, j] = int.Parse(Console.ReadLine());
 
                        }
                    }
                }
            }
        }

        public void VermenigvuldigingMatrix()
        {
            if (z.GetLength(1) == b.GetLength(0))
            {
                c = new int[z.GetLength(0), b.GetLength(1)];
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < z.GetLength(1); k++)
                            c[i, j] = c[i, j] + z[i, k] * b[k, j];
                    }
                }
            }
            
        }
        public void PrintMatrix()
        {
            Console.WriteLine("\nEerste Matrix:");
            for (int i = 0; i < z.GetLength(0); i++)
            {
                for (int j = 0; j < z.GetLength(1); j++)
                {
                    Console.Write("\t" + z[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Tweede Matrix:");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write("\t" + b[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Resultaat vermedigvuldiging");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write("\t" + c[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("druk op een toets om te eindigen");
            Console.ReadKey();
            Environment.Exit(-1);
        }

    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            MatrixMultiplicatie MM = new MatrixMultiplicatie();
            MM.ReadMatrix();
            MM.VermenigvuldigingMatrix();
            MM.PrintMatrix(); 
        }
    }
}