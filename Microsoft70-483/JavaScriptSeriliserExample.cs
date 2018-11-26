using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Microsoft70_483
{
    public class JavaScriptSeriliserExample
    {
        public static void Example()
        {
            var json = "{\"Id\": \"1\", \"Name\":\"John\", \"Hobby\":\"Swimming\"}";

            var serializer = new JavaScriptSerializer();
            var result = serializer.Deserialize<Person>(json);

            Console.WriteLine($"Id : {result.Id}");
            Console.WriteLine($"Name : {result.Name}");
            Console.WriteLine($"Hobby : {result.Hobby}");
        }
    }
}
