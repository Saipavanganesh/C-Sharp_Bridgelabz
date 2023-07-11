using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    internal class JsFileDemo
    {
        public void ReadData()
        {
            string filePath = @"D:\C#\FileDemo\InputJsonFile.txt"; //Reading data from Json file
            string jsonData = File.ReadAllText(filePath);
        }
    }
}
