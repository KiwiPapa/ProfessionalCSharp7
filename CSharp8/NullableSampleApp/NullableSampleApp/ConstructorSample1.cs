﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullableSampleApp
{
#nullable disable
    public class AppServicesLegacy
    {
        public AppServicesLegacy()
        {
            RegisterServices();
        }

        public void RegisterServices()
        {
            var services = new ServiceCollection();
            //...
            Services = services.BuildServiceProvider();
        }

        public IServiceProvider Services { get; private set; }
    }
#nullable restore

}
