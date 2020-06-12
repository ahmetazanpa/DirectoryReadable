using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryReadable
{
    class Program
    {
        static void Main(string[] args)
        {
            int directoryCount = 0 , fileCount = 0;
            Console.Write("Directory path input :");
            string path = Console.ReadLine();
            string[] directories, files;
            DirectoryInfo rootInfo = new DirectoryInfo(path);
            try
            {
                directories = Directory.GetDirectories(rootInfo.FullName, "*.*", SearchOption.AllDirectories);
                files = Directory.GetFiles(rootInfo.FullName, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Searching....");
                GetDiretory();
                GetFiles();
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
            
            void GetDiretory()
            {
                if (directories.Length > 0)
                {
                    Console.WriteLine(directories[directoryCount]);
                    directoryCount++;
                }
                if (directoryCount != directories.Length)
                {
                    GetDiretory();
                }
            }

            void GetFiles()
            {
                if (files.Length > 0)
                {
                    Console.WriteLine(files[fileCount]);
                    fileCount++;
                }
                if (fileCount != files.Length)
                {
                    GetFiles();
                }
            }
            Console.WriteLine("Finished..!");
            Console.ReadKey();
        }
    }
}
