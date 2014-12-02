
namespace SampleOdataHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Runtime.Serialization;

    using Newtonsoft.Json;

    [DataContract]
    public class Person
    {
        public Person()
        {
            Context = "http://localhost:53305/odata/$metadata#People/$entity"; // bleh
        }

        [DataMember]
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Special facade on top of extra fields that should hopefully make the schema fill clients correctly
        /// </summary>
        [DataMember(Name = "ExtraFields")]
        public IDictionary<string, object> DynamicProperties
        {
            get
            {
                return ExtraFields.Self;
            }
        }

        public ExtraFields ExtraFields { get; set; }

        //private IDictionary<string, object> extendedFields;
        //[DataMember]
        //public IDictionary<string, object> ExtraFields
        //{
        //    get
        //    {
        //        return this.extendedFields;
        //    }
        //    set
        //    {
        //        this.extendedFields = value;
        //    }
        //}
    }

    public class ExtraFields
    {
        public ExtraFields()
        {

        }
        public ExtraFields(IDictionary<string, object> self)
        {
            this.Self = self;
        }
        public IDictionary<string, object> Self { get; set; }
    }
}