using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRsueOOP
{
    public class PhysicalPerson : Client
    {
        #region Поля

        string fio, sex;
        int birthYear;

        #endregion
        #region Свойства
        public string Fio { get => fio; set => fio = value; }
        public string Sex { get => sex; set => sex = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }

        #endregion
        #region Методы

        public override void Input()
        {
            Console.WriteLine("\n///////////// Физ.лицо /////////////");
            base.Input();
            Console.Write("Введите ФИО: ");
            fio = Console.ReadLine();
            Console.Write("Введите пол: ");
            sex = Console.ReadLine();
            Console.Write("Введите год.рож: ");
            birthYear = Convert.ToInt32(Console.ReadLine());
        }

        public override void Output()
        {
            Console.WriteLine("\n///////////// Физ.лицо /////////////");
            base.Output();
            Console.WriteLine($"ФИО: {fio}, пол: {sex}, год рож.:{birthYear}");
        }

        #endregion
    }
}
