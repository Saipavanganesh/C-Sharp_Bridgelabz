using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    internal class CSFileDemocs
    {
        public void WriteToCsv()
        {
            Console.WriteLine("Started");
            string csvPath = @"D:\C#\FileDemo\SampleCsv.csv";

            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("First Name, Last Name, Email");
            csvContent.AppendLine("Chandler, Bing, chandlerbing@gmail.com");
            csvContent.AppendLine("Sheldon, Cooper, sheldoncooper@gmail.com");
            csvContent.AppendLine("Eren, Jaeger, erenjaeger@gmail.com");
            if (File.Exists(csvPath))
            {
                File.Delete(csvPath);
            }
            File.AppendAllText(csvPath, csvContent.ToString());
            Console.WriteLine("Ended");
        }
        public void ReadFromCsv()
        {
            Console.WriteLine("Reading from CSV");
            string csvPath = @"D:\C#\FileDemo\SampleCsv.csv";
            string csvContent = File.ReadAllText(csvPath);
            Console.WriteLine(csvContent);
        }
    }
}
