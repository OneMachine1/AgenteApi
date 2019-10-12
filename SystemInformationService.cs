using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace agenteapi
{
    class SystemInformationService
    {

        public SystemInformation GetOperationSystemInformationService()
        {
            var systemOperational = GetOperationSystem();
            var memory = GetMemoryInfor();
            var ip = GetIpaddres();
            var osInformations = new SystemInformation(systemOperational, memory, ip);
            return osInformations;
        }



        private string GetOperationSystem()
        {
            return System.Runtime.InteropServices.RuntimeInformation.OSDescription;

        }

        private string GetMemoryInfor()
        {
            var memory = 0.0;
            Process proc = Process.GetCurrentProcess();
            memory = Math.Round(proc.PrivateMemorySize64 / 1e+6, 2);
            proc.Dispose();
            return memory.ToString();
        }

        public string GetIpaddres()
        {
            //pegar so primeiro
            var ip = new RunCommand().RunTask("ifconfig");
            
            return ip;
        }

    }
}
