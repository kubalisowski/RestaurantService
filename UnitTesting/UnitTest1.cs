using Model;
using Service;
using System;
using Xunit;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void PayTest()
        {
            MenuService service = new MenuService(Menu.GetMenu(), new Customer());
            service.Customer.CashBalance = 0.0;
            Assert.Equal(0.0, service.Pay());
        }

        [Fact]
        public void CheckCustomerBalanceTest()
        {
            MenuService service = new MenuService(Menu.GetMenu(), new Customer());
            Assert.True(service.CheckCustomerBalance(new Order { Price = 100.0 }));
            Assert.False(service.CheckCustomerBalance(new Order { Price = 101.0 }));
        }

        [Fact]
        public void CheckQuantityTest()
        {
            MenuService service = new MenuService(Menu.GetMenu(), new Customer());

            var qtyTest = service.CheckQuantity(new Order { MenuNumber = 1, Quantity = 5 });
            Assert.True(qtyTest);
            qtyTest = service.CheckQuantity(new Order { MenuNumber = 1, Quantity = 6 });
            Assert.False(qtyTest);
        }


    }
}
