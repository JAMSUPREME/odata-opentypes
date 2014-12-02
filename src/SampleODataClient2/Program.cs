

namespace SampleODataClient2
{
    using System;
    using SampleODataClient2.Client.Default;

    class Program
    {
        static void Main(string[] args)
        {
            // see http://blogs.msdn.com/b/odatateam/archive/2014/03/12/how-to-use-odata-client-code-generator-to-generate-client-side-proxy-class.aspx
            Container c = new Container(new Uri("http://localhost:53305/odata"));
            foreach (var person in c.People)
            {
                //Console.WriteLine(person.ExtraFields.KeyVal); // this is the field we want to validate exists
            }

            Console.Read();
        }
    }
}
