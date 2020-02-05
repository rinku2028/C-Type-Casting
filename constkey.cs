using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class constkey

    {
        static void Main(string []args)
        {
            const double pi = 3.14159; //declaring constant
            double rad;
            Console.WriteLine("Please enter radius:");
            rad = Convert.ToDouble(Console.ReadLine());
            double areaofcircle = pi * rad * rad;
            Console.WriteLine("Radius:{0},Area:{1}", rad, areaofcircle);
            Console.ReadLine();

        }
    }
}
