using System;
using System.Text.RegularExpressions;

namespace HomeWork3
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
                        Console.WriteLine("Массив простых чисел корень которых меньше 100");
                        foreach(int item in GetSimpleNumbers())
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите предложение(без точки)");
                        GetShareOfLastChar(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Введите ip адрес или email для проверки");
                        string Line = Console.ReadLine();
                        Regex regIp = new Regex(@"([0-9]{1,3}[\.]){3}[0-9]{1,3}");
                        Regex regEmail = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                        if(regIp.IsMatch(Line))
                            Console.WriteLine("Ваш ip верный");
                        else if(regEmail.IsMatch(Line))
                            Console.WriteLine("Ваш email верный");
                        else
                            Console.WriteLine("Проверка не пройдена");
                        break;
                    case 4:
                        string[] Names = {"Ивнвнов Иван Иванович","Петров Петр Петрович","Сорокин Воробей Леопольдович","Павлов Константин Львович","Попов Олег Алексеевич","Смирнов Никита Сергеевич"};
                        Worker[] Workers = new Worker[7];
                        for(int i=0; i < Workers.Length; i++)
                        {
                            Workers[i] = new Worker(Names[new Random().Next(0,Names.Length-1)]);
                            if(Workers[i].Salary > 30000)
                            {
                                Console.WriteLine(Workers[i].Name + "\nВозраст " + Workers[i].Age + "\nЗарплата " + Workers[i].Salary);
                            } 
                        }
                        
                        break;
                    default:
                        workStatus = false;
                        break;
                }
            }
        }
        static int[] GetSimpleNumbers()
        {
            int ArrayIndex = 0;
            int[] ResultArray = new int[25];
            for(int i = 0; i < Math.Sqrt(100); i++)
            {
                int DividersCount = 0;
                for (int j = 1; j <= (i/2);j++)
                {
                    if(i % j == 0)
                    {
                        DividersCount++;
                    }
                }
                if (DividersCount == 1)
                {
                    ResultArray[ArrayIndex++] = i;
                }
            }
            return ResultArray;
        }
        static void GetShareOfLastChar(string Line)
        {
            int CountOfChar = 0;
            for (int i = 0; i < Line.Length; i++)
            {
                if (Line[i].Equals(Line[Line.Length - 1]))
                {
                    CountOfChar++;
                }
            }
            int ShareOfChar = (int)Math.Round((Convert.ToDouble(CountOfChar) / Line.Length) * 100);
            Console.WriteLine("Процент буквы \"" + Line[Line.Length-1] + "\" составляет " + ShareOfChar + "%");
        }
    }
    class Worker
    {
        public string Name;
        public int Salary, Age;
        public Worker(string Name)
        {
            Salary = new Random().Next(15000, 45000);
            Age = new Random().Next(22, 60);
            this.Name = Name;
        }
    }
}
