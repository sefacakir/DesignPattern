using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            Customer customer1 = new Customer()
            {
                CashAmount = 123456789,
                CustomerNumber = "123456789"
            };
            Customer customer2 = new Customer()
            {
                CashAmount = 500000,
                CustomerNumber = "123456790"
            };

            facade.SendEFT(customer1, customer2, 12345);
            facade.UseCredit(customer2);

        }
    }
}
