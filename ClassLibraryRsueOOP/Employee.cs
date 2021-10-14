using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRsueOOPInterfaces;

namespace ClassLibraryRsueOOP
{
    public class Employee : IEmployee, IComparable
    {
        #region Поля и свойства

        private int id;
        public int Id {
            get { return id; }
            set { id = value; }
        }
        
        private string fio;
        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }


        private double salary;
        public double Salary { get => salary; set => salary = value; }

        #endregion
        #region Методы
        public void Display()
        {
            Console.WriteLine($"Код: {id} ФИО: {fio} Зарплата: {salary}");
        }

        public void Enter()
        {
            Console.WriteLine("Введите номер: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО: ");
            Fio = Console.ReadLine();
            Console.WriteLine("Введите зарплату: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }

        public void Getbonus()
        {
            Salary = Salary + 1000;
        }

        public int CompareTo(object obj)
        {
            Employee emp = (Employee)obj;
            if (Salary > emp.Salary)
                return 1;
            else if (Salary < emp.Salary)
                return -1;
            else
                return 0;
        }

        #endregion

    }
}
