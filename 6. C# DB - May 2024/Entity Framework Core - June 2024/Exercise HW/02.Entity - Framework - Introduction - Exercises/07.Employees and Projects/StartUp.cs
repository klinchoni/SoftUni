﻿using System.Text;
using SoftUni.Data;
using SoftUni.Models;

namespace SoftUni
{
    public class StartUp
    {
       public static void Main()
        {
            SoftUniContext dbContext= new SoftUniContext();
            //Console.WriteLine(GetEmployeesFullInformation(dbContext));
            //Console.WriteLine(GetEmployeesWithSalaryOver50000(dbContext));
           // Console.WriteLine(GetEmployeesFromResearchAndDevelopment(dbContext));
           // Console.WriteLine(AddNewAddressToEmployee(dbContext));
            Console.WriteLine(GetEmployeesInPeriod(dbContext));
        }

       // 03. Employees Full Information
       public static string GetEmployeesFullInformation(SoftUniContext context)
       {
           StringBuilder sb = new StringBuilder();

           var employees = context.Employees
               .OrderBy(e => e.EmployeeId)
               .Select(e => new
               {
                   e.FirstName,
                   e.LastName,
                   e.MiddleName,
                   e.JobTitle,
                   e.Salary
               })
               .ToList(); // правим го на лист, за да материализираме заявката веднага (да се изпълни)

            // Console.WriteLine(employees.ToQueryString()); - по този начин можем да видим кода като SQL заявка, но трябва преди това да премахнем .ToList(), защото с него заявката веднага се изпраща към базата и не можем да видим кода


           foreach (var employee in employees)
           {
               sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
           }

           return sb.ToString().TrimEnd();

        }

       
       // 04. Employees with Salary Over 50000
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            var richEmployees = context.Employees
                .Where(e => e.Salary > 50000)
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var e in richEmployees)
            {
                sb.AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

     
        //05. Employees from Research and Development
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var employees = context.Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary,
                    e.Department
                })
                .Where (e=>e.Department.Name == "Research and Development")
                .OrderBy(e=>e.Salary)
                .ThenByDescending(e=>e.FirstName)
                .ToList();
            
            StringBuilder sb = new StringBuilder();

            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} from {e.Department.Name} - ${e.Salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }

      
        // 06. Adding a New Address and Updating Employee
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            Address newAddress = new Address()
            {
                AddressText ="Vitoshka 15",
                TownId=4
            };

            var nakov = context.Employees
                .FirstOrDefault(e => e.LastName == "Nakov");

            if (nakov != null)
            {
                nakov.Address = newAddress;
                context.SaveChanges();
            }

            var employees = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => e.Address.AddressText)
                .ToList();


            return string.Join(Environment.NewLine, employees);
        }


        // 07. Employees and Projectspublic static string public static string GetEmployeesInPeriod(SoftUniContext context)
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var result = context.Employees
                .Take(10)
                .Select(e => new
                {
                   EmployeeNames = $"{e.FirstName} {e.LastName}",
                   ManagerNames = $"{e.Manager.FirstName} {e.Manager.LastName}",
                   Projects = e.EmployeesProjects
                       .Where(ep=>ep.Project.StartDate.Year>=2001 && 
                              ep.Project.StartDate.Year<=2003)
                       .Select(ep=> new
                       {
                           ProjectName = ep.Project.Name,
                           ep.Project.StartDate,
                           EndDate =  ep.Project.EndDate.HasValue? // проверяваме дали EndDate има стойност
                               ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt")  // ако има връщаме тази стойност
                               : "not finished"  // ако няма връщаме тази
                       })
                });

            var sb = new StringBuilder();

            foreach (var e in result)
            {
                sb.AppendLine($"{e.EmployeeNames} - Manager: {e.ManagerNames}");
                if (e.Projects.Any())
                {
                    foreach (var p in e.Projects)
                    {
                        sb.AppendLine(
                            $"--{p.ProjectName} - {p.StartDate:M/d/yyyy h:mm:ss tt} - {p.EndDate:M/d/yyyy h:mm:ss tt}");
                    }
                    
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
