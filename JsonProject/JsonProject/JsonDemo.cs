using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonProject
{
    internal class JsonDemo
    {
        string FilePath = @"D:\C#\JsonProject\TestFile.JSON";
        public void Write()
        {
            var person = new Person();
            person.Name = "Ganesh";
            person.Age = 13;
            person.Email = "ganesh@gmail.com";
            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText(FilePath, jsonString);
            Console.WriteLine("JSON File updated successfully");
        }
        public void Read()
        {
            string jsonString = File.ReadAllText(FilePath);
            var person = JsonSerializer.Deserialize<Person>(jsonString);
            Console.WriteLine($"Name:{person.Name}");
            Console.WriteLine($"Age:{person.Age}");
            Console.WriteLine("JSON File read successfully");
        }
    }
}
