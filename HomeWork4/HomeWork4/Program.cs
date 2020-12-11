using System;

namespace HomeWork4
{
    class Program
    {
        struct User
        {
            public string login,password;
        }
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
                        Product firstProduct = new Product("Штаны");
                        Product secondProduct = new Product("Телевизор");
                        Product.ComparePrice(firstProduct, secondProduct);
                        break;
                    case 2:
                        User[] users = new User[3];
                        users[0].login = "example@user.user";
                        users[0].password = "1234";
                        users[1].login = "noname";
                        users[1].password = "qwe";
                        users[2].login = "myname";
                        users[2].password = "myname";

                        Authorization(users);
                        break;
                    case 3:
                        Product pr = new Product("Диван", 20000, 3);
                        pr.Sell(2);
                        Food f = new Food("Рыба", 1000, 5, "01.12.2020");
                        f.Sell(4);
                        break;
                    default:
                        workStatus = false;
                        break;
                }
            }
        }
        static void Authorization(User[] users)
        {
            bool authorizationCheck = false;
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string pw = Console.ReadLine();
            foreach(User user in users)
            {
                if(user.login.Equals(login,StringComparison.OrdinalIgnoreCase) && user.password.Equals(pw))
                {
                    authorizationCheck = true;
                    Console.WriteLine("Вы авторизованы");
                }
            }
            if(!authorizationCheck)
            {
                Console.WriteLine("Неверный логин или пароль");
            }
        }
    }
}
