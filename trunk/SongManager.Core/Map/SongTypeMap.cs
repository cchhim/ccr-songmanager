using FluentNHibernate.Mapping;
using SongManager.Core.Domain;

namespace SongManager.Core.Map
{
    public class SongTypeMap : ClassMap<SongType>
    {
        public SongTypeMap() 
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.SongTypeName);
            Map(x => x.Created);
            Map(x => x.Modified);
          
            HasMany(x => x.Albums)
                .Cascade.DeleteOrphan()
                .Inverse().KeyColumn("SongTypeId");
            //HasMany(x => x.Songs)
            //   .Cascade.DeleteOrphan()
            //   .Inverse().KeyColumn("SongTypeId");
            Table("SongType");
        }
    }
}
