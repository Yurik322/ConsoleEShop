using System;
using System.Collections.Generic;
using System.Linq;
using Store.Core.ApplicationService;
using Store.Core.Entities;

namespace Store
{
    public class Printer : IPrinter
    {
        readonly IDataService _data;
        public Printer(IDataService data)
        {
            _data = data;
            ShowMenu();
        }

        public void ShowMenu()
        {
            while (true)
            {
                Guest guest = new Guest();
                guest.CheckMainMenu();
                int choice = guest.MenuChoice(5);
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        guest.ShowAllProducts(_data.GetAllProducts());
                        break;
                    case 2:
                        Console.Clear();
                        guest.GetProductByName(_data.GetAllProducts());
                        break;
                    case 3:
                        AccessToStore(_data.VerificationUser());
                        break;
                    case 4:
                        _data.AddUser(_data.CreateUser(1));
                        break;
                    case 5:
                        Environment.Exit(-1);
                        break;
                }
                Console.Clear();
            }
        }

        public void AccessToStore(User credential)
        {
            if (credential.Role == 2)
            {
                Registered registered = (Registered)credential;
                bool flag = true;
                while (flag)
                {
                    Console.Clear();
                    registered.CheckMainMenu();
                    int choice = registered.MenuChoice(8);
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            registered.ShowAllProducts(_data.GetAllProducts());
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 2:
                            registered.GetProductByName(_data.GetAllProducts());
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 3:
                            registered.CreateOrder(_data.GetAllOrders(), _data.GetAllProducts());
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 4:
                            registered.HistoryOfOrder(_data.GetAllOrders(), registered.Id);
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 5:
                            Registered editedUser = SubMenus.EditAccountMenu();
                            if (editedUser != null)
                            {
                                registered.EditAccount(editedUser);
                            }
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 6:
                            SubMenus.StatusOrder();
                            int orderId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter 1 to set (RECEIVED) / 2 to set (CANCELED)");
                            string c = Console.ReadLine();
                            if (c == "1")
                            {
                                registered.SetStatusOrder(_data.GetAllOrders(), orderId, "RECEIVED");
                            }
                            else if (c == "2")
                            {
                                registered.SetStatusOrder(_data.GetAllOrders(), orderId, "CANCELED");
                            }
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 7:
                            registered.LogOut(registered);
                            flag = false;
                            break;
                    }
                }
            }
            else if (credential.Role == 1)
            {
                Admin admin = (Admin)credential;
                bool flag = true;
                while (flag)
                {
                    Console.Clear();
                    admin.CheckMainMenu();
                    int choice = admin.MenuChoice(9);
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:
                            admin.ShowAllProducts(_data.GetAllProducts());
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 2:
                            admin.GetProductByName(_data.GetAllProducts());
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 3:
                            admin.CreateOrder(_data.GetAllOrders(), _data.GetAllProducts());
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 4:
                            admin.HistoryOfOrder(_data.GetAllOrders(), admin.Id);
                            SubMenus.PressAnyKeyInOrderToContinue();
                            break;
                        case 5:
                            User editedUser = SubMenus.EditAccountMenu();
                            if (editedUser != null)
                            {
                                admin.EditAccount(editedUser);
                            }
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("Enter User id ");
                            int userId = Convert.ToInt32(Console.ReadLine());
                            admin.EditUserInfo(_data.GetAllUsers(), userId);
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Enter Product id ");
                            int productId = Convert.ToInt32(Console.ReadLine());
                            admin.EditProduct(_data.GetAllProducts(), productId);
                            break;
                        case 8:
                            SubMenus.StatusOrder();
                            int orderId = Convert.ToInt32(Console.ReadLine());
                            if (_data.GetAllOrders().FindIndex(x => x.Id == orderId) > 0)
                            {
                                Console.WriteLine("Enter 1 to set (RECEIVED) / 2:(CANCELED BY ADMIN) / 3:(SEND) / 4:(COMPLETE)");
                                string c = Console.ReadLine();
                                if (c == "1")
                                {
                                    admin.SetStatusOrder(_data.GetAllOrders(), orderId, "RECEIVED");
                                }
                                else if (c == "2")
                                {
                                    admin.SetStatusOrder(_data.GetAllOrders(), orderId, "CANCELED BY ADMIN");
                                }
                                else if (c == "3")
                                {
                                    admin.SetStatusOrder(_data.GetAllOrders(), orderId, "SEND");
                                }
                                else if (c == "4")
                                {
                                    admin.SetStatusOrder(_data.GetAllOrders(), orderId, "COMPLETE");
                                }
                            }
                            Console.WriteLine("Cant find order");
                            Console.WriteLine("Enter any key to exit");
                            break;
                        case 9:
                            flag = false;
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Bad email or password");
            }
        }
    }
}

