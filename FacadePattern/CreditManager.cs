using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class CreditManager
    {
        public void UseCredit(Customer customer)
        {
            if (ControlManager.CheckCanUseCredit(customer.CustomerNumber))
            {
                Console.WriteLine("Transaction successful.");
            }else
                Console.WriteLine("Operation failed.");
        }
    }
}
