using System;
using System.Collections.Generic;
using System.Text;
using Store.Core.Entities;

namespace Store
{
    static class SubMenus
    {
        internal static Registered EditAccountMenu()
        {
            Registered user = new Registered();
            Console.WriteLine("\tEdit Account");
            Console.WriteLine("1) Enter new FirstName");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("2) Enter new Last Name");
            user.LastName = Console.ReadLine();
            Console.WriteLine("3) Enter new password");
            user.Password = Console.ReadLine();
            Console.WriteLine("4) Enter new email");
            user.Email = Console.ReadLine();
            Console.WriteLine("Write 1 to save changes");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                return user;
            }
            return null;
        }

        internal static void StatusOrder()
        {
            Console.Clear();
            Console.WriteLine("Enter order id to change status");
        }

        public static void PressAnyKeyInOrderToContinue()
        {
            Console.WriteLine("Press any key to back home");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
