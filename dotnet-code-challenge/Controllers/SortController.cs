using dotnet_code_challenge.Service;
using System;
using System.Linq;

namespace dotnet_code_challenge.Controllers
{
    public class SortController
    {
        private readonly IHorseResultService _houseService;

        // production or DI framework, such as Autofac
        public SortController()
        {
            _houseService = new HorseResultService();
        }
        // mock test
        public SortController(IHorseResultService houseService)
        {
            _houseService = houseService;
        }

        public string[] AscendingPriceOrder()
        {
            return _houseService.CombineHorses().OrderBy(h =>
            {
                double.TryParse(h.Price, out double p);
                return p;
            }).Select(h => h.Name).ToArray();
        }
    }
}
