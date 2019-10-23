using dotnet_code_challenge.Util.FilesFactory;
using NUnit.Framework;

namespace dotnet_code_challenge.Test
{
    [TestFixture]
    class TestXmlFactory
    {
        [Test]
        public void TestXmlileFactory_createXml_ReturnXmlFileObject()
        {
            var result = new XmlFileFactory().Create();
            Assert.That(result, Is.TypeOf<XmlReader>());
        }

    }
}
