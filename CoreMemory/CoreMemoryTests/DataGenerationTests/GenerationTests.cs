using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreMemory.DataGeneration;
using CoreMemoryTests.Helpers;

namespace CoreMemoryTests.DataGenerationTests
{
    [TestClass]
    public class GenerationTests
    {
        [TestMethod]
        public void GeneratingObject_UsingTestStub_GeneratesTestStub()
        {
            // Arrange
            var expectedType = typeof(TestStub);

            // Act
            var actualType = Generation.GenerateObject<TestStub>().GetType();

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

        [TestMethod]
        public void GeneratingObject_UsingTestStub_PopulatesTestProperty()
        {
            // Arrange

            // Act
            var actualType = Generation.GenerateObject<TestStub>();

            // Assert
            Assert.IsNotNull(actualType.TestProperty);
        }

        [TestMethod]
        public void GeneratingObjects_UsingTestStub_GeneratesTestStubCollection()
        {
            // Arrange
            var expectedType = typeof(TestStub);

            // Act
            var actualType = Generation.GenerateObjectCollection<TestStub>(5).First().GetType();

            // Assert
            Assert.AreEqual(expectedType, actualType);
        }

        [TestMethod]
        public void GeneratingObjects_WithACollectionAmount_GeneratesCorrectAmountOfObjects()
        {
            // Arrange
            const int expectedObjectAmount = 5;

            // Act
            var actualObjectAmount = Generation.GenerateObjectCollection<TestStub>(5).Count();

            // Assert
            Assert.AreEqual(expectedObjectAmount, actualObjectAmount);
        }
    }
}
