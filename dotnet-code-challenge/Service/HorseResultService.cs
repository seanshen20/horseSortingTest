using System;
using dotnet_code_challenge.Util;
using dotnet_code_challenge.Util.GetPath;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace dotnet_code_challenge.Service
{
    public class HorseResultService : IHorseResultService
    {
        // duplicate name, conflict price are not considered,   
        public IEnumerable<Horse> CombineHorses()
        {
            IEnumerable<Horse> result = new List<Horse>();
            var paths = new PathService().Paths();
            foreach (var path in paths)
            {
                var reader = new FileReader().ExecuteCreation(Path.GetExtension(path));
                var a = reader.read(path);
                result = result.Concat(reader.read(path).ToList()) ;
            }

            return result;
        }

    }
}
