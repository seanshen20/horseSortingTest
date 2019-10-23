using NUnit.Framework;
using System.Collections.Generic;
using dotnet_code_challenge.Service;
using Moq;
using dotnet_code_challenge.Controllers;

namespace dotnet_code_challenge.Test.Mock
{
    [TestFixture]
    class TestSortControllerByMoq
    {
        [Test]
        public void SortController_SortAscendingOrderOfEmpty_ReturnEnpty()
        {
            var mockHorseService = new Mock<IHorseResultService>();
            mockHorseService.Setup(hs => hs.CombineHorses())
                .Returns(new List<Horse>());
            var controller = new SortController(mockHorseService.Object);
            var result = controller.AscendingPriceOrder();
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void SortController_SortAscendingOrderTwoItems_ReturnCorrectOrder()
        {
            var mockHorseService = new Mock<IHorseResultService>();
            mockHorseService.Setup(hs => hs.CombineHorses())
                .Returns(
                    new List<Horse>()
                    {
                        new Horse(){Price = "10", Name = "horse1"},
                        new Horse(){Price = "12", Name="horse2"}
                    });
            var controller = new SortController(mockHorseService.Object);
            var result = controller.AscendingPriceOrder();
            var expectedResult = new string[]{"horse1", "horse2"};
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
