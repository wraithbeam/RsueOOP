using System;
using ClassLibraryRsueOOP;

namespace Lab5
{
    class Program
    {
        static bool sortCondition(EmployeeWithDeligate first, EmployeeWithDeligate second) //Метод для делигата
        {
            if (first.Salary < second.Salary)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            EmployeeWithDeligate emp1 = new EmployeeWithDeligate(1,"Иван Петров", 14000);
            EmployeeWithDeligate emp2 = new EmployeeWithDeligate(2, "Евгений Иванов", 17000);
            EmployeeWithDeligate emp3 = new EmployeeWithDeligate(3, "Савелий Кринжеслав", 19000);
            EmployeeWithDeligate emp4 = new EmployeeWithDeligate(4, "Семен Кравченко", 24000);
            EmployeeWithDeligate emp5 = new EmployeeWithDeligate(5, "Рита Мерова", 5000);
            EmployeeWithDeligate emp6 = new EmployeeWithDeligate(6, "Петя Петров", 10000);

            EmployeeWithDeligate[] emps = { emp1, emp2, emp3, emp4, emp5, emp6};

            EmployeeInfo[] employees =
            {
                emps[0].Display, emps[1].Display, emps[2].Display, emps[3].Display, emps[4].Display, emps[5].Display
            };

            for(int i =0; i< emps.Length; i++)
            {
                employees[i]();
            }


            SortEmployeeCondition sortEmployeeCondition = sortCondition; //Метод для реализации делигата

            EmployeeWithDeligate.SortBy(ref emps, sortEmployeeCondition);//Сортировка

            for (int i = 0; i < emps.Length; i++)
            {
                emps[i].Display();
            }
        }
    }
}
