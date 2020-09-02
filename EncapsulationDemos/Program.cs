using System;

namespace EncapsulationDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = JustTesting();

            Console.WriteLine(message);
        }

        static string JustTesting()
        {
            return "Hello world";
        }
    }
}
