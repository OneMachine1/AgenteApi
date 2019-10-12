using System;
using System.Collections.Generic;
using System.Text;

namespace agenteapi
{
    class SystemInformation
    {
        public string Os { get; set; }
        public string Memory { get; set; }

        public string Host { get; set;}

        public string User { get; set;}

       public SystemInformation(string Os, string Memory, string Host, string User)
        {
            this.Os = Os;
            this.Memory = Memory;
            this.Host = Host;
            this.User = User;
        }

    }
}
