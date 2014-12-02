
namespace SampleOdataHost.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    public class PersonContext
    {
        public PersonContext(IEnumerable<Person> people)
        {
            Context = "http://localhost:53305/odata/$metadata#People"; // bleh
            Value = people;
        }

        [DataMember]
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [DataMember]
        [JsonProperty("value")]
        public IEnumerable<Person> Value { get; set; }
    }
}