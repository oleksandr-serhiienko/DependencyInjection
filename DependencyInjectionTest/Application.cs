using DemoLIbrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionTest
{
    public class Application : IApplication
    {
        IBuisnessLogic buisnessLogic;

        public Application(IBuisnessLogic buisnessLogic)
        {
            this.buisnessLogic = buisnessLogic;
        }

        public void Run()
        {
            buisnessLogic.ProcessData();
        }
    }
}
