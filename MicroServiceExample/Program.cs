using System;
using MicroService4Net; 

namespace MicroServiceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var micro = new MicroService(8082);
            Console.WriteLine("Hello World!");
        }
    }
}
