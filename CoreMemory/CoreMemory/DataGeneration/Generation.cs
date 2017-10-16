using Ploeh.AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreMemory.DataGeneration
{
    public static class Generation
    {
        public static T GenerateObject<T>()
        {
            Fixture fixture = new Fixture();

            return fixture.Create<T>();
        }

        public static IEnumerable<T> GenerateObjectCollection<T>()
        {
            Fixture fixture = new Fixture();

            return fixture.CreateMany<T>();
        }
    }
}
