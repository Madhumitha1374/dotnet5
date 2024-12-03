using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;

namespace MultiThreading
{
    internal class version1
    {
        public void version()
        {
            string clrVersion = Environment.Version.ToString();
            Console.WriteLine("CLR Version: " + clrVersion);

            // Get the target framework version using reflection
            var targetFrameworkAttribute = (TargetFrameworkAttribute)Assembly
                .GetExecutingAssembly()
                .GetCustomAttribute(typeof(TargetFrameworkAttribute));

            string frameworkVersion = targetFrameworkAttribute?.FrameworkName ?? "Unknown";
            Console.WriteLine("Target Framework: " + frameworkVersion);

        }
    }
}
