using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое задание вы хотите проверить?(1-5)");
            int SwitchCase = Convert.ToInt32(Console.ReadLine());
            switch (SwitchCase)
            {
                case 1:
                    Console.WriteLine("Введите стоимость звонка: ");
                    int InputCost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите номер дня недели(0-Воскресенье, 1-Понедельник ...)");
                    int InputDay = Convert.ToInt32(Console.ReadLine());
                    if (InputDay == 0 || InputDay == 6)
                    {
                        double FinalCost = InputCost * 0.8;
                        Console.WriteLine("Стоимость вашего звонка составила " + FinalCost + " у.е.");

                    }
                    else
                    {
                        Console.WriteLine("Стоимость вашего звонка не изменилась");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите дату начала второй мировой войны(В формате дд.мм.гггг) : ");
                    string StringDate = Console.ReadLine();
                    var ParsedDate = DateTime.Parse(StringDate);
                    DateTime CorrectDate = DateTime.Parse("01.09.1939");
                    if(CorrectDate.Equals(ParsedDate))
                    {
                        Console.WriteLine("Верно!");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка :( \nНастоящая дата начала войны " + CorrectDate.ToString("d"));
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите коэффициент a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите коэффициент b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите коэффициент c: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    GetRoots(a, b, c);
                    break;
                case 4:
                    Console.WriteLine("Введите x: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    double s = ((600 + x) / Math.Sqrt(Math.Pow(1200, 2) + Math.Pow((600 + x), 2))) - ((1500 - x) / Math.Sqrt(Math.Pow(900, 2) + Math.Pow((1500 - x), 2)));
                    Console.WriteLine("Ответ = " + s);
                    break;
                case 5:
                    Random RandomNumber= new Random();
                    int Dividend = RandomNumber.Next(100, 100000);
                    int Divisor = RandomNumber.Next(100);
                    Console.WriteLine("Целочисленно разделите число " + Dividend + " на число " + Divisor + " и введите результат");
                    int Expexcted = Dividend / Divisor;
                    int Actual = Convert.ToInt32(Console.ReadLine());
                    if(Expexcted == Actual)
                    {
                        Console.WriteLine("Верно!");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка :( \nПравильный результат = " + Expexcted);
                    }
                    break;
            }
        }
        public static void GetRoots(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0 || D == 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= " + x1 + "\nx2= " + x2);
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
    }
}
