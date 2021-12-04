using System;
using System.Collections.Generic;
using ClassLibraryRsueOOP;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ATS> atsList = new List<ATS>(); 

            //Добавление элементов в коллецкию
            atsList.Add(new ATS(13, 5, 2020, 0, "Moskow", 123, 113));
            atsList.Add(new ATS(13, 5, 2020, 0, "Moskow", 123, 113));
            atsList.Add(new ATS(31, 4, 2021, 0, "Moskow", 38, 113));
            atsList.Add(new ATS(4, 12, 2020, 0, "Moskow", 2, 113));
            atsList.Add(new ATS(13, 5, 2020, 1, "Rostov-on-Don", 13, 113));

            //Вывод всех элементов в коллекцию      !WriteInfo(List<ATS> atsList)!
            foreach (ATS ats in atsList)
                Console.WriteLine(ats); //ToString()

            //Cортировка данных
            atsList.Sort(new AtsComparer(AtsComparer.CompareType.Minutes));
            WriteInfo("\nСортировка по длительности звонка:");
            WriteInfo(atsList);

            atsList.Sort(new AtsComparer(AtsComparer.CompareType.CityId));
            WriteInfo("\nСортировка по городам:");
            WriteInfo(atsList);

            //Поиск элемента(-ов)
            WriteInfo("\nПоиск звонка по городу:");
            FindATS findATS = new FindATS(0);

            foreach (ATS st in atsList.FindAll(findATS => findATS.IdCity == 0))
                Console.WriteLine(st);

            //Сравнение элементов коллекции
            WriteInfo("\nСравнение элементов:");
            Console.WriteLine(atsList[2].Equals(atsList[3]));

            //Вывод элементов по условию
            WriteInfo("\nВывод элементов по условию");
            foreach (ATS ats in atsList) {
                if (ats.IdCity == 0)
                    Console.WriteLine(ats);
            }

            //Удаление элемента
            WriteInfo("\nУдаление элемента:");
            Console.WriteLine(atsList[0]);
            atsList.RemoveAt(0);
            WriteInfo("\nОбновленный список:");
            WriteInfo(atsList);


        }

        static void WriteInfo(List<ATS> atsList)
        {
            foreach (ATS ats in atsList)
                Console.WriteLine(ats); //ToString()
        }
        static void WriteInfo(string value)
        {
            Console.WriteLine(value);
        }
    }
}