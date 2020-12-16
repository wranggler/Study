using System;
using System.Collections.Generic;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            var DrinksList = new Dictionary<string, int>();
            DrinksList.Add("Вода горячая", 10);
            DrinksList.Add("Молоко горячее", 30);
            DrinksList.Add("Эспрессо", 50);
            DrinksList.Add("Американо", 60);
            DrinksList.Add("Капучино", 90);
            DrinksList.Add("Латте", 110);
            DrinksList.Add("Раф с сиропом", 160);

            CoffeMachine(DrinksList);
        }
        static void CoffeMachine(Dictionary<string,int> list)
        {
            Console.WriteLine("Введите суммму денег в наличии");
            int moneyAmount = Convert.ToInt32(Console.ReadLine());
            bool checker = false;
            foreach (var item in list)
            {
                if(item.Value <= moneyAmount)
                {
                    Console.WriteLine("Вы можете проиобрести " + item.Key);
                    checker = true;
                }
            }
            if (!checker)
            {
                Console.WriteLine("К сожалению ваших средств недостаточно для приобретения напитка");
            }
        }
    }
}
