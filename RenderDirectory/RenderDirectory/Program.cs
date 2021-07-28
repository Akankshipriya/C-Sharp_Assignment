using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenderDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory=DirectoryInfo();
            treeStructure(directory);
            Console.ReadLine();
        }
        static DirectoryInfo DirectoryInfo()
        {
            Console.WriteLine("Enter Directory Path:");
            DirectoryInfo userDirectory = new DirectoryInfo(Console.ReadLine());
            if(!userDirectory.Exists)
            {
                Console.WriteLine("Enter valid directory path:");
            }
            return userDirectory;
        }

        static void treeStructure(DirectoryInfo directory)
        {
            try
            {
                Console.WriteLine($"--{directory.Name}");
                DirectoryInfo[] directories = directory.GetDirectories();
                for (int i = 0; i < directories.Length; i++)
                {
                    treeStructure(directories[i]);
                }

                FileInfo[] fileInfos = directory.GetFiles();
                for (int i = 0; i < directories.Length; i++)
                {
                    Console.WriteLine($"-{fileInfos[i].Name}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception occured while forming directory tree: {e.Message}");
            }

        }
    }
}
