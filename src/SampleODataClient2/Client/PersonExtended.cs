using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleODataClient2.Client.SampleOdataHost
{
    using global::System.Dynamic;

    // solution - rather than implement as dictated, the "ExtendedFields" property should be pulled into a separate class
    // Since Person itself is not actually an open type (ExtendedFields is an open type) the schema is misleading and so expectedly invalid

    // alt work-around: declare dictionary as a complex property

    // right now neither impl. above results in a filled client object

    //partial class Person
    //{
    //    //[global::Microsoft.OData.Client.OriginalNameAttribute("ExtraFields")]
    //    //public dynamic ExtraFields { get; set; }

    //    [global::Microsoft.OData.Client.OriginalNameAttribute("ExtraFields")]
    //    public ExtraFields ExtraFields { get; set; }
    //}

    //public class ExtraFields
    //{
    //    public IDictionary<string, object> Fields { get; set; }
    //}

    partial class Person
    {
        [global::Microsoft.OData.Client.OriginalNameAttribute("key")]
        public string ExtraFieldValue { get; set; }

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExtraFields")]
        public Dictionary<string, object> ExtraFieldsDyn { get; set; }

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExtraFields")]
        public ExtendedFieldExplicit ExtraFieldsKnown { get; set; }
    }

    public class ExtendedFieldExplicit
    {
        [global::Microsoft.OData.Client.OriginalNameAttribute("key")]
        public string KeyInfo { get; set; }
    }
}

namespace SampleODataClient2.Client.System.Collections.Generic
{
    partial class Dictionary_2OfString_Object
    {
        [global::Microsoft.OData.Client.OriginalNameAttribute("key")]
        public object ExtraFieldValue { get; set; }
    }
}
