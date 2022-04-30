using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_project_Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity_of_earth = 9.807;
            double gravity_of_moon = gravity_of_earth * 0.17;
            Console.Write("This program will calculate your weight in MOON\ninsert your mass: ");
            double x = double.Parse(Console.ReadLine()) * gravity_of_moon;
            Console.WriteLine("Your weight in MOON is: " + x);


        }
    }
}
