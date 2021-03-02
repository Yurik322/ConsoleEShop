using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Store.Core;
using Store.Core.Entities;

namespace Store.Data.Repositories
{
    public class DataRepository : IDataRepository
    {
        static int _id = 5;
        public IEnumerable<Product> ReadAllProducts()
        {
            return StaticDb.Products;
        }

        public IEnumerable<User> ReadAllUsers()
        {
            return StaticDb.Users;
        }

        public IEnumerable<Order> ReadAllOrders()
        {
            return StaticDb.Orders;
        }

        public Product AddProduct(Product newProduct)
        {
            newProduct.Id = ++_id;
            var productsFromDb = StaticDb.Products.ToList();
            productsFromDb.Add(newProduct);
            StaticDb.Products = productsFromDb;
            StaticDb.Products.ToList().Add(newProduct);
            return newProduct;
        }

        public User AddUser(User newUser)
        {
            newUser.Id = ++_id;
            var usersFromDb = StaticDb.Users.ToList();
            usersFromDb.Add(newUser);
            StaticDb.Users = usersFromDb;
            StaticDb.Users.ToList().Add(newUser);
            return newUser;
        }

        public Order AddOrder(Order newOrder)
        {
            newOrder.Id = ++_id;
            var ordersFromDb = StaticDb.Orders.ToList();
            ordersFromDb.Add(newOrder);
            StaticDb.Orders = ordersFromDb;
            StaticDb.Orders.ToList().Add(newOrder);
            return newOrder;
        }

        public Product GetProductById(int id)
        {
            foreach (Product product in StaticDb.Products.ToList())
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }

        public User GetUserById(int id)
        {
            foreach (User user in StaticDb.Users.ToList())
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public Product UpdateProduct(Product updatedProduct)
        {
            Product selectedProduct = GetProductById(updatedProduct.Id);
            if (selectedProduct != null)
            {
                selectedProduct.Name = updatedProduct.Name;
                selectedProduct.Category = updatedProduct.Category;
                selectedProduct.Description = updatedProduct.Description;
                selectedProduct.Price = updatedProduct.Price;
                return selectedProduct;
            }
            return null;
        }

        public User UpdateUser(User updatedUser)
        {
            User selectedUser = GetUserById(updatedUser.Id);
            if (selectedUser != null)
            {
                selectedUser.FirstName = updatedUser.FirstName;
                selectedUser.LastName = updatedUser.LastName;
                selectedUser.Email = updatedUser.Email;
                selectedUser.Password = updatedUser.Password;
                return selectedUser;
            }
            return null;
        }

        public List<Product> GetProductByName(string name)
        {
            return StaticDb.Products.Where(x => x.Name.Contains(name)).ToList();
        }
    }
}
