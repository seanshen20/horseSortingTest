using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Util.Exceptions
{
    public class FileHandleException : Exception
    {
        public FileHandleException()
        {
            
        }

        public FileHandleException(string message)
            : base(message)
        {
        }
    }
}
