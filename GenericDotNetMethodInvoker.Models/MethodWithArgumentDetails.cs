using Newtonsoft.Json.Linq;

namespace GenericDotNetMethodInvoker.Models
{
    public class MethodWithArgumentDetails : BasicMethodDetails
    {
        public JObject Arguments { get; set; }
    }
}
