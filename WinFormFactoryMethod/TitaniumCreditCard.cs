using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormFactoryMethod
{
    class TitaniumCreditCard : CreditCard
    {
        private readonly string cardType;
        private int creditLimit;
        private int annualCharge;

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            this.cardType = "Titanium";
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }

        public override string CardType
        {
            get { return cardType; }
        }

        public override int CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }

        public override int AnnualCharge
        {
            get { return annualCharge; }
            set { annualCharge = value; }
        }
    }
}
