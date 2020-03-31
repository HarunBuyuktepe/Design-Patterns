using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormAbstractFactory
{
    class Samsung : IMobilePhone
    {
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
