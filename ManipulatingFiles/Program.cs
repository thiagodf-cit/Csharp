using System;
using System.IO;

namespace ManipulatingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"E:\repos\Csharp\ManipulatingFiles\files\fileSource.txt";
            string targetPath = @"E:\repos\Csharp\ManipulatingFiles\files\fileSource";

            StreamReader sr = null;

            try
            {
                /*Console.WriteLine("Copy file1 as new targertPath: FileInfo + CopyTo");
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath + "New.txt");*/
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                /*Console.WriteLine("\nRead lines from file1: File + ReadAllLines");
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }*/
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("\nRead line per line from file1 with Stream: FileStream + StreamReader");
                sr = File.OpenText(sourcePath);

                while (!sr.EndOfStream)
                {
                    string rline = sr.ReadLine();
                    Console.WriteLine(rline);
                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                /*Console.WriteLine("\nRead line per line with Stream and using: the block is closed after use");
                using (StreamReader usr = File.OpenText(sourcePath))
                {
                    while (!usr.EndOfStream)
                    {
                        string uline = usr.ReadLine();
                        Console.WriteLine(uline);
                    }
                }*/
                /////////////////////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("\nRead file1 and create new file with leatters in caps: File + StreamWriter");
                string[] swlines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath + "NewToUpper.txt"))
                {
                    foreach (string swline in swlines)
                    {
                        sw.WriteLine(swline.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sr != null ) sr.Close();
            }
        }
    }
}
