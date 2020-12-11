using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class Food : Product
    {
        private DateTime expirationDate;

        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }

        public Food(string name, int cost, int quantity, string date) : base(name,cost,quantity)
        {
            expirationDate = DateTime.Parse(date);
        }

        public new void Sell(int quantity)
        {
            if (Quantity >= quantity)
            {
                Quantity -= quantity;
                checkDates();
                Console.WriteLine("Вы продали " + Name + " в количестве " + quantity + " на сумму " + (Cost * quantity) + " остаток товара " + Quantity + " срок годности до " + expirationDate.ToString("d"));
            }
            else
            {
                Console.WriteLine("Недостаточно товара на складе");
            }
        }

        void checkDates()
        {
            if (expirationDate.CompareTo(DateTime.Now) == -1)
            {
                Console.WriteLine(Name + " просрочен цена изменена на 0");
                Cost = 0;
            }
        }

    }
}
