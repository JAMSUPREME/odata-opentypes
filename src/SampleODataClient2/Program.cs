using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleODataClient2
{
    using SampleODataClient2.Client.Default;
    using SampleODataClient2.Client.SampleOdataHost;

    class Program
    {
        static void Main(string[] args)
        {
            // see http://blogs.msdn.com/b/odatateam/archive/2014/03/12/how-to-use-odata-client-code-generator-to-generate-client-side-proxy-class.aspx

            Container c = new Container(new Uri("http://localhost:53305/odata"));
            c.Format.UseJson();
            

            //might work with custom?
            foreach (var person in c.People)
            {
                Console.WriteLine(person.Name);
            }

            //works with custom
            //var p = c.People.ByKey(1);
            //var pActual = p.GetValue();
            //Console.WriteLine(pActual);

            Console.Read();
        }
    }
}
