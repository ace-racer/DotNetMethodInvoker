using GenericDotNetMethodInvoker.BusinessLogics.Interfaces;

namespace GenericDotNetMethodInvoker.BusinessLogics.Implementations
{
    public class BaseOperationsContainer
    {
        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        /// <value>
        /// The logger.
        /// </value>
        protected ILogger Logger { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOperationsContainer"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public BaseOperationsContainer(ILogger logger)
        {
            this.Logger = logger;
        }
    }
}
