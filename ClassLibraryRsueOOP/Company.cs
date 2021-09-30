using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRsueOOP
{
    public class Company : Client
    {

        #region Поля

        string name, form;
        int day, month, year;

        #endregion
        #region Свойства

        public string Name { get => name; set => name = value; }
        public string Form { get => form; set => form = value; }
        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        #endregion
        #region Методы

        public override void Input()
        {
            Console.WriteLine("\n///////////// Юр.лицо /////////////");
            base.Input();
            Console.Write("Введите название: ");
            name = Console.ReadLine();
            Console.Write("Введите организ-ную форму: ");
            form = Console.ReadLine();
            Console.Write("Введите Дату основания(поочередно): ");
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine("\n///////////// Юр.лицо /////////////");
            base.Output();
            Console.WriteLine($"Название: {form} ''{ name}'', дата открытия: {day}.{month}.{year}");
        }

        #endregion
    }
}