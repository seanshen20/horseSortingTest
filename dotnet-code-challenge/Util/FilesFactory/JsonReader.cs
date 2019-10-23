using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using dotnet_code_challenge.Util.Exceptions;

namespace dotnet_code_challenge.Util.FilesFactory
{
    public class JsonReader : IReader
    {
        public IEnumerable<Horse> read(string filePath)
        {
            JObject jo;
            JArray selections;
            IEnumerable<Horse> result = null;
            try
            {
                jo = JObject.Parse(File.ReadAllText((filePath)));
            }
            catch (Exception e)
            {
                throw new FileHandleException("cannot read file");
            }

            try
            {
                selections = (JArray)jo["RawData"]["Markets"][0]["Selections"];
                result = selections.Select(a => { return new Horse { Price = (string)a["Price"], Name = (string)a["Tags"]["name"] }; }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("file format error");
            }

            return result;
        }
    }
}
