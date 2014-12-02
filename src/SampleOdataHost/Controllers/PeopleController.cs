
namespace SampleOdataHost.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.OData;
    using SampleOdataHost.Models;

    //public class PeopleController : ODataController
    //{
    //    public IHttpActionResult Get()
    //    {
    //        return this.Ok(PersonFactory.GetPeople());
    //    }

    //    public IHttpActionResult Get(int key)
    //    {
    //        return this.Ok(PersonFactory.GetPeople().First());
    //    }
    //}

    [RoutePrefix("odata/People")]
    public class PeopleController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return this.Ok(new PersonContext(PersonFactory.GetPeople()));
        }

        [HttpGet]
        [Route("~/odata/People({key})")]
        public IHttpActionResult Get(int key)
        {
            return this.Ok(PersonFactory.GetPeople().First());
        }
    }
}
