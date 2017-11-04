namespace GenericDotNetMethodInvoker.BusinessLogics.Interfaces
{
    public interface IDotNetMethodsInvoker
    {
        /// <summary>
        /// Invokes the methods.
        /// </summary>
        /// <param name="methodDetailsObtainer">The method details obtainer.</param>
        void InvokeMethods(IMethodDetailsObtainer methodDetailsObtainer);
    }
}
