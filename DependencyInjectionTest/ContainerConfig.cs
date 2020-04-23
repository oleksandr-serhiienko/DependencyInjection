using Autofac;
using DemoLIbrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DependencyInjectionTest
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BuisnessLogic>().As<IBuisnessLogic>();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                   .Where(t => t.Namespace.Contains("Utilities"))
                   .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
