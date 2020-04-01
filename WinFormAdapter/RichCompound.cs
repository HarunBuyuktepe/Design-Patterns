using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAdapter
{
    class RichCompound : Compound
    {
        private ChemicalDatabank chemicalDatabank;

        public RichCompound(string name) : base(name) 
        { }

        public override string Display()
        {
            chemicalDatabank = new ChemicalDatabank();

            _boilingPoint = chemicalDatabank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = chemicalDatabank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = chemicalDatabank.GetMolecularWeight(_chemical);
            _molecularFormula = chemicalDatabank.GetMolecularStructure(_chemical);

            string base_display = base.Display();

            string new_display = "\n  Formula       : " + _molecularFormula +
                                 "\n  Weight        : " + _molecularWeight +
                                 "\n  Melting Point     : " + _meltingPoint +
                                 "\n  Boiling Point     : " + _boilingPoint;

            return base_display + new_display;
        }

    }
}
