using AutoMapper;
using AutoMapper.QueryableExtensions;
using SatvaPartyRegister.Utility.Contract;
using System.Linq;

namespace SatvaPartyRegister.Utility.Implementation
{
    public class AutoDataMapper : IDataMapper
    {
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map<TSource, TDestination>(source, destination);
        }

        public IQueryable<TDestination> Project<TSource, TDestination>(IQueryable<TSource> query)
        {
            return query.ProjectTo<TDestination>();
        }
    }
}
