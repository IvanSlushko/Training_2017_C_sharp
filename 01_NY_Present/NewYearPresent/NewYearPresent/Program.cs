﻿using NewYearPresent.Gift;
using static NewYearPresent.CandyElement;

namespace NewYearPresent
{
    class Program
    {
        static void Main(string[] args)
        {

            IGift gift = new Gift();

            Creator[] variants = new Creator[1];
            //     Имя | Вес | Сахар | Калории | Тип элемента

            //gift.Add("Конфета Мишка", 10, 15, 20, CandyElement.TypeCandyElement.ChocolateCandy);



        }
    }
}
