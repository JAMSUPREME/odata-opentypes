using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleODataClient2.Client.SampleOdataHost
{
    //partial class ExtraFields
    //{
    //    [global::Microsoft.OData.Client.OriginalNameAttribute("key")]
    //    public string Key { get; set; }
    //}

    partial class ExtraFields
    {
        public int Worthless { get; set; }
        [global::Microsoft.OData.Client.OriginalNameAttribute("key")]
        public string KeyVal { get; set; }
    }
}
