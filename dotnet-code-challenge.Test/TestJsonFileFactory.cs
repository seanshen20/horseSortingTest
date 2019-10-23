using dotnet_code_challenge.Util.FilesFactory;
using NUnit.Framework;

namespace dotnet_code_challenge.Test
{
    [TestFixture]
    class TestJsonFileFactory
    {
        [Test]
        public void TestJsonFileFactory_createJson_ReturnJsonFileObject()
        {
            var result = new JsonFileFactory().Create();
            Assert.That(result, Is.TypeOf<JsonReader>());
        }

    }
}
