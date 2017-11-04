using GenericDotNetMethodInvoker.BusinessLogics.Interfaces;
using System;
using System.Reflection;

namespace GenericDotNetMethodInvoker.BusinessLogics.Implementations
{
    public class DotNetMethodsInvoker : BaseOperationsContainer, IDotNetMethodsInvoker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DotNetMethodsInvoker"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public DotNetMethodsInvoker(ILogger logger = null) : base(logger)
        {
            if (logger == null)
            {
                logger = new ConsoleLogger();
            }

            base.Logger = logger;
        }

        /// <summary>
        /// Invokes the methods.
        /// </summary>
        /// <param name="methodDetailsObtainer">The method details obtainer.</param>
        public void InvokeMethods(IMethodDetailsObtainer methodDetailsObtainer)
        {
            if (methodDetailsObtainer != null)
            {
                var detailsOfMethodsToInvoke = methodDetailsObtainer.GetDetailsOfMethodsToInvoke();
                if (detailsOfMethodsToInvoke != null && detailsOfMethodsToInvoke.Count > 0)
                {
                    foreach (var detailsOfMethod in detailsOfMethodsToInvoke)
                    {
                        try
                        {
                            var qualifiedTypeName = detailsOfMethod.TypeName;
                            if (!string.IsNullOrWhiteSpace(detailsOfMethod.Namespace))
                            {
                                qualifiedTypeName = detailsOfMethod.Namespace + "." + detailsOfMethod.TypeName;
                            }

                            var instance = Activator.CreateInstance(detailsOfMethod.AssemblyName, qualifiedTypeName);
                            if (instance != null)
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            Logger.Log(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
