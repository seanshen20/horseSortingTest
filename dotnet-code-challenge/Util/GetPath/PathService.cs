using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace dotnet_code_challenge.Util.GetPath
{
    public class PathService
    {
        public string[] Paths(string dataFolder = "FeedData")
        {
            var rootDir = Environment.CurrentDirectory;
            var projectName = PjName();

            var index = rootDir.IndexOf(projectName) + projectName.Length;
            var root = rootDir.Substring(0, index);
            var folder = root + @"\" + dataFolder;

            string[] filePaths = Directory.GetFiles(folder, "*.*")
                .Where(s => s.EndsWith(".xml") || s.EndsWith(".json")).ToArray();

            return filePaths;
        }

        public string PjName()
        {
            return Assembly.GetEntryAssembly().GetName().Name.Replace('_', '-');
        }
    }
}
