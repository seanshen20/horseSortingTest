using dotnet_code_challenge.Util.GetPath;
using NUnit.Framework;

namespace dotnet_code_challenge.Test
{
    [TestFixture]
    class TestPathService
    {
        [Test]
        public void PathService_ProjectNaem_ReturnNotEmpty()
        {
            var service = new PathService();
            var result = service.PjName();
            Assert.That(result, Is.Not.Empty);
        }
    }
}
