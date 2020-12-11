using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Product
    {
        private string name;
        private int cost, quantity;

        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Product(string Name, int Cost, int Quantity)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Quantity = Quantity;
        }

        public Product(string Name)
        {
            this.Name = Name;
            Cost = new Random().Next(1000, 100000);
        }

        public static void ComparePrice(Product x, Product y)
        {
            if(x.Cost >= y.Cost)
            {
                Console.WriteLine("Товар " + x.Name + " дороже товара " + y.Name + " на " + (x.Cost - y.Cost));
            }
            else
            {
                Console.WriteLine("Товар " + y.Name + " дороже товара " + x.Name + " на " + (y.Cost - x.Cost));
            }
        }
        public void Sell(int quantity)
        {
            if(Quantity >= quantity)
            {
                Quantity -= quantity;
                Console.WriteLine("Вы продали " + Name + " в количестве " + quantity + " на сумму " + (Cost * quantity) + " остаток товара " + Quantity);
            }
            else
            {
                Console.WriteLine("Недостаточно товара на складе");
            }
        }

    }
}
