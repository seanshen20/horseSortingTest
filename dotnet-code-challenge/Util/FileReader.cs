using dotnet_code_challenge.Util.FilesFactory;
using System.Collections.Generic;

namespace dotnet_code_challenge.Util
{
    class FileReader
    {

        private readonly Dictionary<string, FileFactory> _factories;

        public FileReader()
        {
            _factories = new Dictionary<string, FileFactory>
            {
                {".json", new JsonFileFactory()},
                {".xml", new XmlFileFactory()}
            };
        }

        public IReader ExecuteCreation(string type) 
            => _factories[type].Create();

    }
        
    }
