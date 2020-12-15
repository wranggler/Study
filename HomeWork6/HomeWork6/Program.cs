using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWork6
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
                        Notary();
                        break;
                    case 2:
                        PassportOffice();
                        break;
                    case 3:
                        List<Passport> list = new List<Passport>();
                        list.Add(new Passport("Петров Иван Сидорович", 1312, 819273));
                        list.Add(new Passport("Петров Сидр Петрович", 8901, 237805));
                        list.Add(new Passport("Сидоров Иван Иванович", 3590, 127643));
                        list.Add(new Passport("Иванов Иван Петрович", 2992, 489126));
                        try
                        {
                            Console.WriteLine("Найден " + FindPassportByNumber(list).FIO);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        workStatus = false;
                        break;
                }
            }
        }
        static void Notary()
        {
            Queue queue = new Queue();
            string line;

            for (; ; )
            {
                Console.WriteLine("Введите свое имя(0-для завершения работы)");
                line = Console.ReadLine();
                if (line == "0")
                {
                    while (queue.Count != 0)
                    {
                        Console.WriteLine("В кабинет приглашается " + queue.Dequeue());
                    }
                    break;
                }
                queue.Enqueue(line);
                if (queue.Count == 6)
                {
                    Console.WriteLine("В кабинет приглашается " + queue.Dequeue());
                }
            }
        }
        static void PassportOffice()
        {
            List<Passport> list = new List<Passport>();
            for (int i = 0; i < new Random().Next(1,7); i++)
            {
                Console.WriteLine("Для автоматического заполнения серии паспорта введите 'А' \nЛюбой другой символ для ручного заполнения");
                if(Console.ReadLine().Equals("А",StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Введите ФИО");
                    list.Add(new Passport(Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine("Введите ФИО");
                    string fio = Console.ReadLine();
                    Console.WriteLine("Введите серию паспорта");
                    list.Add(new Passport(fio,Convert.ToInt32(Console.ReadLine())));
                }
            }
            ShowAllPassports(list);
        }
        static void ShowAllPassports(List<Passport> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.FIO + " серия " + item.Series + " номер " + item.Number);
            }
        }
        static Passport FindPassportByNumber(List<Passport> list)
        {
            Console.WriteLine("Введите номер паспорта который хотите найти(6 цифр)");
            int value = Convert.ToInt32(Console.ReadLine());
            foreach (var item in list)
            {
                if(item.Number == value)
                {
                    return item;
                }
            }
            throw new Exception("Нет такого паспорта");
        }
    }
    public class Passport
        {
        public int Series { get; set; }
        public int Number { get; set; }
        public string FIO { get; set; }

        public Passport(string fio)
        {
            Series = new Random().Next(1000, 9999);
            Number = new Random().Next(100000, 999999);
            FIO = fio;
        }
        public Passport(string fio, int series)
        {
            Series = series;
            Number = new Random().Next(100000, 999999);
            FIO = fio;
        }
        public Passport(string fio, int series , int number)
        {
            FIO = fio;
            Series = series;
            Number = number;
        }
    }
}
