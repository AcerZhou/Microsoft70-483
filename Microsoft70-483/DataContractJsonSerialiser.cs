using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Microsoft70_483
{
    public class DataContractJsonSerialiser
    {
        public static void Example()
        {
            Person p = new Person
            {
                Id = 1,
                Name = "John Doe",
                Hobby = "Sleep"
            };

            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
                ser.WriteObject(stream, p);
                stream.Position = 0;
                StreamReader streamReader = new StreamReader(stream);
                Console.WriteLine(streamReader.ReadToEnd()); // Displays {"Id":1,"Name":"John Doe"}
                stream.Position = 0;
                Person result = (Person)ser.ReadObject(stream);
            }

        }
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }

        public string Hobby { get; set; }
    }

}
