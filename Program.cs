using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                Id = 1,
                Name = "Sumedh",
                Gender = "Male",
                Experience = 0,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                Id = 2,
                Name = "SaiRam",
                Gender = "Male",
                Experience = 3,
                Salary = 45000
            };
            Employee emp3 = new Employee()
            {
                Id = 3,
                Name = "Ravi",
                Gender = "Male",
                Experience = 3,
                Salary = 55000
            };
            List<Employee> lstemp = new List<Employee>();
            lstemp.Add(emp1);
            lstemp.Add(emp2);
            lstemp.Add(emp3);

            Employee.PromoteEmployee(lstemp,x =>x.Experience > 2);
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> lstemp,EligibleToPromotion IsEmployeeEligible)
        {
            foreach(Employee employee in lstemp)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine(employee.Name+" "+"Promoted");
                }
            }
        }
    }
}
