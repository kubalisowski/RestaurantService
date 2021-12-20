using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class MenuService
    {
        public List<Menu> Menu { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public Customer Customer { get; set; }

        public MenuService(List<Menu> menu, Customer customer)
        {
            this.Menu = menu;
            this.Customer = customer;
        }

        private Order NewOrder()
        {
            Order newOrder = new Order();
            Console.Write("Provide number of menu item: ");
            newOrder.MenuNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Provide quantity: ");
            newOrder.Quantity = Convert.ToInt32(Console.ReadLine());

            return newOrder;
        }

        public void DisplayMenu()
        {
            foreach (var item in Menu)
            {
                Console.WriteLine(item.Number + " " + item.Description + ", Price: " + item.Price + ", Quantity: " + item.Quantity);
            }
            Console.WriteLine();
        }

        public bool CheckQuantity(Order order)
        {
            var item = Menu.Where(m => m.Number == order.MenuNumber).FirstOrDefault();
            var itemQuantity = item.Quantity - order.Quantity;
            if (itemQuantity >= 0)
                return true;
            else
                return false;
        }

        public bool CheckCustomerBalance(Order order)
        {
            if (Customer.CashBalance - (order.Price * order.Quantity) >= 0)
                return true;
            else
                return false;
        }

        public string PlaceOrder()
        {
            var order = NewOrder();
            order.Price = Menu.Where(m => m.Number == order.MenuNumber).FirstOrDefault().Price;
            var checkQty = CheckQuantity(order);
            var checkBalance = CheckCustomerBalance(order);

            if (!checkQty)
                return "Menu item is not available in provided quantity.";
            else if (!checkBalance)
                return "You have no enough cash to place the order.";

            Orders.Add(order);
            Menu.Where(m => m.Number == order.MenuNumber).FirstOrDefault().Quantity -= order.Quantity;
            Customer.CashBalance -= order.Price * order.Quantity;

            return "Your order has been placed successfully.";
        }

        public double Pay()
        {
            return Customer.CashBalance;
        }
    }
}
