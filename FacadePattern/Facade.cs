using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Facade
    {
        EFTManager _eftManager;
        CreditManager _creditManager;
        public Facade()
        {
            _eftManager = new EFTManager();
            _creditManager = new CreditManager();
        }
        public void SendEFT(Customer fromCustomer, Customer toCustomer,decimal eftAmount)
        {
            if (ControlManager.CheckHasEnoughCashInBankAccount(fromCustomer, eftAmount))
            {
                _eftManager.SendEFT(fromCustomer,toCustomer,eftAmount);
            }
        }
        public void UseCredit(Customer customer)
        {
            _creditManager.UseCredit(customer);
        }
    }
}
