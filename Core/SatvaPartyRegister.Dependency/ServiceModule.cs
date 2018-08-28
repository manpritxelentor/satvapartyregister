using Autofac;
using SatvaPartyRegister.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SatvaPartyRegister.Dependency
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var services = typeof(CompanyService).Assembly.GetTypes()
                .Where(w => w.Name.EndsWith("Service")).ToArray();

            builder.RegisterTypes(services)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
