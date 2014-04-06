using FluentNHibernate.Mapping;
using SongManager.Core.Domain;

namespace SongManager.Core.Map
{
    public class SingerMap : ClassMap<Singer>
    {
        public SingerMap() {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.SingerName);
            HasMany(x => x.Songs)
                .Cascade.DeleteOrphan()
                .Inverse().KeyColumn("SingerId");
            Map(x => x.Created);
            Map(x => x.Modified);
            Table("Singer");
        }
    }
}
