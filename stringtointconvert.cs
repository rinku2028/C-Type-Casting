
using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion from string to int
            string x = "10";
            string y = "10";
            int sum = Convert.ToInt32(x) + Convert.ToInt32(y);
            int mul = Convert.ToInt32(x) * Convert.ToInt32(y);
            int div = Convert.ToInt32(x) / Convert.ToInt32(y);
;           Console.WriteLine("Sum:"+ "\t"+sum.ToString());
            Console.WriteLine("Multiple value:" + "\t" + mul.ToString());
            Console.WriteLine("Divide value:" + "\t" + div.ToString());
            Console.ReadLine();

                
        }
    }
}
