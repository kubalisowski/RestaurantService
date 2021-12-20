using Model;
using Service;
using System;
using System.Collections.Generic;

namespace RestaurantService
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuService menu_service = new MenuService(Menu.GetMenu(), new Customer());
            AppService app_service = new AppService();

            List<Order> order = new List<Order>();
            bool run = true;

            Console.WriteLine("############ WELCOME TO THE RESTAURANT ############");
            Console.WriteLine("Write 'help' to see all available commands.");
            Console.WriteLine();

            while (run)
            {
                var command = Console.ReadLine();
                switch (command)
                {
                    case "pay":
                        var balance = menu_service.Pay();
                        Console.WriteLine("Order has been paid. Your cash balance is now: " + balance);
                        Console.WriteLine();
                        break;

                    case "add":
                        var result = menu_service.PlaceOrder();
                        Console.WriteLine();
                        Console.WriteLine(result);
                        Console.WriteLine();
                        break;

                    case "quit":
                        run = false;
                        break;

                    case "display":
                        menu_service.DisplayMenu();
                        break;

                    case "help":
                        app_service.Help();
                        break;
                }
            }
        }
    }
}
