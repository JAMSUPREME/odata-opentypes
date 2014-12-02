

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
            var eProp = extType.Property(e => e.Empty);
            eProp.IsOptional();

            var pType = builder.EntityType<Person>();
            pType.Ignore(p => p.Context);
            var exProp = pType.ComplexProperty(p => p.ExtraFields); // fake, but must exist for CSDL to validate on client
            exProp.IsOptional();

            config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
            config.Formatters.InsertRange(0, ODataMediaTypeFormatters.Create()); // add default OData serializers to enable XML support
        }
    }
}