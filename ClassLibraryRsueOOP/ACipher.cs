using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRsueOOPInterfaces;

namespace ClassLibraryRsueOOP
{
    public class ACipher : ICipher
    {
        private string text;
        public string Text { get => text; set => text= value; }

        public void CodeEngine(int countOfChange) //countOfChange - сдвиг по алфавиту
        {
            string resultText = ""; //Итоговое значение
            const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; //Алфавит
            string fullAlfabet = "";
            fullAlfabet = alfabet + alfabet.ToLower(); //Прибавляем буквы нижнего регистра

            var letterQty = fullAlfabet.Length; //Вычисляем длинну

            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    resultText += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + countOfChange) % letterQty;
                    resultText += fullAlfabet[codeIndex];
                }
            }
            Text = resultText;
        }

        public void Decode() => CodeEngine(1);

        public void Encode() => CodeEngine(-1);
    }
}
