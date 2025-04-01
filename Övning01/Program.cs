using System;
using System.Collections.Generic;
using static System.Console;

namespace Övning01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool stopApp = false;
            List<Employee> employees = new List<Employee>();

            while (!stopApp)
            {
                switch (PrintMenu())
                {
                    case ConsoleKey.A:
                        AddEmployee(employees);
                        break;
                    case ConsoleKey.L:
                        ListEmployees(employees);
                        break;
                    case ConsoleKey.S:
                        stopApp = true;
                        break;
                }
            }
        }

        private static void ListEmployees(List<Employee> employees)
        {
            ClearConsole();
            Console.WriteLine("-----------------------------------------");
            foreach (Employee employee in employees)
            {
                WriteLine($"Name:\t{employee.Name}");
                WriteLine($"Salary:\t{employee.Salary}");
                Console.WriteLine("-----------------------------------------");
            }

            WriteLine();
            Write("Press any key to continue...");
            ReadKey(true);
        }

        private static void AddEmployee(List<Employee> employees)
        {
            ClearConsole();

            string name = string.Empty;
            do
            {
                Write("Enter employee NAME: ");
                name = ReadLine();
            } while (name.Length < 2);

            ClearConsole();

            string salaryStr = string.Empty;
            bool convertOK;
            decimal salary;

            do
            {
                Write("Enter employee SALARY: ");
                salaryStr = ReadLine();
                convertOK = decimal.TryParse(salaryStr, out salary);
            } while (!convertOK);

            employees.Add(new Employee(name, salary));
        }

        static void ClearConsole()
        {
            Clear();
            WriteLine("--- Personalregister ---\n\r");
        }

        private static ConsoleKey PrintMenu()
        {
            ConsoleKey key;

            do
            {
                Clear();
                WriteLine("--- Personalregister ---\n\r");
                WriteLine("[A]ddera ny anställd");
                WriteLine("[L]ista anställda");
                WriteLine("[S]toppa appen!");
                Write("=> ");

                key = ReadKey().Key;
            } while (!(key == ConsoleKey.A || key == ConsoleKey.L || key == ConsoleKey.S));

            return key;
        }
    }
}
