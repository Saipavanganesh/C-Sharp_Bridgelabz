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
        public void CsvFiles()
        {
            string filePath = @"D:\C#\FileDemo\InputCSVfile.txt"; //Reading from a sample CSV file
            List<Person> people = new List<Person>();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] details = line.Split(',');
                Person person = new Person();
                person.firstName = details[0];
                person.lastName = details[1];
                person.age = details[2];
                people.Add(person);
            }
            foreach (var person in people)
            {
                Console.WriteLine($"{person.firstName} {person.lastName} is {person.age} years old");
            }


            string targetFilePath = @"D:\C#\FileDemo\TargetFile.txt"; //Writing into a CSV file
            List<string> target = new List<string>();
            foreach (var person in people)
            {
                target.Add($"{person.firstName},{person.lastName},{person.age}");
            }
            File.WriteAllLines(targetFilePath, target);
            Console.WriteLine("Written in the File");
        }
    }
}
