using System;
using System.Collections.Generic;

namespace Store.Core.Entities
{
    public class Admin : Registered
    {
        public Admin()
        {
            Role = 1;
        }
        public override void CheckMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello, ADMIN, Welcome to Console Store\n" +
                              "1 - List items\n" +
                              "2 - Search items\n" +
                              "3 - Create Order\n" +
                              "4 - Order History\n" +
                              "5 - Edit Account\n" +
                              "6 - Edit Users\n" +
                              "7 - Edit Product\n" +
                              "8 - Log out\n" +
                              "9 - Exit\n" +
                              "Please, choose one:");
        }
        public void EditUserInfo(List<User> users, int userId)
        {
            int item = users.FindIndex(x => x.Id == userId);
            Console.WriteLine("Enter new user name");
            users[item].FirstName = Console.ReadLine();
            Console.WriteLine("Enter new user lastname ");
            users[item].LastName = Console.ReadLine();
            Console.WriteLine("Enter new  email");
            users[item].Email = Console.ReadLine();
            Console.WriteLine("Enter new password");
            users[item].Password = Console.ReadLine();
            Console.WriteLine("User id:" + userId + "  info changed");
        }
        public void EditProduct(List<Product> products, int prodId)
        {
            int item = products.FindIndex(x => x.Id == prodId);
            Console.WriteLine("Enter new name of product");
            products[item].Name = Console.ReadLine();
            Console.WriteLine("Enter new price of product");
            products[item].Price = WriteAndReadNextLineDecimal("Price: ");
            Console.WriteLine("Enter new category of product");
            products[item].Category = Console.ReadLine();
            Console.WriteLine("Enter new description");
            products[item].Description = Console.ReadLine();
            Console.WriteLine("Product info changed");
        }
        decimal WriteAndReadNextLineDecimal(string text)
        {
            Console.Write(text);
            decimal price;
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Please write number!");
            }

            return price;
        }
    }
}
