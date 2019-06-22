using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise11
{
    public struct Student
    {
        public string naam;
        public int leeftijd;
        public List<float> cijfers;
        public string huisdier;

        public Student(string nm, int lt, string hd)
        {
            naam = nm;
            leeftijd = lt;
            cijfers = new List<float>();
            huisdier = hd;
        }
    }
    public struct Klas
    {
        public string naam;
        public List<object> studenten;
        public string docenten;

        public Klas(string klas, string leraar)
        {
            naam = klas;
            studenten = new List<object>();
            docenten = leraar;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student bob = new Student("bob", 11, "kat");
            bob.cijfers.Add(6.5f);
            bob.cijfers.Add(4.5f);
            bob.cijfers.Add(6.9f);
            bob.cijfers.Add(9.5f);
            Student kees = new Student("kees", 12, null);
            kees.cijfers.Add(7.4f);
            kees.cijfers.Add(7.9f);
            kees.cijfers.Add(7.8f);
            kees.cijfers.Add(7.6f);
            Klas groep5 = new Klas("groep5", "jan");
            groep5.studenten.Add(bob);
            groep5.studenten.Add(kees);

            float gemiddelde = (kees.cijfers.Average() + bob.cijfers.Average())/2;
            Console.WriteLine(gemiddelde);
        }
    }
}