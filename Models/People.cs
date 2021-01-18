using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WeigthLoss.Interface;

namespace WeigthLoss.Models
{
    public class People : IPeople
    {
        public string Name { get; set; }
        public string FName { get; set; }
        public int Age { get; set; }
        public int Weigth { get; set; }
        public int Height { get; set; }

        public string MName { get; set; }

        public string IMT(double Weigth, double Heigth,string[] str)
        {
            double IMT = Weigth / (Heigth * Heigth);

            bool isToLoow = IMT <= 18.5;
            bool isNormal = IMT > 18.5 && IMT < 25;
            bool isAboveNormal = IMT >= 25 && IMT <= 30;
            bool isFat = IMT > 30;
            string st1;
            if (isToLoow)
            {
                st1 = "Вы истощены!";
            }
            else if (isNormal)
            {
                 st1 = "Вы в хорошей форме!";
            }
            else if (isAboveNormal)
            {
                 st1 = "Вам немного скинуть!";
            }
            else if (isFat)
            {
                 st1 = "У вас лишний вес!!!";
            }
            else
            {
                 st1 = "Ошибка!";
            }

            string s = null;
            foreach (var item in str)
            {
                s += $"{item} ";
            }
            File.AppendAllText("Info.txt", $"{s} Результат :{IMT} Итог: {st1}\n");


            string str1 = ($"Ваш результат {IMT} \n Истощение > 18.5 \n Отличная форма 18,5 до 25 \n немного скинуть 25 до 30 \n У вас лишний вес! 30 + \n Итог : {st1}");

            return str1;
        }
    }
}
