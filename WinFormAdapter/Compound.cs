using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAdapter
{
    class Compound
    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        // Constructor

        public Compound(string chemical)
        {
            this._chemical = chemical;
        }

        public virtual string Display()
        {
            return "\nCompound: " + _chemical + "------ " ;
        }
    }
}
