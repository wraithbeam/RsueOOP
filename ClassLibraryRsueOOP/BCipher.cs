using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRsueOOPInterfaces;

namespace ClassLibraryRsueOOP
{
    public class BCipher : ICipher
    {
        private string text;
        public string Text { get => text; set => text = value; }

        public void CodeEngine() //countOfChange - сдвиг по алфавиту
        {
            string resultText = ""; //Итоговое значение
            const string upperAlfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"; //Алфавит верхнего регистра
            string lowerAlfabet =  upperAlfabet.ToLower(); //Заполняем буквы нижнего регистра

            var letterQty = 33;

            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
   
                if (!(upperAlfabet.Contains(c) || lowerAlfabet.Contains(c)))
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    resultText += c.ToString();
                }
                else
                {
                    //Если смивол найден, меняем его, согласно заданию
                    if (upperAlfabet.Contains(c))
                        resultText += upperAlfabet[(letterQty - upperAlfabet.IndexOf(c) - 1) % letterQty];
                    if (lowerAlfabet.Contains(c))
                        resultText += lowerAlfabet[(letterQty - lowerAlfabet.IndexOf(c) - 1) % letterQty];
                }
            }
            Text = resultText;
        }

        public void Decode() => CodeEngine();

        public void Encode() => CodeEngine();
    }
}
