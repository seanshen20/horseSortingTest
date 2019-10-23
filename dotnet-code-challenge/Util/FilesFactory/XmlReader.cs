using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace dotnet_code_challenge.Util.FilesFactory
{
    public class XmlReader : IReader
    {
        public IEnumerable<Horse> read(string filePath)
        {
            
            var result = new List<Horse>();

            XElement x = XElement.Load(filePath);
            var price = x.Descendants("horse").Where(h => !string.IsNullOrEmpty((string)h.Attribute("Price"))).Select(h =>
            {
                return new
                {
                    number = (string)h.Attribute("number"),
                    price = (string)h.Attribute("Price")
                };
            });

            var hs = x.Descendants("horse")
                    .Select(h =>
                    {
                        return new
                        {
                            number = (string)h.Element("number"),
                            name = (string)h.Attribute("name"),
                        };
                    })
                ;


            foreach (var p in price)
            {
                string name = hs.Where(h => h.number == p.number).Select(h => h.name).ToList()[0];
                result.Add(new Horse
                {
                    Name = name,
                    Price = p.price
                });
            }

            return result;
        }
    }
}