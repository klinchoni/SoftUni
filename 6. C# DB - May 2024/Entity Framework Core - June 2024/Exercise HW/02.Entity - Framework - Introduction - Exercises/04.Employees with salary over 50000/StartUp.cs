using System.Text;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
       public static void Main()
        {
            SoftUniContext dbContext= new SoftUniContext();
            //Console.WriteLine(GetEmployeesFullInformation(dbContext));
            Console.WriteLine(GetEmployeesWithSalaryOver50000(dbContext));
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
               .ToList(); // правим го на лист, за да материализираме заявката (да се изпълни)


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
    }
}
