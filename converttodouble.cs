using System;

namespace ConsoleApp7
{
    class converttodouble
    {
        static void Main(string[] args)
        {
            double x = 1899.33;
            int i;

            //cast double to int
            i = (int)x;
            Console.WriteLine(i);
            Console.ReadLine(); //Output is 1899
        }
    }
}
