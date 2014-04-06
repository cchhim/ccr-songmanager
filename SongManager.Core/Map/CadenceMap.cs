using FluentNHibernate.Mapping;
using SongManager.Core.Domain;

namespace SongManager.Core.Map
{
    public class CadenceMap : ClassMap<Cadence>
    {
        public CadenceMap() 
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.CadenceName);
            HasMany(x => x.Songs)
                .Cascade.DeleteOrphan()
                .Inverse().KeyColumn("CadenceId");
            Map(x => x.Created);
            Map(x => x.Modified);
            Table("Cadence");
        }
    }
}
