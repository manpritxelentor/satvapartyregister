using Autofac;
using SatvaPartyRegister.Utility.Contract;
using SatvaPartyRegister.Utility.Implementation;

namespace SatvaPartyRegister.Dependency
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AutoDataMapper>()
                .As<IDataMapper>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TenantProvider>()
                .As<ITenantProvider>()
                .InstancePerLifetimeScope();
        }
    }
}
