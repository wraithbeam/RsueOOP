using System;
using ClassLibraryRsueOOPInterfaces;
using ClassLibraryRsueOOP;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЗадание №1:\n");

            #region Задание 1
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

            #endregion

            Console.WriteLine("\nЗадание №2:\n");

            #region Задание 2

            ICipher cipher = new ACipher();
            cipher.Text = "Привет, пицца!";
            cipher.Encode();
            Console.WriteLine("Результат шифрования: " + cipher.Text);
            cipher.Decode();
            Console.WriteLine("Результат дешифрования: " + cipher.Text);

            ICipher cipher1 = new BCipher();
            cipher1.Text = "АБВгдеЭЮЯ";
            cipher1.Encode();
            Console.WriteLine("\nРезультат шифрования: " + cipher1.Text);
            cipher1.Decode();
            Console.WriteLine("Результат дешифрования: " + cipher1.Text);

            #endregion

        }
    }
}
