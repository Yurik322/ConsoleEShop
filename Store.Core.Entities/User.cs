using System;
using System.Collections.Generic;
using Store.Core.Entities.Exceptions;

namespace Store.Core.Entities
{
    public abstract class User
    {
        public int Id { get; set; }
        public int Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public abstract void CheckMainMenu();
        public int MenuChoice(int max)
        {
            int n = 0;
            bool flag = true;
            do
            {
                try
                {
                    n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    if (n > max || n <= 0)
                    {
                        throw new ConsoleShopLowArgumentException();
                    }
                    flag = false;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Incorrect input, please try again");
                }
                catch (ConsoleShopLowArgumentException)
                {
                    Console.WriteLine("Incorrect input,that case don`t exist. Please, try again");
                }
            } while (flag);

            return n;
        }
    }
}
