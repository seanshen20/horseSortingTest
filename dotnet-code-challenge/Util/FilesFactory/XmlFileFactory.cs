using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Util.FilesFactory
{
    public class XmlFileFactory : FileFactory
    {
        public override IReader Create()
            => new XmlReader();
    }
}
