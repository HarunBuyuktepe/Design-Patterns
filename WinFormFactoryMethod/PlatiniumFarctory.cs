using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFactoryMethod
{
    class PlatiniumFarctory : CardFactory
    {
        private int creditLimit;
        private int annualCharge;

        public PlatiniumFarctory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new PlatiniumCreditCard(creditLimit, annualCharge);
        }
    }
}
