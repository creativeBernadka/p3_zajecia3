using System;
using System.Collections.Generic;
using System.Linq;

namespace zajecia3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = {"matematyka", "jezyk polski", "jezyk angielski", "fizyka", "chemia"};
            List<double> means = new List<double>();
            foreach (string subject in subjects)
            {
                List<int> grades = new List<int>();
                Console.WriteLine("Podaj oceny z przedmiotu --" + subject + "--, 0 zatwierdza oceny");
                int grade = Convert.ToInt32(Console.ReadLine());
                while (grade != 0)
                {
                    grades.Add(grade);
                    grade = Convert.ToInt32(Console.ReadLine());
                }
                means.Add(grades.Average());
            }
            
            Console.WriteLine("\nSrednie z pojedynczych przedmiotow:");

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i] + ": " + means[i]);
            }
            
            Console.WriteLine("Srednia wszystkich ocen: " + means.Average());
        }
    }
}