using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class EFTManager
    {
        public void SendEFT(Customer fromCustomer,Customer toCustomer, decimal eftAmount)
        {
            if (ControlManager.CheckHasEnoughCashInBankAccount(fromCustomer, eftAmount))
            {
                fromCustomer.CashAmount -= eftAmount;
                toCustomer.CashAmount += eftAmount;
                Console.WriteLine("EFT sent to account "+toCustomer.CustomerNumber);
            }
        }
    }
}
