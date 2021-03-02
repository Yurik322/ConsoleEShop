using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Core.Entities
{
    public class Guest : User
    {
        public override void CheckMainMenu()
        {
            Console.WriteLine("Hello, Guest, Welcome to Console Store\n" +
                              "1 - List items\n" +
                              "2 - Search items\n" +
                              "3 - Sign in\n" +
                              "4 - Sign up\n" +
                              "5 - Exit\n" +
                              "Please, choose one:");
        }
        public void ShowAllProducts(List<Product> productsList)
        {
            Console.WriteLine("\nId\tName\tCategory\tDescription\tPrice");
            Console.WriteLine("----\t----\t--------\t-----------\t------");
            foreach (var product in productsList)
            {
                Console.WriteLine("{0}\t{1}\t{2:C}\t\t{3}\t{4}", product.Id, product.Name, product.Category,
                    product.Description, product.Price);
            }
            Console.ReadLine();
        }
        public void GetProductByName(List<Product> products)
        {
            Console.WriteLine("Enter product name");
            string name = Console.ReadLine();
            foreach (var n in products)
            {
                if (n.Name == name)
                {
                    Console.WriteLine($"Name: {n.Name} \nCategory: {n.Category}\nPrice: {n.Price}\nDescription: {n.Description}\n");
                }
            }
        }
    }
}
