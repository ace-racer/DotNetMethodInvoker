using GenericDotNetMethodInvoker.Models;
using System.Collections.Generic;

namespace GenericDotNetMethodInvoker.BusinessLogics.Interfaces
{
    public interface IMethodDetailsObtainer
    {
        /// <summary>
        /// Gets the details of methods to invoke.
        /// </summary>
        /// <returns>The method details to invoke</returns>
        List<BasicMethodDetails> GetDetailsOfMethodsToInvoke();
    }
}
