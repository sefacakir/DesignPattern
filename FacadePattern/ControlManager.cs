using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class ControlManager
    {
        public static bool CheckHasEnoughCashInBankAccount(Customer customer, decimal eftAmount)
        {
            if (customer.CashAmount >= eftAmount)
            {
                return true;
            }
            else return false;
        }
        public static bool CheckCanUseCredit(string IdNo)
        {
            return true;
        }
    }
}
