using System;
using System.Collections.Generic;
using System.Text;

namespace agenteapi
{
    class SystemInformation
    {
        public string oSName { get; set; }
        public string memory { get; set; }

        public string hostName { get; set;}

        public string userName { get; set;}

       public SystemInformation(string oSName, string memory, string hostName, string userName)
        {
            this.oSName = oSName;
            this.memory = memory;
            this.hostName = hostName;
            this.userName = userName;
        }

    }
}
