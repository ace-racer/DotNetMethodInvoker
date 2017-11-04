using System;
using System.Collections.Generic;
using GenericDotNetMethodInvoker.BusinessLogics.Interfaces;
using GenericDotNetMethodInvoker.Models;

namespace GenericDotNetMethodInvoker.BusinessLogics.Implementations
{
    public class JsonFileParser : IMethodDetailsObtainer
    {
        /// <summary>
        /// The json file fully qualified name
        /// </summary>
        private string jsonFileFullyQualifiedName;

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonFileParser"/> class.
        /// </summary>
        /// <param name="jsonFileFullyQualifiedName">Name of the json file fully qualified.</param>
        public JsonFileParser(string jsonFileFullyQualifiedName = null)
        {
            this.jsonFileFullyQualifiedName = jsonFileFullyQualifiedName;
        }

        /// <summary>
        /// Gets the details of methods to invoke.
        /// </summary>
        /// <returns>
        /// The method details to invoke
        /// </returns>
        public List<BasicMethodDetails> GetDetailsOfMethodsToInvoke()
        {
            return new List<BasicMethodDetails>()
            {
                new BasicMethodDetails()
                {
                    // AssemblyName = "GenericDotNetMethodInvoker.BusinessLogics",
                    AssemblyName = null,
                    TypeName = "DotNetMethodsInvoker",
                    Namespace = "Implementations",
                    Method = "InvokeMethods"
                }
            };
        }
    }
}
