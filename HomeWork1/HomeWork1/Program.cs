using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость звонка: ");
            int InputCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер дня недели(0-Воскресенье, 1-Понедельник ...)");
            int InputDay = Convert.ToInt32(Console.ReadLine());
            if(InputDay == 0 || InputDay == 6)
            {
                double FinalCost = InputCost * 0.8;
                Console.WriteLine("Стоимость вашего звонка составила " + FinalCost + " у.е.");

            }
            else
            {
                Console.WriteLine("Стоимость вашего звонка не изменилась");
            }
        }
    }
}
