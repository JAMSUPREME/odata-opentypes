

namespace SampleOdataHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Http;
    using System.Web.OData.Builder;
    using System.Web.OData.Extensions;
    using System.Web.OData.Formatter;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            var builder = new ODataConventionModelBuilder();

            //register types
            builder.EntitySet<Person>("People");
            var extType = builder.ComplexType<ExtraFields>();
            //extType.HasDynamicProperties(e => e.Self); //might work? (appears it is already known that self is dynamic)

            var pType = builder.EntityType<Person>();
            pType.Ignore(p => p.Context);
            pType.ComplexProperty(p => p.ExtraFields); // fake, but must exist for CSDL to validate on client
            //pType.HasDynamicProperties(f => f.ExtraFields);

            config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
            config.Formatters.InsertRange(0, ODataMediaTypeFormatters.Create()); // add default OData serializers to enable XML support
        }
    }
}