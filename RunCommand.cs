using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace agenteapi
{
    class RunCommand
    {

        public string RunTask(string command)
        {
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    //FileName = "/bin/bash",
                    //Arguments = $"-c \"{escapedArgs}\"", 					 
                    FileName = command,
                   // Arguments = $"localhost",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            return process.StandardOutput.ReadToEnd();
        }
    }
}
