using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAbstractFactory
{
    class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model : Samsung Galaxy\nRAM : 2 GB\nCamera : 13 MP\n";
        }
    }
}
