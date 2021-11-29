using System;
using ClassLibraryRsueOOP;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объекты класса
            ATS first = new ATS(13, 5, 2020, 0, "Moskow", 123, 113);
            ATS second = new ATS(31, 4, 2021, 0, "Moskow", 38, 113); 
            ATS third = new ATS(4, 12, 2020, 0, "Moskow", 2, 113); 
            ATS four = new ATS(13, 5, 2020, 1, "Rostov-on-Don", 13, 113);

            //Коллекция 
            ATS_s ats_s = new ATS_s();

            ats_s.AddAtsInfo(first);//Добавление
            ats_s.AddAtsInfo(second);
            ats_s.AddAtsInfo(third);
            ats_s.AddAtsInfo(four);

            //Назначаем делигаты
            SortATSCondition sortATSCondition = SortATSCondition;
            FindATSCondition findATSCondition = FindATSCondition;

            ats_s.FindElement(findATSCondition).ToString();//Находим и сразу выводим

            ats_s.ShowAllInfo();
            ats_s.DeleteElement(0);
            ats_s.SortBy(sortATSCondition); //Выводим и сортируем
            ats_s.ShowAllInfo();

            //И само индивидуальное задание: вывести сумму времени разговора

            ATS tempAts; int sumMinutesOfCall = 0;
            for(int i = 0; i < ats_s.AtsList.Count; i++)
            {
                tempAts = (ATS)ats_s.AtsList[i];
                if(findATSCondition(tempAts))
                    sumMinutesOfCall += tempAts.TimeOfCall;
            }
            Console.WriteLine($"Суммарное время разговора {sumMinutesOfCall}");

        }

        static bool SortATSCondition(ATS first, ATS second)
        {
            if (first.TimeOfCall < second.TimeOfCall)
                return true;
            else
                return false;
        }

        static bool FindATSCondition(ATS first)
        {
            if (first.IdCity == 0)
                return true;
            else
                return false;
        }

    }
}
