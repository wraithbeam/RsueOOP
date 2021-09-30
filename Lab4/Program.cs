using System;
using ClassLibraryRsueOOPInterfaces;
using ClassLibraryRsueOOP;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp_e = new Employee();
            emp_e.Enter();

            Employee emp_2 = new Employee()
            {
                Id = 2,
                Fio = "Смирнов А.А.",
                Salary = 15000
            };

            Employee emp_3 = new Employee()
            {
                Id = 3,
                Fio = "Петров Б.Е.",
                Salary = 12000
            };

            Employee[] employees = new Employee[]
            {
                (Employee)emp_e, emp_2, emp_3
            };

            Array.Sort(employees);
            for (int i = 0; i < 3; i++)
                employees[i].Display();

        }
    }
}
