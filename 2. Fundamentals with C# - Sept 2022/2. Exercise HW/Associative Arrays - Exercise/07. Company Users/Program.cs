using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();
            string[] employeesData = Console.ReadLine().Split(" -> ");

            while (employeesData[0] != "End")
            {
                string company = employeesData[0];
                string employeeID = employeesData[1];

                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees.Add(company, new List<string>());
                }

                if (!companyEmployees[company].Contains(employeeID))
                {
                    companyEmployees[company].Add(employeeID);
                }

                employeesData = Console.ReadLine().Split(" -> ");
            }

            foreach (var company in companyEmployees)
            {
                Console.WriteLine(company.Key);
                company.Value.ForEach(id => Console.WriteLine($"-- {id}"));
            }
        }
    }
}
