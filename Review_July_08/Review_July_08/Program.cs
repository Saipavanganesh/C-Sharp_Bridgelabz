using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Review_July_08
{
    /* Extract Email from a Text, also handle necessary exception handling
    Text: "Visit my website at http://www.example.com. For more information contact us on, email : Pavan123@gmail.com" */

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting");
                string emailPattern = "^[a-zA-Z0-9]+@[a-z]+(.com)$";
                string message = "Visit my website at http://www.example.com. For more information contact us on, email : Ganesh@gmail ";
                int count = 0;

                string[] messArr = message.Split(' ');
                foreach (string m in messArr)
                {
                    bool isMatch = Regex.IsMatch(m, emailPattern);
                    if (isMatch)
                    {
                        Console.WriteLine("Found " + m);
                        count++;
                    }
                }
                if (count == 0)
                {
                    throw new EmailNotFoundException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
