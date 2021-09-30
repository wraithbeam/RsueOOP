using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRsueOOP
{
    public class Client
    {
        #region Поля

        double inn;
        string adress;

        #endregion;
        #region Свойства

        public double Inn { get => inn; set => inn = value; }
        public string Adress { get => adress; set => adress = value; }

        #endregion
        #region Методы

        virtual public void Input()
        {
            Console.WriteLine("------------Ввод данных--------------");
            Console.Write("Введите инн: ");
            inn = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите адресс: ");
            adress = Console.ReadLine();
        }
        virtual public void Output()
        {
            Console.WriteLine("------------Вывод данных--------------");
            Console.WriteLine("ИНН: " + inn);
            Console.WriteLine("Адрес: " + adress);
        }

        #endregion

    }
}
