using Ploeh.AutoFixture;
using System.Collections.Generic;

namespace CoreMemory.DataGeneration
{
    public static class Generation
    {
        public static T GenerateObject<T>()
        {
            var fixture = new Fixture();

            return fixture.Create<T>();
        }

        public static IEnumerable<T> GenerateObjectCollection<T>(int collectionAmount)
        {
            var fixture = new Fixture();

            return fixture.CreateMany<T>(collectionAmount);
        }
    }
}
