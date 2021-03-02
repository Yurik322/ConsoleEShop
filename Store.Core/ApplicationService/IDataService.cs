using System.Collections.Generic;
using Store.Core.Entities;

namespace Store.Core.ApplicationService
{
    public interface IDataService
    {
        List<Product> GetAllProducts();
        List<User> GetAllUsers();
        List<Order> GetAllOrders();
        User VerificationUser();
        Registered AddUser(Registered newUser);
        Registered CreateUser(int id);
    }
}
