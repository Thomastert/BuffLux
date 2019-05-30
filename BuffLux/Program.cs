using System;

namespace BuffLux
{

    //Write a program that prints the numbers from 1 to 100.
    //But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
    //For numbers which are multiples of both three and five print “FizzBuzz”.
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 1; i < 100; i++)

            {
                var i2 = 1.0;
                i2 = i / 3.0;

                var i3 = 1.0;
                i3 = i / 5.0;

                if (Math.Abs(i2 % 1) < double.Epsilon && Math.Abs(i3 % 1) < double.Epsilon)
                {
                    Console.WriteLine("BuffLux");
                }

                else if(Math.Abs(i3 % 1) < double.Epsilon)
                {
                    Console.WriteLine("Lux");
                }
                else if(Math.Abs(i2 % 1) < double.Epsilon)
                {
                    Console.WriteLine("Buff");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();
            Console.WriteLine("End of Stream");
        }
    }
}
