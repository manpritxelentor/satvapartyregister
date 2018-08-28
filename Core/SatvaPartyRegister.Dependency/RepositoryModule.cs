using Autofac;
using SatvaPartyRegister.Repository.Contract.BaseClass;
using SatvaPartyRegister.Repository.Implementation;
using SatvaPartyRegister.Repository.Implementation.BaseClass;
using System.Linq;

namespace SatvaPartyRegister.Dependency
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>()
                .InstancePerLifetimeScope();

            var repositories = typeof(CompanyRepository).Assembly.GetTypes()
                .Where(w => w.Name.EndsWith("Repository")).ToArray();

            builder.RegisterTypes(repositories)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
