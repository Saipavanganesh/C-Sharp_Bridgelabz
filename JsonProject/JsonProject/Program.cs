using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonProject
{ 
    internal class Program
    {      
        static void Main()
        {
            JsonDemo jsonDemo = new JsonDemo();
            jsonDemo.Write();
            jsonDemo.Read();
            Console.ReadLine();
        }
    }
}
