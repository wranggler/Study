using System;

namespace HomeWork5
{
    abstract class Product
    {
        public int Price { get; set; } = 5000;
        public string Name { get; set; }
        public int  Markup { get; set; }
        public int Quality { get; set; }
        public abstract int GetPrice();
        public abstract int GetIncome();
        public void Show()
        {
            Console.WriteLine("Ваш товар "+Name+" его цена "+ GetPrice()+" в наличии " +Quality+" вы заработаете "+ GetIncome());
        }
    }

    class PhysicalProduct : Product
    {
        public PhysicalProduct(string name,int quality)
        {
            Name = name;
            Markup = new Random().Next(2);
            Quality = quality;
            }
        public override int GetIncome()
        {
            return GetPrice() * Quality;
        }

        public  override int GetPrice()
        {
            return Price * Markup + Price;
        }

    }
    class DigitalProduct : Product
    {
        public DigitalProduct(string name, int quality)
        {
            Name = name;
            Markup = new Random().Next(2);
            Quality = quality;
        }
        public override int GetIncome()
        {
            return GetPrice() * Quality;
        }

        public override int GetPrice()
        {
            return Price / 2 * Markup + Price / 2;
        }

    }
    class WeightProduct : Product
    {

        public WeightProduct(string name, int quality)
        {
            Name = name;
            Markup = new Random().Next(2);
            Quality = quality;
        }
        public override int GetIncome()
        {
            return GetPrice() * Quality;
        }

        public override int GetPrice()
        {
            return Price;
        }
        public new void Show()
        {
            Console.WriteLine("Ваш товар " + Name + " его цена за кг " + GetPrice() + " в наличии " + Quality + "кг вы заработаете " + GetIncome());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Product phys = new PhysicalProduct("Ноутбук", 6);
            Product digi = new DigitalProduct("Подписка на музыку", 3);
            WeightProduct weig = new WeightProduct("Печеньки", 5);

            phys.Show();
            digi.Show();
            weig.Show();

        }
    }
}
