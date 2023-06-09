using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            //
            // int n = int.Parse(Console.ReadLine());
            //
            // Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();
            //
            // for (int i = 0; i < n; i++)
            // {
            //     var student = Console.ReadLine().Split();
            //     var name = student[0];
            //     var grade = decimal.Parse(student[1]);
            //
            //     if (!studentsGrades.ContainsKey(name))
            //     {
            //         studentsGrades.Add(name, new List<decimal>());
            //     }
            //
            //     studentsGrades[name].Add(grade);
            // }
            //
            // foreach (var student in studentsGrades)
            // {
            //     Console.Write($"{student.Key} -> ");
            //
            //     foreach (var grade in student.Value)
            //     {
            //         Console.Write($"{grade:f2} ");
            //     }
            //
            //     Console.WriteLine($"(avg: {student.Value.Average():f2})");
            // }

            // 2 WAY 

            //1 + 2 +3 + 4 = 10 /4 = 2.5
            // Console.WriteLine(new List<int>() { 1, 2, 3, 4 }.Average());
             Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            
             Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();
            
             int n = int.Parse(Console.ReadLine());
            
             // Pesho 2
             // Pesho 3
             // Pesho 4
             for (int i = 0; i < n; i++)
             {
                 string[] input = Console.ReadLine().Split();
                 string studentName = input[0];
                 decimal grade = decimal.Parse(input[1]);
            
                 if (!studentGrades.ContainsKey(studentName))
                 {
                     studentGrades.Add(studentName, new List<decimal>());
                 }
            
                 studentGrades[studentName].Add(grade);
             }
            
            
             foreach (var studentGrade in studentGrades)
             {
                 Console.WriteLine($"{studentGrade.Key} -> {string.Join(" ", studentGrade.Value.Select(x => $"{x:f2}").ToList())} (avg: {studentGrade.Value.Average():f2})");
                //Console.Write($"{studentGrade.Key} -> ");
            
                 //foreach (var grade in studentGrade.Value)
                 //{
                 //    Console.Write($"{grade:f2} ");
                 //}
                //Console.WriteLine($"(avg: {studentGrade.Value.Average():f2})");
             }

            // 3 WAY

          // int n = int.Parse(Console.ReadLine());
          //
          // Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
          //
          // for (int i = 0; i < n; i++)
          // {
          //     string[] tokins = Console.ReadLine().Split(" ");
          //
          //     if (students.ContainsKey(tokins[0]))
          //     {
          //         students[tokins[0]].Add(decimal.Parse(tokins[1]));
          //     }
          //     else
          //     {
          //         students.Add(tokins[0], new List<decimal> { decimal.Parse(tokins[1]) });
          //     }
          // }
          // foreach (var exellent in students)
          // {
          //     Console.WriteLine($"{exellent.Key} -> {string.Join(" ", exellent.Value.Select(s => s.ToString("F2")))}" +
          //         $" (avg: {exellent.Value.Average():f2})");
          // }
        }
    }
}
