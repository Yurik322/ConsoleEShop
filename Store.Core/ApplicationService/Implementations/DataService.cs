using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Store.Core.Entities;

namespace Store.Core.ApplicationService.Implementations
{
    public class DataService : IDataService
    {
        readonly IDataRepository _data;

        public DataService(IDataRepository data)
        {
            _data = data;
        }

        public List<Product> GetAllProducts()
        {
            return _data.ReadAllProducts().ToList();
        }

        public List<Product> GetAllProductsByName(string name)
        {
            return _data.GetProductByName(name);
        }
        public List<User> GetAllUsers()
        {
            return _data.ReadAllUsers().ToList();
        }

        public List<Order> GetAllOrders()
        {
            return _data.ReadAllOrders().ToList();
        }

        public User VerificationUser()
        {
            Console.Clear();
            Console.WriteLine("Enter email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password");
            string pass = Console.ReadLine();
            var user = GetAllUsers().FirstOrDefault(u => u.Password == pass && u.Email == email);
            return user;
        }

        public Registered AddUser(Registered newUser)
        {
            _data.AddUser(newUser);
            return newUser;
        }

        public Registered CreateUser(int id)
        {
            var firstName = WriteAndReadNextLine("FirstName: ");
            var lastName = WriteAndReadNextLine("LastName: ");
            var email = WriteAndReadNextLine("Email: ");
            var password = WriteAndReadNextLine("Password: ");
            var confirmPassword = WriteAndReadNextLine("Confirm Password: ");
            return new Registered()
            {
                Id = id,
                Role = 2,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password
            };
        }

        string WriteAndReadNextLine(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
    }
}
