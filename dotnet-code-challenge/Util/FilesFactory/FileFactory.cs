using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Util.FilesFactory
{
    public abstract class FileFactory
    {
        public abstract IReader Create();
    }
}
