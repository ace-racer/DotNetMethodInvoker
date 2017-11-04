using GenericDotNetMethodInvoker.BusinessLogics.Implementations;
using GenericDotNetMethodInvoker.BusinessLogics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDotNetMethodInvoker.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IDotNetMethodsInvoker dotNetMethodsInvoker = new DotNetMethodsInvoker();
            IMethodDetailsObtainer methodDetailsObtainer = new JsonFileParser();
            dotNetMethodsInvoker.InvokeMethods(methodDetailsObtainer);
            Console.ReadKey();
        }
    }
}
