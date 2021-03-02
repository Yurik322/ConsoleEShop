using System;
using System.Collections.Generic;
using Store.Core.Entities;

namespace Store.Data
{
    public class StaticDb
    {
        public static IEnumerable<Product> Products;
        public static IEnumerable<User> Users;
        public static IEnumerable<Order> Orders;
        
        public static void InitData()
        {
            var product1 = new Product()
            {
                Id = 1, 
                Name = "Name", 
                Category = "food", 
                Description = "delicious", 
                Price = 100
            };
            var product2 = new Product()
            {
                Id = 2,
                Name = "Name2",
                Category = "food2",
                Description = "delicious",
                Price = 100
            };
            var product3 = new Product()
            {
                Id = 3,
                Name = "Name3",
                Category = "food3",
                Description = "delicious",
                Price = 100
            };
            var product4 = new Product()
            {
                Id = 4,
                Name = "Name4",
                Category = "food4",
                Description = "delicious",
                Price = 100
            };
            var product5 = new Product()
            {
                Id = 5,
                Name = "Name5",
                Category = "food5",
                Description = "delicious",
                Price = 100
            };

            var user1 = new Registered()
            {
                Id = 2,
                Role = 2,
                FirstName = "Yurii",
                LastName = "Boyko",
                Email = "user",
                Password = "111"
            };
            var user2 = new Registered()
            {
                Id = 3,
                Role = 2,
                FirstName = "Vova",
                LastName = "Pupkin",
                Email = "user2",
                Password = "222"
            };
            var user3 = new Registered()
            {
                Id = 3,
                Role = 2,
                FirstName = "Oleg",
                LastName = "Gepkin",
                Email = "User@gmail.com",
                Password = "333"
            };
            var user4 = new Registered()
            {
                Id = 4,
                Role = 2,
                FirstName = "Oleg",
                LastName = "Gepkin",
                Email = "User@gmail.com",
                Password = "333"
            };
            var admin1 = new Admin()
            {
                Id = 1,
                Role = 1,
                FirstName = "Admin",
                LastName = "Admin",
                Email = "admin",
                Password = "admin"
            };

            var order1 = new Order()
            {
                Id = 1,
                CustomerId = 2,
                ProductId = 1,
                QuantityOrder = 2,
                Status = "new",
                Date = DateTime.Today,
                TotalPrice = 322
            };
            var order2 = new Order()
            {
                Id = 2,
                CustomerId = 2,
                ProductId = 2,
                QuantityOrder = 2,
                Status = "new",
                Date = DateTime.Today,
                TotalPrice = 200
            };
            var order3 = new Order()
            {
                Id = 3,
                CustomerId = 2,
                ProductId = 3,
                QuantityOrder = 2,
                Status = "new",
                Date = DateTime.Today,
                TotalPrice = 200
            };
            var order4 = new Order()
            {
                Id = 4,
                CustomerId = 3,
                ProductId = 4,
                QuantityOrder = 2,
                Status = "new",
                Date = DateTime.Today,
                TotalPrice = 200
            };
            var order5 = new Order()
            {
                Id = 5,
                CustomerId = 2,
                ProductId = 5,
                QuantityOrder = 2,
                Status = "new",
                Date = DateTime.Today,
                TotalPrice = 200
            };

            Products = new List<Product> { product1, product2, product3, product4, product5 };
            Users = new List<User> { user1, user2, user3, user4, admin1 };
            Orders = new List<Order> { order1, order2, order3, order4, order5 };
        }
    }
}