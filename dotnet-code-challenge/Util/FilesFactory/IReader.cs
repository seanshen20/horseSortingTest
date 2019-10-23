using System.Collections.Generic;

namespace dotnet_code_challenge.Util.FilesFactory
{
    public interface IReader
    {
        IEnumerable<Horse> read(string filePath);
    }
}