using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool workStatus = true;
            while (workStatus)
            {
                Console.WriteLine("Какое задание вы хотите проверить?");
                int SwitchCase = Convert.ToInt32(Console.ReadLine());
                switch (SwitchCase)
                {
                    case 1:
                        Console.WriteLine("Введите число ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите степень ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ответ " + ToPower(a,b));
                        break;
                    case 2:
                        BullsAndCows();
                        break;
                    default:
                        workStatus = false;
                        break;
                }
            }
        }
        static void BullsAndCows()
        {
            Random RandomNumber = new Random();
            int[] Expected = new int[4];
            int randomItem, bullsCount = 0, cowsCount = 0;
            for (int i = 0; i < Expected.Length; i++)
            {
                do
                {
                    randomItem = RandomNumber.Next(1, 9);
                }
                while (Array.IndexOf(Expected, randomItem) != -1);
                Expected[i] = randomItem;
            }
            for (; ; )
            {
                Console.WriteLine("Введите свою последовательность из 4 уникальных цифр(\"-1\" для выхода из игры) ");
                String Line = Console.ReadLine();
                if (Line.Equals("-1"))
                {
                    break;
                }
                if (Line.Length != Expected.Length)
                {
                    Console.WriteLine("Неверные входные данные");
                    continue;
                }
                for (int i = 0; i < 4; i++)
                {
                    int a = Convert.ToInt32(Line.Substring(i, 1));
                    if (Array.IndexOf(Expected, a) != -1)
                    {
                        if (Expected[i] == a)
                        {
                            bullsCount++;
                        }
                        else
                        {
                            cowsCount++;
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                if (bullsCount == 4)
                {
                    Console.WriteLine("Вы победили!");
                    break;
                }
                else
                {
                    Console.WriteLine("Быков - " + bullsCount + "\nКоров - " + cowsCount + "\nПопробуй еще раз!");
                    bullsCount = 0;
                    cowsCount = 0;
                }
            }
        }
        static double ToPower(int x, int i)
        {
            if (i == 0)
                return 1;
            if (i > 0)
                return ToPower(x, i - 1) * x;
            return 1.0 / ToPower(x, -i);
        }
    }
}
