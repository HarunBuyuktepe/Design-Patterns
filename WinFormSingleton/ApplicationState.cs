using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSingleton
{
    class ApplicationState
    {
        private static ApplicationState instance = null;

        public string LoginId { get; set; }
        public string RoleId { get; set; }

        private ApplicationState() { }

        private static object lockThis = new object();

        public static ApplicationState GetState()
        {
            lock(lockThis)
            {
                if (ApplicationState.instance == null)
                    instance = new ApplicationState();
            }

            return instance;
        }
    }
}
