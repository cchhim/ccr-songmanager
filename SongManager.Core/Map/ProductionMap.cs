using FluentNHibernate.Mapping;
using SongManager.Core.Domain;

namespace SongManager.Core.Map
{
    public class ProductionMap :ClassMap<Production>
    {
        public ProductionMap() 
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.ProductionName);
            HasMany(x => x.Albums)
                .Cascade.DeleteOrphan()
                .Inverse().KeyColumn("ProductionId");
            //HasMany(x => x.Songs)
            //    .Cascade.DeleteOrphan()
            //    .Inverse().KeyColumn("ProductionId");
            Map(x => x.Created);
            Map(x => x.Modified);
            Table("Production");
        }
    }
}
