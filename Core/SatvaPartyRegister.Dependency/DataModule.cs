using Autofac;
using Microsoft.EntityFrameworkCore;
using SatvaPartyRegister.Data.Contract;
using SatvaPartyRegister.Data.Implementation;
using System;

namespace SatvaPartyRegister.Dependency
{
    public class DataModule : Module
    {
        private readonly string _connectionString;

        public DataModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EfDataContext>();
            optionsBuilder.UseSqlServer(_connectionString);

            builder.RegisterType<EfDataContext>()
                .As<IDataContext>()
                .WithParameter(new NamedParameter("options", optionsBuilder.Options))
                .InstancePerLifetimeScope();

        }
    }
}
