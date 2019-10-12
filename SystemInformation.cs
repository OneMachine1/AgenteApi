using System;
using System.Collections.Generic;
using System.Text;

namespace agenteapi
{
    class SystemInformation
    {
        public string oSName { get; set; }
        public string memory { get; set; }

        public string ipAddress { get; set;}

       public SystemInformation(string oSName, string memory, string ipAddres)
        {
            this.oSName = oSName;
            this.memory = memory;
            this.ipAddress = ipAddres;
        }

    }
}
