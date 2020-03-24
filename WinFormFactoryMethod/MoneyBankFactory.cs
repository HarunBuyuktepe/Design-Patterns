using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFactoryMethod
{
    class MoneyBankFactory : CardFactory
    {
        private int creditLimit;
        private int annualCharge;

        public MoneyBankFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new MoneyBankCreditCard(creditLimit, annualCharge);
        }
    }
}
