using System;
using System.Globalization;
using System.IO;
using ProductsSold.Entities;

namespace ProductsSold
{
    class Program
    {
        static void Main(string[] args)
        {

            string pathSouce = @"E:\repos\Csharp\ProductsSold\entry\";
            string fileSource = "itemsonsold.csv";
            string targetPath = @"E:\repos\Csharp\ProductsSold\out\";

            try
            {
                Console.WriteLine("Read directory and file csv...");
                Console.WriteLine(pathSouce + fileSource);

                string[] swLines = File.ReadAllLines(pathSouce + fileSource);

                Console.WriteLine("\nFile Read...");
                foreach (string swLine in swLines)
                {
                    Console.WriteLine(swLine);
                }

                Console.WriteLine("\nCreate Folder");
                Directory.CreateDirectory(targetPath);

                Console.WriteLine("Create and Manipulating File");
                using (StreamWriter sw = File.AppendText(targetPath + "summary.csv"))
                {
                    foreach (string swLine in swLines)
                    {
                        string[] field = swLine.Split(",");
                        string name = field[0];
                        double value = double.Parse(field[1], CultureInfo.InvariantCulture);
                        int quant = int.Parse(field[2]);

                        Product product = new Product(name, value, quant);
                        string total = product.Total(value, quant).ToString("F2", CultureInfo.InvariantCulture);

                        sw.WriteLine(product.Name + "," + total);
                        Console.WriteLine(product.Name + "," + total);
                    }
                }

                Console.WriteLine("File finalized....");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
