using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo
{
    internal class Program
    {
        public void TxtFile()
        {
            SampleTextFile stf = new SampleTextFile();
            stf.FileExists();
            stf.WriteData();
            stf.ReadData();
        }
        public void CsvFile()
        {
            CSFileDemocs cs = new CSFileDemocs();
            cs.CsvFiles();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.TxtFile();
            p.CsvFile();
            Console.ReadLine();
        }
    }
}
