using System;
using System.Collections.Generic;

namespace Store.Core.Entities
{
    public class Registered : Guest
    {
        public Registered()
        {
            Role = 2;
        }
        public override void CheckMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Hello, " + FirstName + ", Welcome to Console Store\n" +
                              "1 - List items\n" +
                              "2 - Search items\n" +
                              "3 - Create Order\n" +
                              "4 - Order History\n" +
                              "5 - Edit Account\n" +
                              "6 - Set Status\n" +
                              "7 - Log out\n" +
                              "8 - Exit\n" +
                              "Please, choose one:");
        }

        public void CreateOrder(List<Order> order, List<Product> products)
        {
            Console.Clear();
            Console.WriteLine("Choose product to create new order");
            int count = 0;
            foreach (var n in products)
            {
                count++;
                Console.WriteLine(count + ")" + n.Name + " " + n.Price + " " + n.Category + " " + n.Description);
            }
            int choose = Convert.ToInt32(Console.ReadLine());
            Order order1 = new Order();
            order1.CustomerId = this.Id;
            order1.ProductId = products[choose-1].Id;
            order1.Id = order.Count + 1;
            order1.QuantityOrder = order.Capacity;
            order1.Date = DateTime.Now;
            order.Add(order1);
            Console.WriteLine("Order added ");
        }

        public void HistoryOfOrder(List<Order> orders, int userId)
        {
            Console.Clear();
            
            foreach (var t in orders)
            {
                if (t.CustomerId == userId)
                {
                    Console.WriteLine(t.Id + " " + t.QuantityOrder + "  " + t.TotalPrice + "  " + t.Status);
                }
            }
        }

        public void EditAccount(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Password = user.Password;
            Email = user.Email;
        }

        public void SetStatusOrder(List<Order> orders, int orderId, string status)
        {
            var item = orders.FindIndex(x => x.Id == orderId && x.CustomerId == this.Id);
            orders[item].Status = status;
            Console.WriteLine("Status Changed");
        }

        public void LogOut(User user) => user = new Guest();
    }
}
