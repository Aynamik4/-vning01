using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning01;
internal class Employee
{
    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public string Name { get; set; }
    public decimal Salary { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Salary: {Salary}";
    }
}
