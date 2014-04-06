using FluentNHibernate.Mapping;
using SongManager.Core.Domain;

namespace SongManager.Core.Map
{
    public class AlbumMap : ClassMap<Album>
    {
        public AlbumMap() 
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.AlbumNum);
            References(x => x.Production)
                .Cascade.SaveUpdate()
                .Column("ProductionId")
                .Not.LazyLoad();
            References(x => x.SongType)
                .Cascade.SaveUpdate().
                Column("SongTypeId")
                .Not.LazyLoad() ;
            HasMany(x => x.Songs)
                .Cascade.DeleteOrphan()
                .Inverse().KeyColumn("AlbumId");
            Map(x => x.Created);
            Map(x => x.Modified);
            Table("Album");
        }
    }
}
