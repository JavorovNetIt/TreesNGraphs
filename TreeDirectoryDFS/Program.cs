using System;
using System.IO;

namespace TreeDirectoryDFS
{
    class Program
    {
        private static void TraverseDir(DirectoryInfo dir, string spaces)
        {
            Console.WriteLine(spaces + dir.FullName);

            DirectoryInfo[] children = dir.GetDirectories();

            foreach (var child in children)
            {
                TraverseDir(child, spaces + "   ");
            }
        }

        public static void TraerseDir(string directoryPath)
        {
            TraverseDir(new DirectoryInfo(directoryPath), string.Empty);
        }

        static void Main(string[] args)
        {
            TraerseDir("D:\\Downloads");
        }
    }
}
