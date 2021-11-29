using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRsueOOP
{
    public delegate bool SortATSCondition(ATS first, ATS second);//Делигат для условия сортировки
    public delegate bool FindATSCondition(ATS first);//Делигат для поиска


    public class ATS_s
    {
        ArrayList atsList;

        public ArrayList AtsList { get => atsList; set => atsList = value; }

        public ATS_s()
        {
            atsList = new ArrayList();
        }

        public void AddAtsInfo(ATS ats) //доабвляет элементы в коллекцию
        {
            atsList.Add(ats);
        }

        public void ShowAllInfo() //выводит все элементы в консоль
        {
            foreach (Object obj in atsList)
               Console.WriteLine(obj.ToString());
        }

        public void SortBy(SortATSCondition sort) //сортирует колеекцию по условию
        {
            ATS tempAts = new ATS();

            for (int i = 0; i < atsList.Count; i++)
            {
                for (int j = i + 1; j < atsList.Count; j++)
                {
                    if (sort((ATS)atsList[i], (ATS)atsList[j]))//Используем делигат
                    {
                        tempAts = (ATS)atsList[i];
                        atsList[i] = atsList[j];
                        atsList[j] = tempAts;
                        Console.WriteLine($"Заменен {i} на {j}");
                    }
                }
            }
        }

        public ATS FindElement(FindATSCondition condition) //Поиск элемента по условию
        {
            foreach (Object obj in atsList)
                if (condition((ATS)obj))
                    return (ATS)obj;
            return null;
        }

        public void ShowElementsWhere(FindATSCondition condition) //Вывод элементов с условием
        {
            foreach (Object obj in atsList)
                if (condition((ATS)obj))
                   Console.WriteLine(obj.ToString());
        }

        public void DeleteElement(int number)
        {
            atsList.RemoveAt(number);
        }

    }
}
