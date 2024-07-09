using System.Text;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
       public static void Main()
        {
           SoftUniContext dbContext= new SoftUniContext();
            Console.WriteLine(GetEmployeesFullInformation(dbContext));
        }

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
               .ToArray();

           foreach (var employee in employees)
           {
               sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
           }

           return sb.ToString().TrimEnd();

        }


    }
}
