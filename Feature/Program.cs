using System;
using System.Collections.Generic;
using System.Linq;

namespace Feature
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> liu = x => x * x;
            Action<int> write = y => Console.WriteLine(y);

            write(liu(10));
            
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Liu"},
                new Employee {Id = 2, Name = "Quaan"}
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Thanh"}
            };

            foreach (var employee in developers.Where(e => e.Name.StartsWith('Q')))
            {
                Console.WriteLine(employee.Name);
            }
        }

        private static bool NameStartsWiths(Employee employee)
        {
            return employee.Name.StartsWith('Q');
        }
    }
}
