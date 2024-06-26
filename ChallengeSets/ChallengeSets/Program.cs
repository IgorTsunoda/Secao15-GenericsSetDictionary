﻿namespace ChallengeSets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();


            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }

            Console.Write("How many students for course B? ");
            n = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }

            Console.Write("How many students for course C? ");
            n = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> allStudents = new HashSet<int>();
            allStudents.UnionWith(courseB);
            allStudents.UnionWith(courseC);

            Console.WriteLine("Total Students: " + allStudents.Count());
        }
    }
}
