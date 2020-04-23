using Autofac;
using DemoLIbrary;
using System;

namespace DependencyInjectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            using var scope = container.BeginLifetimeScope();
            var app = scope.Resolve<IApplication>();

            app.Run();

            Console.ReadLine();
        }
    }
}
