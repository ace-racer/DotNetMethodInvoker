namespace GenericDotNetMethodInvoker.BusinessLogics.Interfaces
{
    public interface ILogger
    {
        /// <summary>
        /// Logs the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="isException">if set to <c>true</c> [is exception].</param>
        void Log(string value, bool isException = false);
    }
}
