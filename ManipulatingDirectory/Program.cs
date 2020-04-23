using System;
using System.IO;

namespace ManipulantingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\repos\Csharp\ManipulantingDirectory\myfolders";
            string filePath = @"E:\repos\Csharp\ManipulantingDirectory\myfolders\file1.txt";

            try
            {
                Console.WriteLine("Read all folders in directory");
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folder: ");
                foreach (string fo in folders)
                {
                    Console.WriteLine(fo);
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("\nRead all files in directory");
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("File: ");
                foreach (string fi in files)
                {
                    Console.WriteLine(fi);
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////
                /*Console.WriteLine("\nCreate new folder in directory");

                Directory.CreateDirectory(path + @"\newfolder");
                Console.WriteLine(path + @"\newfolder");*/

                //////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("\nPath options:");

                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(filePath));
                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
