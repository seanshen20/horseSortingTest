using NUnit.Framework;
using dotnet_code_challenge.Util.Exceptions;

namespace dotnet_code_challenge.Test
{
    [TestFixture]
    class TestJsonReader
    {
        [Test]       
        public void ReadFile_FileIsNotExsit_ThrowError()
        {
            var jsonReader = new Util.FilesFactory.JsonReader();
            
            Assert.That(() => jsonReader.read("abc"), Throws.TypeOf<FileHandleException>());
        }
    }
}
