using System;
using System.IO;
using dotnet_code_challenge.Controllers;
using dotnet_code_challenge.Service;
using dotnet_code_challenge.Util;
using dotnet_code_challenge.Util.GetPath;

namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            IHorseResultService horseService = new HorseResultService();
            var sortController = new SortController(horseService);
            var sorted = sortController.AscendingPriceOrder();
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
