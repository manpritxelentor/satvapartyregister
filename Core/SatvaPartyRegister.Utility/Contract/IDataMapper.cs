using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SatvaPartyRegister.Utility.Contract
{
    public interface IDataMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
        TDestination Map<TSource, TDestination>(TSource source, TDestination destination);
        IQueryable<TDestination> Project<TSource, TDestination>(IQueryable<TSource> query);
    }
}
