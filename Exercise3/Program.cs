using System;
using System.Collections.Generic;

namespace Exercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<bool> list = new List<bool>();
            list.Add(true);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(false);
            list.Add(true);
            list.Add(true);
            list.Add(false);
            list.Add(true);
            list.Add(true);
            list.Add(false);
            list.Add(true);
            list.Add(true);
            list.Add(false);
            list.Add(true);

            int truecount = 0;
            int falsecount = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == true)
                {
                    truecount = truecount + 1;
                }
                else
                {
                    falsecount = falsecount + 1;
                }
            }

            if (truecount < falsecount)
            {
                Console.WriteLine("er zijn meer false waardes dan true");
            }
            else
            {
                Console.WriteLine("er zijn meer true waardes dan fasle");
            }
            if (falsecount > 12)
            {
                Console.WriteLine("er zijn meer dan 12 false waardes");
            }
        }
    }
}