using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    internal class SampleTextFile
    {
        public void FileExists()
        {
            string filePath = @"D:\C#\FileDemo\Sample.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists");
            }
        }
        public void WriteData()
        {
            string text = "Hi, this text is from Visual Studio";
            string text2 = "Added some more data";
            string filePath = @"D:\C#\FileDemo\Sample.txt";
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(text);
            sw.Close();
            Console.WriteLine("Text Written");
        }
        public void ReadData() 
        {
            string filePath = @"D:\C#\FileDemo\Sample.txt";
            StreamReader sr = new StreamReader(filePath);
            string data= sr.ReadLine();
            while(data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();
            }
            sr.Close();
            Console.WriteLine("Text Ended in the file");
        }

    }
}
