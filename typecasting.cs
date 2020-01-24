using System;

namespace typecast
{
    class typecasting
    {
        static void Main(string[] args)
        {
            int i = 10;
            double x = 20.22;
            bool myvalue = false;
            Console.WriteLine(i);
            Console.WriteLine("Value of i:"+"\t"+i);
            Console.WriteLine("Value of x:"+"\t"+x);
            Console.WriteLine("Convert int value i to double:" + "\t" + Convert.ToDouble(i));//Returns 10
            Console.WriteLine("Convert double value x to int:" + "\t" + Convert.ToInt32(x));//Returns 20
            Console.WriteLine("Convert int value i to string:" + "\t" + Convert.ToString(i));//Returns 10
            Console.WriteLine("Convert double value x to string:" + "\t" + Convert.ToString(x));//Returns 20.22
            Console.WriteLine("Convert boolean value to string:" + "\t" + Convert.ToString(myvalue));//Returns False
            Console.ReadLine();

        }
    }
}
