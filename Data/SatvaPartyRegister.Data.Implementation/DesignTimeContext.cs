using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Data.Implementation
{
    public class DesignTimeContext : IDesignTimeDbContextFactory<EfDataContext>
    {
        public EfDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EfDataContext>();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KGEC3SN;Initial Catalog=SatvaPartyRegister;Persist Security Info=True;User ID=sa;Password=1234");
            return new EfDataContext(optionsBuilder.Options);
        }
    }
}
