﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(student))
                {
                    studentGrades.Add(student, new List<double>());
                }

                studentGrades[student].Add(grade);
            }

            foreach (var student in studentGrades.Where(s => s.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}
