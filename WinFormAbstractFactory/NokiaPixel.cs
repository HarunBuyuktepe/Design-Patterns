using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAbstractFactory
{
    class NokiaPixel : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model : Nokia Pixel\nRAM : 3 GB\nCamera : 8 MP\n";
        }
    }
}
