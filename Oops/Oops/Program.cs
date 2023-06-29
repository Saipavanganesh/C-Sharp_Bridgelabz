using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Program
    {
        static void Encapsulation()
        {
            MovieRating infinityWar = new MovieRating("Infinity War", "Russo Brothers", "R");
            Console.WriteLine(infinityWar.name);
            Console.WriteLine(infinityWar.director);
            Console.WriteLine(infinityWar.Rating);
            infinityWar.Rating = "PG-13";
            Console.WriteLine(infinityWar.Rating);
            MovieRating inception = new MovieRating("Inception", "Christopher Nolan", "G");
            Console.WriteLine(inception.name);
            Console.WriteLine(inception.director);
            inception.Rating = "ganesh";
            Console.WriteLine(inception.Rating);
        }

        //static void Main(string[] args)
        //{

        //    Inherited inherited = new Inherited();
        //    inherited.name = "Ganesh";
        //    inherited.role = "Full stack developer";
        //    inherited.salary = 40000;
        //    inherited.showCompany();

        //    Console.ReadLine();

        //}
    }
}
