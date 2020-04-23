using DemoLIbrary;
using System;

namespace DependencyInjectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BuisnessLogic buisnessLogic = new BuisnessLogic();

            buisnessLogic.ProcessData();

            Console.ReadLine();
        }
    }
}
