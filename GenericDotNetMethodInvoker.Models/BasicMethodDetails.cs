namespace GenericDotNetMethodInvoker.Models
{
    public class BasicMethodDetails
    {
        /// <summary>
        /// Gets or sets the assembly location.
        /// </summary>
        /// <value>
        /// The assembly location.
        /// </value>
        public string AssemblyLocation { get; set; }

        /// <summary>
        /// Gets or sets the assembly.
        /// </summary>
        /// <value>
        /// The assembly.
        /// </value>
        public string AssemblyName { get; set; }

        /// <summary>
        /// Gets or sets the namespace.
        /// </summary>
        /// <value>
        /// The namespace.
        /// </value>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the name of the class.
        /// </summary>
        /// <value>
        /// The name of the class.
        /// </value>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        /// <value>
        /// The method.
        /// </value>
        public string Method { get; set; }
        
    }
}
