
namespace SampleOdataHost.Models
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Linq;
    using System.Web;

    public static class PersonFactory
    {
        public static IEnumerable<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 10; i++)
            {
                var p = new Person { Id = i, Name = "n".PadRight(i, 'n') };
                if (i % 2 == 0)
                {
                    //p.ExtraFields = new Dictionary<string, object> { { "key", "value" } };
                    //p.ExtraFields = new ExtraFields { { "key", "val" } };
                    p.ExtraFields = new ExtraFields(new Dictionary<string, object> { { "key", "value" } });
                }
                else
                {
                    p.ExtraFields = new ExtraFields();
                    //p.ExtraFields = new Dictionary<string, object>();
                }
                people.Add(p);
            }
            return people;
        }
    }
}