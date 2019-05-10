using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercise9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<List<int>> list = new List<List<int>>();
            List<int> sublist = new List<int>();
            sublist.Add(3);
            sublist.Add(2);
            sublist.Add(5);
            sublist.Add(7);
            list.Add(sublist);
            List<int> sublist2 = new List<int>();
            sublist2.Add(5);
            sublist2.Add(6);
            sublist2.Add(7);
            sublist2.Add(5);
            list.Add(sublist2);
            List<int> sublist3 = new List<int>();
            sublist3.Add(8);
            sublist3.Add(9);
            sublist3.Add(0);
            sublist3.Add(4);
            list.Add(sublist3);
            List<int> sublist4 = new List<int>();
            sublist4.Add(2);
            sublist4.Add(5);
            sublist4.Add(7);
            sublist4.Add(3);
            list.Add(sublist4);
            
            
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; ++j)
                {
                    Console.WriteLine(list[i][j]);
                }

                Console.WriteLine('.');
            }
            
            Console.WriteLine("new matrix:");
            
            
            List<List<int>> newlist = new List<List<int>>();
            List<int> newsublist = new List<int>();
            newsublist.Add(list[0][0]);
            newsublist.Add(list[1][0]);
            newsublist.Add(list[2][0]);
            newsublist.Add(list[3][0]);
            newlist.Add(newsublist);
            List<int> newsublist2 = new List<int>();
            newsublist2.Add(list[0][1]);
            newsublist2.Add(list[1][1]);
            newsublist2.Add(list[2][1]);
            newsublist2.Add(list[3][1]);
            newlist.Add(sublist2);
            List<int> newsublist3 = new List<int>();
            newsublist3.Add(list[0][2]);
            newsublist3.Add(list[1][2]);
            newsublist3.Add(list[2][2]);
            newsublist3.Add(list[3][2]);
            newlist.Add(newsublist3);
            List<int> newsublist4 = new List<int>();
            newsublist4.Add(list[0][3]);
            newsublist4.Add(list[1][3]);
            newsublist4.Add(list[2][3]);
            newsublist4.Add(list[3][3]);
            newlist.Add(newsublist4);

            for (int i = 0; i < newlist.Count; i++)
            {
                for (int j = 0; j < newlist[i].Count; ++j)
                {
                    Console.WriteLine(newlist[i][j]);
                }

                Console.WriteLine('.');
            }
        }
    }
}