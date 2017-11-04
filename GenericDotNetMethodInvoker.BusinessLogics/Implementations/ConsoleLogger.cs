using System;
using GenericDotNetMethodInvoker.BusinessLogics.Interfaces;

namespace GenericDotNetMethodInvoker.BusinessLogics.Implementations
{
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Logs the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="isException">if set to <c>true</c> [is exception].</param>
        public void Log(string value, bool isException)
        {
            if(!string.IsNullOrWhiteSpace(value))
            {
                if (isException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.WriteLine(value);
            }
        }
    }
}
