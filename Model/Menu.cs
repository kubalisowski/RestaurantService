using System;
using System.Collections.Generic;

namespace Model
{
    public class Menu
    {
        public int Number { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public static List<Menu> GetMenu()
        {
            List<Menu> menu = new List<Menu>();
            menu.Add(new Menu { Number = 1, Description = "Market inspired soup", Price = 5.99, Quantity = 5 });
            menu.Add(new Menu { Number = 2, Description = "Mixed salad with walnuts", Price = 7.99, Quantity = 5 });
            menu.Add(new Menu { Number = 3, Description = "Duck liver", Price = 15.99, Quantity = 2 });
            menu.Add(new Menu { Number = 4, Description = "Fresh oysters", Price = 18.99, Quantity = 7 });
            menu.Add(new Menu { Number = 5, Description = "Royal chocolate", Price = 5.99, Quantity = 8 });
            menu.Add(new Menu { Number = 6, Description = "Crème brûlée", Price = 6.99, Quantity = 2 });

            return menu;
        }
    }
}
