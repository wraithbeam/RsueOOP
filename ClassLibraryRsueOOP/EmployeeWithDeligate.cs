
using System;

namespace ClassLibraryRsueOOP
{
    public delegate void EmployeeInfo();
    public delegate double RaiseSalary();
    public delegate bool SortEmployeeCondition(EmployeeWithDeligate first, EmployeeWithDeligate second);

    public class EmployeeWithDeligate : Employee
    {
        public EmployeeWithDeligate(int id, string fio, double salary)
        {
            Id = id;
            Fio = fio;
            Salary = salary;
        }

        public EmployeeWithDeligate()
        {
        }

        public double GiveBonus(double bonus)
        {
            return Salary *= (1 + bonus);
        }

        public static void SortBy(ref EmployeeWithDeligate[] employees, SortEmployeeCondition sort)
        {
            EmployeeWithDeligate employee = new EmployeeWithDeligate();

            for (int i = 0; i < employees.Length; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (sort(employees[i], employees[j]))
                    {
                        employee = employees[i];
                        employees[i] = employees[j];
                        employees[j] = employee;
                        Console.WriteLine($"Заменен {i} на {j}");
                    }
                }
            }
        }

    }
}
