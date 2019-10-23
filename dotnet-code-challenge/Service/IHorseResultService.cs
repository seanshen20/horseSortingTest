using System.Collections.Generic;

namespace dotnet_code_challenge.Service
{
    public interface IHorseResultService
    {
        IEnumerable<Horse> CombineHorses();
    }
}