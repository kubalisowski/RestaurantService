using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public Customer()
        {
        }

        //public static double StartAmount { get { return 100.0; } }
        public double CashBalance { get; set; } = 100.0;
    }
}
