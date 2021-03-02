using System.Collections.Generic;
using Store.Core.Entities;

namespace Store.Core
{
    public interface IDataRepository
    {
        IEnumerable<Product> ReadAllProducts();
        IEnumerable<User> ReadAllUsers();
        IEnumerable<Order> ReadAllOrders();
        Product AddProduct(Product newProduct);
        User AddUser(User newUser);
        Order AddOrder(Order newOrder);
        Product GetProductById(int id);
        User GetUserById(int id);
        Product UpdateProduct(Product updatedProduct);
        User UpdateUser(User updatedUser);
        List<Product> GetProductByName(string name);
    }
}
